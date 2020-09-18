using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyDbApp;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace efcoreGenerics
{
    class CoreRepoBasic<Core, SubOne, SubTwo> where Core : BaseCore<SubOne, SubTwo>
            where SubOne : BaseSubOne
            where SubTwo : BaseSubTwo
    {
        private readonly DbAppContext ctx;
        private readonly IMapper mapper;

        public DbSet<Core> DbSet { get; }

        public CoreRepoBasic(DbAppContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            this.DbSet = this.ctx.Set<Core>();
        }

        public CoreRepoModel Get(int id)
        {
            var dbItem = this.DbSet.AsNoTracking().Where(i => i.Id == id);
            return mapper.Map<CoreRepoModel>(dbItem);
        }
        /// <summary>
        /// Do not need to know the parent type
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public IEnumerable<SubOne> GetSubsForParentId(int parentId)
        {
            var dbItem = this.DbSet.Include(a => a.SubsOne)
                                    .Include(a => a.SubsTwo).First(i => i.Id == parentId);
            return dbItem.SubsOne.ToList();
        }

        /// <summary>
        /// This query in SQL Land is a straight join
        /// The Semantics of c# dont make that easy. We use outer joins, and asubselect....poor show
        /// This is because we cannot know the host type.
        ///       SELECT *
        /// FROM [CoreOne] AS [c]
        ///  LEFT JOIN [CoreOneS1] AS [c0] ON [c].[Id] = [c0].[HostId]
        ///  LEFT JOIN [CoreOneS2] AS [c1] ON [c].[Id] = [c1].[HostId]
        ///   WHERE EXISTS (
        ///       SELECT 1
        ///       FROM [CoreOneS2] AS [c2]
        ///       WHERE ([c].[Id] = [c2].[HostId]) AND ([c2].[Id] = @__subTwoId_0))
        ///   ORDER BY [c].[Id], [c0].[Id], [c1].[Id]
        /// </summary>
        /// <param name="subTwoId"></param>
        /// <returns></returns>
        public IEnumerable<Core> GetCoreForSub(int subTwoId)
        {
            var dbItem = this.DbSet.AsNoTracking()
                                    .Include(a => a.SubsOne)
                                    .Include(a => a.SubsTwo)
                                    .Where(i => i.SubsTwo.Any(s2 => s2.Id == subTwoId));
            return dbItem;
        }
    }
}

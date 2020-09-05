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
            var dbItem  = this.DbSet.AsNoTracking().Where(i => i.Id == id);
            return mapper.Map<CoreRepoModel>(dbItem);
        }
        /// <summary>
        /// Do not need to know the parent type
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public IEnumerable<SubOne>GetSubsForParentId(int parentId)
        {
            var dbItem = this.DbSet.Include(a => a.SubsOne)
                                    .Include(a => a.SubsTwo).First(i => i.Id == parentId);
            return dbItem.SubsOne.ToList();
        }


        public IEnumerable<Core> GetCoreForSub(int subTwoId)
        {
            var dbItem = this.DbSet.AsNoTracking()
                                    .Include(a=>a.SubsOne)
                                    .Include(a=>a.SubsTwo)
                                    .Where(i => i.SubsTwo.Any(s2=>s2.Id == subTwoId ));
            return dbItem;
        }
    }
}

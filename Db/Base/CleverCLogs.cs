using System;

namespace MyDbApp
{
    /// Smattering of fields that are shared
    // between the grand objects that otherwise having nothing in commomns
    // Implmented on the concrete types.
    public interface IDbParentFields
    {
        string SameSame { get; set; }
        DateTime NoTime { get; set; }
    }
    // THe name and type of the id field.
    // Can be Generic but it gets messy really fast.
    // implemented on the Concrete types
    public interface IDbIntId
    {
        int Id { get; set; }
    }

    // The parent type of this object is...
    // This PLays no role in the db.
    // It appears on the CONCRETE types not in the base abstract definitions.
    // THis makes the use of Generics...well actually work.
    public interface IHasHost<T>
    {
        public T Host{get;}
    }
}
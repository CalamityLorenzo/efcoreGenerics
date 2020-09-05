# efcoreGenerics

Exploring abusing generics to manage a hierarchy.

The trouble with generics is work with them to be more expressive, and open in your code. 
However it's easy to get caught in a cul-de-sac of nested generic types that cannot actually be usefully expressed.

Here `Parent` is a property that is a relationship with another entity. 
This table layout (properties) is re-used so I want to replace the Parent Type for each implementation.

 ```
 abstract class B<T>
 {
    int Id{get;set;}
    T Parent{get;set;}
 }
 public class C1<DbEntity> : B<string>
 {
    DbEntity Parent{get;set;}
 }
 
 ```
 However you lose the ability to use the B type as a general type. 
 So a general repo working on a type B needs more type information presented at compile time.
 
 You must always know what the parent is, but you don't *know* anything about it if you need to query.
  ```
 class CRepo<T,U> where T : B<U> {
  var dbSet = DbContext.Set<T>();
  
 }
 var repo = new CRepo<C1,DbEntity>();
 
```

So the idea is change it up, the base class stays a general base with information about that object. 
The behaviour of what object is to be the parent, moves into the Concrete class, and is exposed by an interface

```
interface IParentObject<pObj>{
   pObj Parent {get;}
}

abstract class B {
    int Id{get;set;};}
 }
 
 public class C1<DbEntity> : B, IParentObject<DbEntity>
 {
    DbEntity Parent{get;set;}
 }
 ```

So far so bland, what does this gain us.
Easier to reason about hierarchies.

Entity hierarchies are ordered in a particular way T1->T2->T3. That's how the information is organised, that's how you access the data.
What does change are the relations. So they are the same classes (bag of properties), but differing hosts.




 

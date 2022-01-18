using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    /*
     ABP Framework has two fundamental base classes for entities: 
        AggregateRoot and Entity. 
        Aggregate Root is a Domain Driven Design concept which can be thought as a root entity that is directly queried 
        and worked on.
     */

    /* 
       The Book entity inherits from the AuditedAggregateRoot which adds some base auditing properties
       (like CreationTime, CreatorId, LastModificationTime...) on top of the AggregateRoot class.
       ABP automatically manages these properties for you.
    */
    /*
       Guid is the primary key type of the Book entity.
     */
    {
        public string Name { get; set; }   
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }  
        public float Price { get; set; }

    }
}

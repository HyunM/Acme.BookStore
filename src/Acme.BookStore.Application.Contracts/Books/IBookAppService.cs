using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService : 
        /*
            ICrudAppService defines common CRUD methods: GetAsync, GetListAsync, CreateAsync, UpdateAsync and DeleteAsync.
         */
        /*
            There are some variations of the ICrudAppService where you can use separated DTOs for each method 
            (like using different DTOs for create and update).
         */
        ICrudAppService<    //Defined CRUD methods
            BookDto,    //Used to show books
            Guid,   //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>    //Used to create/update a book
    {

    }
}

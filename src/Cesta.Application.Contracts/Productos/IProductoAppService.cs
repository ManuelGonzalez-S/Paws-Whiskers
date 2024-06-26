﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Cesta.Productos
{
    public interface IProductoAppService :

        ICrudAppService< //Defines CRUD methods
        ProductoDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateProductoDto>
    {



    }
}

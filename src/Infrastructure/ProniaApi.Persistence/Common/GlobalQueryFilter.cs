using Microsoft.EntityFrameworkCore;
using ProniaApi.Domain.Entities.Common;
using ProniaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Persistence.Common
{
    internal static class GlobalQueryFilter
    {
        public static void ApplyQuery<T>(
            ModelBuilder builder) where T : BaseEntity, new()
        {

            builder.Entity<T>().HasQueryFilter(x => x.IsDeleted == false);
        }

        public static void ApplyQueryFilters(this ModelBuilder builder)
        {
            ApplyQuery<Category>(builder);

            ApplyQuery<Product>(builder);

            ApplyQuery<Color>(builder);

            ApplyQuery<Tag>(builder);

            ApplyQuery<ProductColor>(builder);

            ApplyQuery<ProductTag>(builder);
        }
    }
}

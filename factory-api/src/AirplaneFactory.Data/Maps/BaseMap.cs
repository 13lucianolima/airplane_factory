using AirplaneFactory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirplaneFactory.Data.Maps
{
    public abstract class BaseMap<TModel> : IEntityTypeConfiguration<TModel> where TModel : BaseModel
    {
        public void Configure(EntityTypeBuilder<TModel> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureMap(builder);
        }

        public abstract void ConfigureMap(EntityTypeBuilder<TModel> builder);
    }
}

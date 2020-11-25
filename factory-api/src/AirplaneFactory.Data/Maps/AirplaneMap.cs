using AirplaneFactory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirplaneFactory.Data.Maps
{
    public class AirplaneMap : BaseMap<AirplaneModel>
    {
        public override void ConfigureMap(EntityTypeBuilder<AirplaneModel> builder)
        {
            builder.HasMany(x => x.Motors).WithOne(x => x.Airplane).HasForeignKey(x => x.AirplaneId).OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("airplanes");
        }
    }
}

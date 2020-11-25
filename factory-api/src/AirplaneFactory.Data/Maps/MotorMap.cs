using AirplaneFactory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirplaneFactory.Data.Maps
{
    public class MotorMap : BaseMap<MotorModel>
    {
        public override void ConfigureMap(EntityTypeBuilder<MotorModel> builder)
        {
            builder.ToTable("motors");
        }
    }
}

using AutoMapper;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;

namespace DrillRoad.Database.Mappers
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {

            CreateMap<AddressRow, Address>()
                .ReverseMap();
        }
    }
}
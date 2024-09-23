using AutoMapper;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Entities.Account;

namespace DrillRoad.Database.Mappers
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            // Mapowanie z ContactRow do Contact
            CreateMap<ContactRow, Contact>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ReverseMap(); // ReverseMap umożliwia mapowanie z powrotem
            
            // Zakładamy, że AddressProfile już istnieje i jest dodany do konfiguracji
        }
    }
}
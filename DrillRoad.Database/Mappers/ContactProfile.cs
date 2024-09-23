using AutoMapper;
using DrillRoad.Contracts.Account;
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
            CreateMap<IContact,ContactRow>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address)) // Mapujemy Address
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
        }
            
            // Zakładamy, że AddressProfile już istnieje i jest dodany do konfiguracji
        }
    }

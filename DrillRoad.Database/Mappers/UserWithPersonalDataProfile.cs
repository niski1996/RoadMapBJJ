using AutoMapper;
using DrillRoad.Contracts.Account;
using DrillRoad.Database.Tables.Account;
using DrillRoad.Database.Tables.Techniques;
using DrillRoad.Entities.Account;

public class UserWithPersonalDataProfile : Profile
{
    public UserWithPersonalDataProfile()
    {
        // Mapowanie z AdditionalUserInfoRow na UserWithPersonalData
        CreateMap<AdditionalUserInfoRow, UserWithPersonalData>()
            .ForMember(dest => dest.Contact, opt => opt.MapFrom(src => src.ContactRow))  // Mapujemy ContactRow na Contact
            .ForMember(dest => dest.JoinDate, opt => opt.MapFrom(src => src.InsertTime)) // Mapujemy InsertTime na JoinDate
            .ForMember(dest => dest.PictureRepoPatch, opt => opt.MapFrom(src => src.PictureRepoPatch));

        // Mapowanie z UserWithPersonalData na AdditionalUserInfoRow
        CreateMap<UserWithPersonalData, AdditionalUserInfoRow>()
            .ForMember(dest => dest.ContactRow, opt => opt.MapFrom(src => src.Contact)) // Mapujemy Contact na ContactRow
            .ForMember(dest => dest.InsertTime, opt => opt.MapFrom(src => src.JoinDate)) // Mapujemy JoinDate na InsertTime
            .ForMember(dest => dest.PictureRepoPatch, opt => opt.MapFrom(src => src.PictureRepoPatch))
            .ForMember(dest => dest.fightActions, opt => opt.MapFrom(src => new List<FightActionRow>()))  // Mapowanie pustych list
            .ForMember(dest => dest.positions, opt => opt.MapFrom(src => new List<PositionRow>()))
            .ForMember(dest => dest.transactions, opt => opt.MapFrom(src => new List<TransitionRow>()))
            .ForMember(dest => dest.trainers, opt => opt.MapFrom(src => new List<UserDrillIdentity>()));

    }
}
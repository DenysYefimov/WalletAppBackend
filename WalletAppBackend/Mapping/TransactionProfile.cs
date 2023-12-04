using AutoMapper;
using WalletAppBackend.Data.Entities;
using WalletAppBackend.Dtos;

namespace WalletAppBackend.Mapping
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, TransactionDto>()
                .ConstructUsing(t => new TransactionDto(t.Name))
                .ForMember(td => td.Id, o => o.MapFrom(t => t.Id))
                .ForMember(td => td.Type, o => o.MapFrom(t => t.Type))
                .ForMember(td => td.Amount, o => o.MapFrom(t => t.Amount))
                .ForMember(td => td.Description, o => o.MapFrom(t => t.Description))
                .ForMember(td => td.DateTime, o => o.MapFrom(t => t.DateTime))
                .ForMember(td => td.IsPending, o => o.MapFrom(t => t.IsPending))
                .ForMember(td => td.UserName, o => o.Ignore());
        }
    }
}

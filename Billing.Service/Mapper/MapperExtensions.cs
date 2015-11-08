using Billing.Service.Models;
using Billing.Api.Models;

namespace Billing.Service.Mapper
{
    public static class MapperExtensions
    {
        static MapperExtensions()
        {
            AutoMapper.Mapper.CreateMap<Bill, BillDto>();
            AutoMapper.Mapper.CreateMap<Call, CallDto>();
            AutoMapper.Mapper.CreateMap<CallCharges, CallChargesDto>();
            AutoMapper.Mapper.CreateMap<Package, PackageDto>();
            AutoMapper.Mapper.CreateMap<Period, PeriodDto>();
            AutoMapper.Mapper.CreateMap<Programme, ProgrammeDto>();
            AutoMapper.Mapper.CreateMap<SkyStore, SkyStoreDto>();
            AutoMapper.Mapper.CreateMap<Statement, StatementDto>();
            AutoMapper.Mapper.CreateMap<Subscription, SubscriptionDto>();
        }

        public static BillDto ToDto(this Bill bill)
        {
            return AutoMapper.Mapper.Map<BillDto>(bill);
        }
    }
}

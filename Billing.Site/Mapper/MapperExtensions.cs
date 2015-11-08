using System;
using System.Linq;
using System.ComponentModel;
using Billing.Site.BillingService;
using Billing.Site.Models;

namespace Billing.Site.Mapper
{
    public static class MapperExtensions
    {
        static MapperExtensions()
        {
            AutoMapper.Mapper.CreateMap<BillDto, Bill>();
            AutoMapper.Mapper.CreateMap<CallDto, Call>();
            AutoMapper.Mapper.CreateMap<CallChargesDto, CallCharges>();
            AutoMapper.Mapper.CreateMap<PackageDto, Package>();
            AutoMapper.Mapper.CreateMap<PeriodDto, Period>();
            AutoMapper.Mapper.CreateMap<ProgrammeDto, Programme>();
            AutoMapper.Mapper.CreateMap<SkyStoreDto, SkyStore>();
            AutoMapper.Mapper.CreateMap<StatementDto, Statement>();
            AutoMapper.Mapper.CreateMap<SubscriptionDto, Subscription>()
                      .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToEnum<Subscription.SubscriptionType>().ToDescription()));

        }

        public static Bill ToViewModel(this BillDto billDto)
        {
            return AutoMapper.Mapper.Map<Bill>(billDto);
        }

        private static T ToEnum<T>(this string enumValue) where T : struct
        {
            return (T)Enum.Parse(typeof (T), enumValue);
        }

        public static string ToDescription<T>(this T enumValue) where T : struct
        {
            var value = (Enum)(object)enumValue;
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes.Single().Description : value.ToString();
        }
    }
}

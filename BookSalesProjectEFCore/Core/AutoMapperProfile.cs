using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalesProjectEFCore.Core
{
    public class AutoMapperProfile
    {
        public static T1 MapperConfigure<T1,T2>(T2 t)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullDestinationValues = true;
                cfg.CreateMap<T1, T2>().ReverseMap();
            });
            IMapper mapper = config.CreateMapper();
           return mapper.Map<T1>(t);
        }
        public static T1 MapperConfigure<T1, T2>(T1 t)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullDestinationValues = true;
                cfg.CreateMap<T1, T2>().ReverseMap();
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<T1>(t);
        }
    }
}

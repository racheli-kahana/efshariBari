using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Dto
{
    public class WeightDto
    {
        public WeightDto()
        {

        }
        public int idmishkal { get; set; }
        public Nullable<int> codemitzrach { get; set; }
        public Nullable<int> kodmidaa { get; set; }
        public Nullable<double> mishkal { get; set; }
        public static WeightDto DalToDto(Weight mi)
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Weight, WeightDto>()
            );
            var mapper = new Mapper(config);
            return mapper.Map<WeightDto>(mi);
        }
        public Weight DtoToDal()
        {
            var config = new MapperConfiguration(cfg =>
           cfg.CreateMap<WeightDto, Weight>()
           );
            var mapper = new Mapper(config);
            return mapper.Map<Weight>(this);
        }
    }
}

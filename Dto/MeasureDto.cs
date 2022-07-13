using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{

   public class MeasureDto
    {
        public MeasureDto()
        {

        }
        public int idmida { get; set; }
        public int kodmida { get; set; }
        public string shmmida { get; set; }
        public static MeasureDto DalToDto(Measure mi)
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Measure, MeasureDto>()
            );
            var mapper = new Mapper(config);
            return mapper.Map<MeasureDto>(mi);
        }
        public  Measure DtoToDal()
        {
            var config = new MapperConfiguration(cfg =>
           cfg.CreateMap<MeasureDto, Measure>()
           );
            var mapper = new Mapper(config);
            return mapper.Map<Measure>(this);
        }
   
    }

}

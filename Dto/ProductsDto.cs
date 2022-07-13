using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
  
    public class ProductDto
    {
        public ProductDto()
        {

        }

        public int idprod { get; set; }
        public int code { get; set; }
        public Nullable<int> smlmitrach { get; set; }
        public string shmmitzrach { get; set; }

     //   Dictionary<string,double>
        public double? protein { get; set; }
        public Nullable<double> total_fat { get; set; }
        public Nullable<double> food_energy { get; set; }
        public Nullable<double> carbohydrates { get; set; }
        public Nullable<double> total_dieatry_fiber { get; set; }
        public Nullable<double> calcium { get; set; }
        public Nullable<double> iron { get; set; }
        public Nullable<double> total_sugars { get; set; }
        public Nullable<double> trans_fatty_acids { get; set; }
        public Nullable<double> magnesium { get; set; }
        public Nullable<double> phosphours { get; set; }
        public Nullable<double> potassium { get; set; }
        public Nullable<double> sodium { get; set; }
        public Nullable<double> zinc { get; set; }
        public Nullable<double> cholesterol { get; set; }
        public Nullable<double> saturated_fat { get; set; }
        public Nullable<double> vitamin_a_ui { get; set; }
        public Nullable<double> vitamin_e { get; set; }
        public Nullable<double> vitamin_c { get; set; }
        public Nullable<double> vitamin_a_re { get; set; }
        public Nullable<double> vitamin_k { get; set; }
        public Nullable<double> vitamin_b6 { get; set; }
        public Nullable<double> vitamin_b12 { get; set; }
        public Nullable<double> vitamin_d { get; set; }
        public static ProductDto DalToDto(product pi)
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<product, ProductDto>()
            );
            var mapper = new Mapper(config);
            return mapper.Map<ProductDto>(pi);
        }
        public product DtoToDal()
        {
            var config = new MapperConfiguration(cfg =>
           cfg.CreateMap<ProductDto, product>()
           );
            var mapper = new Mapper(config);
            return mapper.Map<product>(this);
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityProv.Models
{
    public class Province
    {
        [Key]
        [Display(Name="Code")]
        [Required(ErrorMessage="You must enter {0}.")]
        public string ProvinceCode { get; set; }
        
        [Display(Name="Name")]
        [Required(ErrorMessage="You must enter {0}.")]
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CityProv.Models
{
    public class City
    {
        [Key]
        [Display(Name="ID")]
        [Required(ErrorMessage="You must enter {0}.")]
        public int CityId { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage="You must enter {0}.")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display(Name="Province")]
        [Required(ErrorMessage="You must select {0}.")]
        public string ProvinceCode { get; set; }
    }
}
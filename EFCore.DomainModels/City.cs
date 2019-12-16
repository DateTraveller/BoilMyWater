using System.Collections.Generic;

namespace EFCore.DomainModels
{
    public class City
    {
        public City()
        {
            CityCompanies = new List<CityCompany>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }

        public int ProvinceId { get; set; }
        public Province province { get; set; }

        public List<CityCompany> CityCompanies { get; set; }

        public Mayor Mayor { get; set; }
    }
}

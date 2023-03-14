using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB.Entities;

namespace WEB.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel)
        {
            Id = hotel.id;
            Name = hotel.Name;
            CountOfStar = (int)hotel.CountOfStar;
            CodeCountry = hotel.CodeCountry;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStar { get; set; }
        public string CodeCountry { get; set; }
    }
}
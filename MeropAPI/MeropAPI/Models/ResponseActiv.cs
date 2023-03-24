using MeropAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeropAPI.Models
{
    
    public class ResponseActiv
    {
        public ResponseActiv(Активности активности)
        {
            КодАктивности = активности.КодАктивности;
            КодМероприятия = (int)активности.КодМероприятия;
            Победители = активности.Победители;
            НазваниеАтивности = активности.НазваниеАтивности;
            День = (int)активности.День;
            ВремяНачала = (TimeSpan)активности.ВремяНачала;

        }
        public int КодАктивности { get; set; }
        public int КодМероприятия { get; set; }
        public string Победители { get; set; }
        public string НазваниеАтивности { get; set; }
        public int День { get; set; }
        public TimeSpan ВремяНачала { get; set; }

    }
}
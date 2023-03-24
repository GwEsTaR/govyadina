using MeropAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeropAPI.Models
{
    public class ResponseMerop
    {
        public ResponseMerop(Мероприятия мероприятия) 
        {
            КодМероприятия = мероприятия.КодМероприятия;
            КодГорода = мероприятия.КодГорода;
            События = мероприятия.События;
            ДатаНачала = (DateTime)мероприятия.ДатаНачала;
            Продолжительность = (int)мероприятия.Продолжительность;
            КодНаправления = (int)мероприятия.КодНаправления;
            Описание = мероприятия.Описание;
        }

        public int КодМероприятия {get; set;}
        public int КодГорода { get; set;}
        public string События { get; set; }
        public DateTime ДатаНачала { get; set; }
        public int Продолжительность { get; set; }
        public int КодНаправления { get; set; }
        public string Описание { get; set; }
    }
}   
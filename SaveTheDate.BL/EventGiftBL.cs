using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.BL
{
    public class EventGiftBL : IEventGiftBL
    {

        IEventGiftDL _eventGiftDL;
        IMapper mapper;

        public EventGiftBL(IEventGiftDL EventGiftDL)
        {
            _eventGiftDL = EventGiftDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        //GET
        //אותה פונקציה תשמש גם ל:
        //שליפת כל המתנות שהתקבלו ופרטיהם
        //וגם לשליפת הברכות שהתקבלו על המתנה
        //הקריאה תהיה מאנגולר
        public List<EventGift> GetAllGivenGifts(int id)
        {

            return _eventGiftDL.GetAllGivenGifts(id);
        }

        //GET
        //שליפת כל המתנות שלא התקבלו
        public List<EventGift> GetAllUnGivenGifts(int id)
        {
            return _eventGiftDL.GetAllUnGivenGifts(id);
        }

        //PUT
        //הכנסת ברכה ועדכון שהמתנה תפוסה
        //מקבל את ה מזהה של המתנה מתוך רשימת המתנות שהמזמין בחר
        //וכן מקבל את שם האורח שהביא את המתנה במקרה זה היוזר הוא מביא המתנה
        //ומכניס את הברכה המצורפת לטבלה
        public bool GetAGiftFromGuest(int EventGiftID, int userId, string blessing)
        {
            return _eventGiftDL.GetAGiftFromGuest(EventGiftID, userId, blessing);
        }
    }
}

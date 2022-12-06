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

        IEventGiftDL EventGiftDL;
        IMapper mapper;

        public EventGiftBL(IEventGiftDL EventGiftDL)
        {
            this.EventGiftDL = EventGiftDL;
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

            return EventGiftDL.GetAllGivenGifts(id);
        }

        //GET
        //שליפת כל המתנות שלא התקבלו
        public List<EventGift> GetAllUnGivenGifts(int id)
        {
            return EventGiftDL.GetAllUnGivenGifts(id);
        }

        //PUT
        //הכנסת ברכה ועדכון שהמתנה תפוסה
        //מקבל את ה מזהה של המתנה מתוך רשימת המתנות שהמזמין בחר
        //וכן מקבל את שם האורח שהביא את המתנה במקרה זה היוזר הוא מביא המתנה
        //ומכניס את הברכה המצורפת לטבלה
        public bool GetAGiftFromGuest(int EventGiftID, int userId, string blessing)
        {
            return EventGiftDL.GetAGiftFromGuest(EventGiftID, userId, blessing);
        }
    }
}

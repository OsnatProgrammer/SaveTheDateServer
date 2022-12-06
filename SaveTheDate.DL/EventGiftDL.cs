using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class EventGiftDL : IEventGiftDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //GET
        //אותה פונקציה תשמש גם ל:
        //שליפת כל המתנות שהתקבלו ופרטיהם
        //וגם לשליפת הברכות שהתקבלו על המתנה
        //הקריאה תהיה מאנגולר
        public List<EventGift> GetAllGivenGifts(int id)
        {
            try
            {
                return SaveTheDateContext.EventGifts.Where(x => x.EventId == id && x.Status == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //GET
        //שליפת כל המתנות שלא התקבלו
        public List<EventGift> GetAllUnGivenGifts(int id)
        {
            try
            {
                return SaveTheDateContext.EventGifts.Where(x => x.EventId == id && x.Status == false).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT
        //הכנסת ברכה ועדכון שהמתנה תפוסה
        //מקבל את ה מזהה של המתנה מתוך רשימת המתנות שהמזמין בחר
        //וכן מקבל את שם האורח שהביא את המתנה במקרה זה היוזר הוא מביא המתנה
        //ומכניס את הברכה המצורפת לטבלה
        public bool GetAGiftFromGuest(int eventGiftID, int userId, string blessing)
        {
            try
            {
                EventGift currentEventGiftToUpdate = SaveTheDateContext.EventGifts.SingleOrDefault(x => x.Id == eventGiftID);
                EventGift newGift = new EventGift();
                newGift.Id = eventGiftID; newGift.GiftId = currentEventGiftToUpdate.GiftId; newGift.EventId = currentEventGiftToUpdate.EventId;
                newGift.UserId = userId; newGift.Status = true; newGift.Blessing = blessing;

                SaveTheDateContext.Entry(currentEventGiftToUpdate).CurrentValues.SetValues(newGift);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

//------------------------------------------------------------------------------------------------


        // הוספת מתנה שאין ברשימת המתנות.

        public bool AddGift(Gift newGift)
        {
            try
            {
                SaveTheDateContext.Add(newGift);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // מחיקת מתנה מרשימה שמגיעה מהדטה בייס.

        public bool DeleteGift(string giftID)
        {
            try
            {
                Gift currentGiftToDelete = SaveTheDateContext.Gifts.SingleOrDefault(x => x.Id == int.Parse(giftID));
                SaveTheDateContext.Remove(currentGiftToDelete);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Gift GetGiftById(int v)
        {
            try
            {
                return SaveTheDateContext.Gifts.SingleOrDefault(x => x.Id == v);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }



}



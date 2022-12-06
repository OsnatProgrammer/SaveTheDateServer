using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class GiftDL : IGiftDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

       // שליפת כל המתנות שקיימות בדאטה בייס בהתאם לסוג האירוע
        public List<Gift> GetAllGift()
        {
            try
            {
                return SaveTheDateContext.Gifts.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Gift> GetGiftsByEventType(int eventType)
        {
            try
            {
                List<Gift> g = SaveTheDateContext.Gifts.ToList();
                return g.FindAll(x => x.EventTypeId == eventType).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        // הוספת מתנה שאין ברשימת המתנות.


        // מחיקת מתנה מרשימה שמגיעה מהדטה בייס.

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

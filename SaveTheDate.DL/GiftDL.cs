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

        public Gift GetGiftById(int v)
        {
            throw new NotImplementedException();
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
    }
}

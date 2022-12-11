using SaveTheDate.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveTheDate.DL
{
    public class BusDL : IBusDL
    {
        SaveTheDateContext SaveTheDateContext = new SaveTheDateContext();

        //  GET
        //שליפת רשימת הסעות 
        public List<Bus> GetAllBus()
        {
            try
            {
                return SaveTheDateContext.buses.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //שליפת כמות נוסעים לפי מספר אטובוס
        public int GetSumPersonInBus(int busNumber)
        {
            try
            {
                int personNumber = SaveTheDateContext.Guests.Where(x => x.Id.Equals(busNumber)).Count();
                return personNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //שליפת המקומות הריקים בהסעה  
        public int EmptySeatsOnTheBus(int busNumber)
        {
            try
            {
                int reservedSeats = SaveTheDateContext.Guests.Where(x => x.Id.Equals(busNumber)).Count();
                Bus SeatsNumber = SaveTheDateContext.buses.SingleOrDefault(x => x.Id.Equals(busNumber));
                return SeatsNumber.SeatsNum - reservedSeats;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // שליפת כל ההסעות בארוע
        public List<Bus> GetAllBusesOfEvent(int eventId)
        {
            try
            {
                List<Bus> allBusesOfEvent = SaveTheDateContext.buses.Where(x => x.EventId.Equals(eventId)).ToList();
                return allBusesOfEvent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //POST
        // הוספת הסעה לאירוע
        public bool AddBus(Bus newBus)
        {
            try
            {
                SaveTheDateContext.Add(newBus);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // מחיקת הסעה 
        public bool deleteBus(int id)
        {
            try
            {
                Bus currentBusToDelete = SaveTheDateContext.buses.SingleOrDefault(x => x.Id == id);
                SaveTheDateContext.Remove(currentBusToDelete);
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT
        //עדכון מסלול ההסעה 
        public bool UpdateRoute(int busId, string RouteToUpdate)
        {
            try
            {
                Bus busToUpdate = SaveTheDateContext.buses.SingleOrDefault(x => x.Id.Equals(busId));
                busToUpdate.Route = RouteToUpdate;
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // עידכון אדם להסעה  
        public bool UpdateGuestToBus(int guestId, int busId)
        {
            try
            {
                Guest guestToAdd = SaveTheDateContext.Guests.SingleOrDefault(x => x.UserId.Equals(guestId));
                guestToAdd.BusId = busId;
                SaveTheDateContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface ITableDL
    {
        bool AddTable(Table newTable);
        bool DeleteTable(int id);
        List<Table> GetAllTablesOfEvent(int eventId);
        List<Guest> GetNotTakePlaceGuests(int eventId);
        int GetTableByPhone(string phone, int eventId);
        List<Guest> GetTakePlaceGuests(int eventId);
        List<Guest> GuestsInTable(int tableNum);
        bool UpdateGuestToTable(int guestId, int tableNum);
    }
}
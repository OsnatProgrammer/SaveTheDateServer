using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface ITableBL
    {
        bool AddTable(TableDTO newTable);
        bool DeleteTable(int id);
        List<Table> GetAllTablesOfEvent(int eventId);
        List<Guest> GetNotTakePlaceGuests(int eventId);
        int GetTableByPhone(string phone, int eventId);
        List<Guest> GetTakePlaceGuests(int eventId);
        List<Guest> GuestsInTable(int tableNum);
        bool UpdateGuestToTable(int guestId, int tableNum);
    }
}
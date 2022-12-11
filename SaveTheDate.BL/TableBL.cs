using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.BL
{
    public class TableBL : ITableBL
    {
        ITableDL _tableDL;
        IMapper mapper;

        public TableBL(ITableDL TableDL)
        {
            _tableDL = TableDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }


        //POST
        public bool AddTable(TableDTO newTable)
        {
            Table myTable = mapper.Map<TableDTO, Table>(newTable);
            return _tableDL.AddTable(myTable);

        }

        //DELETE
        public bool DeleteTable(int id)
        {
            return _tableDL.DeleteTable(id);
        }

        //GET

        public List<Table> GetAllTablesOfEvent(int eventId)
        {
            return _tableDL.GetAllTablesOfEvent(eventId);
        }

        public List<Guest> GetNotTakePlaceGuests(int eventId)
        {
            return _tableDL.GetNotTakePlaceGuests(eventId);

        }
        public int GetTableByPhone(string phone, int eventId)
        {
            return _tableDL.GetTableByPhone(phone, eventId);

        }
        public List<Guest> GetTakePlaceGuests(int eventId)
        {
            return _tableDL.GetTakePlaceGuests(eventId);

        }
        public List<Guest> GuestsInTable(int tableNum)
        {
            return _tableDL.GuestsInTable(tableNum);

        }

        //PUT
        public bool UpdateGuestToTable(int guestId, int tableNum)
        {
            return _tableDL.UpdateGuestToTable(guestId, tableNum);

        }
    }
}

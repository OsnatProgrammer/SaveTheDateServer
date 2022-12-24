using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.BL
{

    public class GuestBL : IGuestBL
    {
        IGuestDL _guestDL;
        IMapper mapper;

        public GuestBL(IGuestDL GuestDL)
        {
            _guestDL = GuestDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        //POST
        public bool AddGuest(GuestDTO newGuestDTO)
        {
            Guest myGuest = mapper.Map<GuestDTO, Guest>(newGuestDTO);
            return _guestDL.AddGuest(myGuest);
        }

        //DELETE
        public bool DeleteGuest(int GuestID)
        {
            return _guestDL.DeleteGuest(GuestID);
        }

        //GET
      //  public List<EventGiftDTO> GetAllCash(int id)
      //  {
      //      List<EventGift> EventGift = _guestDL.GetAllCash(id);
      //      return mapper.Map<List<EventGift>, List<EventGiftDTO>>(EventGift);
      //
      //  }
        public List<Guest> GetAllConfirmGuests(int id)
        {
            return _guestDL.GetAllConfirmGuests(id);
        }
        public List<Guest> GetAllInvitedGuests(int id)
        {
            return _guestDL.GetAllInvitedGuests(id);
        }
        public List<Guest> GetAllUnConfirmGuests(int id)
        {
            return _guestDL.GetAllUnConfirmGuests(id);
        }
        public Guest GetGuestByPhone(string phone, int eventId)
        {
            return _guestDL.GetGuestByPhone(phone, eventId);

        }
    }
}

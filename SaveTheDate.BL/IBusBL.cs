using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.BL
{
    public interface IBusBL
    {
        int GetSumPersonInBus(int busNumber);
        public List<Bus> GetAllBus();
    }
}
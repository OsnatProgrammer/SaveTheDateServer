using SaveTheDate.DL.Models;
using System.Collections.Generic;

namespace SaveTheDate.DL
{
    public interface IBusDL
    {
        bool AddBus(Bus newBus);
        List<Bus> GetAllBus();
        int GetSumPersonInBus(int busNumber);
    }
}
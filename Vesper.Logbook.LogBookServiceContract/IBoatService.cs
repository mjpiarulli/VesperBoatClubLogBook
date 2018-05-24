using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IBoatService
    {
        List<BoatDto> GetAllBoatsAlphabetical();
        List<BoatDto> GetBoatsByBoatType(string boatType);
        BoatDto AddNewBoat(BoatDto dto);
        BoatDto GetBoatById(int id);
        BoatDto EditBoat(BoatDto dto);
    }
}

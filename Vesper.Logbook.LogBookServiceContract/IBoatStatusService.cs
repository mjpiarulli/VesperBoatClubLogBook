using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IBoatStatusService
    {
        List<BoatStatusDto> GetAllBoatStatusesAlphabetical();
    }
}

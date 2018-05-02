using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IBoatStatusLogService
    {
        List<BoatStatusLogDto> GetAllDamagedBoats();
        List<BoatStatusLogDto> SearchBoatStatusLog(BoatStatusLogSearchParameter searchParam);
    }
}

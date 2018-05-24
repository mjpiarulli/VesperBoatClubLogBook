using System.Collections.Generic;
using Vesper.LogBook.Common;

namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IBoatTypeService
    {
        List<BoatTypeDto> GetAllBoatTypesOrderedBySeats();
    }
}

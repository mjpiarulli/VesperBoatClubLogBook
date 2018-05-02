namespace Vesper.Logbook.LogBookServiceContract
{
    public interface IVesperLogBookService : IMemberService,
        IBoatService,
        ILogBookService,
        IBoatStatusLogService,
        IBoatTypeService
    {
    }
}

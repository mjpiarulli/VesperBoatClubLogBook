namespace Vesper.LogBook.Common
{
    public class UseRestrictionDto
    {
        public UseRestrictionDto()
        {
            UseRestrictionId = 0;
            Restriction = string.Empty;
        }

        public int UseRestrictionId { get; set; }
        public string Restriction { get; set; }
    }
}

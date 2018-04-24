using System.IO;
using System.Web;

namespace Common.Extensions
{
    public static class HttpPostedFileBaseExtensions
    {
        public static byte[] ToBytes(this HttpPostedFileBase hpfb)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                hpfb.InputStream.CopyTo(ms);
                fileBytes = ms.ToArray();
            }

            return fileBytes;
        }
    }
}

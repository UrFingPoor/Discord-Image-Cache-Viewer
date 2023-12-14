using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;

public class HelperLib
{
    public string GetExtFromMemory(string fileName)
    {
        using (var target = new MemoryStream())
        {
            using (FileStream source = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                source.CopyTo(target);
                var contentArray = target.GetBuffer();
                var content = Encoding.ASCII.GetString(contentArray);
                if (content.StartsWith("GIF")) return ".gif.png";
                if (content.Contains("JFIF")) return ".jpg";
                if (content.StartsWith("PNG")) return ".png";
                return string.Empty;
            }
        }
    }
    public bool LoadCheck(string fileName)
    {
        using (var target = new MemoryStream())
        {
            using (FileStream source = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                source.CopyTo(target);
                var contentArray = target.GetBuffer();
                var content = Encoding.ASCII.GetString(contentArray);

                if (content.StartsWith("PNG") || content.Contains("JFIF") || content.StartsWith("GIF"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}

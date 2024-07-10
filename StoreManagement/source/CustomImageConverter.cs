using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.source
{
    public class CustomImageConverter
    {
        private static CustomImageConverter instance;

        public static CustomImageConverter Instance {
            get { if(instance==null) instance=new CustomImageConverter();return instance;}
            private set => instance = value; }

        public CustomImageConverter() { }
        public byte[] ConvertImageToByteArray(Image image)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            
        }
        public Image ConvertByteArrayToImage(byte[] bytes)
        {
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}

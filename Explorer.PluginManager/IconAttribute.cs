using System;
using System.Drawing;
using System.IO;

namespace Explorer.PluginManager
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class IconAttribute : Attribute
    {
        public Image image;

        public IconAttribute(string path)
        {
            if (Path.GetExtension(path).ToLower().CompareTo(".png") != 0)
                throw new Exception("The format of file is not true. files format is png");

            image = Image.FromFile(path);
        }
    }
}

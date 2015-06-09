using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHandler
{
    public class GISLayers
    {
        public static bool IsSupportLayerType(string extension)
        {
            bool isSupport = false;
            if (extension == ".img" || extension == ".tif" || extension == ".shp" || extension == ".mm" || extension == ".mxd")
            {
                isSupport = true;
            }
            return isSupport;
        }
    }
}

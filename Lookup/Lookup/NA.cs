using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lookup
{
    public class NA
    {
        public string UserName { get; set; }
        public string Dimension { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double PosZ { get; set; }
        public NA(string userName, string dimension, double posX, double posY, double posZ)
        {
            UserName = userName;
            Dimension = dimension;
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;



namespace WinFormsApp1
{

    internal class Mob
    {
        public string nameMob;
        public double HPMob;
        public int physicalDepend;
        public int magicDepend;
        public Image mobImg;

        public Mob(string nameMob, double hPMob, int physicalDepend, int magicDepend, Image mobImg)
        {
            this.nameMob = nameMob;
            HPMob = hPMob;
            this.physicalDepend = physicalDepend;
            this.magicDepend = magicDepend;
            this.mobImg = mobImg;
        }
    }
}

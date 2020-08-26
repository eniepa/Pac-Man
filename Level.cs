using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pac_Man
{
    class Level : PictureBox
    {
        public Level()
        {
            InitializeLevel();
        }

        private void InitializeLevel()
        {
            this.BackColor = Color.SteelBlue;
            this.Size = new Size(400, 400);
            this.Location = new Point(20, 20);
            this.Name = "Level";
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Umožní pohybovat borderless oknem
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Objekty ve formuláři
        //Vypnutí programu
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Full Backup Icon to White
        void bi_hover(bool input)
        {
            if(input)
            {
                full_backup_label.ForeColor = Color.White;
                //full_backup_img.BackgroundImage = Image.FromFile("full_backup_icon_hover.png");
            }
            else
            {
                full_backup_label.ForeColor = Color.Black;
                //full_backup_img.BackgroundImage = Image.FromFile("full_backup_icon.png");
            }
        }

        private void full_backup_panel_MouseMove(object sender, MouseEventArgs e)
        {
            bi_hover(true);
        }

        private void full_backup_panel_MouseLeave(object sender, EventArgs e)
        {
            bi_hover(false);
        }
    }
}

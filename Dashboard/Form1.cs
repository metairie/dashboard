using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class main : Form
    {
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        public main()
        {
            InitializeComponent();
        }

        
        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
                this.SetDesktopLocation(MousePosition.X - mouseX - menu.Size.Width, MousePosition.Y - mouseY);
            }
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*int headerX = this.headerpanel.Left;
string message = " mouse X relative = " + (MousePosition.X - headerX) + " mouseX =" + MousePosition.X + " left " +  this.Left;
string caption = "Error Detected in Input";
MessageBoxButtons buttons = MessageBoxButtons.OK;
DialogResult result;
result = MessageBox.Show(message, caption, buttons);*/

    }
}

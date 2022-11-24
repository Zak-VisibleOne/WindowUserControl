using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private Color _controlColor;
        public event EventHandler ColorChanged;
        public Color ControlColor
        {
            get { return _controlColor; }
            set { _controlColor = value; }
        }       
        public UserControl1()
        {
            InitializeComponent();
        }
        private void tb_Scroll(object sender, EventArgs e)
        {
            int redValue = tbRed.Value;
            int blueValue = tbBlue.Value;
            int greenValue = tbGreen.Value;
            Color controlColor = Color.FromArgb(redValue, greenValue, blueValue);
            try
            {
                PanelColor.BackColor = controlColor;
                _controlColor = controlColor;
                OnColorChanged(EventArgs.Empty);
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged.Invoke(this, e);
        }
    }
}

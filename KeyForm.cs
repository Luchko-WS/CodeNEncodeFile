using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace CodeNEncodeFile
{
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();
        }

        [STAThread]
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => Clipboard.SetText(this.textBoxKey.Text));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}

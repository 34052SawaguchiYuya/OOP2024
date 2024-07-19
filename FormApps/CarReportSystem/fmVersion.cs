using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class btVersionOK : Form {
        public btVersionOK() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {
            Close();
        }

        private void fmVersion_Load(object sender,EventArgs e) {
            var asm = Assembly.LoadEventArgs.GetExecutingAssembly();
            var var = asm.GetName().Version;
        }
    }
}

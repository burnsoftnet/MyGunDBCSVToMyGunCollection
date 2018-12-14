using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurnSoft.Universal;
using BurnSoft.mgc.convert.MyGunCollection;
using System.Diagnostics;

namespace MyGunDBCSVToMyGunCollection
{
    public partial class frmMain : Form
    {
        private string DatabaseLocation;

        private void Init()
        {
            BSRegistry obj = new BSRegistry();

            DatabaseLocation = obj.GetRegSubKeyValue(BurnSoft.mgc.convert.MyGunCollection.Registry.DefaultRegPath, "DataBase", "");
            Debug.Print(DatabaseLocation);


        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using SharpUpdate;
using AutoUpdaterDotNET;

namespace UpdateTest2
{
    public partial class Form1 : Form, AutoUpdater.AutoUpdatable
    {
		//private AutoUpdater.AutoUpdater updater;
		public Form1()
        {
            InitializeComponent();
			//updater = new AutoUpdater.AutoUpdater(this);
			label1.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

		public string ApplicationName
		{
			get { return "UpdateTest2"; }
		}

		public string ApplicationID
		{
			get { return "UpdateTest2"; }
		}

		public Language Lang
		{
			get { return new Language("en_"); }
		}

		public Assembly ApplicationAssembly
		{
			get { return Assembly.GetExecutingAssembly(); }
		}

		public Icon ApplicationIcon
		{
			get { return this.Icon; }
		}

		public Uri UpdateXmlLocation
		{
			get { return new Uri("http://etshnetgear.royalwebhosting.net/update.xml"); }
		}

		public Form Context
		{
			get { return this; }
		}

        private void button1_Click(object sender, EventArgs e)
        {
			//updater.DoUpdate(false);
			AutoUpdaterDotNET.AutoUpdater.Start("http://etshnetgear.royalwebhosting.net/UpdateTest2_Update.xml");
		}
    }
}

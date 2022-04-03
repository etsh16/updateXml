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

namespace UpdateTest2
{
    public partial class Form1 : Form, AutoUpdater.AutoUpdatable
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

		public string ApplicationName
		{
			get { return "test"; }
		}

		public string ApplicationID
		{
			get { return "test"; }
		}

		public Language Lang
		{
			get { return null; }
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
			get { return new Uri("https://raw.githubusercontent.com/henryxrl/UpdateTest2/master/UpdateTest2_Update.xml"); }
		}

		public Form Context
		{
			get { return this; }
		}
	}
}

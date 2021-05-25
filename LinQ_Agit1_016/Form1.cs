using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_Agit1_016
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		DataClasses1DataContext db = new DataClasses1DataContext();
		private void button1_Click(object sender, EventArgs e)
		{
			var user = (from s in db.TB_M_USERs where s.USERNAME == txtUsername.Text select s).First();
			if (user.PASSWORD == txtPassword.Text)
			{
				this.Hide();
				MasterProduct a = new MasterProduct();
				a.Show();
			}
			else
			{
				MessageBox.Show("Password Wrong");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		#region Propiedades
		#endregion

		#region Contructores
		public Form1()
		{
			InitializeComponent();
		}
		#endregion

		#region Eventos
		private void Form1_Load(object sender, EventArgs e)
		{
			this.ApplyResources();
		}
		#endregion

		#region Metodos
		private void ApplyResources()
		{
			//this.Text= Resources.UI_LOQUESEA;
		}

		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Test");
		}
	}
}


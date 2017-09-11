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
	public partial class frmTest : Form
	{
		#region Propiedades
		#endregion

		#region Contructores
		public frmTest()
		{
			InitializeComponent();
		}
		#endregion

		#region Eventos
		private void frmTest_Load(object sender, EventArgs e)
		{
			this.ApplyResources();
		}
		#endregion

		#region Metodos
		private void ApplyResources()
		{
			this.Text = Resources.UI_LOQUESEA;
		}
		#endregion


	}
}

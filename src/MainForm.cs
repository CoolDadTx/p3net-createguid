using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreateGuid
{
	public partial class MainForm : Form
	{
		public MainForm ( )
		{
			InitializeComponent();
		}

		#region Protected Members

		#region Methods

		protected override void OnLoad ( EventArgs e )
		{
			base.OnLoad(e);

			System.Collections.ArrayList arr = new System.Collections.ArrayList();

			foreach (Control ctrl in m_cntFormats.Controls)
			{
				if (ctrl is RadioButton)
					arr.Add(ctrl);
			};

			m_Buttons = (RadioButton[])arr.ToArray(typeof(RadioButton));
		}
		#endregion

		#endregion  //Protected Members

		#region Event Handlers

		private void OnCopyClicked ( object sender, EventArgs e )
		{
			CopyResults();
		}

		private void OnCopyNewClicked ( object sender, EventArgs e )
		{
			NewGuid();
			CopyResults();
		}
		
		private void OnExitClicked ( object sender, EventArgs e )
		{
			Close();
		}

		private void OnNewClicked ( object sender, EventArgs e )
		{
			NewGuid();
		}

		private void OnCheckedChanged ( object sender, EventArgs e )
		{
			UpdateResults();
		}
		#endregion //Event Handlers

		#region Private Members

		#region Types

		private enum GuidFormat
		{
			OleCreate = 1,
			DefineGuid,
			ConstStruct,
			RegFormat,
			GuidAttr,
		}
		#endregion

		#region Methods

		private void CopyResults ( )
		{
			Clipboard.SetText(m_txtResults.Text);
		}

		private string GetFormatText ( GuidFormat format )
		{
			StringBuilder bldr = new StringBuilder();

			switch (format)
			{
				case GuidFormat.OleCreate:
				{
					bldr.AppendLine(String.Format("// {0:B}", m_Guid));
					bldr.AppendLine("IMPLEMENT_OLECREATE(<<class>>, <<external_name>>,");
									
					byte[] arr = m_Guid.ToByteArray();
					bldr.AppendFormat("0x{0:x}", BitConverter.ToUInt32(arr, 0));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 4));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 6));
					bldr.AppendFormat(", 0x{0:x}", arr[8]);
					bldr.AppendFormat(", 0x{0:x}", arr[9]);
					bldr.AppendFormat(", 0x{0:x}", arr[10]);
					bldr.AppendFormat(", 0x{0:x}", arr[11]);
					bldr.AppendFormat(", 0x{0:x}", arr[12]);
					bldr.AppendFormat(", 0x{0:x}", arr[13]);
					bldr.AppendFormat(", 0x{0:x}", arr[14]);
					bldr.AppendFormat(", 0x{0:x});", arr[15]);
					bldr.AppendLine();
					break;
				};

				case GuidFormat.DefineGuid:
				{
					bldr.AppendLine(String.Format("// {0:B}", m_Guid));
					bldr.AppendLine("DEFINE_GUID(<<class>>,");

					byte[] arr = m_Guid.ToByteArray();

					bldr.AppendFormat("0x{0:x}", BitConverter.ToUInt32(arr, 0));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 4));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 6));
					bldr.AppendFormat(", 0x{0:x}", arr[8]);
					bldr.AppendFormat(", 0x{0:x}", arr[9]);
					bldr.AppendFormat(", 0x{0:x}", arr[10]);
					bldr.AppendFormat(", 0x{0:x}", arr[11]);
					bldr.AppendFormat(", 0x{0:x}", arr[12]);
					bldr.AppendFormat(", 0x{0:x}", arr[13]);
					bldr.AppendFormat(", 0x{0:x}", arr[14]);
					bldr.AppendFormat(", 0x{0:x});", arr[15]);
					bldr.AppendLine();
					break;
				};

				case GuidFormat.ConstStruct:
				{
					bldr.AppendLine(String.Format("// {0:B}", m_Guid));
					bldr.AppendLine("static const GUID <<name>> =");

					byte[] arr = m_Guid.ToByteArray();

					bldr.AppendFormat("{{ 0x{0:x}", BitConverter.ToUInt32(arr, 0));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 4));
					bldr.AppendFormat(", 0x{0:x}", BitConverter.ToUInt16(arr, 6));
					bldr.AppendFormat(", {{ 0x{0:x}", arr[8]);
					bldr.AppendFormat(", 0x{0:x}", arr[9]);
					bldr.AppendFormat(", 0x{0:x}", arr[10]);
					bldr.AppendFormat(", 0x{0:x}", arr[11]);
					bldr.AppendFormat(", 0x{0:x}", arr[12]);
					bldr.AppendFormat(", 0x{0:x}", arr[13]);
					bldr.AppendFormat(", 0x{0:x}", arr[14]);
					bldr.AppendFormat(", 0x{0:x} }} }};", arr[15]);
					bldr.AppendLine();
					break;
				};

				case GuidFormat.RegFormat:
				{
					bldr.AppendFormat("{0:B}", m_Guid);
					break;
				};

				case GuidFormat.GuidAttr:
				{
					bldr.AppendFormat("[Guid(\"{0:D}\")]", m_Guid);
					break;
				};
			};

			return bldr.ToString();
		}

		private void NewGuid ( )
		{
			m_Guid = Guid.NewGuid();

			UpdateResults();
		}

		private void UpdateResults ( )
		{
			string strText = "";

			foreach(RadioButton btn in m_Buttons)
			{
				if (btn.Checked)
				{
					strText = GetFormatText((GuidFormat)Convert.ToInt32(btn.Tag));
					break;
				};
			};

			m_txtResults.Clear();
			m_txtResults.Text = strText;
		}
		#endregion

		#region Data

		private Guid m_Guid = Guid.NewGuid();
		private RadioButton[] m_Buttons;
		#endregion

		#endregion  //Private Members
	}
}
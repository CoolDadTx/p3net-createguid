namespace CreateGuid
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.Windows.Forms.GroupBox m_cntResults;
			System.Windows.Forms.Button m_btnCopy;
			System.Windows.Forms.Button m_btnNew;
			System.Windows.Forms.Button m_btnExit;
			System.Windows.Forms.Button m_btnCopyNew;
			System.Windows.Forms.RadioButton m_rbFormatOle;
			System.Windows.Forms.RadioButton m_rbFormatDefine;
			System.Windows.Forms.RadioButton m_rbFormatStruct;
			System.Windows.Forms.RadioButton m_rbFormatReg;
			System.Windows.Forms.RadioButton m_rbFormatAttribute;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_txtResults = new System.Windows.Forms.TextBox();
			this.m_cntFormats = new System.Windows.Forms.GroupBox();
			m_cntResults = new System.Windows.Forms.GroupBox();
			m_btnCopy = new System.Windows.Forms.Button();
			m_btnNew = new System.Windows.Forms.Button();
			m_btnExit = new System.Windows.Forms.Button();
			m_btnCopyNew = new System.Windows.Forms.Button();
			m_rbFormatOle = new System.Windows.Forms.RadioButton();
			m_rbFormatDefine = new System.Windows.Forms.RadioButton();
			m_rbFormatStruct = new System.Windows.Forms.RadioButton();
			m_rbFormatReg = new System.Windows.Forms.RadioButton();
			m_rbFormatAttribute = new System.Windows.Forms.RadioButton();
			m_cntResults.SuspendLayout();
			this.m_cntFormats.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_cntResults
			// 
			m_cntResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			m_cntResults.Controls.Add(this.m_txtResults);
			m_cntResults.Location = new System.Drawing.Point(13, 165);
			m_cntResults.Name = "m_cntResults";
			m_cntResults.Size = new System.Drawing.Size(305, 91);
			m_cntResults.TabIndex = 1;
			m_cntResults.TabStop = false;
			m_cntResults.Text = "Results";
			// 
			// m_txtResults
			// 
			this.m_txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_txtResults.Location = new System.Drawing.Point(7, 20);
			this.m_txtResults.Multiline = true;
			this.m_txtResults.Name = "m_txtResults";
			this.m_txtResults.ReadOnly = true;
			this.m_txtResults.ShortcutsEnabled = false;
			this.m_txtResults.Size = new System.Drawing.Size(292, 65);
			this.m_txtResults.TabIndex = 0;
			// 
			// m_btnCopy
			// 
			m_btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			m_btnCopy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			m_btnCopy.Location = new System.Drawing.Point(237, 27);
			m_btnCopy.Name = "m_btnCopy";
			m_btnCopy.Size = new System.Drawing.Size(75, 23);
			m_btnCopy.TabIndex = 2;
			m_btnCopy.Text = "&Copy";
			m_btnCopy.UseVisualStyleBackColor = true;
			m_btnCopy.Click += new System.EventHandler(this.OnCopyClicked);
			// 
			// m_btnNew
			// 
			m_btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			m_btnNew.Location = new System.Drawing.Point(237, 54);
			m_btnNew.Name = "m_btnNew";
			m_btnNew.Size = new System.Drawing.Size(75, 23);
			m_btnNew.TabIndex = 3;
			m_btnNew.Text = "&New GUID";
			m_btnNew.UseVisualStyleBackColor = true;
			m_btnNew.Click += new System.EventHandler(this.OnNewClicked);
			// 
			// m_btnExit
			// 
			m_btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			m_btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			m_btnExit.Location = new System.Drawing.Point(237, 122);
			m_btnExit.Name = "m_btnExit";
			m_btnExit.Size = new System.Drawing.Size(75, 23);
			m_btnExit.TabIndex = 4;
			m_btnExit.Text = "E&xit";
			m_btnExit.UseVisualStyleBackColor = true;
			m_btnExit.Click += new System.EventHandler(this.OnExitClicked);
			// 
			// m_btnCopyNew
			// 
			m_btnCopyNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			m_btnCopyNew.DialogResult = System.Windows.Forms.DialogResult.OK;
			m_btnCopyNew.Location = new System.Drawing.Point(237, 81);
			m_btnCopyNew.Name = "m_btnCopyNew";
			m_btnCopyNew.Size = new System.Drawing.Size(75, 23);
			m_btnCopyNew.TabIndex = 5;
			m_btnCopyNew.Text = "Copy New";
			m_btnCopyNew.UseVisualStyleBackColor = true;
			m_btnCopyNew.Click += new System.EventHandler(this.OnCopyNewClicked);
			// 
			// m_rbFormatOle
			// 
			m_rbFormatOle.AutoSize = true;
			m_rbFormatOle.Location = new System.Drawing.Point(7, 20);
			m_rbFormatOle.Name = "m_rbFormatOle";
			m_rbFormatOle.Size = new System.Drawing.Size(185, 17);
			m_rbFormatOle.TabIndex = 0;
			m_rbFormatOle.TabStop = true;
			m_rbFormatOle.Tag = "1";
			m_rbFormatOle.Text = "&1. IMPLEMENT_OLECREATE(...)";
			m_rbFormatOle.UseVisualStyleBackColor = true;
			m_rbFormatOle.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
			// 
			// m_rbFormatDefine
			// 
			m_rbFormatDefine.AutoSize = true;
			m_rbFormatDefine.Location = new System.Drawing.Point(7, 44);
			m_rbFormatDefine.Name = "m_rbFormatDefine";
			m_rbFormatDefine.Size = new System.Drawing.Size(124, 17);
			m_rbFormatDefine.TabIndex = 1;
			m_rbFormatDefine.Tag = "2";
			m_rbFormatDefine.Text = "&2. DEFINE_GUID(...)";
			m_rbFormatDefine.UseVisualStyleBackColor = true;
			m_rbFormatDefine.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
			// 
			// m_rbFormatStruct
			// 
			m_rbFormatStruct.AutoSize = true;
			m_rbFormatStruct.Location = new System.Drawing.Point(7, 68);
			m_rbFormatStruct.Name = "m_rbFormatStruct";
			m_rbFormatStruct.Size = new System.Drawing.Size(179, 17);
			m_rbFormatStruct.TabIndex = 2;
			m_rbFormatStruct.Tag = "3";
			m_rbFormatStruct.Text = "&3. static const struct GUID = {...}";
			m_rbFormatStruct.UseVisualStyleBackColor = true;
			m_rbFormatStruct.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
			// 
			// m_rbFormatReg
			// 
			m_rbFormatReg.AutoSize = true;
			m_rbFormatReg.Location = new System.Drawing.Point(7, 92);
			m_rbFormatReg.Name = "m_rbFormatReg";
			m_rbFormatReg.Size = new System.Drawing.Size(130, 17);
			m_rbFormatReg.TabIndex = 3;
			m_rbFormatReg.Tag = "4";
			m_rbFormatReg.Text = "&4. Registry Format {...}";
			m_rbFormatReg.UseVisualStyleBackColor = true;
			m_rbFormatReg.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
			// 
			// m_rbFormatAttribute
			// 
			m_rbFormatAttribute.AutoSize = true;
			m_rbFormatAttribute.Checked = true;
			m_rbFormatAttribute.Location = new System.Drawing.Point(7, 116);
			m_rbFormatAttribute.Name = "m_rbFormatAttribute";
			m_rbFormatAttribute.Size = new System.Drawing.Size(116, 17);
			m_rbFormatAttribute.TabIndex = 4;
			m_rbFormatAttribute.TabStop = true;
			m_rbFormatAttribute.Tag = "5";
			m_rbFormatAttribute.Text = "&5. GuidAttribute [...]";
			m_rbFormatAttribute.UseVisualStyleBackColor = true;
			m_rbFormatAttribute.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
			// 
			// m_cntFormats
			// 
			this.m_cntFormats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_cntFormats.Controls.Add(m_rbFormatAttribute);
			this.m_cntFormats.Controls.Add(m_rbFormatReg);
			this.m_cntFormats.Controls.Add(m_rbFormatStruct);
			this.m_cntFormats.Controls.Add(m_rbFormatDefine);
			this.m_cntFormats.Controls.Add(m_rbFormatOle);
			this.m_cntFormats.Location = new System.Drawing.Point(13, 13);
			this.m_cntFormats.Name = "m_cntFormats";
			this.m_cntFormats.Size = new System.Drawing.Size(204, 146);
			this.m_cntFormats.TabIndex = 0;
			this.m_cntFormats.TabStop = false;
			this.m_cntFormats.Text = "GUID Format";
			// 
			// MainForm
			// 
			this.AcceptButton = m_btnCopyNew;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = m_btnExit;
			this.ClientSize = new System.Drawing.Size(330, 268);
			this.Controls.Add(m_btnCopyNew);
			this.Controls.Add(m_btnExit);
			this.Controls.Add(m_btnNew);
			this.Controls.Add(m_btnCopy);
			this.Controls.Add(m_cntResults);
			this.Controls.Add(this.m_cntFormats);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(288, 300);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Create GUID";
			m_cntResults.ResumeLayout(false);
			m_cntResults.PerformLayout();
			this.m_cntFormats.ResumeLayout(false);
			this.m_cntFormats.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox m_txtResults;
		private System.Windows.Forms.GroupBox m_cntFormats;
	}
}


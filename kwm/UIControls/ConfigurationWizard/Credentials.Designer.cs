namespace kwm
{
    partial class Credentials
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkUseDefaultServer = new System.Windows.Forms.CheckBox();
            this.txtKpsAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ErrorMsgTip = new System.Windows.Forms.ToolTip(this.components);
            this.KPSAdressLBL = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkUseDefaultServer
            // 
            this.chkUseDefaultServer.AutoSize = true;
            this.chkUseDefaultServer.Checked = true;
            this.chkUseDefaultServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDefaultServer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDefaultServer.Location = new System.Drawing.Point(6, 3);
            this.chkUseDefaultServer.Name = "chkUseDefaultServer";
            this.chkUseDefaultServer.Size = new System.Drawing.Size(158, 21);
            this.chkUseDefaultServer.TabIndex = 14;
            this.chkUseDefaultServer.Text = "Use the default server";
            this.chkUseDefaultServer.UseVisualStyleBackColor = true;
            this.chkUseDefaultServer.Visible = false;
            this.chkUseDefaultServer.CheckedChanged += new System.EventHandler(this.chkUseDefaultServer_CheckedChanged);
            // 
            // txtKpsAddress
            // 
            this.txtKpsAddress.Enabled = false;
            this.txtKpsAddress.Location = new System.Drawing.Point(123, 27);
            this.txtKpsAddress.Name = "txtKpsAddress";
            this.txtKpsAddress.Size = new System.Drawing.Size(138, 20);
            this.txtKpsAddress.TabIndex = 15;
            this.txtKpsAddress.Visible = false;
            this.txtKpsAddress.TextChanged += new System.EventHandler(this.txtKpsAddress_TextChanged);
            this.txtKpsAddress.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(138, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(123, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(138, 20);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(5, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "New password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(8, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 17);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Your email:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ErrorMsgTip
            // 
            this.ErrorMsgTip.IsBalloon = true;
            this.ErrorMsgTip.ToolTipTitle = "Error";
            // 
            // KPSAdressLBL
            // 
            this.KPSAdressLBL.AutoSize = true;
            this.KPSAdressLBL.Location = new System.Drawing.Point(97, 7);
            this.KPSAdressLBL.Name = "KPSAdressLBL";
            this.KPSAdressLBL.Size = new System.Drawing.Size(38, 13);
            this.KPSAdressLBL.TabIndex = 16;
            this.KPSAdressLBL.Text = "Server";
            this.KPSAdressLBL.Visible = false;
            // 
            // lblServer
            // 
            this.lblServer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(8, 29);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(101, 17);
            this.lblServer.TabIndex = 18;
            this.lblServer.Text = "Server:";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.chkUseDefaultServer);
            this.Controls.Add(this.txtKpsAddress);
            this.Controls.Add(this.KPSAdressLBL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "Credentials";
            this.Size = new System.Drawing.Size(275, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUseDefaultServer;
        private System.Windows.Forms.TextBox txtKpsAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolTip ErrorMsgTip;
        private System.Windows.Forms.Label KPSAdressLBL;
        private System.Windows.Forms.Label lblServer;
    }
}

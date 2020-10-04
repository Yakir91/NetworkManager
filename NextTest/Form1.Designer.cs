namespace NetworkManager
{

    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDisableNetwork = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.toggleSwitch1 = new JCS.ToggleSwitch();
            this.LebBulbIndicator = new NetworkManager.LedBulb();
            this.SuspendLayout();
            // 
            // btnDisableNetwork
            // 
            this.btnDisableNetwork.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableNetwork.Location = new System.Drawing.Point(3, 43);
            this.btnDisableNetwork.Name = "btnDisableNetwork";
            this.btnDisableNetwork.Size = new System.Drawing.Size(121, 19);
            this.btnDisableNetwork.TabIndex = 1;
            this.btnDisableNetwork.Text = "Disable Networks";
            this.btnDisableNetwork.UseVisualStyleBackColor = false;
            this.btnDisableNetwork.Click += new System.EventHandler(this.btnDisableNetwork_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.Location = new System.Drawing.Point(3, 2);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffButtonImage = global::NextTest.Properties.Resources.USA_Flag;
            this.toggleSwitch1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OffForeColor = System.Drawing.Color.Firebrick;
            this.toggleSwitch1.OffText = "US";
            this.toggleSwitch1.OnButtonImage = global::NextTest.Properties.Resources.IL_Flag;
            this.toggleSwitch1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OnForeColor = System.Drawing.Color.White;
            this.toggleSwitch1.OnText = "IL";
            this.toggleSwitch1.Size = new System.Drawing.Size(121, 35);
            this.toggleSwitch1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            this.toggleSwitch1.TabIndex = 0;
            this.toggleSwitch1.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.ToggleSwitch1_CheckedChanged);
            // 
            // ledBulb1
            // 
            this.LebBulbIndicator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LebBulbIndicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LebBulbIndicator.Location = new System.Drawing.Point(132, 8);
            this.LebBulbIndicator.Name = "ledBulb1";
            this.LebBulbIndicator.On = true;
            this.LebBulbIndicator.Size = new System.Drawing.Size(75, 23);
            this.LebBulbIndicator.TabIndex = 2;
            this.LebBulbIndicator.Text = "ledBulb1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(162, 69);
            this.Controls.Add(this.LebBulbIndicator);
            this.Controls.Add(this.btnDisableNetwork);
            this.Controls.Add(this.toggleSwitch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-100, -100);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.ResumeLayout(false);

        }

        #endregion

        private JCS.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Button btnDisableNetwork;
        private System.Diagnostics.Process process1;
        private LedBulb LebBulbIndicator;
    }
}


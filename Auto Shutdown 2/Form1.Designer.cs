namespace Auto_Shutdown_2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonTimedShutdown = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelShutdown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 38);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 4, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(12, 12);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(212, 38);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "labelDate";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTimedShutdown
            // 
            this.buttonTimedShutdown.Location = new System.Drawing.Point(230, 56);
            this.buttonTimedShutdown.Name = "buttonTimedShutdown";
            this.buttonTimedShutdown.Size = new System.Drawing.Size(100, 34);
            this.buttonTimedShutdown.TabIndex = 2;
            this.buttonTimedShutdown.Text = "Shutdown at specified time";
            this.buttonTimedShutdown.UseVisualStyleBackColor = true;
            this.buttonTimedShutdown.Click += new System.EventHandler(this.ButtonTimedShutdown_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonCancelShutdown
            // 
            this.buttonCancelShutdown.Enabled = false;
            this.buttonCancelShutdown.Location = new System.Drawing.Point(230, 96);
            this.buttonCancelShutdown.Name = "buttonCancelShutdown";
            this.buttonCancelShutdown.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelShutdown.TabIndex = 3;
            this.buttonCancelShutdown.Text = "Cancel shutdown";
            this.buttonCancelShutdown.UseVisualStyleBackColor = true;
            this.buttonCancelShutdown.Click += new System.EventHandler(this.ButtonCancelShutdown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Shutdown now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelShutdown);
            this.Controls.Add(this.buttonTimedShutdown);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Auto Shutdown";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonTimedShutdown;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonCancelShutdown;
        private System.Windows.Forms.Button button1;
    }
}


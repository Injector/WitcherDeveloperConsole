
namespace WitcherDebug
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.activate = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findProc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.activateFreeCamera = new System.Windows.Forms.CheckBox();
            this.activateDisableGUI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // activate
            // 
            this.activate.AutoSize = true;
            this.activate.BackColor = System.Drawing.SystemColors.Control;
            this.activate.Font = new System.Drawing.Font("Mason Chronicles", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activate.Location = new System.Drawing.Point(15, 34);
            this.activate.Name = "activate";
            this.activate.Size = new System.Drawing.Size(138, 23);
            this.activate.TabIndex = 0;
            this.activate.Text = "Активировать";
            this.activate.UseVisualStyleBackColor = false;
            this.activate.CheckedChanged += new System.EventHandler(this.activate_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Mason Chronicles", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(669, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Активатор Консоли Разработчика The Witcher: Enhanced Edition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mason Chronicles", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bloomstorm\r\nSunBeam";
            // 
            // findProc
            // 
            this.findProc.AutoSize = true;
            this.findProc.BackColor = System.Drawing.Color.White;
            this.findProc.Font = new System.Drawing.Font("Mason Chronicles", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findProc.Location = new System.Drawing.Point(303, 340);
            this.findProc.Name = "findProc";
            this.findProc.Size = new System.Drawing.Size(243, 24);
            this.findProc.TabIndex = 4;
            this.findProc.Text = "Ищем процесс с игрой...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mason Chronicles", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(740, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "V1.0";
            // 
            // activateFreeCamera
            // 
            this.activateFreeCamera.AutoSize = true;
            this.activateFreeCamera.BackColor = System.Drawing.SystemColors.Control;
            this.activateFreeCamera.Font = new System.Drawing.Font("Mason Chronicles", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activateFreeCamera.Location = new System.Drawing.Point(15, 130);
            this.activateFreeCamera.Name = "activateFreeCamera";
            this.activateFreeCamera.Size = new System.Drawing.Size(179, 23);
            this.activateFreeCamera.TabIndex = 6;
            this.activateFreeCamera.Text = "Свободная камера";
            this.activateFreeCamera.UseVisualStyleBackColor = false;
            this.activateFreeCamera.CheckedChanged += new System.EventHandler(this.activateFreeCamera_CheckedChanged);
            // 
            // activateDisableGUI
            // 
            this.activateDisableGUI.AutoSize = true;
            this.activateDisableGUI.BackColor = System.Drawing.SystemColors.Control;
            this.activateDisableGUI.Font = new System.Drawing.Font("Mason Chronicles", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activateDisableGUI.Location = new System.Drawing.Point(15, 168);
            this.activateDisableGUI.Name = "activateDisableGUI";
            this.activateDisableGUI.Size = new System.Drawing.Size(155, 23);
            this.activateDisableGUI.TabIndex = 7;
            this.activateDisableGUI.Text = "Отключить GUI";
            this.activateDisableGUI.UseVisualStyleBackColor = false;
            this.activateDisableGUI.CheckedChanged += new System.EventHandler(this.disableGUI_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WitcherDebug.Properties.Resources._1800787859_preview_Caer_a_Muirehen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.activateDisableGUI);
            this.Controls.Add(this.activateFreeCamera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.activate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Активатор Консоли Разработчика";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox activate;
        public System.Windows.Forms.Label findProc;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox activateFreeCamera;
        public System.Windows.Forms.CheckBox activateDisableGUI;
    }
}


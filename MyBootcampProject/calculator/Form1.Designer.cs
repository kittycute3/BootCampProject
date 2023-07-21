
namespace calculator
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
            this.lblNameMenu = new System.Windows.Forms.Label();
            this.lbllCalculator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AutoSize = true;
            this.lblNameMenu.Font = new System.Drawing.Font("Verdana", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMenu.Location = new System.Drawing.Point(153, 56);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.Size = new System.Drawing.Size(285, 57);
            this.lblNameMenu.TabIndex = 0;
            this.lblNameMenu.Text = "Welcome!";
            // 
            // lbllCalculator
            // 
            this.lbllCalculator.ActiveLinkColor = System.Drawing.Color.Thistle;
            this.lbllCalculator.AutoSize = true;
            this.lbllCalculator.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllCalculator.LinkColor = System.Drawing.Color.Gray;
            this.lbllCalculator.Location = new System.Drawing.Point(200, 175);
            this.lbllCalculator.Name = "lbllCalculator";
            this.lbllCalculator.Size = new System.Drawing.Size(193, 32);
            this.lbllCalculator.TabIndex = 1;
            this.lbllCalculator.TabStop = true;
            this.lbllCalculator.Text = "Калькулятор";
            this.lbllCalculator.VisitedLinkColor = System.Drawing.Color.DarkSlateBlue;
            this.lbllCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllCalculator_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.lbllCalculator);
            this.Controls.Add(this.lblNameMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameMenu;
        private System.Windows.Forms.LinkLabel lbllCalculator;
    }
}


namespace PizzaCostAllisonC
{
    partial class frmPizzaCost
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNumberOfPizza = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNumberOfPizzas = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblcosttotal = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblcostsubtotal = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCalculate.Font = new System.Drawing.Font("Gentium Book Basic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(186, 139);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNumberOfPizza
            // 
            this.lblNumberOfPizza.AutoSize = true;
            this.lblNumberOfPizza.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizza.Location = new System.Drawing.Point(33, 52);
            this.lblNumberOfPizza.Name = "lblNumberOfPizza";
            this.lblNumberOfPizza.Size = new System.Drawing.Size(243, 19);
            this.lblNumberOfPizza.TabIndex = 1;
            this.lblNumberOfPizza.Text = "How many pizzas would you like? ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(33, 88);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(306, 19);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Enter the diameter (in inches) of the pizza:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(33, 217);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(91, 19);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "The total is:";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(484, 24);
            this.mnuMenu.TabIndex = 4;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // txtNumberOfPizzas
            // 
            this.txtNumberOfPizzas.Location = new System.Drawing.Point(349, 52);
            this.txtNumberOfPizzas.Name = "txtNumberOfPizzas";
            this.txtNumberOfPizzas.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfPizzas.TabIndex = 5;
            this.txtNumberOfPizzas.Text = "1";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(349, 88);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 6;
            // 
            // lblcosttotal
            // 
            this.lblcosttotal.AutoSize = true;
            this.lblcosttotal.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosttotal.Location = new System.Drawing.Point(205, 217);
            this.lblcosttotal.Name = "lblcosttotal";
            this.lblcosttotal.Size = new System.Drawing.Size(0, 19);
            this.lblcosttotal.TabIndex = 7;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(33, 188);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(114, 19);
            this.lblsubtotal.TabIndex = 8;
            this.lblsubtotal.Text = "The subtotal is:";
            // 
            // lblcostsubtotal
            // 
            this.lblcostsubtotal.AutoSize = true;
            this.lblcostsubtotal.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostsubtotal.Location = new System.Drawing.Point(205, 188);
            this.lblcostsubtotal.Name = "lblcostsubtotal";
            this.lblcostsubtotal.Size = new System.Drawing.Size(0, 19);
            this.lblcostsubtotal.TabIndex = 9;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lblcostsubtotal);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.lblcosttotal);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtNumberOfPizzas);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblNumberOfPizza);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost by Allison C";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNumberOfPizza;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtNumberOfPizzas;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblcosttotal;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblcostsubtotal;
    }
}


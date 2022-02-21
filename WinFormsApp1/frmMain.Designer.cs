namespace WinFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDrinks = new System.Windows.Forms.GroupBox();
            this.rdoWater = new System.Windows.Forms.RadioButton();
            this.rdoAppleJuice = new System.Windows.Forms.RadioButton();
            this.rdoChocolateMilk = new System.Windows.Forms.RadioButton();
            this.rdoWhiteMilk = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMeats = new System.Windows.Forms.GroupBox();
            this.rdoSphagetti = new System.Windows.Forms.RadioButton();
            this.rdoHotdog = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.grpVeggies = new System.Windows.Forms.GroupBox();
            this.chkPeas = new System.Windows.Forms.CheckBox();
            this.chkBakedBeans = new System.Windows.Forms.CheckBox();
            this.chkGreenBeans = new System.Windows.Forms.CheckBox();
            this.chkCorn = new System.Windows.Forms.CheckBox();
            this.grpDessert = new System.Windows.Forms.GroupBox();
            this.rdoOrange = new System.Windows.Forms.RadioButton();
            this.rdoApple = new System.Windows.Forms.RadioButton();
            this.rdoVanPudding = new System.Windows.Forms.RadioButton();
            this.rdoCookie = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpDrinks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpMeats.SuspendLayout();
            this.grpVeggies.SuspendLayout();
            this.grpDessert.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDrinks
            // 
            this.grpDrinks.Controls.Add(this.rdoWater);
            this.grpDrinks.Controls.Add(this.rdoAppleJuice);
            this.grpDrinks.Controls.Add(this.rdoChocolateMilk);
            this.grpDrinks.Controls.Add(this.rdoWhiteMilk);
            this.grpDrinks.Location = new System.Drawing.Point(380, 86);
            this.grpDrinks.Name = "grpDrinks";
            this.grpDrinks.Size = new System.Drawing.Size(411, 146);
            this.grpDrinks.TabIndex = 3;
            this.grpDrinks.TabStop = false;
            this.grpDrinks.Text = "Choose your Drink:";
            // 
            // rdoWater
            // 
            this.rdoWater.AutoSize = true;
            this.rdoWater.Location = new System.Drawing.Point(208, 71);
            this.rdoWater.Name = "rdoWater";
            this.rdoWater.Size = new System.Drawing.Size(82, 25);
            this.rdoWater.TabIndex = 3;
            this.rdoWater.TabStop = true;
            this.rdoWater.Text = "Water";
            this.rdoWater.UseVisualStyleBackColor = true;
            // 
            // rdoAppleJuice
            // 
            this.rdoAppleJuice.AutoSize = true;
            this.rdoAppleJuice.Location = new System.Drawing.Point(6, 71);
            this.rdoAppleJuice.Name = "rdoAppleJuice";
            this.rdoAppleJuice.Size = new System.Drawing.Size(131, 25);
            this.rdoAppleJuice.TabIndex = 2;
            this.rdoAppleJuice.TabStop = true;
            this.rdoAppleJuice.Text = "Apple Juice";
            this.rdoAppleJuice.UseVisualStyleBackColor = true;
            // 
            // rdoChocolateMilk
            // 
            this.rdoChocolateMilk.AutoSize = true;
            this.rdoChocolateMilk.Location = new System.Drawing.Point(208, 40);
            this.rdoChocolateMilk.Name = "rdoChocolateMilk";
            this.rdoChocolateMilk.Size = new System.Drawing.Size(163, 25);
            this.rdoChocolateMilk.TabIndex = 1;
            this.rdoChocolateMilk.TabStop = true;
            this.rdoChocolateMilk.Text = "Chocolate Milk";
            this.rdoChocolateMilk.UseVisualStyleBackColor = true;
            // 
            // rdoWhiteMilk
            // 
            this.rdoWhiteMilk.AutoSize = true;
            this.rdoWhiteMilk.Location = new System.Drawing.Point(6, 40);
            this.rdoWhiteMilk.Name = "rdoWhiteMilk";
            this.rdoWhiteMilk.Size = new System.Drawing.Size(126, 25);
            this.rdoWhiteMilk.TabIndex = 0;
            this.rdoWhiteMilk.TabStop = true;
            this.rdoWhiteMilk.Text = "White Milk";
            this.rdoWhiteMilk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 36);
            this.panel1.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(81, 3);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(695, 30);
            this.txtStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // grpMeats
            // 
            this.grpMeats.Controls.Add(this.rdoSphagetti);
            this.grpMeats.Controls.Add(this.rdoHotdog);
            this.grpMeats.Controls.Add(this.rdoHamburger);
            this.grpMeats.Location = new System.Drawing.Point(12, 86);
            this.grpMeats.Name = "grpMeats";
            this.grpMeats.Size = new System.Drawing.Size(308, 146);
            this.grpMeats.TabIndex = 4;
            this.grpMeats.TabStop = false;
            this.grpMeats.Text = "Choose your Meat: ";
            // 
            // rdoSphagetti
            // 
            this.rdoSphagetti.AutoSize = true;
            this.rdoSphagetti.Location = new System.Drawing.Point(6, 102);
            this.rdoSphagetti.Name = "rdoSphagetti";
            this.rdoSphagetti.Size = new System.Drawing.Size(112, 25);
            this.rdoSphagetti.TabIndex = 2;
            this.rdoSphagetti.TabStop = true;
            this.rdoSphagetti.Text = "Sphagetti";
            this.rdoSphagetti.UseVisualStyleBackColor = true;
            // 
            // rdoHotdog
            // 
            this.rdoHotdog.AutoSize = true;
            this.rdoHotdog.Location = new System.Drawing.Point(6, 71);
            this.rdoHotdog.Name = "rdoHotdog";
            this.rdoHotdog.Size = new System.Drawing.Size(93, 25);
            this.rdoHotdog.TabIndex = 1;
            this.rdoHotdog.TabStop = true;
            this.rdoHotdog.Text = "Hotdog";
            this.rdoHotdog.UseVisualStyleBackColor = true;
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(6, 40);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(129, 25);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            // 
            // grpVeggies
            // 
            this.grpVeggies.Controls.Add(this.chkPeas);
            this.grpVeggies.Controls.Add(this.chkBakedBeans);
            this.grpVeggies.Controls.Add(this.chkGreenBeans);
            this.grpVeggies.Controls.Add(this.chkCorn);
            this.grpVeggies.Location = new System.Drawing.Point(12, 259);
            this.grpVeggies.Name = "grpVeggies";
            this.grpVeggies.Size = new System.Drawing.Size(308, 127);
            this.grpVeggies.TabIndex = 4;
            this.grpVeggies.TabStop = false;
            this.grpVeggies.Text = "Choose Two Vegetables: ";
            // 
            // chkPeas
            // 
            this.chkPeas.AutoSize = true;
            this.chkPeas.Location = new System.Drawing.Point(157, 76);
            this.chkPeas.Name = "chkPeas";
            this.chkPeas.Size = new System.Drawing.Size(70, 25);
            this.chkPeas.TabIndex = 3;
            this.chkPeas.Text = "Peas";
            this.chkPeas.UseVisualStyleBackColor = true;
            this.chkPeas.CheckedChanged += new System.EventHandler(this.chkCorn_CheckedChanged);
            // 
            // chkBakedBeans
            // 
            this.chkBakedBeans.AutoSize = true;
            this.chkBakedBeans.Location = new System.Drawing.Point(157, 45);
            this.chkBakedBeans.Name = "chkBakedBeans";
            this.chkBakedBeans.Size = new System.Drawing.Size(141, 25);
            this.chkBakedBeans.TabIndex = 2;
            this.chkBakedBeans.Text = "Baked Beans";
            this.chkBakedBeans.UseVisualStyleBackColor = true;
            this.chkBakedBeans.CheckedChanged += new System.EventHandler(this.chkCorn_CheckedChanged);
            // 
            // chkGreenBeans
            // 
            this.chkGreenBeans.AutoSize = true;
            this.chkGreenBeans.Location = new System.Drawing.Point(6, 76);
            this.chkGreenBeans.Name = "chkGreenBeans";
            this.chkGreenBeans.Size = new System.Drawing.Size(142, 25);
            this.chkGreenBeans.TabIndex = 1;
            this.chkGreenBeans.Text = "Green Beans";
            this.chkGreenBeans.UseVisualStyleBackColor = true;
            this.chkGreenBeans.CheckedChanged += new System.EventHandler(this.chkCorn_CheckedChanged);
            // 
            // chkCorn
            // 
            this.chkCorn.AutoSize = true;
            this.chkCorn.Location = new System.Drawing.Point(4, 45);
            this.chkCorn.Name = "chkCorn";
            this.chkCorn.Size = new System.Drawing.Size(73, 25);
            this.chkCorn.TabIndex = 0;
            this.chkCorn.Text = "Corn";
            this.chkCorn.UseVisualStyleBackColor = true;
            this.chkCorn.CheckedChanged += new System.EventHandler(this.chkCorn_CheckedChanged);
            // 
            // grpDessert
            // 
            this.grpDessert.Controls.Add(this.rdoOrange);
            this.grpDessert.Controls.Add(this.rdoApple);
            this.grpDessert.Controls.Add(this.rdoVanPudding);
            this.grpDessert.Controls.Add(this.rdoCookie);
            this.grpDessert.Location = new System.Drawing.Point(380, 259);
            this.grpDessert.Name = "grpDessert";
            this.grpDessert.Size = new System.Drawing.Size(411, 127);
            this.grpDessert.TabIndex = 4;
            this.grpDessert.TabStop = false;
            this.grpDessert.Text = "Choose a Fruit or Dessert";
            // 
            // rdoOrange
            // 
            this.rdoOrange.AutoSize = true;
            this.rdoOrange.Location = new System.Drawing.Point(208, 71);
            this.rdoOrange.Name = "rdoOrange";
            this.rdoOrange.Size = new System.Drawing.Size(95, 25);
            this.rdoOrange.TabIndex = 3;
            this.rdoOrange.TabStop = true;
            this.rdoOrange.Text = "Orange";
            this.rdoOrange.UseVisualStyleBackColor = true;
            // 
            // rdoApple
            // 
            this.rdoApple.AutoSize = true;
            this.rdoApple.Location = new System.Drawing.Point(208, 40);
            this.rdoApple.Name = "rdoApple";
            this.rdoApple.Size = new System.Drawing.Size(82, 25);
            this.rdoApple.TabIndex = 2;
            this.rdoApple.TabStop = true;
            this.rdoApple.Text = "Apple";
            this.rdoApple.UseVisualStyleBackColor = true;
            // 
            // rdoVanPudding
            // 
            this.rdoVanPudding.AutoSize = true;
            this.rdoVanPudding.Location = new System.Drawing.Point(6, 71);
            this.rdoVanPudding.Name = "rdoVanPudding";
            this.rdoVanPudding.Size = new System.Drawing.Size(170, 25);
            this.rdoVanPudding.TabIndex = 1;
            this.rdoVanPudding.TabStop = true;
            this.rdoVanPudding.Text = "Vanilla Pudding";
            this.rdoVanPudding.UseVisualStyleBackColor = true;
            // 
            // rdoCookie
            // 
            this.rdoCookie.AutoSize = true;
            this.rdoCookie.Location = new System.Drawing.Point(6, 40);
            this.rdoCookie.Name = "rdoCookie";
            this.rdoCookie.Size = new System.Drawing.Size(92, 25);
            this.rdoCookie.TabIndex = 0;
            this.rdoCookie.TabStop = true;
            this.rdoCookie.Text = "Cookie";
            this.rdoCookie.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(236, 63);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(561, 481);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(236, 63);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 556);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpDessert);
            this.Controls.Add(this.grpVeggies);
            this.Controls.Add(this.grpMeats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpDrinks);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.grpDrinks.ResumeLayout(false);
            this.grpDrinks.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMeats.ResumeLayout(false);
            this.grpMeats.PerformLayout();
            this.grpVeggies.ResumeLayout(false);
            this.grpVeggies.PerformLayout();
            this.grpDessert.ResumeLayout(false);
            this.grpDessert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grpDrinks;
        private RadioButton rdoAppleJuice;
        private RadioButton rdoChocolateMilk;
        private RadioButton rdoWhiteMilk;
        private Panel panel1;
        private TextBox txtStudentName;
        private Label label1;
        private RadioButton rdoWater;
        private GroupBox grpMeats;
        private RadioButton rdoSphagetti;
        private RadioButton rdoHotdog;
        private RadioButton rdoHamburger;
        private GroupBox grpVeggies;
        private CheckBox chkPeas;
        private CheckBox chkBakedBeans;
        private CheckBox chkGreenBeans;
        private CheckBox chkCorn;
        private GroupBox grpDessert;
        private RadioButton rdoOrange;
        private RadioButton rdoApple;
        private RadioButton rdoVanPudding;
        private RadioButton rdoCookie;
        private Button btnSubmit;
        private Button btnClear;
    }
}
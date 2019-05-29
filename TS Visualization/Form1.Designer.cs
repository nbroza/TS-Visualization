namespace TS_Visualization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.dragHeader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragArrow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragText = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.btnZoomIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnZoomOUT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblEqn = new System.Windows.Forms.Label();
            this.dropFunction = new Bunifu.Framework.UI.BunifuDropdown();
            this.sldTaylor = new Bunifu.Framework.UI.BunifuSlider();
            this.lblTaylor = new System.Windows.Forms.Label();
            this.lblTaylorVal = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Controls.Add(this.picArrow);
            this.pnlHeader.Location = new System.Drawing.Point(-2, -5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(808, 35);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(69, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(107, 17);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "TS Visualization";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(771, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(29, 29);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picArrow
            // 
            this.picArrow.Image = ((System.Drawing.Image)(resources.GetObject("picArrow.Image")));
            this.picArrow.Location = new System.Drawing.Point(0, 0);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(382, 39);
            this.picArrow.TabIndex = 0;
            this.picArrow.TabStop = false;
            // 
            // dragHeader
            // 
            this.dragHeader.Fixed = true;
            this.dragHeader.Horizontal = true;
            this.dragHeader.TargetControl = this.pnlHeader;
            this.dragHeader.Vertical = true;
            // 
            // dragArrow
            // 
            this.dragArrow.Fixed = true;
            this.dragArrow.Horizontal = true;
            this.dragArrow.TargetControl = this.picArrow;
            this.dragArrow.Vertical = true;
            // 
            // dragText
            // 
            this.dragText.Fixed = true;
            this.dragText.Horizontal = true;
            this.dragText.TargetControl = this.lblHeader;
            this.dragText.Vertical = true;
            // 
            // picGraph
            // 
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGraph.Location = new System.Drawing.Point(13, 37);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(589, 401);
            this.picGraph.TabIndex = 2;
            this.picGraph.TabStop = false;
            // 
            // btnZoomIN
            // 
            this.btnZoomIN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnZoomIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnZoomIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIN.BorderRadius = 0;
            this.btnZoomIN.ButtonText = "";
            this.btnZoomIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIN.DisabledColor = System.Drawing.Color.Gray;
            this.btnZoomIN.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZoomIN.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnZoomIN.Iconimage")));
            this.btnZoomIN.Iconimage_right = null;
            this.btnZoomIN.Iconimage_right_Selected = null;
            this.btnZoomIN.Iconimage_Selected = null;
            this.btnZoomIN.IconMarginLeft = 0;
            this.btnZoomIN.IconMarginRight = 0;
            this.btnZoomIN.IconRightVisible = false;
            this.btnZoomIN.IconRightZoom = 0D;
            this.btnZoomIN.IconVisible = true;
            this.btnZoomIN.IconZoom = 90D;
            this.btnZoomIN.IsTab = false;
            this.btnZoomIN.Location = new System.Drawing.Point(493, 387);
            this.btnZoomIN.Name = "btnZoomIN";
            this.btnZoomIN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnZoomIN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnZoomIN.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZoomIN.selected = false;
            this.btnZoomIN.Size = new System.Drawing.Size(51, 50);
            this.btnZoomIN.TabIndex = 3;
            this.btnZoomIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomIN.Textcolor = System.Drawing.Color.White;
            this.btnZoomIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIN.Click += new System.EventHandler(this.btnZoomIN_Click);
            // 
            // btnZoomOUT
            // 
            this.btnZoomOUT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnZoomOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnZoomOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomOUT.BorderRadius = 0;
            this.btnZoomOUT.ButtonText = "";
            this.btnZoomOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOUT.DisabledColor = System.Drawing.Color.Gray;
            this.btnZoomOUT.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZoomOUT.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnZoomOUT.Iconimage")));
            this.btnZoomOUT.Iconimage_right = null;
            this.btnZoomOUT.Iconimage_right_Selected = null;
            this.btnZoomOUT.Iconimage_Selected = null;
            this.btnZoomOUT.IconMarginLeft = 0;
            this.btnZoomOUT.IconMarginRight = 0;
            this.btnZoomOUT.IconRightVisible = false;
            this.btnZoomOUT.IconRightZoom = 0D;
            this.btnZoomOUT.IconVisible = true;
            this.btnZoomOUT.IconZoom = 90D;
            this.btnZoomOUT.IsTab = false;
            this.btnZoomOUT.Location = new System.Drawing.Point(550, 387);
            this.btnZoomOUT.Name = "btnZoomOUT";
            this.btnZoomOUT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnZoomOUT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnZoomOUT.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZoomOUT.selected = false;
            this.btnZoomOUT.Size = new System.Drawing.Size(51, 50);
            this.btnZoomOUT.TabIndex = 4;
            this.btnZoomOUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomOUT.Textcolor = System.Drawing.Color.White;
            this.btnZoomOUT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOUT.Click += new System.EventHandler(this.btnZoomOUT_Click);
            // 
            // lblEqn
            // 
            this.lblEqn.AutoSize = true;
            this.lblEqn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqn.Location = new System.Drawing.Point(627, 67);
            this.lblEqn.Name = "lblEqn";
            this.lblEqn.Size = new System.Drawing.Size(150, 21);
            this.lblEqn.TabIndex = 6;
            this.lblEqn.Text = "Choose a Function";
            // 
            // dropFunction
            // 
            this.dropFunction.BackColor = System.Drawing.Color.Transparent;
            this.dropFunction.BorderRadius = 3;
            this.dropFunction.DisabledColor = System.Drawing.Color.Gray;
            this.dropFunction.ForeColor = System.Drawing.Color.White;
            this.dropFunction.Items = new string[] {
        "x^2",
        "e^x",
        "sin(x)",
        "cos(x)",
        "ln(1+x)"};
            this.dropFunction.Location = new System.Drawing.Point(619, 91);
            this.dropFunction.Name = "dropFunction";
            this.dropFunction.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dropFunction.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dropFunction.selectedIndex = -1;
            this.dropFunction.Size = new System.Drawing.Size(158, 35);
            this.dropFunction.TabIndex = 8;
            this.dropFunction.onItemSelected += new System.EventHandler(this.dropFunction_onItemSelected);
            // 
            // sldTaylor
            // 
            this.sldTaylor.BackColor = System.Drawing.Color.Transparent;
            this.sldTaylor.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sldTaylor.BorderRadius = 0;
            this.sldTaylor.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.sldTaylor.Location = new System.Drawing.Point(608, 174);
            this.sldTaylor.MaximumValue = 20;
            this.sldTaylor.Name = "sldTaylor";
            this.sldTaylor.Size = new System.Drawing.Size(158, 30);
            this.sldTaylor.TabIndex = 9;
            this.sldTaylor.Value = 0;
            this.sldTaylor.ValueChanged += new System.EventHandler(this.sldTaylor_ValueChanged);
            // 
            // lblTaylor
            // 
            this.lblTaylor.AutoSize = true;
            this.lblTaylor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaylor.Location = new System.Drawing.Point(603, 150);
            this.lblTaylor.Name = "lblTaylor";
            this.lblTaylor.Size = new System.Drawing.Size(193, 21);
            this.lblTaylor.TabIndex = 10;
            this.lblTaylor.Text = "Number of Taylor Terms";
            // 
            // lblTaylorVal
            // 
            this.lblTaylorVal.AutoSize = true;
            this.lblTaylorVal.Location = new System.Drawing.Point(775, 179);
            this.lblTaylorVal.Name = "lblTaylorVal";
            this.lblTaylorVal.Size = new System.Drawing.Size(13, 13);
            this.lblTaylorVal.TabIndex = 11;
            this.lblTaylorVal.Text = "0";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Location = new System.Drawing.Point(677, 129);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(0, 13);
            this.lblCenter.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.lblTaylorVal);
            this.Controls.Add(this.lblTaylor);
            this.Controls.Add(this.sldTaylor);
            this.Controls.Add(this.dropFunction);
            this.Controls.Add(this.lblEqn);
            this.Controls.Add(this.btnZoomOUT);
            this.Controls.Add(this.btnZoomIN);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picArrow;
        private Bunifu.Framework.UI.BunifuDragControl dragHeader;
        private Bunifu.Framework.UI.BunifuDragControl dragArrow;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblHeader;
        private Bunifu.Framework.UI.BunifuDragControl dragText;
        private Bunifu.Framework.UI.BunifuFlatButton btnZoomIN;
        private System.Windows.Forms.PictureBox picGraph;
        private Bunifu.Framework.UI.BunifuFlatButton btnZoomOUT;
        private System.Windows.Forms.Label lblEqn;
        private Bunifu.Framework.UI.BunifuDropdown dropFunction;
        private System.Windows.Forms.Label lblTaylor;
        private Bunifu.Framework.UI.BunifuSlider sldTaylor;
        private System.Windows.Forms.Label lblTaylorVal;
        private System.Windows.Forms.Label lblCenter;
    }
}


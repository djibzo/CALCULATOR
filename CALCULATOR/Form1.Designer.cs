namespace CALCULATOR
{
    partial class CALCULATOR
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALCULATOR));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPm = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnPrct = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.button2);
            this.pnlTitle.Controls.Add(this.button1);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(350, 40);
            this.pnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 40);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(248, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(299, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.txtDisplay2.Location = new System.Drawing.Point(0, 40);
            this.txtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.ReadOnly = true;
            this.txtDisplay2.Size = new System.Drawing.Size(350, 30);
            this.txtDisplay2.TabIndex = 2;
            this.txtDisplay2.TabStop = false;
            this.txtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisplay1.Location = new System.Drawing.Point(0, 70);
            this.txtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.ReadOnly = true;
            this.txtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.txtDisplay1.TabIndex = 3;
            this.txtDisplay1.TabStop = false;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.SlateGray;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Location = new System.Drawing.Point(279, 152);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(70, 61);
            this.btnBackSpace.TabIndex = 4;
            this.btnBackSpace.Text = "CONE";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.SlateGray;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Location = new System.Drawing.Point(136, 152);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(70, 61);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPm
            // 
            this.btnPm.BackColor = System.Drawing.Color.SlateGray;
            this.btnPm.FlatAppearance.BorderSize = 0;
            this.btnPm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPm.Location = new System.Drawing.Point(66, 152);
            this.btnPm.Margin = new System.Windows.Forms.Padding(0);
            this.btnPm.Name = "btnPm";
            this.btnPm.Size = new System.Drawing.Size(70, 61);
            this.btnPm.TabIndex = 6;
            this.btnPm.Text = "+/-";
            this.btnPm.UseVisualStyleBackColor = false;
            this.btnPm.Click += new System.EventHandler(this.BtnSp_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.SlateGray;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(206, 152);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(73, 61);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Firebrick;
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Location = new System.Drawing.Point(277, 213);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(73, 61);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkOrange;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(93, 213);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(101, 61);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkOrange;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(0, 213);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 61);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkOrange;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(188, 213);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 61);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Firebrick;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Location = new System.Drawing.Point(277, 274);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(73, 61);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkOrange;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(93, 274);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(101, 61);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkOrange;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(0, 274);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 61);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkOrange;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(188, 274);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 61);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.Color.Firebrick;
            this.btnSubstract.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubstract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstract.Location = new System.Drawing.Point(277, 335);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(73, 61);
            this.btnSubstract.TabIndex = 4;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = false;
            this.btnSubstract.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkOrange;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(93, 335);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(101, 61);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkOrange;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(0, 335);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 61);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkOrange;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(188, 335);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 61);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Firebrick;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(277, 396);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 61);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkOrange;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(91, 396);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(101, 61);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Firebrick;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Location = new System.Drawing.Point(0, 396);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(95, 61);
            this.btnEquals.TabIndex = 6;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.Firebrick;
            this.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Location = new System.Drawing.Point(188, 396);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(89, 61);
            this.btnDecimal.TabIndex = 7;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnPrct
            // 
            this.btnPrct.BackColor = System.Drawing.Color.SlateGray;
            this.btnPrct.FlatAppearance.BorderSize = 0;
            this.btnPrct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPrct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrct.Location = new System.Drawing.Point(1, 152);
            this.btnPrct.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrct.Name = "btnPrct";
            this.btnPrct.Size = new System.Drawing.Size(70, 61);
            this.btnPrct.TabIndex = 4;
            this.btnPrct.Text = "%";
            this.btnPrct.UseVisualStyleBackColor = false;
            this.btnPrct.Click += new System.EventHandler(this.BtnSp_Click);
            // 
            // CALCULATOR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(350, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPm);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPrct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CALCULATOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPm;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnPrct;
    }
}


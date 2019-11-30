namespace C2_Calculator
{
    partial class mainForm
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
            this.drag_bar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.input_box = new System.Windows.Forms.RichTextBox();
            this.trigModeLbl = new System.Windows.Forms.Label();
            this.modeLbl = new System.Windows.Forms.Label();
            this.solutionLbl = new System.Windows.Forms.Label();
            this.equals_btn = new System.Windows.Forms.Button();
            this.divide_btn = new System.Windows.Forms.Button();
            this.subtract_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.hyperbolic = new System.Windows.Forms.Button();
            this.var_btn = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.pi_btn = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.Button();
            this.e_btn = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.rCaret = new System.Windows.Forms.Button();
            this.lcaret = new System.Windows.Forms.Button();
            this.square_btn = new System.Windows.Forms.Button();
            this.nroot_btn = new System.Windows.Forms.Button();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.nthPower_btn = new System.Windows.Forms.Button();
            this.rPar_btn = new System.Windows.Forms.Button();
            this.lPar_btn = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.indef_int_btn = new System.Windows.Forms.Button();
            this.derivative_btn = new System.Windows.Forms.Button();
            this.def_integral_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.lim_btn = new System.Windows.Forms.Button();
            this.log_btn = new System.Windows.Forms.Button();
            this.ln_btn = new System.Windows.Forms.Button();
            this.cotangent = new System.Windows.Forms.Button();
            this.secant = new System.Windows.Forms.Button();
            this.cosecant = new System.Windows.Forms.Button();
            this.tangent = new System.Windows.Forms.Button();
            this.cosine = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.exit_app = new System.Windows.Forms.Button();
            this.drag_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag_bar
            // 
            this.drag_bar.Controls.Add(this.exit_app);
            this.drag_bar.Controls.Add(this.title);
            this.drag_bar.Location = new System.Drawing.Point(0, 0);
            this.drag_bar.Name = "drag_bar";
            this.drag_bar.Size = new System.Drawing.Size(750, 41);
            this.drag_bar.TabIndex = 0;
            this.drag_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_bar_MouseDown);
            this.drag_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_bar_MouseMove);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(2, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(151, 30);
            this.title.TabIndex = 0;
            this.title.Text = "C2 Calculator";
            // 
            // input_box
            // 
            this.input_box.BackColor = System.Drawing.Color.White;
            this.input_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_box.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_box.Location = new System.Drawing.Point(12, 112);
            this.input_box.Margin = new System.Windows.Forms.Padding(2);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(729, 39);
            this.input_box.TabIndex = 75;
            this.input_box.Text = "";
            this.input_box.TextChanged += new System.EventHandler(this.Input_box_TextChanged);
            this.input_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_box_KeyPress);
            // 
            // trigModeLbl
            // 
            this.trigModeLbl.AutoSize = true;
            this.trigModeLbl.BackColor = System.Drawing.Color.Transparent;
            this.trigModeLbl.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigModeLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.trigModeLbl.Location = new System.Drawing.Point(12, 44);
            this.trigModeLbl.Name = "trigModeLbl";
            this.trigModeLbl.Size = new System.Drawing.Size(0, 17);
            this.trigModeLbl.TabIndex = 2;
            // 
            // modeLbl
            // 
            this.modeLbl.AutoSize = true;
            this.modeLbl.BackColor = System.Drawing.Color.Transparent;
            this.modeLbl.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.modeLbl.Location = new System.Drawing.Point(12, 214);
            this.modeLbl.Name = "modeLbl";
            this.modeLbl.Size = new System.Drawing.Size(56, 17);
            this.modeLbl.TabIndex = 77;
            this.modeLbl.Text = "degrees";
            // 
            // solutionLbl
            // 
            this.solutionLbl.AutoSize = true;
            this.solutionLbl.BackColor = System.Drawing.Color.Transparent;
            this.solutionLbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.solutionLbl.Location = new System.Drawing.Point(651, 44);
            this.solutionLbl.Name = "solutionLbl";
            this.solutionLbl.Size = new System.Drawing.Size(0, 21);
            this.solutionLbl.TabIndex = 78;
            // 
            // equals_btn
            // 
            this.equals_btn.BackColor = System.Drawing.Color.Transparent;
            this.equals_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.equals_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equals_btn.FlatAppearance.BorderSize = 0;
            this.equals_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals_btn.ForeColor = System.Drawing.Color.White;
            this.equals_btn.Location = new System.Drawing.Point(622, 382);
            this.equals_btn.Name = "equals_btn";
            this.equals_btn.Size = new System.Drawing.Size(55, 53);
            this.equals_btn.TabIndex = 74;
            this.equals_btn.Text = "=";
            this.equals_btn.UseVisualStyleBackColor = false;
            this.equals_btn.Click += new System.EventHandler(this.Equals_btn_Click);
            // 
            // divide_btn
            // 
            this.divide_btn.BackColor = System.Drawing.Color.Transparent;
            this.divide_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.divide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divide_btn.FlatAppearance.BorderSize = 0;
            this.divide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_btn.ForeColor = System.Drawing.Color.White;
            this.divide_btn.Location = new System.Drawing.Point(622, 323);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(55, 53);
            this.divide_btn.TabIndex = 73;
            this.divide_btn.Text = "/";
            this.divide_btn.UseVisualStyleBackColor = false;
            this.divide_btn.Click += new System.EventHandler(this.Divide_btn_Click);
            // 
            // subtract_btn
            // 
            this.subtract_btn.BackColor = System.Drawing.Color.Transparent;
            this.subtract_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.subtract_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subtract_btn.FlatAppearance.BorderSize = 0;
            this.subtract_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtract_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_btn.ForeColor = System.Drawing.Color.White;
            this.subtract_btn.Location = new System.Drawing.Point(622, 263);
            this.subtract_btn.Name = "subtract_btn";
            this.subtract_btn.Size = new System.Drawing.Size(55, 53);
            this.subtract_btn.TabIndex = 72;
            this.subtract_btn.Text = "-";
            this.subtract_btn.UseVisualStyleBackColor = false;
            this.subtract_btn.Click += new System.EventHandler(this.Subtract_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(561, 263);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(55, 53);
            this.add_btn.TabIndex = 71;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // mult_btn
            // 
            this.mult_btn.BackColor = System.Drawing.Color.Transparent;
            this.mult_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.mult_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mult_btn.FlatAppearance.BorderSize = 0;
            this.mult_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_btn.ForeColor = System.Drawing.Color.White;
            this.mult_btn.Location = new System.Drawing.Point(561, 323);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(55, 53);
            this.mult_btn.TabIndex = 70;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = false;
            this.mult_btn.Click += new System.EventHandler(this.Mult_btn_Click);
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.Color.Transparent;
            this.zero_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.zero_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zero_btn.FlatAppearance.BorderSize = 0;
            this.zero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_btn.ForeColor = System.Drawing.Color.White;
            this.zero_btn.Location = new System.Drawing.Point(561, 382);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(55, 53);
            this.zero_btn.TabIndex = 69;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            this.zero_btn.Click += new System.EventHandler(this.Zero_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.Color.Transparent;
            this.three_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.three_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.three_btn.FlatAppearance.BorderSize = 0;
            this.three_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_btn.ForeColor = System.Drawing.Color.White;
            this.three_btn.Location = new System.Drawing.Point(500, 381);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(55, 53);
            this.three_btn.TabIndex = 68;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            this.three_btn.Click += new System.EventHandler(this.Three_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.Color.Transparent;
            this.six_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.six_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.six_btn.FlatAppearance.BorderSize = 0;
            this.six_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_btn.ForeColor = System.Drawing.Color.White;
            this.six_btn.Location = new System.Drawing.Point(500, 322);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(55, 53);
            this.six_btn.TabIndex = 67;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            this.six_btn.Click += new System.EventHandler(this.Six_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.Color.Transparent;
            this.nine_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.nine_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nine_btn.FlatAppearance.BorderSize = 0;
            this.nine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_btn.ForeColor = System.Drawing.Color.White;
            this.nine_btn.Location = new System.Drawing.Point(500, 263);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(55, 53);
            this.nine_btn.TabIndex = 66;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.Nine_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.Color.Transparent;
            this.two_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.two_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.two_btn.FlatAppearance.BorderSize = 0;
            this.two_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_btn.ForeColor = System.Drawing.Color.White;
            this.two_btn.Location = new System.Drawing.Point(439, 381);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(55, 53);
            this.two_btn.TabIndex = 65;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            this.two_btn.Click += new System.EventHandler(this.Two_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.Color.Transparent;
            this.five_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.five_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.five_btn.FlatAppearance.BorderSize = 0;
            this.five_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_btn.ForeColor = System.Drawing.Color.White;
            this.five_btn.Location = new System.Drawing.Point(439, 322);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(55, 53);
            this.five_btn.TabIndex = 64;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            this.five_btn.Click += new System.EventHandler(this.Five_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.Color.Transparent;
            this.eight_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.eight_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eight_btn.FlatAppearance.BorderSize = 0;
            this.eight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_btn.ForeColor = System.Drawing.Color.White;
            this.eight_btn.Location = new System.Drawing.Point(439, 263);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(55, 53);
            this.eight_btn.TabIndex = 63;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            this.eight_btn.Click += new System.EventHandler(this.Eight_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.Color.Transparent;
            this.one_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.one_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.one_btn.FlatAppearance.BorderSize = 0;
            this.one_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_btn.ForeColor = System.Drawing.Color.White;
            this.one_btn.Location = new System.Drawing.Point(378, 381);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(55, 53);
            this.one_btn.TabIndex = 62;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            this.one_btn.Click += new System.EventHandler(this.One_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.Color.Transparent;
            this.four_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.four_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.four_btn.FlatAppearance.BorderSize = 0;
            this.four_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_btn.ForeColor = System.Drawing.Color.White;
            this.four_btn.Location = new System.Drawing.Point(378, 322);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(55, 53);
            this.four_btn.TabIndex = 61;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            this.four_btn.Click += new System.EventHandler(this.Four_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.Color.Transparent;
            this.seven_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.lightlight_btn;
            this.seven_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seven_btn.FlatAppearance.BorderSize = 0;
            this.seven_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_btn.ForeColor = System.Drawing.Color.White;
            this.seven_btn.Location = new System.Drawing.Point(378, 263);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(55, 53);
            this.seven_btn.TabIndex = 60;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            this.seven_btn.Click += new System.EventHandler(this.Seven_btn_Click);
            // 
            // hyperbolic
            // 
            this.hyperbolic.BackColor = System.Drawing.Color.Transparent;
            this.hyperbolic.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.hyperbolic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hyperbolic.FlatAppearance.BorderSize = 0;
            this.hyperbolic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hyperbolic.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperbolic.ForeColor = System.Drawing.Color.White;
            this.hyperbolic.Location = new System.Drawing.Point(134, 381);
            this.hyperbolic.Name = "hyperbolic";
            this.hyperbolic.Size = new System.Drawing.Size(55, 53);
            this.hyperbolic.TabIndex = 59;
            this.hyperbolic.Text = "hyp";
            this.hyperbolic.UseVisualStyleBackColor = false;
            this.hyperbolic.Click += new System.EventHandler(this.Hyperbolic_Click);
            // 
            // var_btn
            // 
            this.var_btn.BackColor = System.Drawing.Color.Transparent;
            this.var_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.var_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.var_btn.FlatAppearance.BorderSize = 0;
            this.var_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.var_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_btn.ForeColor = System.Drawing.Color.White;
            this.var_btn.Location = new System.Drawing.Point(73, 381);
            this.var_btn.Name = "var_btn";
            this.var_btn.Size = new System.Drawing.Size(55, 53);
            this.var_btn.TabIndex = 58;
            this.var_btn.Text = "Xy";
            this.var_btn.UseVisualStyleBackColor = false;
            this.var_btn.Click += new System.EventHandler(this.Var_btn_Click);
            // 
            // inverse
            // 
            this.inverse.BackColor = System.Drawing.Color.Transparent;
            this.inverse.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.inverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inverse.FlatAppearance.BorderSize = 0;
            this.inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverse.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse.ForeColor = System.Drawing.Color.White;
            this.inverse.Location = new System.Drawing.Point(134, 322);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(55, 53);
            this.inverse.TabIndex = 57;
            this.inverse.Text = "inv";
            this.inverse.UseVisualStyleBackColor = false;
            this.inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // pi_btn
            // 
            this.pi_btn.BackColor = System.Drawing.Color.Transparent;
            this.pi_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.pi_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pi_btn.FlatAppearance.BorderSize = 0;
            this.pi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pi_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi_btn.ForeColor = System.Drawing.Color.White;
            this.pi_btn.Location = new System.Drawing.Point(73, 322);
            this.pi_btn.Name = "pi_btn";
            this.pi_btn.Size = new System.Drawing.Size(55, 53);
            this.pi_btn.TabIndex = 56;
            this.pi_btn.Text = "pi";
            this.pi_btn.UseVisualStyleBackColor = false;
            this.pi_btn.Click += new System.EventHandler(this.Pi_btn_Click);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.FlatAppearance.BorderSize = 0;
            this.mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode.ForeColor = System.Drawing.Color.White;
            this.mode.Location = new System.Drawing.Point(134, 263);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(55, 53);
            this.mode.TabIndex = 55;
            this.mode.Text = "rad";
            this.mode.UseVisualStyleBackColor = false;
            this.mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // e_btn
            // 
            this.e_btn.BackColor = System.Drawing.Color.Transparent;
            this.e_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.e_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.e_btn.FlatAppearance.BorderSize = 0;
            this.e_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_btn.ForeColor = System.Drawing.Color.White;
            this.e_btn.Location = new System.Drawing.Point(73, 263);
            this.e_btn.Name = "e_btn";
            this.e_btn.Size = new System.Drawing.Size(55, 53);
            this.e_btn.TabIndex = 54;
            this.e_btn.Text = "e";
            this.e_btn.UseVisualStyleBackColor = false;
            this.e_btn.Click += new System.EventHandler(this.E_btn_Click);
            // 
            // dot_btn
            // 
            this.dot_btn.BackColor = System.Drawing.Color.Transparent;
            this.dot_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.dot_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dot_btn.FlatAppearance.BorderSize = 0;
            this.dot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_btn.ForeColor = System.Drawing.Color.White;
            this.dot_btn.Location = new System.Drawing.Point(317, 381);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(55, 53);
            this.dot_btn.TabIndex = 53;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = false;
            this.dot_btn.Click += new System.EventHandler(this.Dot_btn_Click);
            // 
            // rCaret
            // 
            this.rCaret.BackColor = System.Drawing.Color.Transparent;
            this.rCaret.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.rCaret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rCaret.FlatAppearance.BorderSize = 0;
            this.rCaret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rCaret.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCaret.ForeColor = System.Drawing.Color.White;
            this.rCaret.Location = new System.Drawing.Point(256, 381);
            this.rCaret.Name = "rCaret";
            this.rCaret.Size = new System.Drawing.Size(55, 53);
            this.rCaret.TabIndex = 52;
            this.rCaret.Text = ">";
            this.rCaret.UseVisualStyleBackColor = false;
            this.rCaret.Click += new System.EventHandler(this.RCaret_Click);
            // 
            // lcaret
            // 
            this.lcaret.BackColor = System.Drawing.Color.Transparent;
            this.lcaret.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.lcaret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lcaret.FlatAppearance.BorderSize = 0;
            this.lcaret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lcaret.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcaret.ForeColor = System.Drawing.Color.White;
            this.lcaret.Location = new System.Drawing.Point(195, 381);
            this.lcaret.Name = "lcaret";
            this.lcaret.Size = new System.Drawing.Size(55, 53);
            this.lcaret.TabIndex = 51;
            this.lcaret.Text = "<";
            this.lcaret.UseVisualStyleBackColor = false;
            this.lcaret.Click += new System.EventHandler(this.Lcaret_Click);
            // 
            // square_btn
            // 
            this.square_btn.BackColor = System.Drawing.Color.Transparent;
            this.square_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.square_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square_btn.FlatAppearance.BorderSize = 0;
            this.square_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square_btn.ForeColor = System.Drawing.Color.White;
            this.square_btn.Location = new System.Drawing.Point(317, 322);
            this.square_btn.Name = "square_btn";
            this.square_btn.Size = new System.Drawing.Size(55, 53);
            this.square_btn.TabIndex = 50;
            this.square_btn.Text = "^2";
            this.square_btn.UseVisualStyleBackColor = false;
            this.square_btn.Click += new System.EventHandler(this.Square_btn_Click);
            // 
            // nroot_btn
            // 
            this.nroot_btn.BackColor = System.Drawing.Color.Transparent;
            this.nroot_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.nroot_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nroot_btn.FlatAppearance.BorderSize = 0;
            this.nroot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nroot_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroot_btn.ForeColor = System.Drawing.Color.White;
            this.nroot_btn.Location = new System.Drawing.Point(256, 322);
            this.nroot_btn.Name = "nroot_btn";
            this.nroot_btn.Size = new System.Drawing.Size(55, 53);
            this.nroot_btn.TabIndex = 49;
            this.nroot_btn.Text = "root";
            this.nroot_btn.UseVisualStyleBackColor = false;
            this.nroot_btn.Click += new System.EventHandler(this.Nroot_btn_Click);
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.BackColor = System.Drawing.Color.Transparent;
            this.sqrt_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.sqrt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sqrt_btn.FlatAppearance.BorderSize = 0;
            this.sqrt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt_btn.ForeColor = System.Drawing.Color.White;
            this.sqrt_btn.Location = new System.Drawing.Point(195, 322);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.Size = new System.Drawing.Size(55, 53);
            this.sqrt_btn.TabIndex = 48;
            this.sqrt_btn.Text = "sqrt";
            this.sqrt_btn.UseVisualStyleBackColor = false;
            this.sqrt_btn.Click += new System.EventHandler(this.Sqrt_btn_Click);
            // 
            // nthPower_btn
            // 
            this.nthPower_btn.BackColor = System.Drawing.Color.Transparent;
            this.nthPower_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.nthPower_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nthPower_btn.FlatAppearance.BorderSize = 0;
            this.nthPower_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nthPower_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nthPower_btn.ForeColor = System.Drawing.Color.White;
            this.nthPower_btn.Location = new System.Drawing.Point(317, 263);
            this.nthPower_btn.Name = "nthPower_btn";
            this.nthPower_btn.Size = new System.Drawing.Size(55, 53);
            this.nthPower_btn.TabIndex = 47;
            this.nthPower_btn.Text = "^__";
            this.nthPower_btn.UseVisualStyleBackColor = false;
            this.nthPower_btn.Click += new System.EventHandler(this.NthPower_btn_Click);
            // 
            // rPar_btn
            // 
            this.rPar_btn.BackColor = System.Drawing.Color.Transparent;
            this.rPar_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.rPar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rPar_btn.FlatAppearance.BorderSize = 0;
            this.rPar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rPar_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPar_btn.ForeColor = System.Drawing.Color.White;
            this.rPar_btn.Location = new System.Drawing.Point(256, 263);
            this.rPar_btn.Name = "rPar_btn";
            this.rPar_btn.Size = new System.Drawing.Size(55, 53);
            this.rPar_btn.TabIndex = 46;
            this.rPar_btn.Text = ")";
            this.rPar_btn.UseVisualStyleBackColor = false;
            this.rPar_btn.Click += new System.EventHandler(this.RPar_btn_Click);
            // 
            // lPar_btn
            // 
            this.lPar_btn.BackColor = System.Drawing.Color.Transparent;
            this.lPar_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.light_btn;
            this.lPar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lPar_btn.FlatAppearance.BorderSize = 0;
            this.lPar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPar_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPar_btn.ForeColor = System.Drawing.Color.White;
            this.lPar_btn.Location = new System.Drawing.Point(195, 263);
            this.lPar_btn.Name = "lPar_btn";
            this.lPar_btn.Size = new System.Drawing.Size(55, 53);
            this.lPar_btn.TabIndex = 45;
            this.lPar_btn.Text = "(";
            this.lPar_btn.UseVisualStyleBackColor = false;
            this.lPar_btn.Click += new System.EventHandler(this.LPar_btn_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImage = global::C2_Calculator.Properties.Resources.dark_btn;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(12, 381);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 53);
            this.button17.TabIndex = 19;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImage = global::C2_Calculator.Properties.Resources.dark_btn;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(12, 322);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 53);
            this.button16.TabIndex = 18;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImage = global::C2_Calculator.Properties.Resources.dark_btn;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(12, 263);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 53);
            this.button15.TabIndex = 17;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // indef_int_btn
            // 
            this.indef_int_btn.BackColor = System.Drawing.Color.Transparent;
            this.indef_int_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.int_func_btn_;
            this.indef_int_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.indef_int_btn.FlatAppearance.BorderSize = 0;
            this.indef_int_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indef_int_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indef_int_btn.ForeColor = System.Drawing.Color.White;
            this.indef_int_btn.Location = new System.Drawing.Point(686, 234);
            this.indef_int_btn.Name = "indef_int_btn";
            this.indef_int_btn.Size = new System.Drawing.Size(55, 63);
            this.indef_int_btn.TabIndex = 16;
            this.indef_int_btn.Text = "int";
            this.indef_int_btn.UseVisualStyleBackColor = false;
            this.indef_int_btn.Click += new System.EventHandler(this.Indef_int_btn_Click);
            // 
            // derivative_btn
            // 
            this.derivative_btn.BackColor = System.Drawing.Color.Transparent;
            this.derivative_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.int_func_btn_;
            this.derivative_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.derivative_btn.FlatAppearance.BorderSize = 0;
            this.derivative_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.derivative_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derivative_btn.ForeColor = System.Drawing.Color.White;
            this.derivative_btn.Location = new System.Drawing.Point(686, 372);
            this.derivative_btn.Name = "derivative_btn";
            this.derivative_btn.Size = new System.Drawing.Size(55, 63);
            this.derivative_btn.TabIndex = 15;
            this.derivative_btn.Text = "drv";
            this.derivative_btn.UseVisualStyleBackColor = false;
            this.derivative_btn.Click += new System.EventHandler(this.Derivative_btn_Click);
            // 
            // def_integral_btn
            // 
            this.def_integral_btn.BackColor = System.Drawing.Color.Transparent;
            this.def_integral_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.int_func_btn_;
            this.def_integral_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.def_integral_btn.FlatAppearance.BorderSize = 0;
            this.def_integral_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.def_integral_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_integral_btn.ForeColor = System.Drawing.Color.White;
            this.def_integral_btn.Location = new System.Drawing.Point(686, 303);
            this.def_integral_btn.Name = "def_integral_btn";
            this.def_integral_btn.Size = new System.Drawing.Size(55, 63);
            this.def_integral_btn.TabIndex = 14;
            this.def_integral_btn.Text = "def";
            this.def_integral_btn.UseVisualStyleBackColor = false;
            this.def_integral_btn.Click += new System.EventHandler(this.Def_integral_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.clear_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(622, 234);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(55, 23);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Transparent;
            this.del_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(561, 234);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(55, 23);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "del";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // lim_btn
            // 
            this.lim_btn.BackColor = System.Drawing.Color.Transparent;
            this.lim_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.lim_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lim_btn.FlatAppearance.BorderSize = 0;
            this.lim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lim_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lim_btn.ForeColor = System.Drawing.Color.White;
            this.lim_btn.Location = new System.Drawing.Point(500, 234);
            this.lim_btn.Name = "lim_btn";
            this.lim_btn.Size = new System.Drawing.Size(55, 23);
            this.lim_btn.TabIndex = 10;
            this.lim_btn.Text = "lim";
            this.lim_btn.UseVisualStyleBackColor = false;
            this.lim_btn.Click += new System.EventHandler(this.Lim_btn_Click);
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.Transparent;
            this.log_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.log_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(439, 234);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(55, 23);
            this.log_btn.TabIndex = 9;
            this.log_btn.Text = "log";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.Log_btn_Click);
            // 
            // ln_btn
            // 
            this.ln_btn.BackColor = System.Drawing.Color.Transparent;
            this.ln_btn.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.ln_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ln_btn.FlatAppearance.BorderSize = 0;
            this.ln_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ln_btn.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_btn.ForeColor = System.Drawing.Color.White;
            this.ln_btn.Location = new System.Drawing.Point(378, 234);
            this.ln_btn.Name = "ln_btn";
            this.ln_btn.Size = new System.Drawing.Size(55, 23);
            this.ln_btn.TabIndex = 8;
            this.ln_btn.Text = "ln";
            this.ln_btn.UseVisualStyleBackColor = false;
            this.ln_btn.Click += new System.EventHandler(this.Ln_btn_Click);
            // 
            // cotangent
            // 
            this.cotangent.BackColor = System.Drawing.Color.Transparent;
            this.cotangent.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.cotangent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cotangent.FlatAppearance.BorderSize = 0;
            this.cotangent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cotangent.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cotangent.ForeColor = System.Drawing.Color.White;
            this.cotangent.Location = new System.Drawing.Point(317, 234);
            this.cotangent.Name = "cotangent";
            this.cotangent.Size = new System.Drawing.Size(55, 23);
            this.cotangent.TabIndex = 7;
            this.cotangent.Text = "cot";
            this.cotangent.UseVisualStyleBackColor = false;
            this.cotangent.Click += new System.EventHandler(this.Cotangent_Click);
            // 
            // secant
            // 
            this.secant.BackColor = System.Drawing.Color.Transparent;
            this.secant.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.secant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secant.FlatAppearance.BorderSize = 0;
            this.secant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secant.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secant.ForeColor = System.Drawing.Color.White;
            this.secant.Location = new System.Drawing.Point(256, 234);
            this.secant.Name = "secant";
            this.secant.Size = new System.Drawing.Size(55, 23);
            this.secant.TabIndex = 6;
            this.secant.Text = "sec";
            this.secant.UseVisualStyleBackColor = false;
            this.secant.Click += new System.EventHandler(this.Secant_Click);
            // 
            // cosecant
            // 
            this.cosecant.BackColor = System.Drawing.Color.Transparent;
            this.cosecant.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.cosecant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cosecant.FlatAppearance.BorderSize = 0;
            this.cosecant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosecant.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosecant.ForeColor = System.Drawing.Color.White;
            this.cosecant.Location = new System.Drawing.Point(195, 234);
            this.cosecant.Name = "cosecant";
            this.cosecant.Size = new System.Drawing.Size(55, 23);
            this.cosecant.TabIndex = 5;
            this.cosecant.Text = "csc";
            this.cosecant.UseVisualStyleBackColor = false;
            this.cosecant.Click += new System.EventHandler(this.Cosecant_Click);
            // 
            // tangent
            // 
            this.tangent.BackColor = System.Drawing.Color.Transparent;
            this.tangent.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.tangent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tangent.FlatAppearance.BorderSize = 0;
            this.tangent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tangent.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tangent.ForeColor = System.Drawing.Color.White;
            this.tangent.Location = new System.Drawing.Point(134, 234);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(55, 23);
            this.tangent.TabIndex = 4;
            this.tangent.Text = "tan";
            this.tangent.UseVisualStyleBackColor = false;
            this.tangent.Click += new System.EventHandler(this.Tangent_Click);
            // 
            // cosine
            // 
            this.cosine.BackColor = System.Drawing.Color.Transparent;
            this.cosine.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.cosine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cosine.FlatAppearance.BorderSize = 0;
            this.cosine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosine.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosine.ForeColor = System.Drawing.Color.White;
            this.cosine.Location = new System.Drawing.Point(73, 234);
            this.cosine.Name = "cosine";
            this.cosine.Size = new System.Drawing.Size(55, 23);
            this.cosine.TabIndex = 3;
            this.cosine.Text = "cos";
            this.cosine.UseVisualStyleBackColor = false;
            this.cosine.Click += new System.EventHandler(this.Cosine_Click);
            // 
            // sine
            // 
            this.sine.BackColor = System.Drawing.Color.Transparent;
            this.sine.BackgroundImage = global::C2_Calculator.Properties.Resources.top_row_btn;
            this.sine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sine.FlatAppearance.BorderSize = 0;
            this.sine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sine.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sine.ForeColor = System.Drawing.Color.White;
            this.sine.Location = new System.Drawing.Point(12, 234);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(55, 23);
            this.sine.TabIndex = 2;
            this.sine.Text = "sin";
            this.sine.UseVisualStyleBackColor = false;
            this.sine.Click += new System.EventHandler(this.Sine_Click);
            // 
            // exit_app
            // 
            this.exit_app.BackColor = System.Drawing.Color.Transparent;
            this.exit_app.BackgroundImage = global::C2_Calculator.Properties.Resources.steelblue_ext;
            this.exit_app.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_app.FlatAppearance.BorderSize = 0;
            this.exit_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_app.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_app.Location = new System.Drawing.Point(720, 12);
            this.exit_app.Margin = new System.Windows.Forms.Padding(2);
            this.exit_app.Name = "exit_app";
            this.exit_app.Size = new System.Drawing.Size(15, 16);
            this.exit_app.TabIndex = 1;
            this.exit_app.UseVisualStyleBackColor = false;
            this.exit_app.Click += new System.EventHandler(this.Exit_app_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 447);
            this.Controls.Add(this.solutionLbl);
            this.Controls.Add(this.modeLbl);
            this.Controls.Add(this.trigModeLbl);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.equals_btn);
            this.Controls.Add(this.divide_btn);
            this.Controls.Add(this.subtract_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.hyperbolic);
            this.Controls.Add(this.var_btn);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.pi_btn);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.e_btn);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.rCaret);
            this.Controls.Add(this.lcaret);
            this.Controls.Add(this.square_btn);
            this.Controls.Add(this.nroot_btn);
            this.Controls.Add(this.sqrt_btn);
            this.Controls.Add(this.nthPower_btn);
            this.Controls.Add(this.rPar_btn);
            this.Controls.Add(this.lPar_btn);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.indef_int_btn);
            this.Controls.Add(this.derivative_btn);
            this.Controls.Add(this.def_integral_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.lim_btn);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.ln_btn);
            this.Controls.Add(this.cotangent);
            this.Controls.Add(this.secant);
            this.Controls.Add(this.cosecant);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.cosine);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.drag_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "C2 Calculator";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.drag_bar.ResumeLayout(false);
            this.drag_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drag_bar;
        private System.Windows.Forms.Button exit_app;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button sine;
        private System.Windows.Forms.Button cosine;
        private System.Windows.Forms.Button tangent;
        private System.Windows.Forms.Button cosecant;
        private System.Windows.Forms.Button secant;
        private System.Windows.Forms.Button cotangent;
        private System.Windows.Forms.Button ln_btn;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Button lim_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button def_integral_btn;
        private System.Windows.Forms.Button derivative_btn;
        private System.Windows.Forms.Button indef_int_btn;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button rCaret;
        private System.Windows.Forms.Button lcaret;
        private System.Windows.Forms.Button square_btn;
        private System.Windows.Forms.Button nroot_btn;
        private System.Windows.Forms.Button sqrt_btn;
        private System.Windows.Forms.Button nthPower_btn;
        private System.Windows.Forms.Button rPar_btn;
        private System.Windows.Forms.Button lPar_btn;
        private System.Windows.Forms.Button hyperbolic;
        private System.Windows.Forms.Button var_btn;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button pi_btn;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Button e_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button subtract_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button equals_btn;
        private System.Windows.Forms.RichTextBox input_box;
        private System.Windows.Forms.Label trigModeLbl;
        private System.Windows.Forms.Label modeLbl;
        private System.Windows.Forms.Label solutionLbl;
    }
}


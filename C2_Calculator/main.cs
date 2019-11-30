using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2_Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            input_box.SelectAll();
            input_box.SelectionAlignment = HorizontalAlignment.Center;
            input_box.DeselectAll();
            center = true;
            input_box.Focus();
        }

        #region ApplicationEvents

        //
        // on click the user may exit the application
        //
        private void Exit_app_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // allows user to drag the application around their screen and re position it in another spot
        //
        private void Drag_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        static Point lastPoint;
        private void Drag_bar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            input_box.Focus();
        }

        #endregion

        #region Buttons

        private void Equals_btn_Click(object sender, EventArgs e)
        {
            solutionLbl.Text = "SOLUTION";
            solveProblem();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            solutionLbl.Text = "";

            Font currentFont = input_box.Font;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Regular);

            input_box.Clear();
            input_box.Focus();
            input_box.Font = new Font(currentFont.FontFamily, 18, newFontStyle);

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            if (input_box.Text.Length > 0)
            {
                input_box.Text = input_box.Text.Remove(input_box.Text.Length - 1, 1);
                deletePrevChar(input_box);
            }
            input_box.Focus();
            input_box.SelectionStart = caret_pos;
        }

        //
        // buttons that dont work fully yet
        //

        private void Inverse_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            if (trigModeLbl.Text == null || trigModeLbl.Text == "")
            {
                trigModeLbl.Text = "* inverse selected";
                sine.Text = "arcsin";
                cosine.Text = "arccos";
                tangent.Text = "arctan";
                cosecant.Text = "arccsc";
                secant.Text = "arcsec";
                cotangent.Text = "arccot";
            }
            else if (trigModeLbl.Text == "* inverse selected")
            {
                trigModeLbl.Text = "";
                sine.Text = "sin";
                cosine.Text = "cos";
                tangent.Text = "tan";
                cosecant.Text = "csc";
                secant.Text = "sec";
                cotangent.Text = "cot";
            }
            else if (trigModeLbl.Text == "* hyperbolic selected")
            {
                trigModeLbl.Text = "* inverse selected";
                sine.Text = "arcsin";
                cosine.Text = "arccos";
                tangent.Text = "arctan";
                cosecant.Text = "arccsc";
                secant.Text = "arcsec";
                cotangent.Text = "arccot";
            }
            input_box.Focus();
            input_box.SelectionStart = caret_pos;
        }

        private void Hyperbolic_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            if (trigModeLbl.Text == null || trigModeLbl.Text == "")
            {
                trigModeLbl.Text = "* hyperbolic selected";
                sine.Text = "sinh";
                cosine.Text = "cosh";
                tangent.Text = "tanh";
                cosecant.Text = "csch";
                secant.Text = "sech";
                cotangent.Text = "coth";
            }
            else if (trigModeLbl.Text == "* hyperbolic selected")
            {
                trigModeLbl.Text = "";
                sine.Text = "sin";
                cosine.Text = "cos";
                tangent.Text = "tan";
                cosecant.Text = "csc";
                secant.Text = "sec";
                cotangent.Text = "cot";
            }
            else if (trigModeLbl.Text == "* inverse selected")
            {
                trigModeLbl.Text = "* hyperbolic selected";
                sine.Text = "sinh";
                cosine.Text = "cosh";
                tangent.Text = "tanh";
                cosecant.Text = "csch";
                secant.Text = "sech";
                cotangent.Text = "coth";
            }
            input_box.Focus();
            input_box.SelectionStart = caret_pos;
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            if (modeLbl.Text == "degrees")
            {
                modeLbl.Text = "radians";
                mode.Text = "deg";
            }
            else
            {
                modeLbl.Text = "degrees";
                mode.Text = "rad";
            }
            input_box.Focus();
            input_box.SelectionStart = caret_pos;
        }

        private void E_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "e";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Pi_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "π";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Var_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "x";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void LPar_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "(";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void RPar_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = ")";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Sqrt_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "√()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Nroot_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "{}√()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Lcaret_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            input_box.Focus();
            input_box.SelectionStart = caret_pos - 1;
        }

        private void RCaret_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            input_box.Focus();
            input_box.SelectionStart = caret_pos + 1;
        }

        private void Dot_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = ".";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Square_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "^(2)";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void NthPower_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "^()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void One_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "1";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Two_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "2";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Three_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "3";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Zero_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "0";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Four_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "4";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Five_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "5";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Six_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "6";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Seven_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "7";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Eight_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "8";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Nine_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "9";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "+";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Mult_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "*";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Subtract_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "-";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "/";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length;
        }

        private void Sine_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Cosine_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Tangent_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Cosecant_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Secant_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Cotangent_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Ln_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "{10}()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Lim_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = (sender as Button).Text + "{}{}()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Indef_int_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "∫[]";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Def_integral_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "∫{a}{b}[]";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Derivative_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "ƒ'[]";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        #endregion

        #region InputBoxEvents

        static bool center;
        private void Input_box_TextChanged(object sender, EventArgs e)
        {
            //
            // horizontally aligns text to the center of the textbox
            //

            int caret_pos = (sender as RichTextBox).SelectionStart;

            if (center)
            {
                (sender as RichTextBox).SelectAll();
                (sender as RichTextBox).SelectionAlignment = HorizontalAlignment.Center;
                (sender as RichTextBox).DeselectAll();
            }
            
            //
            // fits the text to the application
            //

            Font currentFont = (sender as RichTextBox).Font;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Regular);
            int width = TextRenderer.MeasureText((sender as RichTextBox).Text, (sender as RichTextBox).Font).Width;
            
            if ((width >= (sender as RichTextBox).Width) && ((sender as RichTextBox).Font.Size - 1) > 8)
            {
                (sender as RichTextBox).Font = new Font(currentFont.FontFamily, ((sender as RichTextBox).Font.Size - 1), newFontStyle);
            }
            else if (((sender as RichTextBox).Font.Size == 8) && (width >= (sender as RichTextBox).Width))
            {
                center = false;
            }

            //
            // assigns reference colors to an array
            //

            Color[] txtColors = new Color[6];
            txtColors[0] = Color.Red;
            txtColors[1] = Color.Green;
            txtColors[2] = Color.Blue;
            txtColors[3] = Color.Orange;
            txtColors[4] = Color.Purple;
            txtColors[5] = Color.Black;

            int colorSelect = 0, prevColor = 0;

            //
            // sets colors for coordination and user ease
            //

            int lPars = 0, rPars = 0;

            for (int i = 0; i < input_box.Text.Length; i++)
            {
                if (input_box.Text.Substring(i, 1) == "(")
                {
                    if (colorSelect > 4)
                    {
                        colorSelect = 0;
                    }
                    prevColor = colorSelect;

                    lPars++;
                    if (lPars == rPars+1)
                    {
                        input_box.Select(i, input_box.Text.Length - i);
                        input_box.SelectionColor = Color.Black;
                        input_box.DeselectAll();
                    }
                    else if (lPars > 1)
                    {
                        input_box.Select(i, input_box.Text.Length - i);
                        input_box.SelectionColor = txtColors[colorSelect];
                        input_box.DeselectAll();
                        colorSelect++;
                    }

                    if (i > 0)
                    {
                        if ((input_box.Text.Substring(i - 1, 1).All(char.IsLetter)) && lPars > 1)
                        {
                            for (int c = i-1; c > 0; c--)
                            {
                                if ((input_box.Text.Substring(c, 1).All(char.IsLetterOrDigit)))
                                {
                                    input_box.Select(c, 1);
                                    input_box.SelectionColor = txtColors[prevColor];
                                    input_box.DeselectAll();
                                }
                                else
                                {
                                    c = 0;
                                }
                            }
                        }
                    }
                }
                else if (input_box.Text.Substring(i, 1) == ")")
                {
                    rPars++;
                    if (rPars <= lPars)
                    {
                        colorSelect--;
                        if (colorSelect < 0)
                        {
                            colorSelect = 4;
                        }

                        if (rPars != lPars)
                        {
                            input_box.Select(i, input_box.Text.Length - i);
                            input_box.SelectionColor = txtColors[colorSelect];
                            input_box.DeselectAll();
                        }
                        else
                        {
                            input_box.Select(i, input_box.Text.Length - i);
                            input_box.SelectionColor = Color.Black;
                            input_box.DeselectAll();
                        }
                    }

                }
            }

            (sender as RichTextBox).SelectionStart = caret_pos;
        }

        private void Input_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Convert.ToInt32(e.KeyChar))
            {
                case 8:
                    deletePrevChar((sender as RichTextBox));
                    break;
                default:
                    break;
            }
        }

        private void deletePrevChar(Object sender)
        {
            Font currentFont = (sender as RichTextBox).Font;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Regular);

            //
            // scales text back up as the user deletes text
            //
            if (TextRenderer.MeasureText((sender as RichTextBox).Text, (sender as RichTextBox).Font).Width * 1.1 < (sender as RichTextBox).Width && ((sender as RichTextBox).Font.Size < 18))
            {
                (sender as RichTextBox).Font = new Font(currentFont.FontFamily, ((sender as RichTextBox).Font.Size + 1), newFontStyle);
            }
        }

        #endregion

        #region Solution

        private void solveProblem()
        {
            string answer = readProblem(0, input_box.Text.Length);
        }

        private string readProblem(int start, int readLength)
        {
            string problem = input_box.Text, tempStr = null, solution = null, operation;
            int LH = 0, RH = 1;
            int a = 0, b = 0;
            int lBracCount = 0, rBracCount = 0;
            bool isNumeric = true, integrated = false;
            int operand1 = 0, operand2 = 0;

            if (problem.Substring(LH, 1) == "∫")
            {
                LH++;
                // identifies string as definite integral
                if (problem.Substring(LH, 1) == "{")
                {
                    LH++;
                    RH = 1;
                    do
                    {
                        if (problem.Substring(LH, RH).All(char.IsNumber))
                        {
                            RH++;
                            isNumeric = true;
                        }
                        else
                        {
                            isNumeric = false;
                        }
                    } while (isNumeric);
                    a = int.Parse(problem.Substring(LH, RH - 1));

                    LH = LH + RH + 1;
                    RH = 1;
                    do
                    {
                        if (problem.Substring(LH, RH).All(char.IsNumber))
                        {
                            RH++;
                            isNumeric = true;
                        }
                        else
                        {
                            isNumeric = false;
                        }
                    } while (isNumeric);
                    b = int.Parse(problem.Substring(LH, RH - 1));

                    LH = LH + RH + 1;
                    do
                    {
                        if (problem.Substring(LH, 1) == "∫")
                        {
                            //
                            // handler if there is an integral inside of an integral
                            //

                            lBracCount++;
                            for (int d = 0; d < problem.Length - LH; d++)
                            {
                                if (problem.Substring(d + LH, 1) == "[")
                                {
                                    lBracCount++;
                                }
                                else if (problem.Substring(d + LH, 1) == "]")
                                {
                                    rBracCount++;
                                }

                                if (rBracCount == lBracCount && lBracCount > 1)
                                {
                                    RH = d + LH;
                                    d = problem.Length;
                                }
                            }

                            //
                            // returns simplification to everything inside of the brackets before integrating
                            //

                            tempStr = readProblem(LH - 1, RH);

                            //
                            // perform integration of inside stuff
                            //

                        }
                        else if (problem.Substring(LH, 1) == "ƒ")
                        {
                            //
                            // handler for if there is a derivative inside of a definite integral
                            //
                        }
                        else
                        {
                            //
                            // integrate text
                            //

                            //
                            // remember to check end points for integration
                            //
                        }

                    } while (!integrated);

                }
                // identifies the string as an indefinite integral
                else if (problem.Substring(LH, 1) == "[")
                {
                    LH++;
                    do
                    {
                        if (problem.Substring(LH, 1) == "∫")
                        {
                            //
                            // handler if there is an integral inside of an integral
                            //

                            lBracCount++;
                            for (int d = 0; d < problem.Length - LH; d++)
                            {
                                if (problem.Substring(d + LH, 1) == "[")
                                {
                                    lBracCount++;
                                }
                                else if (problem.Substring(d + LH, 1) == "]")
                                {
                                    rBracCount++;
                                }

                                if (rBracCount == lBracCount && lBracCount > 1)
                                {
                                    RH = d + LH;
                                    d = problem.Length;
                                }
                            }

                            //
                            // returns simplification to everything inside of the brackets before integrating
                            //

                            tempStr = readProblem(LH - 1, RH);

                            //
                            // perform integration of inside stuff
                            //

                        }
                        else if (problem.Substring(LH, 1) == "ƒ")
                        {
                            //
                            // handler for if there is a derivative inside of a definite integral
                            //
                        }
                        else
                        {
                            //
                            // integrate text
                            //

                            //
                            // remember to check endpoints for integration
                            //
                        }

                    } while (!integrated);

                }
                else
                {
                    //
                    // ERROR: USER SHOULD NOT GET HERE
                    //
                }
            }
            else if (problem.Substring(LH, 1).All(char.IsNumber) || problem.Substring(LH, 1).All(char.IsDigit) || problem.Substring(LH, 1) == ".")
            {
                //
                // keep special attention to the '.'
                //

                RH = 1;
                do
                {
                    if (problem.Substring(LH, RH).All(char.IsNumber))
                    {
                        RH++;
                        isNumeric = true;
                    }
                    else
                    {
                        isNumeric = false;
                    }
                } while (isNumeric);
                operand1 = int.Parse(problem.Substring(LH, RH - 1));

                LH = RH - 1;

                //
                // get operation to perform on operand1
                //

                RH = 1;
                if (problem.Substring(LH, RH) == "+")
                {
                    operation = "+";
                    LH++;
                }
                else if (problem.Substring(LH, RH) == "-")
                {
                    operation = "-";
                    LH++;
                }
                else if (problem.Substring(LH, RH) == "*")
                {
                    operation = "*";
                    LH++;
                }
                else if (problem.Substring(LH, RH) == "/")
                {
                    operation = "/";
                    LH++;
                }
                else if (problem.Substring(LH, RH) == "^")
                {
                    operation = "^";
                    LH++;
                }
                else if (problem.Substring(LH, RH) == "(" || problem.Substring(LH, RH) == "{" || problem.Substring(LH, RH).All(char.IsLetter) || problem.Substring(LH, RH) == "ƒ" || problem.Substring(LH, RH) == "∫" || problem.Substring(LH, RH) == "√")
                {
                    operation = "*";
                    //
                    // figure out what you're multiplying by from operand2
                    //
                }
                else if (problem.Substring(LH, RH) == ")" || problem.Substring(LH, RH) == "]")
                {
                    //
                    // no operation should occur here
                    //
                    operation = "N";
                }
                else
                {
                    //
                    // ERROR: USER SHOULD NOT GET HERE
                    //
                }


                //
                // get operand2
                //

                //
                //
                //
                //
                // get stopping point for operand2
                //
                // if operand2 is not a simple calculation resend to read to be simplified
                //
                //

                if (problem.Substring(LH, RH) == ")")
                {

                }


                tempStr = readProblem(LH, RH);
                
            }
            else if (problem.Substring(LH, 1).All(char.IsLetter))
            {
                //
                // from here grab the whole string until it reaches a paranthesis then compare it to all the ln/log/trig stuff remember the limit func
                // dont forget e
                // also dont forget variables, like if they enter something other than x
                //
            }
            else if (problem.Substring(LH, 1) == "√")
            {

            }
            else if (problem.Substring(LH, 1) == "{")
            {
                //
                // for nth root stuff
                //
            }
            else if (problem.Substring(LH, 1) == "π")
            {

            }
            else if (problem.Substring(LH, 1) == "^")
            {
                //
                // can handle both ^2 funcs and ^n funcs
                //
            }
            //
            //
            // may not need to include operation events
            //
            //
            else if (problem.Substring(LH, 1) == "+")
            {
                // addition operation
            }
            else if (problem.Substring(LH, 1) == "-")
            {
                // subtraction operation
            }
            else if (problem.Substring(LH, 1) == "*")
            {
                // multiplication operation
            }
            else if (problem.Substring(LH, 1) == "/")
            {
                // fraction operation
            }
            else
            {
                //
                // ERROR: USER SHOULD NOT GET HERE
                //
            }


            return solution;
        }

        #endregion
        //
        // 1. make sure calculator can do basic algebra and addition and such
        // 2. make it handle derivatives
        // 3. integrals
        // 4. definite integrals
        // 5. validation???
        //
        // show solution is a seperate box with color shit
        //


    }
}

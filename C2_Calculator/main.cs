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
            if (input_box.SelectionStart > 0)
            {
                input_box.Text = input_box.Text.Remove(input_box.SelectionStart-1, 1);
                deletePrevChar(input_box);
                input_box.Focus();
                input_box.SelectionStart = caret_pos-1;
            }
            else
            {
                input_box.Focus();
                input_box.SelectionStart = caret_pos;
            }
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
                trigModeLbl.Text = "* inverse hyperbolic selected";
                sine.Text = "arcsinh";
                cosine.Text = "arccosh";
                tangent.Text = "arctanh";
                cosecant.Text = "arccsch";
                secant.Text = "arcsech";
                cotangent.Text = "arccoth";
            }
            else if (trigModeLbl.Text == "* inverse hyperbolic selected")
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
                trigModeLbl.Text = "* inverse hyperbolic selected";
                sine.Text = "arcsinh";
                cosine.Text = "arccosh";
                tangent.Text = "arctanh";
                cosecant.Text = "arccsch";
                secant.Text = "arcsech";
                cotangent.Text = "arccoth";
            }
            else if (trigModeLbl.Text == "* inverse hyperbolic selected")
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

        private void Infinity_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "∞";
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
            string insertText = "{2}√()";
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
            string insertText = (sender as Button).Text + "{x}{}()";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Indef_int_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "∫{a}{b}[]";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 1;
        }

        private void Def_integral_btn_Click(object sender, EventArgs e)
        {
            int caret_pos = input_box.SelectionStart;
            string insertText = "∫{}{}[]";
            int selectionIndex = input_box.SelectionStart;
            input_box.Text = input_box.Text.Insert(selectionIndex, insertText);
            input_box.Focus();
            input_box.SelectionStart = selectionIndex + insertText.Length - 5;
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
            string problem = input_box.Text;
            SolveForNumber(problem);
        }

        //
        // 1. select operand until an operation
        // 2. if that operation is multiplication via paranthesis, send stuff inside paranthesis back to the same function to be simplified
        // 3. add operands and operations to list
        // 4. if operand has a root, simplify stuff under the root first then take the root using math.power of the func to the 1/n then add that operand to the list as a double.tostring
        // 5. if operand is a trig function determine if in radians or degrees then simplify stuff inside paranthesis and then run the func and add that to the list as a double.tostring
        // 6. if operand has a power, execute and then add it to the list of operands
        // 7. if a subtraction operation is followed by a negative value make it positive
        // 8. if a value is wrapped in absolute values, send the stuff inside the absolute values back through the function to simplify then make it positive if it is not already
        // 
        // be cautious of paranthesis
        // be cautious of sin^(2)(x)
        // 
        //

        private void SolveForNumber(string text)
        {

            #region TrigArrays

            //
            // array containing different trig funcs
            //

            string[] trigFuncs = new string[24];
            trigFuncs[0] = "sin(u)";
            trigFuncs[1] = "cos(u)";
            trigFuncs[2] = "tan(u)";
            trigFuncs[3] = "csc(u)";
            trigFuncs[4] = "sec(u)";
            trigFuncs[5] = "cot(u)";
            trigFuncs[6] = "sinh(u)";
            trigFuncs[7] = "cosh(u)";
            trigFuncs[8] = "tanh(u)";
            trigFuncs[9] = "csch(u)";
            trigFuncs[10] = "sech(u)";
            trigFuncs[11] = "coth(u)";
            trigFuncs[12] = "arcsin(u)";
            trigFuncs[13] = "arccos(u)";
            trigFuncs[14] = "arctan(u)";
            trigFuncs[15] = "arccsc(u)";
            trigFuncs[16] = "arcsec(u)";
            trigFuncs[17] = "arccot(u)";
            trigFuncs[18] = "arcsinh(u)";
            trigFuncs[19] = "arccosh(u)";
            trigFuncs[20] = "arctanh(u)";
            trigFuncs[21] = "arccsch(u)";
            trigFuncs[22] = "arcsech(u)";
            trigFuncs[23] = "arccoth(u)";

            //
            // array containing parent derivatives for trig funcs
            //

            string[] trigFuncsDerivatives = new string[24];
            trigFuncs[0] = "cos(u)";
            trigFuncs[1] = "-sin(u)";
            trigFuncs[2] = "sec^(2)(u)";
            trigFuncs[3] = "-csc(u)cot(u)";
            trigFuncs[4] = "sec(u)tan(u)";
            trigFuncs[5] = "-csc^(2)(u)";
            trigFuncs[6] = "cosh(u)";
            trigFuncs[7] = "sinh(u)";
            trigFuncs[8] = "sech^(2)(u)";
            trigFuncs[9] = "-coth(u)csch(u)";
            trigFuncs[10] = "sech(u)tanh(u)";
            trigFuncs[11] = "-csch^(2)(u)";
            trigFuncs[12] = "(1/{2}√(1-u^(2)))";
            trigFuncs[13] = "-(1/{2}√(1-u^(2)))";
            trigFuncs[14] = "(1/(1+u^(2)))";
            trigFuncs[15] = "-(1/(u{2}√(u^(2)-1)))";
            trigFuncs[16] = "(1/(u{2}√(u^(2)-1)))";
            trigFuncs[17] = "-(1/(1+u^(2)))";
            trigFuncs[18] = "(1/{2}√(u^(2)+1))";
            trigFuncs[19] = "(1/{2}√(u^(2)-1))";
            trigFuncs[20] = "(1/(1-u^(2)))";
            trigFuncs[21] = "-(1/|u|{2}√(1-u^(2)))";
            trigFuncs[22] = "-(1/u{2}√(1-u^(2)))";
            trigFuncs[23] = "(1/(1-u^(2)))";

            //
            // array containing parent integrals for trig funcs
            //

            string[] trigFuncsIntegrals = new string[24];
            trigFuncs[0] = "-cos(u)";
            trigFuncs[1] = "sin(u)";
            trigFuncs[2] = "ln|sec(u)|";
            trigFuncs[3] = "ln|csc(u)-cot(u)|";
            trigFuncs[4] = "ln|sec(u)+tan(u)|";
            trigFuncs[5] = "ln|sin(u)|";
            trigFuncs[6] = "cosh(u)";
            trigFuncs[7] = "sinh(u)";
            trigFuncs[8] = "ln|cosh(u)|";
            trigFuncs[9] = "N";
            trigFuncs[10] = "N";
            trigFuncs[11] = "N";
            trigFuncs[12] = "N";
            trigFuncs[13] = "N";
            trigFuncs[14] = "N";
            trigFuncs[15] = "N";
            trigFuncs[16] = "N";
            trigFuncs[17] = "N";
            trigFuncs[18] = "N";
            trigFuncs[19] = "N";
            trigFuncs[20] = "N";
            trigFuncs[21] = "N";
            trigFuncs[22] = "N";
            trigFuncs[23] = "N";


            #endregion

            List<string> operands = new List<string>();
            List<string> operations = new List<string>();
            string operand, operation, answer = "";
            bool atEnd = false;

            //
            // when select operand returns an operand use operand.contains to check if the operand has been fully simplified or if there is an integral in there that needs to be taken care of
            //
            // all select operand should do is just highlight and copy the piece to be simplified like 3^(2) verses 9
            //

            //
            // reads text and divides the problem into seperate operands and operations
            //

            do
            {
                operand = selectOperand(text);
                operands.Add(operand);
                text = text.Substring(operand.Length);
                if (text != "")
                {
                    operation = selectOperation(text);
                    operations.Add(operation);
                    text = text.Substring(operation.Length);
                    if (text == "")
                    {
                        atEnd = true;
                    }
                }
                else
                {
                    atEnd = true;
                }

            } while (!atEnd);

            foreach (string op in operands)
            {
                if (op.Substring(0, 1) == "∫")
                {
                    //
                    // look at operands and operations inside and split them into a seperate list called operandFocus or something like that and then integrate the operands
                    //
                }
                else if (op.Substring(0, 1) == "ƒ")
                {
                    //
                    //
                    //
                }
                else if (op.Substring(0, 1) == "(")
                {
                    //
                    //
                    //
                }
                else if (op.Substring(0, 1) == "{")
                {
                    //
                    //
                    //
                }

            }












            if (operands.Count == 1 && operands[0].All(char.IsDigit))
            {
                answer = operands[0];
            }

            input_box.Text = answer;
            //
            // get operation between operands just checks hey if this is a paranthesis im gonna leave it but the operation is multiplication or if the operation is addition im gonna remove it
            // and then move on to another operand and if there is no operation then im not taking anything and returning "null"
            //

            //
            // once returned subtract that operand from the list then send to another function where it will simplify/solve operands in the list until can no longer be simplified
            //

        }

        private string selectOperation(string text)
        {
            string operation = null;

            if (text.Substring(0 , 1) == "+")
            {
                operation = "+";
            }
            else if (text.Substring(0, 1) == "-")
            {
                operation = "-";
            }
            else if (text.Substring(0, 1) == "/")
            {
                operation = "/";
            }
            else if (text.Substring(0, 1) == "*")
            {
                operation = "*";
            }
            else if (text.Substring(0, 1) == "(" || text.Substring(0, 1) == "∫" || text.Substring(0, 1) == "ƒ" || text.Substring(0, 1) == "{")
            {
                // multiplication but not via "*"
                operation = "";
            }

            return operation;
        }

        //
        // returns a piece of the problem
        //

        private string selectOperand(string text)
        {
            string operand = null, unknown = null;
            int distance = 0 , vdis = 0;
            

            if (text.Substring(0, 1).All(char.IsNumber) || text.Substring(0, 1).All(char.IsDigit))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Substring(i, 1).All(char.IsNumber) || text.Substring(i, 1).All(char.IsDigit))
                    {
                        operand = text.Substring(0, i + 1);
                    }
                    else if (text.Substring(i, 1) == "^")
                    {
                        for (int p = 0; p < text.Length; p++)
                        {
                            if (i + distance + (3 * p) < text.Length)
                            {
                                if (text.Substring(i + distance + (3 * p), 1) == "^")
                                {
                                    distance = distance + lengthBetween(i + distance + (3 * p) + 1, text, "(", ")");
                                }
                                else
                                {
                                    distance = distance + 3 * p;
                                    p = text.Length;
                                }
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }

                        operand = text.Substring(0, i + distance);
                        i = text.Length;
                    }
                    else
                    {
                        operand = text.Substring(0, i);
                        i = text.Length;
                    }
                }
            }
            if (text.Substring(0, 1) == "ƒ")
            {
                distance = lengthBetween(2, text, "[", "]");
                if (text.Substring(4 + distance, 1) == "^")
                {
                    for (int p = 0; p < text.Length; p++)
                    {
                        if (4 + distance + (3 * p) < text.Length)
                        {
                            if (text.Substring(4 + distance + (3 * p), 1) == "^")
                            {
                                distance = distance + lengthBetween(4 + distance + (3 * p) + 1, text, "(", ")");
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }
                        else
                        {
                            distance = distance + 3 * p;
                            p = text.Length;
                        }
                    }
                }


                operand = text.Substring(0, distance + 4);
            }
            else if (text.Substring(0, 1).All(char.IsLetter)) // Handler if there are letters in the text, such as ln, trig, or limits
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Substring(i, 1).All(char.IsLetter))
                    {
                        unknown = text.Substring(0, i + 1);
                    }
                    else if (text.Substring(i, 1) == "^")
                    {
                        for (int p = 0; p < text.Length; p++)
                        {
                            if (i + distance + (3 * p) < text.Length)
                            {
                                if (text.Substring(i + distance + (3 * p), 1) == "^")
                                {
                                    distance = distance + lengthBetween(i + distance + (3 * p) + 1, text, "(", ")");
                                }
                                else
                                {
                                    distance = distance + 3 * p;
                                    p = text.Length;
                                }
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }
                        if (unknown.Contains("x"))
                        {
                            operand = text.Substring(0, i + distance);
                        }
                        else if (unknown == "e")
                        {
                            operand = text.Substring(0, 1 + distance);
                        }
                        else if (unknown == "π")
                        {
                            operand = text.Substring(0, 1 + distance);
                        }
                        else // handles trig functions with powers
                        {
                            distance = distance + lengthBetween(i + distance, text, "(", ")");
                            operand = text.Substring(0, i + distance + 2);
                        }
                        i = text.Length;
                    }
                    else if (text.Substring(i, 1) == "(")
                    {
                        vdis = lengthBetween(i, text, "(", ")");

                        if (text.Substring(i + vdis + 2, 1) == "^")
                        {
                            for (int p = 0; p < text.Length; p++)
                            {
                                if (i + vdis + distance + 2 + (3 * p) < text.Length)
                                {
                                    if (text.Substring(i + vdis + 2 + distance + (3 * p), 1) == "^")
                                    {
                                        distance = distance + lengthBetween(i + vdis + 2 + distance + (3 * p) + 1, text, "(", ")");
                                    }
                                    else
                                    {
                                        distance = distance + 3 * p;
                                        p = text.Length;
                                    }
                                }
                                else
                                {
                                    distance = distance + 3 * p;
                                    p = text.Length;
                                }
                            }

                            operand = text.Substring(0, i + vdis + distance + 2);
                            i = text.Length;
                        }
                        else
                        {
                            operand = text.Substring(0, i + distance + 2);
                            i = text.Length;
                        }
                    }
                    else if (text.Substring(i, 1) == "{") /////////////////////////////////////////////////////// handler for limits and logs
                    {
                        distance = lengthBetween(i, text, "{", "}");
                        if (text.Substring(i + distance + 2, 1) == "{") // if true then the operand is a limit function
                        {
                            distance = distance + lengthBetween(i + distance + 2, text, "{", "}") + 5;

                            distance = distance + lengthBetween(i + distance + 2, text, "(", ")");

                            if (text.Substring(i + distance + 2, 1) == "^")
                            {
                                for (int p = 0; p < text.Length; p++)
                                {
                                    if (i + distance + 2 + (3 * p) < text.Length)
                                    {
                                        if (text.Substring(i + distance + 2 + (3 * p), 1) == "^")
                                        {
                                            distance = distance + lengthBetween(i + distance + 2 + (3 * p) + 1, text, "(", ")");
                                        }
                                        else
                                        {
                                            distance = distance + 3 * p;
                                            p = text.Length;
                                        }
                                    }
                                    else
                                    {
                                        distance = distance + 3 * p;
                                        p = text.Length;
                                    }
                                }
                            }
                        }
                        else
                        {
                            distance = distance + lengthBetween(i + distance + 2, text, "(", ")");

                            if (text.Substring(i + distance + 4, 1) == "^")
                            {
                                for (int p = 0; p < text.Length; p++)
                                {
                                    if (i + distance + 4 + (3 * p) < text.Length)
                                    {
                                        if (text.Substring(i + distance + 4 + (3 * p), 1) == "^")
                                        {
                                            distance = distance + lengthBetween(i + distance + 4 + (3 * p) + 1, text, "(", ")");
                                        }
                                        else
                                        {
                                            distance = distance + 3 * p;
                                            p = text.Length;
                                        }
                                    }
                                    else
                                    {
                                        distance = distance + 3 * p;
                                        p = text.Length;
                                    }
                                }
                            }
                        }
                        


                        operand = text.Substring(0, i + distance + 2);
                        i = text.Length;
                    }
                    else
                    {
                        unknown = text.Substring(0, i);
                        i = text.Length;
                    }
                }
            }
            else if (text.Substring(0, 1) == "{") /////for roots
            {
                distance = lengthBetween(0, text, "{", "}");
                distance = distance + lengthBetween(distance + 3, text, "(", ")");

                if (text.Substring(distance + 5, 1) == "^")
                {
                    for (int p = 0; p < text.Length; p++)
                    {
                        if (5 + distance + (3 * p) < text.Length)
                        {
                            if (text.Substring(5 + distance + (3 * p), 1) == "^")
                            {
                                distance = distance + lengthBetween(5 + distance + (3 * p) + 1, text, "(", ")");
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }
                        else
                        {
                            distance = distance + 3 * p;
                            p = text.Length;
                        }
                    }
                }

                operand = text.Substring(0, distance + 5);

            }
            else if (text.Substring(0, 1) == "(") /////for quantities
            {
                distance = lengthBetween(0, text, "(", ")");
                if (text.Substring(2 + distance, 1) == "^")
                {
                    for (int p = 0; p < text.Length; p++)
                    {
                        if (2 + distance + (3 * p) < text.Length)
                        {
                            if (text.Substring(2 + distance + (3 * p), 1) == "^")
                            {
                                distance = distance + lengthBetween(2 + distance + (3 * p) + 1, text, "(", ")");
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }
                        else
                        {
                            distance = distance + 3 * p;
                            p = text.Length;
                        }
                    }
                }

                operand = text.Substring(0, distance + 2);
            }
            else if (text.Substring(0, 1) == "∫")
            {
                distance = lengthBetween(1, text, "{", "}");
                distance = distance + lengthBetween(3 + distance, text, "{", "}");
                distance = distance + lengthBetween(5 + distance, text, "[", "]");

                if (7 + distance <= text.Length)
                {
                    if (text.Substring(7 + distance, 1) == "^")
                    {
                        for (int p = 0; p < text.Length; p++)
                        {
                            if (7 + distance + (3 * p) < text.Length)
                            {
                                if (text.Substring(7 + distance + (3 * p), 1) == "^")
                                {
                                    distance = distance + lengthBetween(7 + distance + (3 * p) + 1, text, "(", ")");
                                }
                                else
                                {
                                    distance = distance + 3 * p;
                                    p = text.Length;
                                }
                            }
                            else
                            {
                                distance = distance + 3 * p;
                                p = text.Length;
                            }
                        }
                    }
                }

                operand = text.Substring(0, 7 + distance);
            }

            return operand;
        }

        private int lengthBetween(int pos, string text, string lRef, string rRef)
        {
            int distance = 0;
            int lTrack = 0, rTrack = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text.Substring(pos + i, 1) == lRef)
                {
                    lTrack++;
                }
                else if (text.Substring(pos + i, 1) == rRef)
                {
                    rTrack++;
                }

                if (lTrack == rTrack && lTrack > 0)
                {
                    distance = i - 1;
                    //pos = pos + i + 1;
                    i = text.Length;
                }
            }

            return distance;
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

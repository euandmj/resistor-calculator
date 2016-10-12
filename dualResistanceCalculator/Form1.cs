using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace dualResistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //Page 1
        {
            #region Resistance Calculator
            string band1Color = band1Text.Text;
            string band2Color = band2Text.Text;
            string band3Color = band3Text.Text;
            string multiplierColor = multiplierText.Text;
            string toleranceColor = toleranceText.Text;


            long band1Value;
            long band2Value;
            long band3Value;
            double multiplierValue;
            double toleranceValue;
            long combo;

            #region Determines the value of the first band.
            switch (band1Color)
            {
                case "Black":
                    band1Value = 0;
                    break;
                case "Brown":
                    band1Value = 1;
                    break;
                case "Red":
                    band1Value = 2;
                    break;
                case "Orange":
                    band1Value = 3;
                    break;
                case "Yellow":
                    band1Value = 4;
                    break;
                case "Green":
                    band1Value = 5;
                    break;
                case "Blue":
                    band1Value = 6;
                    break;
                case "Violet":
                    band1Value = 7;
                    break;
                case "Grey":
                    band1Value = 8;
                    break;
                case "White":
                    band1Value = 9;
                    break;
                case "None":
                    band1Value = 0;
                    break;
                default:
                    band1Value = 0;
                    break;
            }
            #endregion


            #region Determines the value of the second band.
            switch (band2Color)
            {
                case "Black":
                    band2Value = 0;
                    break;
                case "Brown":
                    band2Value = 1;
                    break;
                case "Red":
                    band2Value = 2;
                    break;
                case "Orange":
                    band2Value = 3;
                    break;
                case "Yellow":
                    band2Value = 4;
                    break;
                case "Green":
                    band2Value = 5;
                    break;
                case "Blue":
                    band2Value = 6;
                    break;
                case "Violet":
                    band2Value = 7;
                    break;
                case "Grey":
                    band2Value = 8;
                    break;
                case "White":
                    band2Value = 9;
                    break;
                default:
                    band2Value = 0;
                    break;
            }
            #endregion


            #region Determines the value of the third band.
            switch (band3Color)
            {
                case "Black":
                    band3Value = 0;
                    break;
                case "Brown":
                    band3Value = 1;
                    break;
                case "Red":
                    band3Value = 2;
                    break;
                case "Orange":
                    band3Value = 3;
                    break;
                case "Yellow":
                    band3Value = 4;
                    break;
                case "Green":
                    band3Value = 5;
                    break;
                case "Blue":
                    band3Value = 6;
                    break;
                case "Violet":
                    band3Value = 7;
                    break;
                case "Grey":
                    band3Value = 8;
                    break;
                case "White":
                    band3Value = 9;
                    break;
                default:
                    band3Value = 0;
                    break;
            }
            #endregion


            #region Determines the value of the multiplier band.
            switch (multiplierColor)
            {
                case "Black":
                    multiplierValue = 1;
                    break;
                case "Brown":
                    multiplierValue = 10;
                    break;
                case "Red":
                    multiplierValue = 100;
                    break;
                case "Orange":
                    multiplierValue = 1000;
                    break;
                case "Yellow":
                    multiplierValue = 10000;
                    break;
                case "Green":
                    multiplierValue = 100000;
                    break;
                case "Blue":
                    multiplierValue = 1000000;
                    break;
                case "Violet":
                    multiplierValue = 10000000;
                    break;
                case "Gold":
                    multiplierValue = 0.1;
                    break;
                case "Silver":
                    multiplierValue = 0.01;
                    break;
                case "None":
                    multiplierValue = 0;
                    break;
                default:
                    multiplierValue = 0;
                    break;
            }
            #endregion


            #region Determines the value of the tolerance band.
            switch (toleranceColor)
            {
                case "Brown":
                    toleranceValue = 1.0;
                    break;
                case "Red":
                    toleranceValue = 2.0;
                    break;
                case "Green":
                    toleranceValue = 0.5;
                    break;
                case "Blue":
                    toleranceValue = 0.25;
                    break;
                case "Violet":
                    toleranceValue = 0.10;
                    break;
                case "Grey":
                    toleranceValue = 0.05;
                    break;
                case "Gold":
                    toleranceValue = 5.0;
                    break;
                case "Silver":
                    toleranceValue = 10.0;
                    break;
                case "None":
                    toleranceValue = 0;
                    break;
                default:
                    toleranceValue = 0;
                    break;
            }
            #endregion


            combo = int.Parse(band1Value.ToString() + band2Value.ToString() + band3Value.ToString());
            double resistance;

            if (multiplierValue == 0)
            {
                resistance = (combo);
            }
            else
            {
                resistance = (combo * multiplierValue);
                resistance /= 10;
            }


            if (comboBox2.Text == "Kohm")
            {
                resistance /= 1000;
                resistanceResult.Text = (resistance + " KΩ " + toleranceValue + "%");
            }
            if (comboBox2.Text == "Mohm")
            {
                resistance /= 1000000;
                resistanceResult.Text = (resistance + " MΩ " + toleranceValue + "%");
            }
            if (comboBox2.Text == "Ohm")
            {
                resistanceResult.Text = (resistance + " Ω " + toleranceValue + "%");
            }

            
            


            /*MessageBox.Show("value of the 1st " + band1Color + " band is : " + band1Value + Environment.NewLine +
                "value of the 2nd " + band2Color + " band is : " + band2Value + Environment.NewLine +
                "value of the 3rd " + band3Color + " band is : " + multiplierValue + Environment.NewLine +
                "combo: " + combo);
            */


            #endregion
        }
        

        private void resistorChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.digikey.com/~/media/Images/Marketing/Resources/Calculators/resistor-color-chart.jpg?la=en-GB");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e) //Page 2
        {

            #region Calculates color bands from resistance
            if (eSeriesComboBoxP2.Text == "" || toleranceComboBox.Text == "")
            {
                MessageBox.Show("Error: Please complete all resistor options");
                return; 
            }
                        
            
            #region Reformats to E Series
            long inputResistance = long.Parse(resistanceBandText.Text); //User input of their resistance
            double tempResistance = inputResistance; //Puts resistance as double 
            int divisions = 0;



            List<double> preferredValuesList = new List<double> {0, 0};


            List<double> preferredValusE6 = new List<double> { 1.0, 1.5, 2.2, 3.3, 4.7, 6.8 };//E6 Preferred Values 

            List<double> preferredValuesE12 = new List<double> {1.0, 1.2, 1.5, 1.8, 2.2, 2.7, //E12 Preferred Values 
                                                                3.3, 3.9, 4.7, 5.6, 6.8, 8.2};

            List<double> preferredValuesE24 = new List<double> {1.0, 1.1, 1.2, 1.3, 1.5, 1.6, //E24 Preferred Values 
                                                                1.8, 2.0, 2.2, 2.4, 2.7, 3.0,
                                                                3.3, 3.6, 3.9, 4.3, 4.7, 5.1,
                                                                5.6, 6.2, 6.8, 7.5, 8.2, 9.1};

            List<double> preferredValuesE48 = new List<double> {1.00, 1.05, 1.10, 1.15, 1.21, 1.27, //E48 PreferredValues 
                                                            1.33, 1.40, 1.47, 1.54, 1.62, 1.69, 
                                                            1.78, 1.87, 1.96, 2.05, 2.15, 2.26, 
                                                            2.37, 2.49, 2.61, 2.74, 2.87, 3.01, 
                                                            3.16, 3.32, 3.48, 3.65, 3.83, 4.02, 
                                                            4.22, 4.42, 4.64, 4.87, 5.11, 5.36, 
                                                            5.62, 5.90, 6.19, 6.49, 6.81, 7.15, 
                                                            7.50, 7.87, 8.25, 8.66, 9.09, 9.53};

            List<double> preferredValuesE96 = new List<double> {1.00, 1.02, 1.05, 1.07, 1.10, 1.13, 
                                                              1.15, 1.18, 1.21, 1.24, 1.27, 1.30, 
                                                              1.33, 1.37, 1.40, 1.43, 1.47, 1.50, 
                                                              1.54, 1,58, 1.62, 1.65, 1.69, 1.74, 
                                                              1.78, 1.82, 1.87, 1.91, 1.96, 2.00, 
                                                              2.05, 2.10, 2.16, 2.21, 2.26, 2.32, 
                                                              2.37, 2.43, 2.49, 2.55, 2.61, 2.67, 
                                                              2.74, 2.80, 2.87, 2.94, 3.01, 3.09, 
                                                              3.16, 3.24, 3.32, 3.40, 3.48, 3.57, 
                                                              3.65, 3.74, 3.83, 3.92, 4.02, 4.12, 
                                                              4.22, 4.32, 4.42, 4.53, 4.64, 4.75, 
                                                              4.87, 4.99, 5.11, 5.23, 5.36, 5.49, 
                                                              5.62, 5.76, 5.90, 6.04, 6.19, 6.34, 
                                                              6.49, 6.65, 6,81, 6.98, 7.15, 7.32, 
                                                              7.50, 7.68, 7.87, 8.06, 8.25, 8.45, 
                                                              8.66, 8.87, 9.09, 9.31, 9.53, 9.76};


            if (eSeriesComboBoxP2.Text == "E6")
            {
                preferredValuesList = preferredValusE6;
            }
            if (eSeriesComboBoxP2.Text == "E12")
            {
                preferredValuesList = preferredValuesE12;
            }
            if (eSeriesComboBoxP2.Text == "E24")
            {
                preferredValuesList = preferredValuesE24;
            }
            if (eSeriesComboBoxP2.Text == "E48")
            {
                preferredValuesList = preferredValuesE48;
            }
            if (eSeriesComboBoxP2.Text == "E96")
            {
                preferredValuesList = preferredValuesE96;
            }

            while (tempResistance >= 10)
            {
                tempResistance /= 10;
                divisions++;
            }

            double preferredResistance = preferredValuesList.OrderBy(item => Math.Abs(tempResistance - item)).First(); //Rounds to upper number. 
            int reform = 10 * divisions;
            double resistance = preferredResistance * Math.Pow(10.00, divisions); //Puts the resistance back into it's "big number" again. 
            //MessageBox.Show("here: " + closestValue);
            resistanceBandText.Text = (resistance + "");
            #endregion


            int divisions2 = 0;
            while (resistance >= 100)
            {
                resistance /= 10;
                divisions2++;
            }

            string resistance2Char = resistance.ToString();
            char[] chars = new char[2];
            chars = resistance2Char.ToCharArray();
            string char1 = chars[0].ToString();
            string char2 = chars[1].ToString();

            string band1Color = "";
            switch (char1) //sets color of band1
            {
                case "1":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Brown;
                    band1Color = "Brown";
                    break;
                case "2":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Red;
                    band1Color = "Red";
                    break;
                case "3":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Orange;
                    band1Color = "Orange";
                    break;
                case "4":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Yellow;
                    band1Color = "Yellow";
                    break;
                case "5":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Green;
                    band1Color = "Green";
                    break;
                case "6":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Blue;
                    band1Color = "Blue";
                    break;
                case "7":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Violet;
                    band1Color = "Violet";
                    break;
                case "8":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.Gray;
                    band1Color = "Gray";
                    break;
                case "9":
                    band1Band.Visible = true;
                    band1Band.BackColor = Color.White;
                    band1Color = "White";
                    break;
                default:
                    band1Band.Visible = false;
                    break;
            }

            string band2Color = "";
            switch (char2) //sets color of band2
            {
                case "0":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Black;
                    band2Color = "Black";
                    break;
                case "1":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Brown;
                    band2Color = "Brown";
                    break;
                case "2":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Red;
                    band2Color = "Red";
                    break;
                case "3":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Orange;
                    band2Color = "Orange";
                    break;
                case "4":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Yellow;
                    band2Color = "Yellow";
                    break;
                case "5":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Green;
                    band2Color = "Green";
                    break;
                case "6":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Blue;
                    band2Color = "Blue";
                    break;
                case "7":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Violet;
                    band2Color = "Violet";
                    break;
                case "8":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Gray;
                    band2Color = "Gray";
                    break;
                case "9":
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.White;
                    band2Color = "White";
                    break;
                default:
                    band2Band.Visible = true;
                    band2Band.BackColor = Color.Black;
                    band2Color = "Black";
                    break;
            }


            double multiplier = 1 * Math.Pow(10.00, (divisions - 1));
            string multiplierColor = "";
            if (multiplier == 0.01) //sets for color for the multiplier
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Silver;
                multiplierColor = "Silver";
            }
            if (multiplier == 0.1)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Gold;
                multiplierColor = "Gold";
            }
            if (multiplier == 1)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Black;
                multiplierColor = "Black";
            }
            if (multiplier == 10)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Brown;
                multiplierColor = "Brown";
            }
            if (multiplier == 100)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Red;
                multiplierColor = "Red";
            }
            if (multiplier == 1000)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Orange;
                multiplierColor = "Orange";
            }
            if (multiplier == 10000)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Yellow;
                multiplierColor = "Yellow";
            }
            if (multiplier == 100000)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Green;
                multiplierColor = "Green";
            }
            if (multiplier == 1000000)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Blue;
                multiplierColor = "Blue";
            }
            if (multiplier >= 10000000)
            {
                multiplierBand.Visible = true;
                multiplierBand.BackColor = Color.Violet;
                multiplierColor = "Violet";
            }


            string toleranceColor = "";
            switch (toleranceComboBox.Text) //Sets Tolerance Band
            {
                case "+/- 1%":
                    toleranceBand.Visible = true;
                    toleranceBand.BackColor = Color.Brown;
                    toleranceColor = "Brown";
                    break;
                case "+/- 2%":
                    toleranceBand.Visible = true;
                    toleranceBand.BackColor = Color.Red;
                    toleranceColor = "Red";
                    break;
                case "+/- 5%":
                    toleranceBand.Visible = true;
                    toleranceBand.BackColor = Color.Gold;
                    toleranceColor = "Gold";
                    break;
                case "+/- 10%":
                    toleranceBand.Visible = true;
                    toleranceBand.BackColor = Color.Silver;
                    toleranceColor = "Silver";
                    break;
                case "None":
                    toleranceBand.Visible = true;
                    toleranceBand.BackColor = Color.Black;
                    toleranceColor = "Black";
                    break;
                default:
                    toleranceBand.Visible = false;
                    break;
            }
            textBox2.Text = ("The colour code is: " + band1Color + " " + band2Color + " " + multiplierColor + " " + toleranceColor);
            #endregion
        }


        private void button2_Click(object sender, System.Windows.Forms.KeyEventArgs e) //Page 3
        {
            #region Resistance Converter
            if (eSeriesComboBoxP3.Text == "" || resistanceText.Text == "")
            {
                MessageBox.Show("Error: Please complete all options");
                return;
            }

            

            
            
            #region rounds resistance to the eSeries



            long resistance = long.Parse(resistanceText.Text); //User input of their resistance
            double tempResistance = resistance; //Puts resistance as double 
            int divisions = 0;
            string empty = null;

            List<double> preferredValuesList = new List<double> { 0, 0 };


            List<double> preferredValuesE6 = new List<double> { 1.0, 1.5, 2.2, 3.3, 4.7, 6.8 };//E6 Preferred Values 

            List<double> preferredValuesE12 = new List<double> {1.0, 1.2, 1.5, 1.8, 2.2, 2.7, //E12 Preferred Values 
                                                                3.3, 3.9, 4.7, 5.6, 6.8, 8.2};

            List<double> preferredValuesE24 = new List<double> {1.0, 1.1, 1.2, 1.3, 1.5, 1.6, //E24 Preferred Values 
                                                                1.8, 2.0, 2.2, 2.4, 2.7, 3.0,
                                                                3.3, 3.6, 3.9, 4.3, 4.7, 5.1,
                                                                5.6, 6.2, 6.8, 7.5, 8.2, 9.1};

            List<double> preferredValuesE48 = new List<double> {1.00, 1.05, 1.10, 1.15, 1.21, 1.27, //E48 PreferredValues 
                                                            1.33, 1.40, 1.47, 1.54, 1.62, 1.69, 
                                                            1.78, 1.87, 1.96, 2.05, 2.15, 2.26, 
                                                            2.37, 2.49, 2.61, 2.74, 2.87, 3.01, 
                                                            3.16, 3.32, 3.48, 3.65, 3.83, 4.02, 
                                                            4.22, 4.42, 4.64, 4.87, 5.11, 5.36, 
                                                            5.62, 5.90, 6.19, 6.49, 6.81, 7.15, 
                                                            7.50, 7.87, 8.25, 8.66, 9.09, 9.53};

            List<double> preferredValuesE96 = new List<double> {1.00, 1.02, 1.05, 1.07, 1.10, 1.13, 
                                                              1.15, 1.18, 1.21, 1.24, 1.27, 1.30, 
                                                              1.33, 1.37, 1.40, 1.43, 1.47, 1.50, 
                                                              1.54, 1,58, 1.62, 1.65, 1.69, 1.74, 
                                                              1.78, 1.82, 1.87, 1.91, 1.96, 2.00, 
                                                              2.05, 2.10, 2.16, 2.21, 2.26, 2.32, 
                                                              2.37, 2.43, 2.49, 2.55, 2.61, 2.67, 
                                                              2.74, 2.80, 2.87, 2.94, 3.01, 3.09, 
                                                              3.16, 3.24, 3.32, 3.40, 3.48, 3.57, 
                                                              3.65, 3.74, 3.83, 3.92, 4.02, 4.12, 
                                                              4.22, 4.32, 4.42, 4.53, 4.64, 4.75, 
                                                              4.87, 4.99, 5.11, 5.23, 5.36, 5.49, 
                                                              5.62, 5.76, 5.90, 6.04, 6.19, 6.34, 
                                                              6.49, 6.65, 6,81, 6.98, 7.15, 7.32, 
                                                              7.50, 7.68, 7.87, 8.06, 8.25, 8.45, 
                                                              8.66, 8.87, 9.09, 9.31, 9.53, 9.76};


            if (eSeriesComboBoxP3.Text == "E6")
            {
                preferredValuesList = preferredValuesE6;
            }
            if (eSeriesComboBoxP3.Text == "E12")
            {
                preferredValuesList = preferredValuesE12;
            }
            if (eSeriesComboBoxP3.Text == "E24")
            {
                preferredValuesList = preferredValuesE24;
            }
            if (eSeriesComboBoxP3.Text == "E48")
            {
                preferredValuesList = preferredValuesE48;
            }
            if (eSeriesComboBoxP3.Text == "E96")
            {
                preferredValuesList = preferredValuesE96;
            }

            while (tempResistance >= 10)
            {
                tempResistance /= 10;
                divisions++;
            }

            double preferredResistance = 0; 
            foreach (double values in preferredValuesList)
            {
                preferredResistance = Math.Ceiling(values);
            }
            //double preferredResistance = (int)Math.Ceiling(preferredValuesList); //Rounds to upper number. 
            // double preferredResistance = (preferredValuesE24.Max(i => i < tempResistance ? i : Int32.MinValue)); //Rounds to lower number. 
            int reform = 10 * divisions;
            double closestValue = preferredResistance * Math.Pow(10.00, divisions); //Puts the resistance back into it's "big number" again. 
            //MessageBox.Show("here: " + closestValue);

            //Pastes final resistance into text box. 





            closestValueBox.Text = (closestValue + " Ω");

            //Automatic "Paste" onto page 2
            resistanceBandText.Text = (empty + closestValue);
            eSeriesComboBoxP2.Text = eSeriesComboBoxP3.Text; 
            #endregion



            #region % Error Calculation


            long closestValueLong = (long)closestValue;
            decimal decrease = resistance - closestValueLong;

            decimal resistanceDec = resistance;
            decimal error = (decrease / resistance) * 100;
            decimal errorValue = 0;


            if (error == 0)
            {
                errorValue = error;
            }
            else
            {
                errorValue = Math.Round(error, 4);
            }

            errorBox.Text = (errorValue + "%");

            #endregion

            #endregion
        }

        
        
        private void resistanceText_TextChanged(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clearPageToolStripMenuItem_Click(object sender, EventArgs e) //clears the page
        {
            //page 1
            band1Text.Text = "";
            band2Text.Text = "";
            band3Text.Text = "";
            multiplierText.Text = "";
            toleranceText.Text = "";
            resistanceResult.Text = "";
            
            //page 2 
            band1Band.Visible = false;
            band2Band.Visible = false;
            multiplierBand.Visible = false;
            toleranceBand.Visible = false;
            resistanceBandText.Text = "";
            textBox2.Text = "";
            eSeriesComboBoxP2.Text = "";

            //page 3 
            eSeriesComboBoxP3.Text = "";
            resistanceText.Text = "";
            closestValueBox.Text = "";
            errorBox.Text = ""; 
        }

        private void resistanceBandText_TextChanged(object sender, EventArgs e)
        {

        }

        private void eSeriesChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.radio-electronics.com/info/data/resistor/e-series-e3-e6-e12-e24-e48-e96.php");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            DialogResult dialogResult = popup.ShowDialog(); 
            
           
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eSeriesComboBoxP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        
    }
}

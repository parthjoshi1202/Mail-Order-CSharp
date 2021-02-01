/*
COMP 1098 Assignment 1
App Name- Mail Order
Author's Name- Parth Joshi
Student ID (Lakehead): 1126914
Date- 9 February 2020
This is a Sharp Mail Order - SALES BONUS app which will Calculate the Sales Bonus based on the 
number of hours the Employee has Worked (max- 160 Hours) and total sales occured
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace MailOrder
{
    public partial class Sales_BonusForm : Form
    {
        public Sales_BonusForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
         * Radio Buttons for English Language when English is chosen in the Radio Button 
         */

        private void Eng_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Lang_GroupBox.Text = "Language";
            Eng_RadioBtn.Text = "English";
            EmpName_Label.Text = "Employee's Name";
            EmpID_Label.Text = "Employee ID:";
            HrsWork_Label.Text = "Hours Worked :";
            TotSales_Label.Text = "Total Sales :";
            SalesBonus_Label.Text = "Sales Bonus :";
            Cal_Btn.Text = "Calculate";
            Print_Btn.Text = "Print";
            Clear_Btn.Text = "Clear";
        }

        /*
        * Radio Buttons for French Language when French is chosen in the Radio Button 
        */

        private void FrRadio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            Lang_GroupBox.Text = "Les Langues";
            Eng_RadioBtn.Text = "Anglais";
            HinRadio_Btn.Text = "Hindi";
            EmpName_Label.Text = "Nom de l'employé";
            EmpID_Label.Text = "ID d'employé:";
            HrsWork_Label.Text = "Heures travaillées :";
            TotSales_Label.Text = "Ventes totales :";
            SalesBonus_Label.Text = "Bonus de vente:";
            Cal_Btn.Text = "Calculer";
            Print_Btn.Text = "Imprimer";
            Clear_Btn.Text = "Clair";
        }

        /*
        * Radio Buttons for Hindi Language when Hindi is chosen in the Radio Button 
        */

        private void HinRadio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            Lang_GroupBox.Text = "भाषाएँ ";
            Eng_RadioBtn.Text = "अंग्रेजी ";
            FrRadio_Btn.Text = "French";
            EmpName_Label.Text = "कर्मचारी का नाम";
            EmpID_Label.Text = "कर्मचारी क्रमांक: ";
            HrsWork_Label.Text = "घंटे काम किया :";
            TotSales_Label.Text = "कुल बिक्री: ";
            SalesBonus_Label.Text = "सेल्स बोनस: ";
            Cal_Btn.Text = "जोड़ें";
            Print_Btn.Text = "प्रिंट करे";
            Clear_Btn.Text = "हटाएँ";
        }


         /*
         * A Message Box is shown when the Print Button is Clicked 
         */
        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if(Eng_RadioBtn.Checked==true)
            MessageBox.Show("Print Command sent, Please check your Printer");
            if(FrRadio_Btn.Checked==true)
            MessageBox.Show("Commande d'imprimer est envoyée, vérifiez votre imprimante S'il vous plaît");
            if (HinRadio_Btn.Checked == true)
            MessageBox.Show("प्रिंट के लिए भेज दिया गया है, कृपया प्रिंटर जाँचें");
        }

        /*
         *  Clears all data after Clicking the Clear Button
         */
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            EmpName_TextBox.Focus();
            EmpName_TextBox.Text = "";
            EmpID_TextBox.Text = "";
            HrsWork_TextBox.Text = "";
            TotSales_TextBox.Text = "";
            SalesBonus_TextBox.Text = "";
            ResetText();
            
        }

        /*
         * Invoking the Cal_Total() Function which will calculate the Sales Bonus
         */

        private void Cal_Btn_Click(object sender, EventArgs e)
        {
            Cal_Total();
        }
        
        private void HrsWork_TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This method will Calculate the Sales Bonus by determining the Percentage of hours
        ///worked during the bonus period.
        /// It will calculate 2% of sales which is the Total Bonus Amount.
        /// And then it will Multiply the Percentage of Hours Worked by the Total Bonus Amount
        /// </summary>
       

        private void Cal_Total()
        { 
            //Converting String to Double
            double total_hrs = Convert.ToDouble(HrsWork_TextBox.Text);

            if (total_hrs > 160 || total_hrs < 0)
            {
                if (Eng_RadioBtn.Checked == true)
                {
                    MessageBox.Show("Total Hours Worked cannot exceed 160 hours");
                }
                if(FrRadio_Btn.Checked==true)
                {
                    MessageBox.Show("Le nombre total d'heures travaillées ne peut dépasser 160 heures");
                }
                if(HinRadio_Btn.Checked==true)
                {
                    MessageBox.Show("कुल काम के घंटे 160 घंटे से अधिक नहीं हो सकते");
                }
            }

            /*Dividing the Total Hours Worked by 160.This will determine the Percentage of hours
            worked during the bonus period*/
            double percentage_hrs=total_hrs / 160;

            double total_sale = Convert.ToDouble(TotSales_TextBox.Text);

            //Validating Inputs
            if(total_sale<0)
            {
                if (Eng_RadioBtn.Checked == true)
                {
                    MessageBox.Show("Please enter Positive Numbers !");
                }
                if (FrRadio_Btn.Checked == true)
                {
                    MessageBox.Show("Veuillez saisir des nombres positifs!");
                }
                if(HinRadio_Btn.Checked==true)
                {
                    MessageBox.Show("कृपया धनात्मक संख्या दर्ज करें!");
                }
            }
            
            /*Multiplying Total Monthly Sales by 0.02 - this will calculate 2 % of sales which is the
            Total Bonus Amount */
            double bonus_total =total_sale*0.02;

            /*Multiplying the Percentage of Hours Worked by the Total Bonus Amount. This will
            determine the value to display in the Sales Bonus text field. */
            double sales_bonus_amount =percentage_hrs* bonus_total;

            //Displaying the Amount in Standard Currency
            SalesBonus_TextBox.Text = sales_bonus_amount.ToString("C2");
            TotSales_TextBox.Text = total_sale.ToString("C2");
                 
        }

        
        
    }
}

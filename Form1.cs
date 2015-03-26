using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }





        //Validate 8 tab, put here!!!!!!!!!!!!!!!!!!!!!!
        private bool validateCustomer()
        {
            bool error = true;
            if (txtCusComName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusComName, "Enter Customer's company!!!");
                error = false;
            }
            if (txtProductName.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter Customer's name!!!");
                error = false;
            }
            if (txtCusAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusAddress, "Enter Customer's address!!!");
                error = false;
            }
            if (txtCusPhone.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusPhone, "Enter Custumber's phone number!!!");
                error = false;
            }
            return error;
        }

        private bool validateOrder()
        {
            bool error = true;
            if (txtOrderCusID.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusComName, "Enter Customer's cID!!!");
                error = false;
            }
            if (txtOrderEmpID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter Employee's ID!!!");
                error = false;
            }
            if (txtOrderShipName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCusAddress, "Enter Ship Name!!!");
                error = false;
            }
            if (txtOrderShipAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipAddress, "Enter Ship Address!!!");
                error = false;
            }
            if (txtOrderShipCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipCity, "Enter Ship City!!!");
                error = false;
            }
            if (txtOrderShipRegion.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipRegion, "Enter Ship Region!!!");
                error = false;
            }
            if (txtOrderShipPosCode.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipPosCode, "Enter Ship Address!!!");
                error = false;
            }
            if (txtOrderShipPosCode.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipPosCode, "Enter Ship Address!!!");
                error = false;
            }
            return error;
        }

        private bool validateProduct()
        {
            bool error = true;
            if (txtProductName.Text.Length == 0)
            {
                errorProvider1.SetError(txtProductName, "Enter product name!!!");
                error = false;
            }
            if (txtProSupplierID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProSupplierID, "Enter Supplier ID!!!");
                error = false;
            }
            if (txtProCategoryID.Text.Length == 0)
            {
                errorProvider1.SetError(txtProCategoryID, "Enter Category ID!!!");
                error = false;
            }
            if (txtProUnitPrice.Text.Length == 0)
            {
                errorProvider1.SetError(txtProUnitPrice, "Enter Unit Price!!!");
                error = false;
            }
            if (radYes.Checked == false && radNo.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "Please select status!");
                error = false;
            }
            return error;
        }

        private bool validateEmp()
        {
            bool error = true;
            if (txtEmpLastName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpLastName, "Enter Employee's Last Name!!!");
                error = false;
            }
            if (txtEmpFirstName.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpFirstName, "Enter Employee's First Name!!!");
                error = false;
            }
            if (txtEmpTitle.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpTitle, "Enter Ship Name!!!");
                error = false;
            }
            if (txtEmpTitleOfCourtesy.Text.Length == 0)
            {
                errorProvider1.SetError(txtOrderShipAddress, "Enter Title of Courtesy!!!");
                error = false;
            }

            DateTime currDate = DateTime.Now;
            int currYear = currDate.Year;
            DateTime DateofBirth = dtpEmpBirthdate.Value;
            int birthYear = DateofBirth.Year;
            DateTime HireDate = dtpEmpHireDate.Value;
            int hireYear = HireDate.Year;
            if (currYear - birthYear < 18)
            {
                errorProvider1.SetError(dtpEmpBirthdate, "Age must be greater than or equal to 18");
                error = false;
            }
            if (currYear - birthYear < 0)
            {
                errorProvider1.SetError(dtpEmpBirthdate, "Hire date must before today!!!");
                error = false;
            }

            if (txtEmpAddress.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpAddress, "Enter Employee Address!!!");
                error = false;
            }
            if (txtEmpCity.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpCity, "Enter Employee City!!!");
                error = false;
            }
            if (txtEmpRegion.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpRegion, "Enter Employee's Region!!!");
                error = false;
            }
            if (txtEmpPosCode.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpPosCode, "Enter Postal Code!!!");
                error = false;
            }
            if (txtEmpCountry.Text.Length == 0)
            {
                errorProvider1.SetError(txtEmpCountry, "Enter Employee's Country!!!");
                error = false;
            }
            if (mtbEmpPhone.MaskCompleted == false)
            {
                errorProvider1.SetError(mtbEmpPhone, "Please enter require digit!!!");
                error = false;
            }
            return error;
        }

        //End validate!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!




        //Must enter number, put here!!!!!!!!!!!!!!!!!!!    
        private void txtCusPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtCusFax_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtCusPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtShipPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtOrderCusID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtOrderEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtProSupplierID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtProCategoryID_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtEmpPosCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }

        private void txtMgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            else
                if (e.Shift == true)
                    e.SuppressKeyPress = true;
        }
        
        //End enter number

    }
}

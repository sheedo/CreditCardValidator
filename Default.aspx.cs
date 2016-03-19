using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnProcessClick(object sender, EventArgs e)
    {
        int digitSum = 0;
        string digits = "";
        string reversedCardNumber = "";
        string cardNumber = txtCardNumber.Text;

        // Remove spaces and reverse string
        cardNumber = cardNumber.Replace(" ", null);
        for (int i = cardNumber.Length - 1; i >= 0; i--)
            reversedCardNumber += cardNumber[i];

        // Double the digits in even-numbered positions
        for (int i = 0; i < reversedCardNumber.Length; i++)
        {
            if ((i + 1) % 2 == 0)
                digits += Convert.ToInt32(reversedCardNumber.Substring(i, 1)) * 2;
            else
                digits += reversedCardNumber.Substring(i, 1);
        }

        // Add the digits
        for (int i = 0; i<digits.Length; i++)
        digitSum += Convert.ToInt32(digits.Substring(i, 1));
        // Check that the sum is divisible by 10
        if ((digitSum % 10) == 0)
            txtResult.Text = "TRUE";
        else
            txtResult.Text = "FALSE";
    
        }
}
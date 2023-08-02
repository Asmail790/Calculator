using System.Diagnostics;
using org.matheval;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace Pages;

public partial class MainPage : ContentPage
{
 


  

    public MainPage()
	{
		InitializeComponent();
	}


	private void append(object text)
	{

        Debug.Write("here we are");
        ExpresionLabel.Text = ExpresionLabel.Text + text.ToString();
    }

    


    public void add0(object sender, EventArgs args)
    {
        append(0);
    }
    public void add1(object sender, EventArgs args)
	{
        append(1);
    }

    public void add2(object sender, EventArgs args)
    {
        append(2);
    }

    public void add3(object sender, EventArgs args)
    {
        append(3);
    }

    public void add4(object sender, EventArgs args)
    {
        append(4);
    }

    public void add5(object sender, EventArgs args)
    {
        append(5);
    }

    public void add6(object sender, EventArgs args)
    {
        append(6);
    }
    public void add7(object sender, EventArgs args)
    {
        append(7);
    }
    public void add8(object sender, EventArgs args)
    {
        append(8);
    }

    public void add9(object sender, EventArgs args)
    {
        append(9);
    }
    public void addDot(object sender, EventArgs args)
    {
        append(".");
    }

    public void addPlus(object sender, EventArgs args)
    {
        append("+");
    }

    public void addMinus(object sender, EventArgs args)
    {
        append("-");
    }

    public void addMultiply(object sender, EventArgs args)
    {
        append("*");
    }

    public void addDivision(object sender, EventArgs args)
    {
        append("/");
    }

    public void clear(object sender, EventArgs args)
    {
        ExpresionLabel.Text = ExpresionLabel.Text = "";
    }

    public void delete(object sender, EventArgs args)
    {   
        if (! ExpresionLabel.Text.Equals(""))
        {
            ExpresionLabel.Text = ExpresionLabel.Text.Substring(0, ExpresionLabel.Text.Length - 1);
        }
        
    }

    public void calculate(object sender, EventArgs args)
    {

        var e = new Expression(ExpresionLabel.Text);
        if (e.GetError().Count()>0)
        {

            string text = "Invalid Expression";
            ToastDuration duration = ToastDuration.Short;
            var toast = Toast.Make(text, duration, 30);
            var task = toast.Show();
            task.Wait();
           

            Debug.WriteLine("invalid expression");
        } else
        {
            ExpresionLabel.Text = e.Eval().ToString();
        }

    }

   

}


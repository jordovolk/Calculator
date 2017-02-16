using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    class Calc : ContentPage
    {
        String change;

        Label displayLabel;

        Boolean multiplyFlag = false;

        Boolean divideFlag = false;

        Boolean addFlag = false;

        Boolean subtractFlag = false;

        public Calc()

        {

            var layout = new Grid();



            // Rows:

            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });

            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });



            // Columns:

            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(layout, // <= Original layout
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(p => p.Width),
                Constraint.RelativeToParent(p => p.Height));
            Content = relativeLayout;



            



            displayLabel = new Label { Text = "" };











            var b0 = new Button { Text = "0" };

            var b1 = new Button { Text = "1" };

            var b2 = new Button { Text = "2" };

            var b3 = new Button { Text = "3" };

            var b4 = new Button { Text = "4" };

            var b5 = new Button { Text = "5" };

            var b6 = new Button { Text = "6" };

            var b7 = new Button { Text = "7" };

            var b8 = new Button { Text = "8" };

            var b9 = new Button { Text = "9" };

            var bMultiply = new Button { Text = "X" };

            var bDivide = new Button { Text = "/" };

            var bAdd = new Button { Text = "+" };

            var bSubtract = new Button { Text = "-" };

            var bClear = new Button { Text = "C"};

            var bEquals = new Button { Text = "=" };



            //output

            Grid.SetColumn(displayLabel, 1);

            Grid.SetRow(displayLabel, 0);

            Grid.SetColumnSpan(displayLabel, 4);

            //buttons

            Grid.SetColumn(b0, 1);

            Grid.SetColumn(b1, 2);

            Grid.SetColumn(b2, 3);

            Grid.SetColumn(b3, 1);

            Grid.SetColumn(b4, 2);

            Grid.SetColumn(b5, 3);

            Grid.SetColumn(b6, 1);

            Grid.SetColumn(b7, 2);

            Grid.SetColumn(b8, 3);

            Grid.SetColumn(b9, 1);

            Grid.SetColumn(bEquals, 2);

            Grid.SetColumn(bClear, 3);



            Grid.SetColumn(bAdd, 0);

            Grid.SetColumn(bSubtract, 0);

            Grid.SetColumn(bDivide, 0);

            Grid.SetColumn(bMultiply, 0);







            Grid.SetRow(b0, 4);

            Grid.SetRow(b1, 4);

            Grid.SetRow(b2, 4);

            Grid.SetRow(b3, 3);

            Grid.SetRow(b4, 3);

            Grid.SetRow(b5, 3);

            Grid.SetRow(b6, 2);

            Grid.SetRow(b7, 2);

            Grid.SetRow(b8, 2);

            Grid.SetRow(b9, 1);

            Grid.SetRow(bEquals, 1);

            Grid.SetRow(bClear, 1);

            Grid.SetRow(bAdd, 1);

            Grid.SetRow(bSubtract, 2);

            Grid.SetRow(bDivide, 3);

            Grid.SetRow(bMultiply, 4);







            layout.Children.Add(b0);

            layout.Children.Add(b1);

            layout.Children.Add(b2);

            layout.Children.Add(b3);

            layout.Children.Add(b4);

            layout.Children.Add(b5);

            layout.Children.Add(b6);

            layout.Children.Add(b7);

            layout.Children.Add(b8);

            layout.Children.Add(b9);

            layout.Children.Add(displayLabel);

            layout.Children.Add(bClear);

            layout.Children.Add(bEquals);

            layout.Children.Add(bAdd);

            layout.Children.Add(bSubtract);

            layout.Children.Add(bDivide);

            layout.Children.Add(bMultiply);



            //event handlers

            b0.Clicked += OnNumericButtonClicked;

            b1.Clicked += OnNumericButtonClicked;

            b2.Clicked += OnNumericButtonClicked;

            b3.Clicked += OnNumericButtonClicked;

            b4.Clicked += OnNumericButtonClicked;

            b5.Clicked += OnNumericButtonClicked;

            b6.Clicked += OnNumericButtonClicked;

            b7.Clicked += OnNumericButtonClicked;

            b8.Clicked += OnNumericButtonClicked;

            b9.Clicked += OnNumericButtonClicked;

            bEquals.Clicked += OnEqualButtonClicked;

            bClear.Clicked += OnClearButtonClicked;

            bAdd.Clicked += OnAddButtonClicked;

            bSubtract.Clicked += OnSubtractButtonClicked;

            bDivide.Clicked += OnDivideButtonClicked;

            bMultiply.Clicked += OnMultiplyButtonClicked;











        }





        void OnNumericButtonClicked(object sender, EventArgs e)

        {

            Button buttonClickedOn = (Button)sender;



            displayLabel.Text += (string)buttonClickedOn.Text;









        }



        void OnClearButtonClicked(object sender, EventArgs e)

        {



            displayLabel.Text = "";

            addFlag = false;

            subtractFlag = false;

            divideFlag = false;

            multiplyFlag = false;

        }



        void OnAddButtonClicked(object sender, EventArgs e)

        {

            addFlag = true;

            Button buttonClickedOn = (Button)sender;



            displayLabel.Text += (string)buttonClickedOn.Text;





        }



        void OnSubtractButtonClicked(object sender, EventArgs e)

        {

            subtractFlag = true;

            Button buttonClickedOn = (Button)sender;



            displayLabel.Text += (string)buttonClickedOn.Text;





        }



        void OnMultiplyButtonClicked(object sender, EventArgs e)

        {

            multiplyFlag = true;

            Button buttonClickedOn = (Button)sender;



            displayLabel.Text += (string)buttonClickedOn.Text;





        }



        void OnDivideButtonClicked(object sender, EventArgs e)

        {

            divideFlag = true;

            Button buttonClickedOn = (Button)sender;



            displayLabel.Text += (string)buttonClickedOn.Text;





        }



        void OnEqualButtonClicked(object sender, EventArgs e)

        {

            Button buttonClickedOn = (Button)sender;

            String value = displayLabel.Text;

            String result;

            Char delimiter;





            if (multiplyFlag == true)

            {

                delimiter = 'X';

                String[] parts = value.Split(delimiter);







                String value1 = parts[0];

                String value2 = parts[1];



                Double doublevalue1 = Convert.ToDouble(value1);

                Double doublevalue2 = Convert.ToDouble(value2);



                displayLabel.Text = (doublevalue1 * doublevalue2).ToString();

                multiplyFlag = false;



            }

            if (divideFlag == true)

            {

                delimiter = '/';

                String[] parts = value.Split(delimiter);







                String value1 = parts[0];

                String value2 = parts[1];



                Double doublevalue1 = Convert.ToDouble(value1);

                Double doublevalue2 = Convert.ToDouble(value2);



                displayLabel.Text = (doublevalue1 / doublevalue2).ToString();

                divideFlag = false;



            }



            if (addFlag == true)

            {

                delimiter = '+';

                String[] parts = value.Split(delimiter);







                String value1 = parts[0];

                String value2 = parts[1];



                Double doublevalue1 = Convert.ToDouble(value1);

                Double doublevalue2 = Convert.ToDouble(value2);



                displayLabel.Text = (doublevalue1 + doublevalue2).ToString();

                addFlag = false;



            }



            if (subtractFlag == true)

            {

                delimiter = '-';

                String[] parts = value.Split(delimiter);







                String value1 = parts[0];

                String value2 = parts[1];



                Double doublevalue1 = Convert.ToDouble(value1);

                Double doublevalue2 = Convert.ToDouble(value2);



                displayLabel.Text = (doublevalue1 - doublevalue2).ToString();

                subtractFlag = false;



            }



















        }




    }
}

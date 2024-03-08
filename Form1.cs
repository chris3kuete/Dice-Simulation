namespace Dice_Simulator__chap_5_prob_8_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rnum1;
            int rnum2;
            int sum;
            int product;

            var rand = new Random();

            rnum1 = rand.Next(1, 7);
            rnum2 = rand.Next(1, 7);

            if (rnum1 == 1 && rnum2 == 1)
            {
                Dice1pb.Visible = true;
                Dice2pb.Visible = false;
                Dice21pb.Visible = true;
                Dice3pb.Visible = false;
                Dice4pb.Visible = false;
                Dice5pb.Visible = false;
                Dice6pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice24pb.Visible = false;
                Dice25pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 2 && rnum2 == 2)
            {
                Dice1pb.Visible = false;
                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice4pb.Visible = false;
                Dice5pb.Visible = false;
                Dice6pb.Visible = false;

                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice24pb.Visible = false;
                Dice25pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 3 && rnum2 == 3)
            {
                Dice3pb.Visible = true;
                Dice23pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice1pb.Visible = false;
                Dice2pb.Visible = false;

                Dice4pb.Visible = false;
                Dice5pb.Visible = false;
                Dice6pb.Visible = false;

                Dice21pb.Visible = false;
                Dice22pb.Visible = false;

                Dice24pb.Visible = false;
                Dice25pb.Visible = false;
                Dice26pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 4 && rnum2 == 4)
            {
                Dice4pb.Visible = true;
                Dice24pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice1pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice26pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 5)
            {
                Dice5pb.Visible = true;
                Dice25pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice1pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice24pb.Visible = false;
                Dice26pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 6)
            {
                Dice6pb.Visible = true;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice1pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 1 && rnum2 == 2)
            {
                Dice1pb.Visible = true;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice6pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 1 && rnum2 == 3)
            {
                Dice1pb.Visible = true;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice6pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = true;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 1 && rnum2 == 4)
            {
                Dice1pb.Visible = true;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

                Dice6pb.Visible = false;
                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = true;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 1 && rnum2 == 5)
            {
                Dice1pb.Visible = true;
                Dice25pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice26pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 1 && rnum2 == 6)
            {
                Dice1pb.Visible = true;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 2 && rnum2 == 1)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = true;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();

            }
            else if (rnum1 == 2 && rnum2 == 3)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = true;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 2 && rnum2 == 4)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = true;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 2 && rnum2 == 5)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = true;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 2 && rnum2 == 6)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = true;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 3 && rnum2 == 1)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = true;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = true;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 3 && rnum2 == 2)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = true;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 3 && rnum2 == 4)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = true;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = true;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 3 && rnum2 == 5)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = true;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = true;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 3 && rnum2 == 6)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = true;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 4 && rnum2 == 1)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = true;
                Dice6pb.Visible = false;
                Dice21pb.Visible = true;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 4 && rnum2 == 2)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = true;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 4 && rnum2 == 3)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = true;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = true;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 4 && rnum2 == 5)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = true;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = true;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 4 && rnum2 == 6)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = true;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 1)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = true;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = true;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 2)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = true;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 3)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = true;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = true;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 4)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = true;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = true;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 5 && rnum2 == 6)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = true;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = true;
                Dice4pb.Visible = false;
                Dice6pb.Visible = false;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 1)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = true;
                Dice21pb.Visible = true;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 2)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = true;
                Dice21pb.Visible = false;
                Dice22pb.Visible = true;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 3)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = true;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = true;
                Dice25pb.Visible = false;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 4)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = true;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = false;
                Dice24pb.Visible = true;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else if (rnum1 == 6 && rnum2 == 5)
            {
                Dice1pb.Visible = false;
                Dice26pb.Visible = false;
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();


                Dice2pb.Visible = false;
                Dice3pb.Visible = false;
                Dice5pb.Visible = false;
                Dice4pb.Visible = false;
                Dice6pb.Visible = true;
                Dice21pb.Visible = false;
                Dice22pb.Visible = false;
                Dice23pb.Visible = false;
                Dice25pb.Visible = true;
                Dice24pb.Visible = false;

                sum = rnum1 + rnum2;
                product = rnum1 * rnum2;
                sumlbl.Text = sum.ToString();
                productlbl.Text = product.ToString();
            }
            else
            {
                num1lbl.Text = rnum1.ToString();
                num2lbl.Text = rnum2.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

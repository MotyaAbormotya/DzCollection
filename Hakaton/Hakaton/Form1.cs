using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, string> menuPizza = new Dictionary<int, string>();
        Dictionary<int, string> menuDrink = new Dictionary<int, string>();

        Random random = new Random();

        int howMuchNewPerson = 500;
        int[] howMuchAddAdvert = new int[10] { 550, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 128000, 256000 };
        int[] howMuchLevelUp = new int[10] { 750, 1500, 3000, 5000, 10000, 15000, 30000, 50000, 100000, 500000 };

        int scorePressButtonLevelUp = 0;
        int scorePressButtonAddAdvert = 0;
        int scorePressButtonNewPerson = 0;

        int pizza = 0;
        int money = 500;
        int purchase = 0;

        int timePizza = 15;
        int timePurchase = 20;

        int raw = 0;
        int salary = 0;
        int workers = 0;
        int sellDrink = 0;
        int sellPizza = 0;
        int scorePurchase = 1;


        int wantPizza = 0;
        int wantDrink = 0;
        string changePizza = "Нет";
        string changeDrink = "Нет";

        int hours = 9;
        int minutes = 00;

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPizza.Add(1, "Пеперони");
            menuPizza.Add(2, "Цезарь");
            menuPizza.Add(3, "Додо Микс");
            menuPizza.Add(4, "Гавайская");
            menuPizza.Add(5, "Сырная");

            menuDrink.Add(1, "Нет");
            menuDrink.Add(2, "Кола");
            menuDrink.Add(3, "Фанта");
            menuDrink.Add(4, "Спрайт");
            menuDrink.Add(5, "Вода");
        }

        private void buttonCreatePizza_Click(object sender, EventArgs e)
        {
            labelTime.Visible = true;
            labelMoney.Visible = true;
            labelPizza.Visible = true;
            labelLevelUp.Visible = true;
            labelPurchase.Visible = true;
            labelAddAdvert.Visible = true;
            labelNewPerson.Visible = true;

            buttonInfo.Visible = true;
            buttonLevelUp.Visible = true;
            buttonAddAdvert.Visible = true;
            buttonNewPerson.Visible = true;
            buttonCreatePizza.Visible = false;

            pictureBoxMoney.Visible = true;
            pictureBoxPurchase.Visible = true;
            pictureBoxPizza.Visible = true;

            timerPurchase.Enabled = true;
            timerTime.Enabled = true;

            labelMoney.Text = money.ToString();
        }

        private void buttonLevelUp_Click(object sender, EventArgs e)
        {
            if (scorePressButtonLevelUp < 9)
            {
                if (money >= howMuchLevelUp[scorePressButtonLevelUp])
                {
                    money -= howMuchLevelUp[scorePressButtonLevelUp];
                    labelMoney.Text = money.ToString();
                    timePizza--;
                    timePurchase--;
                    scorePressButtonLevelUp++;
                    labelLevelUp.Text = howMuchLevelUp[scorePressButtonLevelUp].ToString() + '₽';
                }
            }
            else
            {
                labelLevelUp.Text = "max";
                buttonLevelUp.Enabled = false;
            }
        }

        private void buttonNewPerson_Click(object sender, EventArgs e)
        {
            if (money >= howMuchNewPerson)
            {
                money -= howMuchNewPerson;
                labelMoney.Text = money.ToString();
                scorePressButtonNewPerson++;
                workers++;
            }
        }

        private void buttonAddAdvert_Click(object sender, EventArgs e)
        {
            if (scorePressButtonAddAdvert < 9)
            {
                if (money >= howMuchAddAdvert[scorePressButtonAddAdvert])
                {
                    money -= howMuchAddAdvert[scorePressButtonAddAdvert];
                    labelMoney.Text = money.ToString();
                    scorePressButtonAddAdvert++;
                    scorePurchase += 1;
                    labelAddAdvert.Text = howMuchAddAdvert[scorePressButtonAddAdvert].ToString() + '₽';
                }
            }
            else
            {
                labelAddAdvert.Text = "max";
                buttonAddAdvert.Enabled = false;
            }
        }

        private void timerPurchase_Tick(object sender, EventArgs e)
        {
            if (purchase == 0)
                buttonChek.Visible = false;

            if (timePurchase != 0)
                timePurchase--;
            else
            {
                purchase += random.Next(1, (scorePurchase) + 1);
                wantDrink = random.Next(1, 5 + 1);
                wantPizza = random.Next(1, 5 + 1);

                if (purchase != 0)
                    buttonChek.Visible = true;

                timePurchase = 20;
            }

            if (purchase != 0 && workers > 0)
            {
                timerPizza.Enabled = true;
            }


            SellFood();

            labelPizza.Text = pizza.ToString();
            labelPurchase.Text = purchase.ToString();
        }

        private void timerPizza_Tick(object sender, EventArgs e)
        {
            if (purchase != 0 && workers > 0)
            {
                if (timePizza != 0)
                    timePizza--;
                else
                {
                    if (purchase != 0 && purchase <= workers)
                        pizza += purchase;
                    if (purchase != 0 && purchase > workers)
                        pizza += workers;

                    timerPizza.Enabled = false;
                    timePizza = 15;
                }
            }
        }

        public void SellFood()
        {
            if (purchase != 0 && pizza != 0)
            {
                purchase--;
                pizza--;

                ChoosePizza();
                ChooseDrink();

                raw += sellDrink + sellPizza;

                sellDrink = 0;
                sellPizza = 0;

                labelMoney.Text = money.ToString();
            }
            if (purchase != 0 && pizza == 0)
            {
                if (purchase != 0 && purchase <= workers)
                    labelInfo.Text = $"Делаем Пиццу ({purchase} шт)";
                if (purchase != 0 && purchase > workers)
                    labelInfo.Text = $"Делаем Пиццу ({workers} шт)";
                if (workers == 0)
                    labelInfo.Text = "Нет работников!";

                changeDrink = menuDrink[wantDrink];
                changePizza = menuPizza[wantPizza];
            }
            else
                labelInfo.Text = " ";

        }

        public void ChoosePizza()
        {
            switch (wantPizza)
            {
                case 1:
                    money += 375;
                    sellPizza += 125;
                    break;
                case 2:
                    money += 425;
                    sellPizza += 150;
                    break;
                case 3:
                    money += 425;
                    sellPizza += 150;
                    break;
                case 4:
                    money += 245;
                    sellPizza += 100;
                    break;
                case 5:
                    money += 375;
                    sellPizza += 125;
                    break;
            }
        }

        public void ChooseDrink()
        {
            switch (wantDrink)
            {
                case 1:
                    money += 0;
                    sellDrink += 0;
                    break;
                case 2:
                    money += 95;
                    sellDrink += 35;
                    break;
                case 3:
                    money += 95;
                    sellDrink += 35;
                    break;
                case 4:
                    money += 95;
                    sellDrink += 35;
                    break;
                case 5:
                    money += 65;
                    sellDrink += 25;
                    break;
            }
        }

        private void buttonChek_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Пицца: {changePizza}\nНапиток: {changeDrink}");
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            minutes++;

            salary = workers * 100;
            
            if (minutes > 59)
            {
                hours++;
                minutes = 00;
            }
            if (hours == 23)
            {
                hours = 9;
                minutes = 00;

                money -= salary + raw;
                salary = 0;
                raw = 0;

                if (money < 0)
                {
                    labelTime.Visible = false;
                    labelMoney.Visible = false;
                    labelPizza.Visible = false;
                    labelLevelUp.Visible = false;
                    labelPurchase.Visible = false;
                    labelAddAdvert.Visible = false;
                    labelNewPerson.Visible = false;

                    buttonInfo.Visible = false;
                    buttonLevelUp.Visible = false;
                    buttonAddAdvert.Visible = false;
                    buttonNewPerson.Visible = false;
                    buttonCreatePizza.Visible = false;

                    pictureBoxMoney.Visible = false;
                    pictureBoxPurchase.Visible = false;
                    pictureBoxPizza.Visible = false;

                    timerPurchase.Enabled = false;
                    timerTime.Enabled = false;

                    MessageBox.Show("Вы банкрот!");
                    this.Close();
                }

                labelMoney.Text = money.ToString();
            }
            if (minutes < 10)
                labelTime.Text = $"{hours} : 0{minutes}";
            else
                labelTime.Text = $"{hours} : {minutes}";
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Работаем от 9:00 до 23:00\n\nРаботников: {scorePressButtonNewPerson}\nУлучшений: {scorePressButtonLevelUp}\nРеклам: {scorePressButtonAddAdvert}\nЗатраты на сегодня: {salary + raw}");
        }
    }
}

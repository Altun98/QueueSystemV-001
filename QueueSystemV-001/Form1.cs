using QueueSystemV_001.Enums;
using QueueSystemV_001.Models;
using System.Reflection.Emit;

namespace QueueSystemV_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void GetOperator()
        {
            Operator op1 = new Operator("Abbas", "Hesenov", OperationType.Arayışlar);
            Operator op2 = new Operator("Qasım", "", OperationType.İpoteka);
            Operator op3 = new Operator("Hicran", "Esgerli", OperationType.Əmanətlər);
            Operator op4 = new Operator("Xedice", "Məmmədova", OperationType.HesabaMədaxil);
            Operator op5 = new Operator("Mədinə", "Əliyeva", OperationType.HesabaMəxaric);
            Operator op6 = new Operator("Elnur", "Cəfərov", OperationType.İpotekaÖdənişi);
            Operator op7 = new Operator("Kamran", "Kazımov", OperationType.KartSifarişi);
            Operator op8 = new Operator("Tural", "Əliyev", OperationType.KreditSifarişi);
            Operator op9 = new Operator("Məsim", "Musayev", OperationType.KreditÖdənişi);
            // Operator[] opArray = new Operator[] { op1, op2, op3, op4, op5, op6, op7, op8, op9 };
            // return opArray;

        }
        private void InitializeComboBox()
        {
            //enamlari comboboxa cekmek
            cmbOperationType.Items.AddRange(Enum.GetNames(typeof(OperationType)));
            cmbSeries.Items.AddRange(Enum.GetNames(typeof(Series)));
        }

        private void cmbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            lblOperationTypeName.Text = cmbOperationType.SelectedItem.ToString();
        }
        private void ElementsClears()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            lblOperationTypeName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Operatorlarin tanidilmasi
            Operator op1 = new Operator("Abbas", "Hesenov", OperationType.Arayışlar);
            Operator op2 = new Operator("Qasım", "Etibarli", OperationType.İpoteka);
            Operator op3 = new Operator("Hicran", "Esgerli", OperationType.Əmanətlər);
            Operator op4 = new Operator("Xedice", "Məmmədova", OperationType.HesabaMədaxil);
            Operator op5 = new Operator("Mədinə", "Əliyeva", OperationType.HesabaMəxaric);
            Operator op6 = new Operator("Elnur", "Cəfərov", OperationType.İpotekaÖdənişi);
            Operator op7 = new Operator("Kamran", "Kazımov", OperationType.KartSifarişi);
            Operator op8 = new Operator("Tural", "Əliyev", OperationType.KreditSifarişi);
            Operator op9 = new Operator("Məsim", "Musayev", OperationType.KreditÖdənişi);
            #endregion

            timer1.Start();
            if (cmbOperationType.SelectedItem.ToString() == OperationType.İpoteka.ToString())
            {
                lblInformations.Text = $"Musteri: {textBox2.Text.ToString()} {textBox1.Text.ToString()} {textBox3.Text.ToString()} \nOperator:{op2.Surname} {op2.Name}";
            }
            ElementsClears();

        }

        int start = 0, seconds = 0, minute = 0, hours = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            start++;
            if (start <= 300)
            {
                progressBar1.Value = start;
            }
            seconds++;
            if (seconds == 60)
            {
                minute++;
                seconds = 0;
            }
            if (minute == 60)
            {
                hours++;
                minute = 0;
            }
            if (minute == 24)
            {
                seconds = 0; minute = 0; hours = 0;
            }
            lblWhotch.Text = $"{String.Format("{0:D2}", hours)}:{  String.Format("{0:D2}", minute)}:{ String.Format("{0:D2}", seconds)}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
    }
}

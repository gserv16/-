using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Гранди
{
    public partial class Form1 : Form
    {
        private List <int> heaps;
        private Random random;
        private bool isPlayerTurn;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            firstDivision.TextChanged += secondCount_TextChanged;
            initialCount.KeyPress += TextBox_KeyPress;
            heapNumber.KeyPress += TextBox_KeyPress;
            firstDivision.KeyPress += TextBox_KeyPress;
        }

        //задание начальной кучи и установка первого хода
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(initialCount.Text, out int initialHeap) || initialHeap <= 2)
            {
                MessageBox.Show("Введите корректное начальное количество элементов (больше 2).");
                return;
                DialogResult result;
            }

            heaps = new List<int> { initialHeap };
            isPlayerTurn = radioButton2.Checked;
            UpdateHeapsDisplay();
            info.Text = $"Игра началась. {(isPlayerTurn ? "Игрок" : "Компьютер")} делает первый ход.";

            if (!isPlayerTurn)
                ComputerMove();
        }

        //обработка нажатия кнопки совершения хода игроком
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlayerTurn)
                MakePlayerMove();
        }

        //обработка нажатия кнопки сброса
        private void button3_Click(object sender, EventArgs e)
        {
            heapNumber.Clear();
            firstDivision.Clear();
            secondDivision.Clear();
        }

        //обработка нажатия кнопки "Правила игры"
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра Гранди — стратегическая математическая игра для двух игроков. Сначала существует одна куча предметов. Два игрока по очереди разделяют любую из куч на две кучи разных размеров. Игра заканчивается, когда остаются только кучи из двух или одного предметов, т.к. ни одна не может быть разделена на кучи разных размеров. Выигрывает игрок, который сделал последний ход.", "Правила игры", MessageBoxButtons.OK);
        }

        //выполнение хода игрока
        private void MakePlayerMove()
        {
            if (!int.TryParse(heapNumber.Text, out int heapIndex) || heapIndex < 1 || heapIndex > heaps.Count)
            {
                MessageBox.Show("Введите корректный номер кучи.");
                return;
            }

            if (!int.TryParse(firstDivision.Text, out int newHeap1) || !int.TryParse(secondDivision.Text, out int newHeap2))
            {
                MessageBox.Show("Введите корректные размеры новых куч.");
                return;
            }

            heapIndex -= 1; //преобразование в индекс массива
            int selectedHeap = heaps[heapIndex];

            heaps.RemoveAt(heapIndex);
            heaps.Add(newHeap1);
            heaps.Add(newHeap2);
            UpdateHeapsDisplay();
            info.Text = $"Игрок разделил кучу {heapIndex + 1} на {newHeap1} и {newHeap2}.";

            //проверка конца игры после хода игрока
            if (CheckGameOver())
                return;

            isPlayerTurn = false;
            ComputerMove();
        }

        //выполнение хода компьютера
        private void ComputerMove()
        {
            //выбираем кучу, которую можно разделить
            List<int> splittableHeaps = heaps.Where(heap => heap > 2).ToList();

            //если таких куч нет, проверяем конец игры
            if (splittableHeaps.Count == 0)
                if (CheckGameOver()) return;

            //выбираем случайную кучу для деления
            int heapIndex = heaps.IndexOf(splittableHeaps[random.Next(splittableHeaps.Count)]);
            int heapSize = heaps[heapIndex];
            int newHeap1, newHeap2;

            do
            {
                newHeap1 = random.Next(1, heapSize);
                newHeap2 = heapSize - newHeap1;
            }
            while (newHeap1 == newHeap2 || newHeap1 <= 0 || newHeap2 <= 0);

            heaps.RemoveAt(heapIndex);
            heaps.Add(newHeap1);
            heaps.Add(newHeap2);
            UpdateHeapsDisplay();
            info.Text = $"Компьютер разделил кучу {heapIndex + 1} на {newHeap1} и {newHeap2}.";

            //проверка конца игры после хода компьютера
            if (CheckGameOver())
                return;

            isPlayerTurn = true;
        }

        //обновление отображения списка куч
        private void UpdateHeapsDisplay()
        {
            heapList.Items.Clear();
            for (int i = 0; i < heaps.Count; i++)
                heapList.Items.Add($"куча {i + 1} - элементов: {heaps[i]}");
        }

        //проверка конца игры: все кучи не могут быть разделены
        private bool CheckGameOver()
        {
            if (heaps.All(heap => heap <= 2))
            {
                string winner = isPlayerTurn ? "Вы выиграли" : "Вы проиграли";
                MessageBox.Show($"{winner}");
                startButton.Enabled = true;
                moveButton.Enabled = true;
                return true;
            }
            return false;
        }

        //автоматическое заполнение второго TextBox при изменении первого
        private void secondCount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(firstDivision.Text, out int firstCount) && int.TryParse(heapNumber.Text, out int heapIndex))
            {
                heapIndex -= 1; //преобразование в индекс массива
                if (heapIndex >= 0 && heapIndex < heaps.Count)
                {
                    int selectedHeap = heaps[heapIndex];
                    if (firstCount > 0 && firstCount < selectedHeap)
                        secondDivision.Text = (selectedHeap - firstCount).ToString();
                    else
                        secondDivision.Clear();
                }
            }
            else
                secondDivision.Clear();
        }

        //обработчик для разрешения ввода только цифр
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        //установка размера окна
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(402, 255);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
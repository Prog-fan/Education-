using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace Online_clothing_store
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        int totalcost = 0;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private int currentImageIndex = 0;
        private readonly (Image image, string name, int price, int stock)[] products;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Магазин одежды";
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseWheel += Form1_MouseWheel;
            products = new (Image image, string name, int price, int stock)[]
           {
                (Properties.Resources._1, "Куртка мужская зимняя", 5200, 309),
                (Properties.Resources._2, "Куртка мужская", 4800, 150),
                (Properties.Resources._3, "Пальто женское", 10800, 500),
                (Properties.Resources._4, "Пальто женское зимнее", 11200, 400),
                (Properties.Resources._5, "Перчатки походные", 1500, 200),
                (Properties.Resources._6, "Перчатки жеские зимние", 3500, 100),
                (Properties.Resources._7, "Перчатки мужские зимние", 2500, 250),
                (Properties.Resources._8, "Куртка мужская походная", 11800, 180),
           };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void UpdateImages()
        {
            if (products.Length >= 4)
            {
                pictureBox.Image = products[currentImageIndex % products.Length].image;
                pictureBox1.Image = products[(currentImageIndex + 1) % products.Length].image;
                pictureBox2.Image = products[(currentImageIndex + 2) % products.Length].image;
                pictureBox3.Image = products[(currentImageIndex + 3) % products.Length].image;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (products.Length > 0)
            {
                currentImageIndex = (currentImageIndex - 1 + products.Length) % products.Length;
                UpdateImages();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (products.Length > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % products.Length;
                UpdateImages();
            }
        }

        private void CloseScreen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fullscreen_Click(object sender, EventArgs e)
        {
            WindowState = (WindowState != FormWindowState.Maximized)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        private void MinimizedScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Fullscreen_Click(sender, e);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                int productIndex = Array.FindIndex(new PictureBox[] { pictureBox, pictureBox1, pictureBox2, pictureBox3 }, pb => pb == clickedPictureBox);
                int index = (currentImageIndex + productIndex) % products.Length;

                var product = products[index];
                ShowProductContextMenu(product);
            }
        }

        private void ShowProductContextMenu((Image image, string name, int price, int stock) product)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem infoItem = new ToolStripMenuItem("Информация о товаре");
            infoItem.Click += (s, e) =>
            {
                MessageBox.Show(
                    $"Наименование: {product.name}" +
                    $"\nСтоимость: {product.price} рублей" +
                    $"\nКоличество на складе: {product.stock} штук",
                    "Информация о товаре");
            };

            ToolStripMenuItem buyItem = new ToolStripMenuItem("Положить товар в корзину");
            buyItem.Click += (s, e) =>
            {
                if (product.stock > 0)
                {
                    listBox.Items.Add($"{product.name} за  {product.price} рублей");

                    label1.Text = $"Общее количество: {listBox.Items.Count} \nИтоговая стоимость  {totalcost += product.price}";
                }
                else
                {
                    MessageBox.Show("К сожалению, товар закончился на складе.", "Ошибка покупки");
                }
            };

            menu.Items.Add(infoItem);
            menu.Items.Add(buyItem);

            menu.Show(Cursor.Position);
        }


        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                PrevButton_Click(sender, e);
            }
            else
            {
                NextButton_Click(sender, e);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.LightGray;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = SystemColors.Control;
            }
        }


        private string CreateReceiptText(decimal totalAmount, string orderNumber, string pickupPoint, DateTime orderDate)
        {
            Random random = new Random();
            string pickupCode = random.Next(100, 1000).ToString();

            string receiptText = $"Талон заказа\n\n";
            receiptText += $"Дата заказа: {orderDate.ToShortDateString()}\n";
            receiptText += $"Номер заказа: {orderNumber}\n";
            receiptText += "Состав заказа:\n";
            receiptText += $"Количество товаров: {listBox.Items.Count}"; 
            receiptText += $"\nОбщая сумма: {totalAmount:C}\n";
            receiptText += $"Код получения: {pickupCode}\n";
            receiptText += $"Пункт выдачи: {pickupPoint}\n";
            DateTime expirationDate = orderDate.AddDays(3);
            receiptText += $"Срок заказа: до {expirationDate.ToShortDateString()}\n";

            return receiptText;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                string orderNumber = $"{DateTime.Now.Ticks}";
                string receiptText = CreateReceiptText(totalcost, orderNumber, "Ул.Сафонова, 27", DateTime.Now);

                MessageBox.Show(receiptText, "Талон заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);

                totalcost = 0 ;
                label1.Text = "";
                listBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("Сначала добавьте товары в заказ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if(listBox.Items.Count > 0)
            {
                listBox.Items.RemoveAt(listBox.Items.Count - 1);
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NHopfild
{
    public partial class Form1 : Form
    {
        private const int ALLOWED_NOISE = 1;
        private const double WEIGHT_CORRECT_COEF = 0.07;
        private const int DIMENSION = 800;

        private double[,] weights = new double[DIMENSION, DIMENSION];
        private List<int> last_inputs;
        private List<int> cur_inputs;

        private Model.Brush brush;
        private Color color;

        private bool isPictureDrown = false;
        
        public Form1()
        {
            InitializeComponent();
            brush = new Model.Brush(3);
            color = Color.Black;
            InitWeights();
            InitLastInputs();
            InitImage();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox.Image);
                brush.Draw(g, e.X, e.Y, color);
                pictureBox.Refresh();
                UpdateLearnButton();
                g.Dispose();
            }
            if (e.Button == MouseButtons.Right)
            {
                Graphics g = Graphics.FromImage(pictureBox.Image);
                brush.Draw(g, e.X, e.Y, Color.White);
                pictureBox.Refresh();
                UpdateLearnButton();
                g.Dispose();
            }
        }

        private void eraiseButton_Click(object sender, EventArgs e)
        {
            InitImage();
            isPictureDrown = false;
            UpdateLearnButton();
        }

        private void UpdateLearnButton()
        {
            learnButton.Enabled = isPictureDrown;
            learnButton.Refresh();
            mislearnButton.Enabled = isPictureDrown;
            learnButton.Refresh();
            identifyButton.Enabled = isPictureDrown;
            identifyButton.Refresh();
        }

        private void identifyButton_Click(object sender, EventArgs e)
        {
            cur_inputs = CurInputsInit();
            PaintInPictureBox(cur_inputs);

            Identify();
            do
            {
                Thread.Sleep(2000);
                PaintInPictureBox(cur_inputs);
                Identify();
            }
            while (!IsInputsEqual());

            Thread.Sleep(2000);
            MessageBox.Show("Успешно!");
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            cur_inputs = CurInputsInit();

            //do
            //{

                for (int RowIndex = 0; RowIndex < DIMENSION; RowIndex++)
                    for (int ColIndex = 0; ColIndex < DIMENSION; ColIndex++)
                    {
                        if (RowIndex != ColIndex)
                            weights[RowIndex, ColIndex] += cur_inputs[RowIndex] * cur_inputs[ColIndex];
                    }

                //CurInputsToLastInputs();
                //cur_inputs = Identify();
            //}
            //while (!IsInputsEqual());

            MessageBox.Show("Успешно!");

        }

        private void mislearnButton_Click(object sender, EventArgs e)
        {
            for (int RowIndex = 0; RowIndex < DIMENSION; RowIndex++)
                for (int ColIndex = 0; ColIndex < DIMENSION; ColIndex++)
                {
                    if (RowIndex != ColIndex)
                        weights[RowIndex, ColIndex] = weights[RowIndex, ColIndex] - cur_inputs[RowIndex] * cur_inputs[ColIndex] * WEIGHT_CORRECT_COEF;
                }

            MessageBox.Show("Успешно!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitImage()
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(pictureBox.Image);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox.Width, pictureBox.Height);
            g.Dispose();
        }

        private void InitWeights()
        {
            for (int RowIndex = 0; RowIndex < DIMENSION; RowIndex++)
                for (int ColIndex = 0; ColIndex < DIMENSION; ColIndex++)
                    weights[RowIndex, ColIndex] = 0;
        }

        private void InitLastInputs()
        {
            last_inputs = new List<int>();
            for (int index = 0; index < DIMENSION / 2; index++)
                last_inputs.Add(0);
            for (int index = DIMENSION / 2; index < DIMENSION; index++)
                last_inputs.Add(0);
        }

        private void CurInputsToLastInputs()
        {
            for (int index = 0; index < DIMENSION; index++)
                last_inputs[index] = cur_inputs[index];
        }

        private bool IsInputsEqual()
        {
            bool equal = true;
            int index = 0;

            while (equal && index < DIMENSION)
            {
                if (last_inputs[index] != cur_inputs[index])
                    equal = false;
                index++;
            } 

            return equal;
        }

        private List<int> CurInputsInit()
        {
            Image image = new Bitmap(pictureBox.Image);

            cur_inputs = new List<int>();
            for (int inputIndex = 0; inputIndex < DIMENSION / 2; inputIndex++)
            {
                int rowNum = inputIndex / 20;
                int colNum = inputIndex % 20;

                bool doesContainImagePart = DoesBlockContainImagePart(image as Bitmap, rowNum, colNum);
                cur_inputs.Add(doesContainImagePart ? 1 : -1);
            }

            for (int index = DIMENSION / 2; index < DIMENSION; index++)
                cur_inputs.Add(1);

            return cur_inputs;
        }

        private void Identify()
        {
            
            List<double> sum = new List<double>();

            for (int ind = 0; ind < DIMENSION; ind++)
            {
                double s = 0;
                for (int RowIndex = 0; RowIndex < DIMENSION; RowIndex++)
                    s += weights[RowIndex, ind] * cur_inputs[RowIndex];
                sum.Add(s);
            }

            isPictureDrown = true;
            UpdateLearnButton();

            List<int> result = new List<int>();

            for (int ind = 0; ind < DIMENSION; ind++)
            {
                if (sum[ind] > 0)
                    result.Add(1);
                else if (sum[ind] < 0)
                    result.Add(-1);
                else result.Add(cur_inputs[ind]);
            }

            CurInputsToLastInputs();

            cur_inputs.Clear();
            cur_inputs.AddRange(result);
        }

        private bool DoesBlockContainImagePart(Bitmap image, int rowNum, int colNum)
        {

            int blackPixelsCount = 0;

            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                for (int colIndex = 0; colIndex < 5; colIndex++)
                {
                    if (Color.Black.ToArgb().Equals(image.GetPixel(5 * colNum + colIndex, 5 * rowNum + rowIndex).ToArgb()))
                    {
                        blackPixelsCount++;
                    }
                }
            }

            return blackPixelsCount - ALLOWED_NOISE > 0;
        }

        private void PaintInPictureBox(List<int> outputs)
        {
            InitImage();
            
            Bitmap image = new Bitmap(100,100);

            for (int index = 0; index < DIMENSION / 2; index++)
            {
                if (outputs[index] == 1)
                {
                    int rowNum = index / 20;
                    int colNum = index % 20;

                    for (int rowIndex = 0; rowIndex < 5; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < 5; colIndex++)
                        {
                            image.SetPixel(5 * colNum + colIndex, 5 * rowNum + rowIndex, Color.Black);
                        }
                    }
                }
            }

            pictureBox.Image = image;
            pictureBox.Refresh();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null) //если в pictureBox есть изображение
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                Image image = new Bitmap(pictureBox.Image);
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Успешно!");

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Bitmap image; 

            OpenFileDialog open_dialog = new OpenFileDialog(); 
            open_dialog.Filter = "Image Files(*.JPG;*.GIF;*.PNG)|*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; 
            if (open_dialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    this.pictureBox.Size = image.Size;
                    pictureBox.Image = image;
                    pictureBox.Refresh();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            isPictureDrown = true;
            UpdateLearnButton();
        }
    }
}

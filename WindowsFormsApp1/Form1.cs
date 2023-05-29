using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        Bitmap img1;
        byte[,] vImg1Gray;
        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;

        Bitmap img2;
        byte[,] vImg2Gray;
        byte[,] vImg2R;
        byte[,] vImg2G;
        byte[,] vImg2B;
        byte[,] vImg2A;

        Bitmap img1Origin;
        byte[,] vImg1GrayOrigin;
        byte[,] vImg1ROrigin;
        byte[,] vImg1GOrigin;
        byte[,] vImg1BOrigin;
        byte[,] vImg1AOrigin;

        Bitmap img2Origin;
        byte[,] vImg2GrayOrigin;
        byte[,] vImg2ROrigin;
        byte[,] vImg2GOrigin;
        byte[,] vImg2BOrigin;
        byte[,] vImg2AOrigin;

        int resultIndex = 0;

        private bool checkDimensions(Bitmap img1, Bitmap img2)
        {
            int size1 = img1.Width + img1.Height;
            int size2 = img2.Width + img2.Height;

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show(
                    "As dimensões devem ser iguais para as duas imagens!",
                    "Dimensões diferentes detectadas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;

            }

            return true;
        }

        private bool checkExistance(String image2 = "notneeded")
        {

            if (img1 == null)
            {
                MessageBox.Show(
                    "Deve existir ao menos a imagem 1 para essa função!",
                    "Imagem faltando!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            if (image2 == "needed" && img2 == null)
            {
                MessageBox.Show(
                    "Devem existir a imagem 1 e 2 para essa função!",
                    "Imagens faltando!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }

            return true;
        }

        private void LoadImgA_Click(object sender, EventArgs e)
        {

            // Configurações iniciais da OpenFileDialogBox
            var openFileDialog1 = new OpenFileDialog();
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Users\\Computação\\Downloads\\MaterialMatlab\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    img1Origin = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    vImg1GrayOrigin = new byte[img1Origin.Width, img1Origin.Height];
                    vImg1ROrigin = new byte[img1Origin.Width, img1Origin.Height];
                    vImg1GOrigin = new byte[img1Origin.Width, img1Origin.Height];
                    vImg1BOrigin = new byte[img1Origin.Width, img1Origin.Height];
                    vImg1AOrigin = new byte[img1Origin.Width, img1Origin.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;
                            vImg1GrayOrigin[i, j] = pixelIntensity;

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;
                            vImg1A[i, j] = A;

                            vImg1ROrigin[i, j] = R;
                            vImg1GOrigin[i, j] = G;
                            vImg1BOrigin[i, j] = B;
                            vImg1AOrigin[i, j] = A;

                        }
                    }
                }
            }
        }

        private void LoadImgB_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var openFileDialog2 = new OpenFileDialog();
            var filePath = string.Empty;
            openFileDialog2.InitialDirectory = "C:\\Users\\Computação\\Downloads\\MaterialMatlab\\Matlab";
            openFileDialog2.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog2.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    img2Origin = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox2.Image = img2;
                    vImg2Gray = new byte[img2.Width, img2.Height];
                    vImg2R = new byte[img2.Width, img2.Height];
                    vImg2G = new byte[img2.Width, img2.Height];
                    vImg2B = new byte[img2.Width, img2.Height];
                    vImg2A = new byte[img2.Width, img2.Height];

                    vImg2GrayOrigin = new byte[img2Origin.Width, img2Origin.Height];
                    vImg2ROrigin = new byte[img2Origin.Width, img2Origin.Height];
                    vImg2GOrigin = new byte[img2Origin.Width, img2Origin.Height];
                    vImg2BOrigin = new byte[img2Origin.Width, img2Origin.Height];
                    vImg2AOrigin = new byte[img2Origin.Width, img2Origin.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img2.Width; i++)
                    {
                        for (int j = 0; j < img2.Height; j++)
                        {
                            Color pixel = img2.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg2Gray[i, j] = pixelIntensity;
                            vImg2GrayOrigin[i, j] = pixelIntensity;

                            // Para imagens RGB, extrair o valor do pixel com...
                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg2R[i, j] = R;
                            vImg2G[i, j] = G;
                            vImg2B[i, j] = B;
                            vImg2A[i, j] = A;

                            vImg2ROrigin[i, j] = R;
                            vImg2GOrigin[i, j] = G;
                            vImg2BOrigin[i, j] = B;
                            vImg2AOrigin[i, j] = A;

                        }
                    }
                }
            }
        }

        private bool IsGrayscaleImage(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    if (pixel.R != pixel.G || pixel.G != pixel.B)
                        return false;
                }
            }
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            Bitmap resultImage = new Bitmap(img1.Width, img1.Height);

            bool isGrayscale = IsGrayscaleImage(img1) && IsGrayscaleImage(img2);

            int addValue = 0;
            if (!string.IsNullOrEmpty(txAdd.Text))
            {
                if (!int.TryParse(txAdd.Text, out addValue))
                {
                    MessageBox.Show("Invalid value in txAdd. Please enter a valid integer.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    int pixelR, pixelG, pixelB, pixelA;

                    if (!string.IsNullOrEmpty(txAdd.Text))
                    {
                        if (!checkExistance())
                            return;

                        // Add the value from txAdd to the pixel values of image 1
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] + addValue;
                            pixelG = pixelR;
                            pixelB = pixelR;
                            pixelA = 255;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] + addValue;
                            pixelG = vImg1G[i, j] + addValue;
                            pixelB = vImg1B[i, j] + addValue;
                        }
                    }
                    else
                    {
                        if (!checkExistance("needed"))
                            return;

                        if (!checkDimensions(img1, img2))
                            return;

                        // Perform the addition of pixel values from image 1 and image 2
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] + vImg2Gray[i, j];
                            pixelG = pixelR;
                            pixelB = pixelR;
                            pixelA = 255;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] + vImg2R[i, j];
                            pixelG = vImg1G[i, j] + vImg2G[i, j];
                            pixelB = vImg1B[i, j] + vImg2B[i, j];
                        }
                    }

                    // Captação dos valores no intervalo válido (0-255)
                    pixelR = Math.Max(0, Math.Min(255, pixelR));
                    pixelG = Math.Max(0, Math.Min(255, pixelG));
                    pixelB = Math.Max(0, Math.Min(255, pixelB));

                    Color pixelColor = Color.FromArgb(pixelR, pixelG, pixelB);
                    resultImage.SetPixel(i, j, pixelColor);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(img1.Width, img1.Height);

            bool isGrayscale = IsGrayscaleImage(img1) && IsGrayscaleImage(img2);

            int subtractValue = 0;
            if (!string.IsNullOrEmpty(txSub.Text))
            {
                if (!int.TryParse(txSub.Text, out subtractValue))
                {
                    MessageBox.Show("Invalid value in txSub. Please enter a valid integer.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    int pixelR, pixelG, pixelB, pixelA;

                    if (!string.IsNullOrEmpty(txSub.Text))
                    {
                        if (!checkExistance())
                            return;

                        // Subtract the value from txSubtract from the pixel values of image 1
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] - subtractValue;
                            pixelG = pixelR;
                            pixelB = pixelR;
                            pixelA = 255;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] - subtractValue;
                            pixelG = vImg1G[i, j] - subtractValue;
                            pixelB = vImg1B[i, j] - subtractValue;
                        }
                    }
                    else
                    {
                        if (!checkExistance("needed"))
                            return;

                        if (!checkDimensions(img1, img2))
                            return;

                        // Perform the subtraction of pixel values from image 1 and image 2
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] - vImg2Gray[i, j];
                            pixelG = pixelR;
                            pixelB = pixelR;
                            pixelA = 255;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] - vImg2R[i, j];
                            pixelG = vImg1G[i, j] - vImg2G[i, j];
                            pixelB = vImg1B[i, j] - vImg2B[i, j];
                        }
                    }

                    // Captação dos valores no intervalo válido (0-255)
                    pixelG = Math.Max(1, Math.Min(255, pixelG));
                    pixelB = Math.Max(1, Math.Min(255, pixelB));
                    pixelR = Math.Max(1, Math.Min(255, pixelR));

                    Color pixelColor = Color.FromArgb(pixelR, pixelG, pixelB);
                    resultImage.SetPixel(i, j, pixelColor);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(img1.Width, img1.Height);

            bool isGrayscale = IsGrayscaleImage(img1) && IsGrayscaleImage(img2);

            int multiplyValue = 0;
            if (!string.IsNullOrEmpty(txMult.Text))
            {
                if (!int.TryParse(txMult.Text, out multiplyValue))
                {
                    MessageBox.Show("Invalid value in txMult. Please enter a valid integer.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    int pixelR, pixelG, pixelB;

                    if (!string.IsNullOrEmpty(txMult.Text))
                    {
                        if (!checkExistance())
                            return;

                        // Multiply the pixel values of image 1 by the multiplyValue
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] * multiplyValue;
                            pixelG = pixelR;
                            pixelB = pixelR;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] * multiplyValue;
                            pixelG = vImg1G[i, j] * multiplyValue;
                            pixelB = vImg1B[i, j] * multiplyValue;
                        }
                    }
                    else
                    {
                        if (!checkExistance("needed"))
                            return;

                        if (!checkDimensions(img1, img2))
                            return;

                        // Perform the multiplication of pixel values from image 1 and image 2
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] * vImg2Gray[i, j];
                            pixelG = pixelR;
                            pixelB = pixelR;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] * vImg2R[i, j];
                            pixelG = vImg1G[i, j] * vImg2G[i, j];
                            pixelB = vImg1B[i, j] * vImg2B[i, j];
                        }
                    }

                    // Ensure that the resulting pixel values are within the valid range (0-255)
                    pixelR = Math.Max(0, Math.Min(255, pixelR));
                    pixelG = Math.Max(0, Math.Min(255, pixelG));
                    pixelB = Math.Max(0, Math.Min(255, pixelB));

                    Color pixelColor = Color.FromArgb(pixelR, pixelG, pixelB);
                    resultImage.SetPixel(i, j, pixelColor);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(img1.Width, img1.Height);

            bool isGrayscale = IsGrayscaleImage(img1) && IsGrayscaleImage(img2);

            int divideValue = 0;
            if (!string.IsNullOrEmpty(txDiv.Text))
            {
                if (!int.TryParse(txDiv.Text, out divideValue) || divideValue == 0)
                {
                    MessageBox.Show("Invalid value in txDiv. Please enter a non-zero valid integer.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    int pixelR, pixelG, pixelB;

                    if (!string.IsNullOrEmpty(txDiv.Text))
                    {
                        if (!checkExistance())
                            return;

                        // Divide the pixel values of image 1 by the divideValue
                        if (isGrayscale)
                        {
                            pixelR = vImg1Gray[i, j] / divideValue;
                            pixelG = pixelR;
                            pixelB = pixelR;
                        }
                        else
                        {
                            pixelR = vImg1R[i, j] / divideValue;
                            pixelG = vImg1G[i, j] / divideValue;
                            pixelB = vImg1B[i, j] / divideValue;
                        }
                    }
                    else
                    {
                        if (!checkExistance("needed"))
                            return;

                        if (!checkDimensions(img1, img2))
                            return;

                        // Perform the division of pixel values from image 1 and image 2
                        if (isGrayscale)
                        {
                            if (vImg2Gray[i, j] != 0) pixelR = vImg1Gray[i, j] / vImg2Gray[i, j];
                            else pixelR = vImg1Gray[i, j];
                            pixelG = pixelR;
                            pixelB = pixelR;
                        }
                        else
                        {
                            if (vImg2R[i, j] != 0) pixelR = vImg1R[i, j] / vImg2R[i, j];
                            else pixelR = vImg1R[i, j];
                            if (vImg2G[i, j] != 0) pixelG = vImg1G[i, j] / vImg2G[i, j];
                            else pixelG = vImg1G[i, j];
                            if (vImg2B[i, j] != 0) pixelB = vImg1B[i, j] / vImg2B[i, j];
                            else pixelB = vImg1B[i, j];
                        }
                    }

                    // Ensure that the resulting pixel values are within the valid range (0-255)
                    pixelR = Math.Max(0, Math.Min(255, pixelR));
                    pixelG = Math.Max(0, Math.Min(255, pixelG));
                    pixelB = Math.Max(0, Math.Min(255, pixelB));

                    Color pixelColor = Color.FromArgb(pixelR, pixelG, pixelB);
                    resultImage.SetPixel(i, j, pixelColor);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {
            Bitmap blendImage = (Bitmap)pictureBox1.Image;
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            double fator = 1.0;

            if (checkDimensions(image1, img2Origin) == false) { return; }

            if (txBlend.Text != "") fator = Convert.ToDouble(txBlend.Text);

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = (int)(fator * vImg1R[x, y] + (1 - fator) * vImg2R[x, y]);
                    int newG = (int)(fator * vImg1G[x, y] + (1 - fator) * vImg2G[x, y]);
                    int newB = (int)(fator * vImg1B[x, y] + (1 - fator) * vImg2B[x, y]);
                    int newA = (int)(fator * vImg1A[x, y] + (1 - fator) * vImg2A[x, y]);

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    blendImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = blendImage;
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(img1.Width, img1.Height);

            bool isGrayscale = IsGrayscaleImage(img1) && IsGrayscaleImage(img2);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    int pixelR, pixelG, pixelB, pixelA;

                    if (!checkExistance("needed"))
                        return;

                    if (!checkDimensions(img1, img2))
                        return;

                    // Calculate the average of pixel values from image 1 and image 2
                    if (isGrayscale)
                    {
                        pixelR = (vImg1Gray[i, j] + vImg2Gray[i, j]) / 2;
                        pixelG = pixelR;
                        pixelB = pixelR;
                        pixelA = 255;
                    }
                    else
                    {
                        pixelR = (vImg1R[i, j] + vImg2R[i, j]) / 2;
                        pixelG = (vImg1G[i, j] + vImg2G[i, j]) / 2;
                        pixelB = (vImg1B[i, j] + vImg2B[i, j]) / 2;
                    }

                    // Cap values within the valid range (0-255)
                    pixelR = Math.Max(0, Math.Min(255, pixelR));
                    pixelG = Math.Max(0, Math.Min(255, pixelG));
                    pixelB = Math.Max(0, Math.Min(255, pixelB));

                    Color pixelColor = Color.FromArgb(pixelR, pixelG, pixelB);
                    resultImage.SetPixel(i, j, pixelColor);
                }
            }

            pictureBox3.Image = resultImage;
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            int x, y;

            if (checkExistance("needed") == false) { return; }

            if (checkDimensions(img1Origin, img2Origin) == false) { return; }

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] & vImg2R[x, y];

                    int newG = vImg1G[x, y] & vImg2G[x, y];

                    int newB = vImg1B[x, y] & vImg2B[x, y];

                    int newA = vImg1A[x, y] & vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            Bitmap notImage = (Bitmap)pictureBox1.Image;
            int max = 255;
            Bitmap image1 = (Bitmap)pictureBox1.Image;

            if (checkExistance() == false) { return; }

            int x, y;

            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < image1.Height; y++)
                {

                    Color newColor = new Color();
                    int newR = max - (int)vImg1R[x, y];
                    newR = newR <= 0 ? 0 : newR;
                    int newG = max - (int)vImg1G[x, y];
                    newG = newG <= 0 ? 0 : newG;
                    int newB = max - (int)vImg1B[x, y];
                    newB = newB <= 0 ? 0 : newB;
                    int newA = max - (int)vImg1A[x, y];
                    newA = newA <= 0 ? 0 : newA;

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    notImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = notImage;
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            if (checkExistance("needed") == false) { return; }

            if (checkDimensions(img1Origin, img2Origin) == false) { return; }

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] | vImg2R[x, y];

                    int newG = vImg1G[x, y] | vImg2G[x, y];

                    int newB = vImg1B[x, y] | vImg2B[x, y];

                    int newA = vImg1A[x, y] | vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void btXOR_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            if (checkExistance("needed") == false) { return; }

            if (checkDimensions(img1Origin, img2Origin) == false) { return; }

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] ^ vImg2R[x, y];

                    int newG = vImg1G[x, y] ^ vImg2G[x, y];

                    int newB = vImg1B[x, y] ^ vImg2B[x, y];

                    int newA = vImg1A[x, y] ^ vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            Bitmap andImage = (Bitmap)pictureBox1.Image;

            if (checkExistance("needed") == false) { return; }

            if (checkDimensions(img1Origin, img2Origin) == false) { return; }

            int x, y;

            for (x = 0; x < andImage.Width; x++)
            {
                for (y = 0; y < andImage.Height; y++)
                {

                    Color newColor = new Color();

                    int newR = vImg1R[x, y] ^ vImg2R[x, y];

                    int newG = vImg1G[x, y] ^ vImg2G[x, y];

                    int newB = vImg1B[x, y] ^ vImg2B[x, y];

                    int newA = vImg1A[x, y] ^ vImg2A[x, y];

                    newColor = Color.FromArgb((int)newA, (int)newR, (int)newG, (int)newB);

                    andImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox3.Image = andImage;
        }
        private void SalvarImagem_Click(object sender, EventArgs e)
        {
            Bitmap finalImage = (Bitmap)pictureBox3.Image;

            using (SaveFileDialog salvarDialog = new SaveFileDialog())
            {
                salvarDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png";
                salvarDialog.Title = "Salvar Imagem";
                salvarDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (salvarDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminho = salvarDialog.FileName;
                    finalImage.Save(caminho);

                    MessageBox.Show("Imagem salva!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void RGBToBit_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;


            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem.");
                return;
            }


            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {


                    //Greyscale
                    int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                    //1bit
                    if (grey >= 128) grey = 255;
                    else if (grey < 128) grey = 0;

                    Color p = Color.FromArgb(grey, grey, grey);

                    vImg1R[i, j] = (byte)grey;
                    vImg1G[i, j] = (byte)grey;
                    vImg1B[i, j] = (byte)grey;

                    image1.SetPixel(i, j, p);

                }
            }

            pictureBox3.Image = image1;
        }

        private void RGBTo8Bit_Click(object sender, EventArgs e)
        {



            Bitmap originalImage = (Bitmap)pictureBox1.Image;

            if (originalImage == null)
            {
                MessageBox.Show("Selecione uma imagem.");
                return;
            }

            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    // Calculate the gray value using a weighted average
                    int grayValue = (int)(0.299 * vImg1R[i, j] + 0.587 * vImg1G[i, j] + 0.114 * vImg1B[i, j]);


                    // Create a gray pixel
                    Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);

                    // Set the pixel in the image
                    originalImage.SetPixel(i, j, grayPixel);

                    // Update the RGB arrays
                    vImg1R[i, j] = (byte)grayValue;
                    vImg1G[i, j] = (byte)grayValue;
                    vImg1B[i, j] = (byte)grayValue;
                }
            }

            pictureBox3.Image = originalImage;
        }



        private void btnToDouble_Click(object sender, EventArgs e)
        {

        }

        private void btnRealceMax_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            if (image1 != null)
            {
                // Verificação para imagem em tons de cinza
                // Verificação para imagem em tons de cinza
                if (image1.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    // A imagem está em tons de cinza

                    // Exemplo: percorrer os pixels em tons de cinza
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {

                            Int32[] mask = new Int32[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (mask[4] * vImg1Gray[i, j]);
                            mask[5] = (mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (mask[8] * vImg1Gray[i + 1, j + 1]);

                            int max = mask.Max();

                           

                            // Atualizar o pixel na imagem de destino
                            Color p2 = Color.FromArgb(max, max, max);
                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                else
                {
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {
                            //Greyscale
                            int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                            Color p = Color.FromArgb(grey, grey, grey);

                            vImg1R[i, j] = (byte)grey;
                            vImg1G[i, j] = (byte)grey;
                            vImg1B[i, j] = (byte)grey;

                            image1.SetPixel(i, j, p);


                            byte[] mask = new byte[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                            mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);


                            byte max = mask.Max();
                            Color p2 = Color.FromArgb(max, max, max);

                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                pictureBox3.Image = image3;
            }
        }

        private void btnRealceMin_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            if (image1 != null)
            {
                // Verificação para imagem em tons de cinza
                // Verificação para imagem em tons de cinza
                if (image1.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    // A imagem está em tons de cinza

                    // Exemplo: percorrer os pixels em tons de cinza
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {

                            Int32[] mask = new Int32[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (mask[4] * vImg1Gray[i, j]);
                            mask[5] = (mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (mask[8] * vImg1Gray[i + 1, j + 1]);

                            int max = mask.Min();



                            // Atualizar o pixel na imagem de destino
                            Color p2 = Color.FromArgb(max, max, max);
                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                else
                {
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {
                            //Greyscale
                            int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                            Color p = Color.FromArgb(grey, grey, grey);

                            vImg1R[i, j] = (byte)grey;
                            vImg1G[i, j] = (byte)grey;
                            vImg1B[i, j] = (byte)grey;

                            image1.SetPixel(i, j, p);


                            byte[] mask = new byte[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                            mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);


                            byte max = mask.Min();
                            Color p2 = Color.FromArgb(max, max, max);

                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                pictureBox3.Image = image3;
            }
        }


        private void btnRealceMedia_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;
            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            if (image1 != null)
            {
                // Verificação para imagem em tons de cinza
                // Verificação para imagem em tons de cinza
                if (image1.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    // A imagem está em tons de cinza

                    // Exemplo: percorrer os pixels em tons de cinza
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {

                            Int32[] mask = new Int32[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (mask[4] * vImg1Gray[i, j]);
                            mask[5] = (mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (mask[8] * vImg1Gray[i + 1, j + 1]);

                            int acc = 0;
                            for (int k = 0; k < mask.Length; k++)
                            {
                                acc += mask[k];
                            }

                            int mean = (acc / 9);



                            // Atualizar o pixel na imagem de destino
                            Color p2 = Color.FromArgb(mean, mean, mean);
                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                else
                {
                    for (int i = 1; i < image1.Width - 1; i++)
                    {
                        for (int j = 1; j < image1.Height - 1; j++)
                        {
                            //Greyscale
                            int grey = (vImg1R[i, j] + vImg1G[i, j] + vImg1B[i, j]) / 3;

                            Color p = Color.FromArgb(grey, grey, grey);

                            vImg1R[i, j] = (byte)grey;
                            vImg1G[i, j] = (byte)grey;
                            vImg1B[i, j] = (byte)grey;

                            image1.SetPixel(i, j, p);


                            byte[] mask = new byte[9];
                            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

                            mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
                            mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
                            mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

                            mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
                            mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
                            mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

                            mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
                            mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
                            mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);


                            int acc = 0;
                            for (int k = 0; k < mask.Length; k++)
                            {
                                acc += mask[k];
                            }

                            byte mean = (byte)(acc / 9);
                            Color p2 = Color.FromArgb(mean, mean, mean);

                            image3.SetPixel(i, j, p2);
                        }
                    }
                }

                pictureBox3.Image = image3;
            }
        }

        private void equalizarHistograma_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)pictureBox1.Image;

            if (image1 == null)
            {
                MessageBox.Show("Selecione uma imagem para a imagem 1.");
                return;
            }

            Bitmap image3 = new Bitmap(image1.Width, image1.Height);

            int width = image1.Width;
            int height = image1.Height;

            int[] pixelIntensityRate = new int[256];

            // Calcula o histograma da imagem original
            for (int i = 0; i < width; i++)
            {
                for (int y = 0; y < height; y++)
                {
                    int pixelVal = image1.GetPixel(i, y).R;
                    pixelIntensityRate[pixelVal]++;
                }
            }

            // Cria um array para armazenar a Distribuição Cumulativa de Frequências (CDF)
            // O tamanho do array é definido como 256, pois esse é o número máximo de valores de intensidade de pixel em uma imagem em escala de cinza
            double[] CFD = new double[256];

            // Conta os pixels da imagem
            int pixelsCount = width * height;

            // Define o primeiro elemento da CDF como a frequência do pixel de intensidade na posição 0 do histograma, dividida pelo número total de pixels na imagem.
            // Essa etapa normaliza o valor para obter a probabilidade de ocorrência desse pixel de intensidade na imagem.
            CFD[0] = pixelIntensityRate[0] / (double)pixelsCount;

            // Calcula a Distribuição Cumulativa de Frequências (CDF)
            for (int i = 1; i < 256; i++)
            {
                CFD[i] = CFD[i - 1] + pixelIntensityRate[i] / (double)pixelsCount;
            }

            // Cria uma nova imagem em escala de cinza para armazenar os pixels equalizados
            byte[,] finalImg = new byte[width, height];

            // Cria um array para armazenar o histograma dos pixels equalizados
            // O tamanho do array é definido como 256 para acomodar todos os possíveis valores de intensidade de pixel
            int[] finalPixelRate = new int[256];

            // Equaliza os valores dos pixels na imagem final
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int pixel = image1.GetPixel(i, j).R;

                    // Calcula o novo valor do pixel equalizado usando a fórmula 
                    finalImg[i, j] = (byte)Math.Floor((CFD[pixel] - CFD.Min()) / (1 - CFD.Min()) * (256 - 1));

                    // Incrementa a contagem do pixel equalizado para o histograma
                    finalPixelRate[finalImg[i, j]]++;
                }
            }

            // Limpa o histograma padrão
            histDefault.Series.Clear();
            // Adiciona uma série para o histograma padrão
            histDefault.Series.Add("Histograma A");
            // Define o tipo de gráfico da série como coluna
            histDefault.Series["Histograma A"].ChartType = SeriesChartType.Column;
            // Popula os pontos do histograma com os valores de intensidade de pixel
            histDefault.Series["Histograma A"].Points.DataBindY(pixelIntensityRate);
            // Define o valor máximo do eixo Y do histograma para garantir que todos os pontos sejam visíveis
            histDefault.ChartAreas[0].AxisY.Maximum = pixelIntensityRate.Max() + 10;

            // Limpa o histograma normalizado
            histNormalizado.Series.Clear();
            // Adiciona uma série para o histograma normalizado
            histNormalizado.Series.Add("Resultado");
            // Define o tipo de gráfico da série como coluna
            histNormalizado.Series["Resultado"].ChartType = SeriesChartType.Column;
            // Popula os pontos do histograma normalizado com os valores de intensidade de pixel equalizados
            histNormalizado.Series["Resultado"].Points.DataBindY(finalPixelRate);
            // Define o valor máximo do eixo Y do histograma normalizado para garantir que todos os pontos sejam visíveis
            histNormalizado.ChartAreas[0].AxisY.Maximum = finalPixelRate.Max() + 10;


            // Percorre cada pixel na imagem final e transforma em escala de cinza equalizada
            for (int i = 0; i < image3.Width; i++)
            {
                for (int j = 0; j < image3.Height; j++)
                {
                    byte color = finalImg[i, j];
                    Color p = Color.FromArgb(255, color, color, color);

                    image3.SetPixel(i, j, p);
                }
            }

            pictureBox3.Image = image3;
        }

        private void btnRealceMediana_Click(object sender, EventArgs e)
        {

        }
    }







}

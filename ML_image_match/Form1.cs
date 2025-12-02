using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ML_image_match
{
    public partial class Form1 : Form
    {
        private string imagePath1;
        private string imagePath2;

        private readonly MLContext mlContext;
        private ITransformer model;
        private PredictionEngine<ImageData, ImageEmbedding> predictionEngine;

        public Form1()
        {
            InitializeComponent();

            mlContext = new MLContext();
            BuildModel();
        }

        private void BuildModel()
        {
            var emptyData = mlContext.Data.LoadFromEnumerable<ImageData>(Array.Empty<ImageData>());

            var pipeline = mlContext.Transforms
                .LoadImages(
                    outputColumnName: "input",
                    imageFolder: "",
                    inputColumnName: nameof(ImageData.ImagePath))
                .Append(mlContext.Transforms.ResizeImages(
                    outputColumnName: "input",
                    imageWidth: 64,
                    imageHeight: 64,
                    inputColumnName: "input"))
                .Append(mlContext.Transforms.ExtractPixels(
                    outputColumnName: "Features",   
                    inputColumnName: "input"));

            model = pipeline.Fit(emptyData);
predictionEngine =
                mlContext.Model.CreatePredictionEngine<ImageData, ImageEmbedding>(model);
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Resim 1 Seç";
                ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath1 = ofd.FileName;
                    pictureBox1.Image = new Bitmap(imagePath1);
                }
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Resim 2 Seç";
                ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath2 = ofd.FileName;
                    pictureBox2.Image = new Bitmap(imagePath2);
                }
            }
        }

        private float[] GetImageEmbedding(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
                throw new FileNotFoundException("Resim bulunamadý.", path);

            var input = new ImageData { ImagePath = path };
            var result = predictionEngine.Predict(input);
            return result.Features;
        }

        private double CosineSimilarity(float[] v1, float[] v2)
        {
            if (v1 == null || v2 == null || v1.Length != v2.Length)
                throw new ArgumentException("Vektör boyutlarý uyumsuz.");

            double dot = 0;
            double norm1 = 0;
            double norm2 = 0;

            for (int i = 0; i < v1.Length; i++)
            {
                dot += v1[i] * v2[i];
                norm1 += v1[i] * v1[i];
                norm2 += v2[i] * v2[i];
            }

            if (norm1 == 0 || norm2 == 0)
                return 0;

            return dot / (Math.Sqrt(norm1) * Math.Sqrt(norm2));
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath1) || string.IsNullOrEmpty(imagePath2))
            {
                MessageBox.Show("Lütfen iki resmi de yükleyin.", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var emb1 = GetImageEmbedding(imagePath1);
                var emb2 = GetImageEmbedding(imagePath2);

                double similarity = CosineSimilarity(emb1, emb2);
                double percentage = similarity * 100.0;

                lblResult.Text = $"Benzerlik: {percentage:F2} %";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

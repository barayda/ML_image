using Microsoft.ML.Data;

namespace ML_image_match
{
    public class ImageData
    {
        public string ImagePath { get; set; }
    }

    public class ImageEmbedding
    {
        [ColumnName("Features")]
        public float[] Features { get; set; }
    }
}

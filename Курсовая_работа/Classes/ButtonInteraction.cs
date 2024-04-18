using image_description_button;
using System.Drawing.Imaging;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using Курсовая_работа.Forms;
using Курсовая_работа.model;

public static class ButtonInteraction
{
    static Image BackGoundImage = null;
    private const int IncreaseSize = 4;

    public static void UpScale_button(object sender, EventArgs e)
    {
        if(sender is Button button) 
        {
            // Увеличение размера кнопки при наведении
            button.Size = new Size(button.Width + IncreaseSize, button.Height + IncreaseSize);
            button.Location = new Point(button.Location.X - IncreaseSize / 2, button.Location.Y - IncreaseSize / 2);
        }
    }

    public static void DownScale_button(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            // Возврат к исходному размеру кнопки при уходе указателя мыши
            button.Size = new Size(button.Width - IncreaseSize, button.Height - IncreaseSize);
            button.Location = new Point(button.Location.X + IncreaseSize / 2, button.Location.Y + IncreaseSize / 2);
        }
    }

    public static void MouseDown(object sender, MouseEventArgs e)
    {
        if (sender is Button button)
        {
            DownScale_button(sender, e);

            BackGoundImage = button.BackgroundImage;
            button.BackgroundImage = DarkenImage(button.BackgroundImage);
        }
    }

    public static void MouseUp(object sender, MouseEventArgs e)
    {
        if (sender is Button button)
        {
            UpScale_button(sender, e);

            button.BackgroundImage = BackGoundImage;
        }
    }

    public static void Registration_MouseOn(object sender, EventArgs e)
    {
        if (sender is LinkLabel link)
        {
            link.LinkColor = Color.FromArgb(255, 255, 128, 0);
        }
    }

    public static void Registration_MouseOff(object sender, EventArgs e)
    {
        if (sender is LinkLabel link)
        {
            link.LinkColor = Color.FromArgb(255, 0, 0, 192);
        }
    }

    public static void FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    public static Image DarkenImage(Image originalImage)
    {
        Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Создаем матрицу преобразования для затемнения изображения
            float[][] matrixItems =
            {
                [0.5f, 0, 0, 0, 0], // Красный
                [0, 0.5f, 0, 0, 0], // Зеленый
                [0, 0, 0.5f, 0, 0], // Синий
                [0, 0, 0, 1, 0], // Альфа (прозрачность)
                [0.1f, 0.1f, 0.1f, 0, 1] // Добавляем к каждому каналу для смещения цвета в темную сторону
            };

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Накладываем матрицу преобразования на изображение
            graphics.DrawImage
            (
                originalImage,
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes
            );
        }

        return bitmap;
    }
}

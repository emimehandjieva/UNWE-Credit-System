namespace LearningCreditSystem.Desktop.Common
{
    using System.Drawing;

    public class ColorFactory
    {
        public static Color GetColor(ProjectColor color)
        {
            switch (color)
            {
                case ProjectColor.Blue:
                    return Color.FromArgb(200, 1, 156, 217);
                case ProjectColor.Green:
                    return Color.FromArgb(200, 1, 156, 217);
                default:
                    return Color.White;
            }
        }
    }
}

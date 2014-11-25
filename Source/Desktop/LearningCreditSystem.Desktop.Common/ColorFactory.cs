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
                    return Color.FromArgb(50, 1, 156, 217);
                case ProjectColor.DarkGrey:
                    return Color.FromArgb(75, 76, 76);
                case ProjectColor.LightGrey:
                    return Color.FromArgb(118, 118, 118);
                case ProjectColor.Transperent:
                    return Color.Transparent;
                default:
                    return Color.White;
            }
        }
    }
}

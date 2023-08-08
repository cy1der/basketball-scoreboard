using Basketball_Scoreboard_System.classes;
using Basketball_Scoreboard_System.forms;
using System.Drawing.Text;

namespace Basketball_Scoreboard_System
{
    internal static class Program
    {
        public static AudienceWindow AudienceWindow = new();
        public static ControlPanel ControlPanel = new();

        public static Team HomeTeam = new(true, false, true);
        public static Team AwayTeam = new(false, true, false);

        public static Clock MainClock = new(Settings.Default.MainClockDefaultTime, false, true);
        public static Clock ShotClock = new(Settings.Default.ShotClockDefaultTime, true, false);

        public static int Period = 1;

        [STAThread]
        private static void Main()
        {
            if (!IsFontInstalled("DSEG7 Classic") || !IsFontInstalled("DSEG14 Classic") || !IsFontInstalled("Fira Mono")) MessageBox.Show("Required fonts are not installed.\nThey can be found in:\n" + Path.Combine(Application.StartupPath, "fonts\\"), "Warning", MessageBoxButtons.OK);
            ApplicationConfiguration.Initialize();
            Application.Run(AudienceWindow);
        }

        public static bool IsFontInstalled(string FontName)
        {
            InstalledFontCollection AllFonts = new();
            foreach (FontFamily Font in AllFonts.Families)
            {
                if (Font.Name == FontName) return true;
            }
            return false;
        }

        public static Font GetFontSize(Graphics Graphics, string Text, Size MaxStringSize, Font LabelFont)
        {
            Font Font = new(LabelFont.Name, LabelFont.Size);
            SizeF Size = Graphics.MeasureString(Text, Font);

            while (Size.Width != MaxStringSize.Width)
            {
                float NewSize = Font.Size * (MaxStringSize.Width / Size.Width);
                Font = new(LabelFont.Name, NewSize);
                Size = Graphics.MeasureString(Text, Font);
            }

            return Font;
        }
    }
}
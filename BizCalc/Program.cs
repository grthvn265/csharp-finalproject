using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace BizCalc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            Application.Run(new Form1());
            ShowSummaryDialog();
        }

        private static void ShowSummaryDialog()
        {
            MessageBox.Show(
                BuildSummaryText(),
                "Program Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static readonly CultureInfo PhilippineCulture = new CultureInfo("en-PH");
        private static readonly TimeZoneInfo PhilippineTimeZone = ResolvePhilippineTimeZone();

        private static string BuildSummaryText()
        {
            var localNow = TimeZoneInfo.ConvertTime(DateTime.UtcNow, PhilippineTimeZone);
            var builder = new StringBuilder();
            builder.AppendLine("CC103");
            builder.AppendLine("Programmed By: Meneses, Gabriel Benedict K.");
            builder.AppendLine("Date of Submission: null");
            builder.AppendLine("Message to Your Professor: Thank you, Mam Lizel, for your guidance, patience, and support throughout this course.");
            builder.AppendLine($"Local Date and Time: {localNow.ToString("F", PhilippineCulture)}");
            return builder.ToString();
        }

        private static TimeZoneInfo ResolvePhilippineTimeZone()
        {
            try
            {
                return TimeZoneInfo.FindSystemTimeZoneById("Philippine Standard Time");
            }
            catch (TimeZoneNotFoundException)
            {
                return TimeZoneInfo.CreateCustomTimeZone(
                    "Philippine Standard Time",
                    TimeSpan.FromHours(8),
                    "Philippine Standard Time",
                    "PST");
            }
            catch (InvalidTimeZoneException)
            {
                return TimeZoneInfo.CreateCustomTimeZone(
                    "Philippine Standard Time",
                    TimeSpan.FromHours(8),
                    "Philippine Standard Time",
                    "PST");
            }
        }
    }
}

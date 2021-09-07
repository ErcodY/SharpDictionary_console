using System;
using System.Collections.Specialized;
using System.Text;

namespace Dictionary
{
    class ConsoleUi
    {
        private static string make_frame(string _Msg)
        {
            StringBuilder builder = new StringBuilder("");
            builder.Append(_Msg + '|' + "\n");
            for (var i = 0; i < _Msg.Length; i++)
            {
                builder.Append('―');
            }
            builder.Append('┘');
            builder.Append('\n');

            return builder.ToString();
        }

        private static string align_text(string _Text, int counter)
        {
            StringBuilder textBuilder = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                textBuilder.Append('\t');
            }

            textBuilder.Append(_Text);
            return textBuilder.ToString();
        }

        private static string make_time_str()
        {
            var curHour = DateTime.Now.Hour;
            if (curHour >= 0 & curHour <= 6)
            {
                return "Good Night";
            }
            if (curHour >= 7 & curHour <= 11)
            {
                return "Good Morning";
            }
            if (curHour >= 12 & curHour <= 17)
            {
                return "Good Day";
            }
            if (curHour >= 18 & curHour <= 23)
            {
                return "Good Evening";
            }
            return "<Error>";
        }

        public static void SettingMenuFirst()
        {
            StringBuilder screenBuilder = new();

            
        }
        
        public static void FirstTimeMenu()
        {
            Console.Clear();
            var screenBuilder = new StringBuilder();

            screenBuilder.Append(align_text(make_time_str(), 6) + '\n');

            screenBuilder.Append(align_text("At first you must choose %DISPLAY_LANG% and type of Dictionary", 3));
            screenBuilder.Append('\n'+ align_text("Press any key...", 6));

            Console.WriteLine(screenBuilder.ToString());

            Console.ReadKey();
            
        }
    }
}
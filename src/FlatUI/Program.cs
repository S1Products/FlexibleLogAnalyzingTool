using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Globalization;

namespace FlexibleLogAnalyzingTool
{
    static class Program
    {
        public const string ARG_REGIST = "/REGIST";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            SetLocale();

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else if (args[0].ToUpper() == ARG_REGIST)
            {
                RegistExtensionToRegistry();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm form = new MainForm();
                form.OpenProject(args[0]);
                Application.Run(form);
            }
        }

        static void SetLocale()
        {
            string locale = Properties.Settings.Default.Locale;

            if (locale == "")
            {
                return;
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(locale, false);
        }

        static void RegistExtensionToRegistry()
        {
            string extension = ".flat";

            string commandline = "\"" + Application.ExecutablePath + "\" \"%1\"";

            string fileType = Application.ProductName + " Project file";

            string description = "FLAT Project file";

            string verb = "open";

            string verbDescription = "FLATで開く(&O)";

            //アイコンのパスとインデックス
            string iconPath = Application.ExecutablePath;
            int iconIndex = 0;

            Microsoft.Win32.RegistryKey rootkey = Microsoft.Win32.Registry.ClassesRoot;

            //拡張子のキーを作成し、そのファイルタイプを登録
            Microsoft.Win32.RegistryKey regkey = rootkey.CreateSubKey(extension);
            regkey.SetValue("", fileType);
            regkey.Close();

            //ファイルタイプのキーを作成し、その説明を登録
            Microsoft.Win32.RegistryKey typekey = rootkey.CreateSubKey(fileType);
            typekey.SetValue("", description);
            typekey.Close();

            //動詞のキーを作成し、その説明を登録
            Microsoft.Win32.RegistryKey verblkey = rootkey.CreateSubKey(fileType + "\\shell\\" + verb);
            verblkey.SetValue("", verbDescription);
            verblkey.Close();

            //コマンドのキーを作成し、実行するコマンドラインを登録
            Microsoft.Win32.RegistryKey cmdkey = rootkey.CreateSubKey(fileType + "\\shell\\" + verb + "\\command");
            cmdkey.SetValue("", commandline);
            cmdkey.Close();

            //アイコンのキーを作成し、アイコンのパスと位置を登録
            Microsoft.Win32.RegistryKey iconkey = rootkey.CreateSubKey(fileType + "\\DefaultIcon");
            iconkey.SetValue("", iconPath + "," + iconIndex.ToString());
            iconkey.Close();
        }
    }
}

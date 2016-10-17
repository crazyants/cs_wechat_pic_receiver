using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace 微信收图
{
    class Util
    {


        //给出一个data文件，和目标目录，返回处理好的文件路径
        public static string getRealPic(string datafile,string sysdir) {
            if (File.Exists(datafile) == false) {
                Console.WriteLine("datafile not exists!");
                return null;
            }
            DateTime dt = DateTime.Now;
            string filename = string.Format("{0:yyyyMMdd_HHmmss}.jpg", dt);
            string outfile = sysdir + "\\" + filename;
            if (File.Exists(outfile)) {
                Console.WriteLine("outfile exists!");
                return null;
            }

            FileStream fs_out = new FileStream(outfile, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs_out);
            FileStream fs = new FileStream(datafile, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            int cont = 0;
            try
            {
                byte abyte;
                br.BaseStream.Seek(0,SeekOrigin.Begin);
                while (br.BaseStream.Position<br.BaseStream.Length) {
                    abyte = br.ReadByte();
                    abyte = (byte)(abyte ^ 0xF0);
                    bw.Write(abyte);
                    cont++;
                }
                
                //MessageBox.Show(abyte.ToString() + bbyte.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                br.Close();
                fs.Close();
                bw.Close();
                fs_out.Close();
            }
            if (File.Exists(outfile))
            {
                return outfile;
            }
            else {
                return null;
            }
        }

        //找到wechat家目录，不存在则返回空
        public static string getWechatHome() {
            string wechat_home=null;
            string doc_dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (doc_dir != null && doc_dir.Equals("") == false)
            {
                wechat_home = doc_dir + @"\" + "WeChat Files";
            }
            else {
                return null;
            }

            if (Directory.Exists(wechat_home))
            {
                return wechat_home;
            }
            else {
                return null;
            }
        }

        //判断微信是否安装
        public static bool isWechatInstall() {
            RegistryKey pregkey = null;
            if (Environment.Is64BitOperatingSystem)
            {
                pregkey = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\WeChat");

            }
            else {
                pregkey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\WeChat");
            }
            if (pregkey == null)
            {
                return false;
            }
            else
                return true;
        }


        //启动微信
        public static void runWechat() {
            RegistryKey pregkey = null;
            if (Environment.Is64BitOperatingSystem)
            {
                pregkey = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\WeChat");

            }
            else
            {
                pregkey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\WeChat");
            }
            if (pregkey != null)
            {
                string name = pregkey.GetValue("DisplayIcon").ToString();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = name;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }

        //微信是否运行
        public static bool isWechatRunning() {
            Process[] proc = Process.GetProcessesByName("WeChat");
            if (proc.Length == 0)
                return false;
            else
                return true;
        }

        //open a pic
        public static void openPic(string picpath) {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = picpath;
            process.StartInfo.Arguments = "rundll32.exe C://WINDOWS//system32//shimgvw.dll";
            process.StartInfo.UseShellExecute = true;
            process.Start();
            return;
        }

        //find the dat file after dt
        public static string findDataFile(String dir,DateTime dt) {
            string[] search = System.IO.Directory.GetFiles(dir, @"*.dat", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < search.Length; i++) {

                string path = System.IO.Path.GetDirectoryName(search[i]);
                //如果路径不以Data结尾，说明不是目标文件
                if (path.EndsWith(@"\Data") == false)
                {
                    continue;
                }

                FileInfo fi = new FileInfo(search[i]);
                if (fi.CreationTime.CompareTo(dt)>0) {
                    return search[i];
                }
            }
            return null;
        }

        //杀死一个进程
        public static string killProcess() {
            Process[] proc = Process.GetProcessesByName("dllhost");
            if (proc.Length == 0) {
                return "null";
            }
            string name = proc[0].StartInfo.Arguments;
            for (int i = 0; i < proc.Length; i++) {
                proc[i].Kill();
            }
            return name;
        }
    }
}

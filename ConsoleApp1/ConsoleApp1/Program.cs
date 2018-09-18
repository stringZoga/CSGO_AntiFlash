using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        public static void ahshgdhjasdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        public static Module clientModule = new Module("client_panorama.dll");
        public static Module engineModule = new Module("engine.dll");
        public static VAMemory vam = new VAMemory("csgo");
        public static int Client;
        public static void ahshgdhjasggdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        static void Main(string[] args)
        {
            Thread title = new Thread(new ThreadStart(titleChng));
            title.Start();
            GetModuleAddress();
            int EngineBase;
            int GameState;
            while (true)
            {
                EngineBase = vam.ReadInt32((IntPtr)engineModule.moduleAddress + 0x588A74);
                GameState = vam.ReadInt32((IntPtr)EngineBase + 0x108);
                Console.Clear();
                Console.WriteLine("Cheat Activated");
                Console.WriteLine("---------------------------------");
                if (GameState == 6)
                {
                    if (flashMaxAlpha == 255f)
                    {
                        flashMaxAlpha = 0f;
                        Thread.Sleep(500);
                        Console.WriteLine("OK!");
                    }
                }
                else
                {
                    //flashMaxAlpha = 255f;
                    Console.WriteLine("Please Enter CS:GO");
                }
            }
        }
        public static void ahshgdhjaasdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        public static float flashMaxAlpha
        {
            get
            {
                int BaseAddress = vam.ReadInt32((IntPtr)clientModule.moduleAddress + 0xC5E87C);
                return vam.ReadFloat((IntPtr)BaseAddress + 0xA304);
            }
            set
            {
                int BaseAddress = vam.ReadInt32((IntPtr)clientModule.moduleAddress + 0xC5E87C);
                vam.WriteFloat((IntPtr)BaseAddress + 0xA304, (float)value);
                vam.WriteFloat((IntPtr)BaseAddress + 0xA308, (float)value);
            }
        }
        public static void ahshgdhjwasdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        private static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        public static void ahshgdhjafsdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        public static void titleChng()
        {
            while (true)
            {
                Console.Title = "CSGOExternal - RandomString: " + RandomString(30);
                Thread.Sleep(1000);
            }
        }
        public static void ahshgdhjasdaghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        public struct Module
        {
            public string moduleName;
            public int moduleAddress;
            public bool fp;
            public Module(string moduleName_)
            {
                moduleName = moduleName_;
                moduleAddress = 0x000000;
                try
                {
                    Process[] p = Process.GetProcessesByName("csgo");

                    if (p.Length > 0)
                    {
                        foreach (ProcessModule m in p[0].Modules)
                        {
                            if (m.ModuleName == moduleName_)
                            {
                                moduleAddress = (Int32)m.BaseAddress;

                                fp = true;
                            }
                        }
                        fp = true;

                    }
                    else
                    {
                        fp = false;
                    }
                }
                catch
                {
                    fp = false;
                }
            }
        }
        public static void ahshgdhsjasdghhj(int kpsxqshpkslk, double sypptcouchgl, bool poidgvhg, double xpaphcphd, double axtabeoqpbyqwhg, string rcquodbffk)
        {
            int qnflt = 4834;
            bool uctgz = false;
            string mxecvnzajd = "lbbkurwsduyavobkyvqfhtlfbsfzamrmfzabifqutibqzxdgurgnpgxampifbkrcbmujbmyazjvqslgw";
            bool itwioewniim = true;
            double nlzstwjx = 50188;
            int pntixhhrxsbyr = 3441;
            int pxxrrjfyafir = 594;
            double pamyck = 48442;
            int dxcyjwt = 851;
            double qdbsqxla = 3594;
            if (50188 != 50188)
            {
                int gqzsqmg;
                for (gqzsqmg = 39; gqzsqmg > 0; gqzsqmg--)
                {
                    continue;
                }
            }
            if (false != false)
            {
                int bzluencd;
                for (bzluencd = 30; bzluencd > 0; bzluencd--)
                {

                }
            }
            if (4834 != 4834)
            {
                int zjn;
                for (zjn = 13; zjn > 0; zjn--)
                {

                }
            }
            if (48442 == 48442)
            {
                int es;
                for (es = 74; es > 0; es--)
                {

                }
            }

        }
        public static bool GetModuleAddress()
        {

            try
            {
                Process[] p = Process.GetProcessesByName("csgo");

                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client_panorama.dll")
                        {
                            Client = (int)m.BaseAddress;
                            return true;
                        }
                    }

                    return true;
                }
                else
                {
                    Console.WriteLine("not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        
    }
}

using LosefDevLab.LosefChat.lcstd;

// Mod : Boot, Des.: LosefChat 启动器
class Boot
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"  _                             __    ____   _               _");
        Console.WriteLine(@" | |       ___    ___    ___   / _|  / ___| | |__     __ _  | |_");
        Console.WriteLine(@" | |      / _ \  / __|  / _ \ | |_  | |     | '_ \   / _` | | __|");
        Console.WriteLine(@" | |___  | (_) | \__ \ |  __/ |  _| | |___  | | | | | (_| | | |_");
        Console.WriteLine(@" |_____|  \___/  |___/  \___| |_|    \____| |_| |_|  \__,_|  \__|");
        Console.WriteLine(@"------------------CLIENT BOT OFFCIAL FRAMEOWRK------------------");
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("欢迎使用LCBOF v1.0.r1.b70\n客户端请注意:正常启动后，仅输出，输入模式请另启动程序（使用-ci附加参数启动程序）\n输入1 启动Bot,输入4发行说明");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out int choose))
            {
                Console.WriteLine("无效输入，请输入1、3或4。");
                return;
            }
            if (choose == 1)
            {
                Client client = new Client();

                Preset preset = new Preset();
                preset.ReadPreset();

                client.Connect(preset.ipvx, preset.ip, preset.port, preset.username, preset.password);
            }
            else if (choose == 3)
            {
                string inputFilePath = ".ci";
                Console.WriteLine(@"  _                             __    ____   _               _");
                Console.WriteLine(@" | |       ___    ___    ___   / _|  / ___| | |__     __ _  | |_");
                Console.WriteLine(@" | |      / _ \  / __|  / _ \ | |_  | |     | '_ \   / _` | | __|");
                Console.WriteLine(@" | |___  | (_) | \__ \ |  __/ |  _| | |___  | | | | | (_| | | |_");
                Console.WriteLine(@" |_____|  \___/  |___/  \___| |_|    \____| |_| |_|  \__,_|  \__|");
                Console.WriteLine(@"------------------CLIENT BOT OFFCIAL FRAMEOWRK------------------");
                Console.WriteLine("LCBOF 纯输入模式,可以在这里输入命令控制bot");
                while (true)
                {
                    Console.Write("> ");
                    string? cinp = Console.ReadLine();
                    if (cinp == "exit")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(inputFilePath, true))
                        {
                            sw.WriteLine(cinp);
                        }
                    }
                }
            }
            else if (choose == 4)
            {
                Console.WriteLine(@"LCBOF 1.0.r1.b70 发行说明：");
                Console.WriteLine(@"-------------------------------------");
                Console.WriteLine(@"新增了服务器配置,不必在启动服务器时手动输入端口号");
                Console.WriteLine(@"新增了服务器名称命名和服务器描述,并且也可以在服务器配置中配置,无需改动代码");
                Console.WriteLine(@"修复部分用户使用体验的不良体验");
                Console.WriteLine(@"这次算是一个小的关键更新吧");
                Console.WriteLine(@"-------------------------------------");
                Console.WriteLine(@"一个Losefchat官方出品的客户端机器人框架");
                Console.WriteLine(@"基于Losefchat3.0.r3.b67");
                Console.WriteLine(@"GitHub：https://github.com/losefdevlab/lcbof");
                Console.WriteLine(@"Email:along-losef@outlook.com");
                    
            }
            else
            {
                Console.WriteLine("无效输入，请输入1、3、4。");
            }
        }
    }
}
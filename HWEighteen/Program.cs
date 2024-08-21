using HWEighteen.Classes;
using System.Security.Cryptography.X509Certificates;
using YoutubeExplode;

namespace HWEighteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeClient client = new YoutubeClient();
            Receiver receiver = new Receiver("https://youtu.be/UqvQEhnHgY8?si=AYVWmEfE2cSAfIAp");
            Command command = new Command();

            GetVideo getVideo = new GetVideo(client, receiver);
            // устанавливаем команду получения информации о видео
            command.SetCommand(getVideo);
            command.Run();

            DownloadVideo downloadVideo = new DownloadVideo(client, receiver);
            command.SetCommand(downloadVideo);
            command.Run();

            Console.ReadKey();
        }
    }
}

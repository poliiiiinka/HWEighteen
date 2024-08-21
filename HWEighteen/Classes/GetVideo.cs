using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HWEighteen.Classes
{
    public class GetVideo : Interfaces.ICommand
    {
        YoutubeClient Client;
        Receiver Receiver;

        public GetVideo(YoutubeClient client, Receiver receiver)
        {
            Client = client;
            Receiver = receiver;
        }

        public async Task Run()
        {
            YoutubeClient client = new YoutubeClient();
            //передаём ссылку на видео, описание которого хотим получить
            var description = await client.Videos.GetAsync(Receiver.Address);
            // выводим информацию в консоль
            Console.WriteLine($"Название видео: {description.Title} \n Описание: {description.Description}");
        }
    }
}

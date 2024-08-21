using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace HWEighteen.Classes
{
    public class DownloadVideo : Interfaces.ICommand
    {
        YoutubeClient Client;
        Receiver Receiver;

        public DownloadVideo(YoutubeClient client, Receiver receiver)
        {
            Client = client;
            Receiver = receiver;
        }

        public async Task Run()
        {
            YoutubeClient client = new YoutubeClient();

            // не до конца понимаю, что именно здесь происходит, нашла на просторах интернета
            var streamManifest = await client.Videos.Streams.GetManifestAsync(Receiver.Address);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            // метод для запуска скачивания видео
            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}

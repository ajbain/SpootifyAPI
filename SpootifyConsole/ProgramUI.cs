using MusicData;
using MusicModels.AlbumFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpootifyConsole
{
    public class ProgramUI
    {
        HttpClient httpClient = new HttpClient();
        string baseUrl = "https://localhost:44365/";
        bool KeepRunning = true;

        public void Menu()
        {
            while (KeepRunning)
            {

                Console.WriteLine("Welcome to the HappyMusic Database! Please put in a number for the action you'd like to perform: \n" +
                "1) Add an Album\n" +
                "2) Get all Albums\n" +
                "3) Exit ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //method here
                        break;
                    case "2":
                        ViewAlbums();
                        break;
                    case "3":
                        KeepRunning = false;
                        break;
                }
            }
        }
        //public void PostAlbum()
        //{
        //    Console.Clear();
        //    Task<HttpResponseMessage> result = httpClient.PostAsync(baseUrl + "api/album");
        //}
        public void ViewAlbums()
        {
            Console.Clear();
            Task<HttpResponseMessage> result = httpClient.GetAsync(baseUrl + "api/album");
            HttpResponseMessage response = result.Result;
            if (response.IsSuccessStatusCode)
            {
                List<AlbumListItem> albumListItems = httpClient.GetAsync(baseUrl + "api/album").Result.Content.ReadAsAsync<List<AlbumListItem>>().Result;
                foreach (AlbumListItem item in albumListItems)
                {
                    Console.WriteLine(item.ArtistName, item.ReleaseDate, item.Songs, item.Title);
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            }
        }
    }
}

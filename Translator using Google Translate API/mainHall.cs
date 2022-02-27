using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Nodes;

namespace Translator_using_Google_Translate_API
{
   
    public partial class mainHall : Form
    {
        public mainHall()
        {
            InitializeComponent();
        }

        private async void btTranslate_ClickAsync(object sender, EventArgs e)
        {
            await getDataAsync();
        }
        private async Task getDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://microsoft-translator-text.p.rapidapi.com/translate?to=vi&api-version=3.0&profanityAction=NoAction&textType=plain&suggestedFrom=en"),
                Headers ={
                            { "x-rapidapi-host", "microsoft-translator-text.p.rapidapi.com" },
                            { "x-rapidapi-key", "a10d63c67cmshd79f69a2d87629ap1e586djsna7cdee48e5de" },
                         },
                Content = new StringContent("[\r\n    {\r\n        \"Text\": \"" + richInput.Text + "\"\r\n    }\r\n]")
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            string body;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
               
                
            }
            JsonNode note = JsonNode.Parse(body);
            string translatedText = note[0]["translations"][0]["text"].GetValue<string>();
            richOutput.Text= translatedText;
        }
      
    }

}
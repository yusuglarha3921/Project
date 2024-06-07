using System; 
using System.Net.Http; 
using HtmlAgilityPack;  
using System.Threading.Tasks;  

class Program
{
    static async Task Main(string[] args)
    {
   
        string url = "https://www.doviz.com/";

        try
        {
        
            HttpClient client = new HttpClient();

           
            HttpResponseMessage response = await client.GetAsync(url);

            
            response.EnsureSuccessStatusCode();


            
            string responseBody = await response.Content.ReadAsStringAsync();

         
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(responseBody);

  
 
            var dolarNode = htmlDoc.DocumentNode.SelectSingleNode("//span[@data-socket-key='USD']");
            var dolarKuru = dolarNode.InnerText;  

           
            var euroNode = htmlDoc.DocumentNode.SelectSingleNode("//span[@data-socket-key='EUR']");
            var euroKuru = euroNode.InnerText;  

           
           
            var sterlinNode = htmlDoc.DocumentNode.SelectSingleNode("//span[@data-socket-key='GBP']");
            var sterlinKuru = sterlinNode.InnerText;  


            Console.WriteLine("Güncel Döviz Kurları:");
            Console.WriteLine($"Dolar (USD/TRY): {dolarKuru}");
            Console.WriteLine($"Euro (EUR/TRY): {euroKuru}");
            Console.WriteLine($"Sterlin (GBP/TRY): {sterlinKuru}");

          
            Console.Write("\nLütfen TL miktarını girin: ");
            double tlMiktari = Convert.ToDouble(Console.ReadLine());

   
            Console.Write("Hangi dövize çevirmek istiyorsunuz? (USD, EUR, GBP): ");
            string hedefDoviz = Console.ReadLine().ToUpper();

        
            double secilenDovizKuru = 0;

           
            switch (hedefDoviz)
            {
                case "USD":
                    secilenDovizKuru = Convert.ToDouble(dolarKuru);
                    break;
                case "EUR":
                    secilenDovizKuru = Convert.ToDouble(euroKuru);
                    break;
                case "GBP":
                    secilenDovizKuru = Convert.ToDouble(sterlinKuru);
                    break;
                default:
                    Console.WriteLine("Geçersiz döviz türü.");
                    return;
            }

            double sonuc = tlMiktari / secilenDovizKuru;

            Console.WriteLine($"{tlMiktari} TL = {sonuc} {hedefDoviz}");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }
    }
}

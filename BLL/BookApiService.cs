using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using BiblioWorld.Models;
using System;

namespace BiblioWorld.BLL
{
    public class BookApiService
    {
        private readonly HttpClient _httpClient;

        public BookApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Book>> SearchBooksAsync(string query)
        {
            var url = $"https://gallica.bnf.fr/services/engine/search/opds?version=1.2&operation=searchRetrieve&query={query}";
            var response = await _httpClient.GetStringAsync(url);
            Console.WriteLine(response); // Affiche la réponse de l'API pour débogage
            var xml = XDocument.Parse(response);

            var books = new List<Book>();
            foreach (var entry in xml.Descendants("{http://www.w3.org/2005/Atom}entry"))
            {
                books.Add(new Book
                {
                    Title = entry.Element("{http://www.w3.org/2005/Atom}title")?.Value ?? "Titre inconnu",
                    AuthorID = 0, // Vous devrez peut-être gérer les auteurs séparément
                    GenreID = 0, // Vous devrez peut-être gérer les genres séparément
                    PublishedYear = entry.Element("{http://www.w3.org/2005/Atom}updated") != null ? int.Parse(entry.Element("{http://www.w3.org/2005/Atom}updated").Value.Substring(0, 4)) : 0,
                    Summary = entry.Element("{http://www.w3.org/2005/Atom}summary")?.Value ?? "Pas de description"
                });
            }

            Console.WriteLine($"Nombre de livres trouvés : {books.Count}"); // Affiche le nombre de livres trouvés
            return books;
        }
    }
}
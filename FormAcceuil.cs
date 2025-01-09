using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioWorld.BLL;
using BiblioWorld.Models;

namespace Projet_cours_1
{
    public partial class FormAccueil : Form
    {
        private readonly BookService _bookService;

        public FormAccueil()
        {
            InitializeComponent();
            _bookService = new BookService();
            LoadBooksAsync();
        }

        private async void LoadBooksAsync()
        {
            await LoadBooks();
        }

        private async Task LoadBooks()
        {
            // Récupérer les livres de la base de données
            List<Book> booksFromDb = _bookService.GetBooks();
            Console.WriteLine($"Livres de la base de données : {booksFromDb.Count}"); // Affiche le nombre de livres de la base de données

            // Afficher les livres dans listBoxBooks
            listBoxBooks.Items.Clear();
            foreach (var book in booksFromDb)
            {
                listBoxBooks.Items.Add($"{book.Title} - {book.AuthorID} - {book.GenreID} - {book.PublishedYear}");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text;
            List<Book> books = _bookService.GetBooks(); // Vous pouvez implémenter une recherche locale si nécessaire
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                if (book.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
                {
                    listBoxBooks.Items.Add($"{book.Title} - {book.AuthorID} - {book.GenreID} - {book.PublishedYear}");
                }
            }
        }
    }
}
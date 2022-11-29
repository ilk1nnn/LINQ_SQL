using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassesExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            DataClasses1DataContext dtx = new DataClasses1DataContext();



            // meslehetlisi

            //var result = from b in dtx.Books
            //             where b.Pages>500
            //             select b;
            //mydatagrid.ItemsSource = result;


            // --------------------------------------

            //var result = dtx.
            //                Books.
            //                Where(b => b.Pages > 500);
            //mydatagrid.ItemsSource = result;

            // -----------------------------------------

            //var result = from b in dtx.Books
            //             where b.Pages > 500
            //             select new {b.Name,b.Pages};

            //mydatagrid.ItemsSource = result;


            // ------------------------------------


            //var result = from a in dtx.Authors
            //             where a.Id == 1
            //             select new { a.FirstName };

            //mydatagrid.ItemsSource = result;



            // ------------------------------------


            //var result = from sc in dtx.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select new { mygroup.Key, mygroup.First().Book.Name, mygroup.First().Student.FirstName };

            //mydatagrid.ItemsSource = result;


            // ------------------------------------


            //var result = from sc in dtx.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select mygroup;


            //var mylist = new List<S_Card>();

            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        mylist.Add(i);
            //    }
            //}

            //var items = from m in mylist
            //            select new ItemDto
            //            {
            //                BookName = m.Book.Name,
            //                StudentName = m.Student.FirstName
            //            };

            //mydatagrid.ItemsSource = items;

            // ------------------------------------


            //var result = from b in dtx.Books
            //             where b.Id == (from s in dtx.S_Cards
            //                            orderby s.Id descending
            //                            select s.Id_Book).First()
            //                select b;


            //mydatagrid.ItemsSource = result;


            // ------------------------------------

            //var result = from b in dtx.Books
            //             join a in dtx.Authors
            //             on b.Id_Author equals a.Id
            //             select new { b.Name , a.FirstName };


            //mydatagrid.ItemsSource = result;


            // ------------------------------------


            //dtx.Books.InsertOnSubmit(new Book
            //{
            //    Id= 1155,
            //    Name = "My Sugar Book",
            //    Pages = 10000,
            //    YearPress = 2021,
            //    Id_Category = 1,
            //    Id_Press = 1,
            //    Id_Themes = 1
            //});


            //dtx.SubmitChanges();


            //var result = from b in dtx.Books
            //             select b;


            //mydatagrid.ItemsSource = result;



            //------------------------------------

            //var book = dtx.Books.FirstOrDefault(x => x.Id == 1155);
            //book.Name = "Hello World";

            //dtx.SubmitChanges();


            // DeleteOnSubmit



        }
    }
}

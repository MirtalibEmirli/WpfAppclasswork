using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;
namespace WpfApp1;


public partial class MainWindow : Window
{

    List<string> cties = new List<string> { "Baku", "Seki", "Quba" };
    List<userr> users = new List<userr>();

    public MainWindow()
    {
        InitializeComponent(); 

        compobox.ItemsSource = cties; 
        usrs.ItemsSource = users; 
    }

    private void add_Click(object sender, RoutedEventArgs e)
    {
        var a = tb1.Text;
        var b = tb2.Text;
        dynamic cty="";
        foreach (var item in compobox.Items)
        {
            if (compobox.SelectedItem == item)
            {
                cty= item;
            }
        }
        dynamic gender;

        if(Rbt1.IsChecked == true) {
            gender = "Male";
        }
        else
        {
            gender = "Female";
        }
        dynamic chkd;
        if (Cbx.IsChecked == true)
        {
            chkd = true;

        }
        else
        {
            chkd = false;
        }
        userr u1 = new userr(a,b, gender,cty,chkd);
        users.Add(u1);
        usrs.ItemsSource=null;
        usrs.ItemsSource=users;
        tb1.Text = "";
        tb2.Text = "";
    }

    private void save_Click(object sender, RoutedEventArgs e)
    {
        var a = new JsonSerializerOptions();
        a.WriteIndented = true;
        string data = JsonSerializer.Serialize<List<userr>>(users, a);
        File.WriteAllText($"../../../{tb1.Text}.json", data);

    }

    private void delet_Click(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < users.Count; i++)
        {
            users.Remove(users.ElementAt(compobox.SelectedIndex));
        }
        usrs.ItemsSource = null;
        usrs.ItemsSource = users;
    }
}
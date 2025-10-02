using System.Text.RegularExpressions;

namespace INF04_2023_czerwiec_desktopApp
{
    public partial class MainPage : ContentPage
    {
        string source = " ";
        double multiplyer = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        //****************************************************************
        //Nazwa Funkcji:verifyEntryData
        //Parametry wejściowe: obiekt wysyłający żądanie
        //Wartość zwracana: brak
        //Informacje: funkcja weryfikuje dane wprowadzane przez użytkownika
        //Autor: Bartosz Semczuk
        //****************************************************************
        void verifyEntryData(object sender, EventArgs e)
        {

            displayError.Text = "W porządku";
            if (postalCode.Text.Trim().All(char.IsLetter))
            {
                displayError.Text = "Kod pocztowy nie może zawierac liter";
            }
            if (displayError.Text.Length < 5)
            {
                displayError.Text = "Nieprwadiłowa liczba cyfr w kodzie pocztowym";
            }
            if (displayError.Text.Length > 5)
            {
                displayError.Text = "Nieprwadiłowa liczba cyfr w kodzie pocztowym";
            }
        }
        //****************************************************************
        //Nazwa Funkcji:setPackageType
        //Parametry wejściowe: obiekt wysyłający żądanie
        //Wartość zwracana: brak
        //Informacje: funkcja sprawdza i ustawia wybrany typ paczki
        //Autor: Bartosz Semczuk
        //****************************************************************
        void setPackageType(object sender, EventArgs e)
            {
            RadioButton rb = sender as RadioButton;
            switch (rb.Value)
            {
                case "1":
                    {
                        source = "list.png";
                        multiplyer = 1;
                        break;
                    }
                case "2":
                    {
                        source = "paczka.png";
                        multiplyer = 1.5;
                        break;
                    }
                case "3":
                    {
                        source = "pocztowka.png";
                        multiplyer = 10;
                        break;
                    }
            }
        }
        //****************************************************************
        //Nazwa Funkcji:priceCheck
        //Parametry wejściowe: obiekt wysyłający żądanie
        //Wartość zwracana: brak
        //Informacje: funkcja ustawia dane wyjściowe wyświetlane w graficznym interfejsie użytkownika
        //Autor: Bartosz Semczuk
        //****************************************************************
        void priceCheck(object sender, EventArgs e) {
            displayPrice.Text = "Cena: " + (1 * multiplyer)+ "zł";
            displayPhoto.Source = source;
        }

    }

}

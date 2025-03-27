using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Super Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },

            new Quarto()
            {
                Descricao = "Suite Super Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };//Fecha List<Quarto>]

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
            {
                var window = base.CreateWindow(activationState);
                
                window.Width = 400;
                window.Height = 600; 
            
            return window;
            }
        
       }
}


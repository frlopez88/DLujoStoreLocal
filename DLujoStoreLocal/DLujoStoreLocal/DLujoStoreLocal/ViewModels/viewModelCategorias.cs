using DLujoStoreLocal.Models;
using DLujoStoreLocal.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DLujoStoreLocal.ViewModels
{
    public class viewModelCategorias : INotifyPropertyChanged
    {

        public viewModelCategorias() {


            lista.Add(new Categorias() {
                
                    nombre = "Anillos", 
                    urlCategoria = "https://www.diamantesa.es/wp-content/uploads/anillo-compromiso-diamantesa.png"

            });

            lista.Add(new Categorias()
            {

                nombre = "Pulseras",
                urlCategoria = "https://imagenes.elpais.com/resizer/ZBY_Wsp9xsJ3U2ZaX6nVkf-JJ8c=/1960x0/cloudfront-eu-central-1.images.arcpublishing.com/prisa/LUZKFP75OOXRAQ6E4VL4EJPUNU.jpg"

            });


            lista.Add(new Categorias()
            {

                nombre = "Collares",
                urlCategoria = "https://www.shutterstock.com/image-vector/pearl-necklace-on-mannequin-stand-260nw-1698685921.jpg"

            });

            lista.Add(new Categorias()
            {

                nombre = "Aritos",
                urlCategoria = "https://cdn.shopify.com/s/files/1/0443/0066/4990/products/ARRACADASA1_480x480.jpg?v=1644966297"

            });


            redirigirCategoria = new Command(() => {

                switch (ObjetoSeleccionado.nombre) {

                    case "Anillos":

                        var pagina = new viewAnillos();
                        Application.Current.MainPage.Navigation.PushAsync(pagina);

                        break;

                    default:

                        Application.Current.MainPage.DisplayAlert("Error", "Objeto no Encontrado", "OK");

                        break;



                }    
            
            
            } );


        }

        Categorias objetoSeleccionado;
        public Categorias ObjetoSeleccionado {

            get => objetoSeleccionado;
            set {
                objetoSeleccionado = value;
                OnPropertyChanged(nameof(ObjetoSeleccionado));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Categorias> lista { get; set; } = new ObservableCollection<Categorias>();

        public Command redirigirCategoria { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

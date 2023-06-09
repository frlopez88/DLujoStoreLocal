using DLujoStoreLocal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DLujoStoreLocal.ViewModels
{
    public class viewModelAnillos : INotifyPropertyChanged
    {
        public viewModelAnillos() {


            listaAnillos.Add( 
                new Anillos( "Anillo de Plata", 
                "https://www.mijoyaideal.es/media/catalog/product/cache/a9f27f6d9186c230c18f799a9f867422/1/0/1003_2.jpg", 
                "Plata", 
                991, "Anillo forjado en Italia con garantia de 40 dias"
                ));

            listaAnillos.Add(
               new Anillos("Anillo de Oro",
               "https://www.nicols.es/53780-home_default/anillo-oro-minimalista-media-cana-alta-9mm.jpg",
               "Oro",
               14, "Anillo aparece en la pelicula The Lord of The Rings"
               ));



            SeleccionAnillo = new Command(() => {

                Application.Current.MainPage.DisplayAlert("Info", AnilloSeleccionado.getHistoria(), "Ok"); 
            
            });

        }

        Anillos anilloSeleccionado;
        public Anillos AnilloSeleccionado {

            get => anilloSeleccionado;
            set {

                anilloSeleccionado = value;

                OnPropertyChanged(nameof(AnilloSeleccionado));

            }
        
        }

        public Command SeleccionAnillo { get; }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Anillos> listaAnillos { get; set; } = new ObservableCollection<Anillos>();
         
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

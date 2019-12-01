using System;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin_Assg2.Models;

namespace Xamarin_Assg2.ViewModels
{
    class PersonViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PersonViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person(){Image="aarslan2.jpg", Name = "Ahmet Arslan", Email = "aarslan@eskisehir.edu.tr", GSM = "05358797555"},
                new Person(){Image="akuysal.jpg", Name = "Alper Kürşat Uysal", Email = "akuysal@eskisehir.edu.tr", GSM = "05358797555"},
                new Person(){Image="aarslan2.jpg", Name = "Burcu Yürekli", Email = "byurekli@eskisehir.edu.tr", GSM = "05358797555"},
                new Person(){Image="ahmetaydin.jpg", Name = "Ahmet Aydın", Email = "ahmetaydin@eskisehir.edu.tr", GSM = "0535497555"},
                new Person(){Image="ekacmaz.jpg", Name = "Emre Kaçmaz", Email = "ekacamaz@eskisehir.edu.tr", GSM = "0534597555"}
            };
        }
    }
}

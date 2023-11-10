using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            MessagingCenter.Subscribe<Binding, Tasks>(this, "DatosTarea", (sender, nuevaTarea) =>
            {
                // Agregamos la nueva tarea a la lista
                Tareas.Add(nuevaTarea);
            });
            BindingContext = this;


        }
        private void CreateOneTask()
        {
            var MiTarea = new Tasks()
            {
                TaskName = "Comprar Pan",
                Status = "Pendiente",
                ColorText = "Blue"
            };

            Tareas.Add(MiTarea);
        }
        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            Binding binding = new Binding();
            Navigation.PushAsync(binding);

            
            //Tareas.Add(new Tasks()
            //{
            //    TaskName = "Estudiar",
            //    Status = "Pendiente",
            //    ColorText = "Blue"
            //});
        }

    }
}
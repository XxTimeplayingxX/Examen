using System.ComponentModel;

namespace ToDoListApp;
	public partial class Binding : ContentPage
{
    public Tasks NuevaTarea { get; set; }
    public Binding()
	{
		InitializeComponent();
        NuevaTarea = new Tasks();
        BindingContext = NuevaTarea;

	}

    private void AgregarButton_Clicked(object sender, EventArgs e)
    {
        NuevaTarea.TaskName = EntryTask.Text;
        NuevaTarea.Status = EntryStatus.Text;
        MessagingCenter.Send(this, "DatosTarea", NuevaTarea);

        // Cerrar la página actual y volver a Pagina1
        Navigation.PopAsync();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        EntryStatus.Text = "";
        EntryStatus.Text = "Pendiente";
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        EntryStatus.Text = "";
        EntryStatus.Text = "Importante";
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        EntryStatus.Text = "";
        EntryStatus.Text = "Urgente";
    }
}
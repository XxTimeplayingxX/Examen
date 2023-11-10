using System.ComponentModel;

namespace ToDoListApp
{
    public class Tasks : INotifyPropertyChanged
    {
        private string taskName;
        private string status;
        private string colorText;

        public string TaskName
        {
            get
            {
                return taskName;
            }

            set
            {
                taskName = value;
                this.OnPropertyChanged(nameof(TaskName));
            }
        }
        public string Status
        {
            get => status; set
            {
                status = value;
                this.OnPropertyChanged(nameof(Status));
            }
        }
        public string ColorText
        {
            get => colorText; set
            {
                colorText = value;
                this.OnPropertyChanged(nameof(ColorText));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

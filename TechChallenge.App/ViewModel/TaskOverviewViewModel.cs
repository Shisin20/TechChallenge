using System.Collections.ObjectModel;
using System.ComponentModel;
using TechChallenge.App.Extensions;
using TechChallenge.Model;
using TechChallenge.App.Service;

namespace TechChallenge.App.ViewModel
{
    //TaskOverviewViewModel class as ViewModel for TaskOverview implementing INotifyPropertyChanged  
    public class TaskOverviewViewModel : INotifyPropertyChanged
    {
        #region Properties

        public event PropertyChangedEventHandler PropertyChanged;
        private ITaskDataService taskDataService;

        private ObservableCollection<TaskDetail> _taskDetailList;

        public ObservableCollection<TaskDetail> TaskDetailList
        {
            get { return _taskDetailList; }
            set
            {
                _taskDetailList = value;
            }
        }

        private TaskDetail _selectedTask;

        public TaskDetail SelectedTask
        {
            get { return _selectedTask; }
            set
            {
                _selectedTask = value;
                RaisePropertyChanged("SelectedTask");
            }
        }

        #endregion

        #region Constructor

        public TaskOverviewViewModel(ITaskDataService taskDataService)
        {
            this.taskDataService = taskDataService;
            LoadTaskData();
        }

        #endregion

        #region Private Methods

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadTaskData()
        {
            TaskDetailList = taskDataService.GetAllTasks().ToObservableCollection();
        }

        #endregion
    }
}

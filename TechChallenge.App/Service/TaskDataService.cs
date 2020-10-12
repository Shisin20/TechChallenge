using System.Collections.Generic;
using TechChallenge.Model;
using TechChallenge.DAL;

namespace TechChallenge.App.Service
{
    // TaskDataService class to get repository data
    public class TaskDataService : ITaskDataService
    {
        #region Private Memeber

        //Repository to get list data
        ITaskRepository repository;

        #endregion

        #region Constructor

        public TaskDataService(ITaskRepository repository)
        {
            this.repository = repository;
            ApiHelper.InitialiseAPI();
        }

        #endregion

        #region Methods

        public List<TaskDetail> GetAllTasks()
        {
           return repository.GetTasks();
        }

        #endregion

    }
}

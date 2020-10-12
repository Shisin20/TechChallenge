using System.Collections.Generic;
using TechChallenge.Model;

namespace TechChallenge.App.Service
{
    public interface ITaskDataService
    {
        #region Methods

        List<TaskDetail> GetAllTasks();

        #endregion
    }
}

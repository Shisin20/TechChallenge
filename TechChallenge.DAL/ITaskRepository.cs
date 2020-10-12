using System.Collections.Generic;
using TechChallenge.Model;

namespace TechChallenge.DAL
{
    public interface ITaskRepository
    {
        #region Method

        List<TaskDetail> GetTasks();

        #endregion
    }
}

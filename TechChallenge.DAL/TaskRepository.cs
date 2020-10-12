using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TechChallenge.Model;

namespace TechChallenge.DAL
{
    public class TaskRepository : ITaskRepository
    {

        #region Method

        //async Method for api call
        public async Task<List<TaskDetail>> GetTaskDetailList()
        {
            string url = "https://jsonplaceholder.typicode.com/todos";
            List<TaskDetail> taskDetails = new List<TaskDetail>();

            //ConfigureAwait is used to prevent from deadlock
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
            {
                if (response.IsSuccessStatusCode)
                {
                    taskDetails = await response.Content.ReadAsAsync<List<TaskDetail>>();
                }
                else{
                    throw new Exception(response.ReasonPhrase);
                }
            }
            
            return taskDetails;
        }

        public List<TaskDetail> GetTasks()
        {
            var details = GetTaskDetailList();
            return details.Result;
        }

        #endregion
    }
}

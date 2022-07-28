using System;
using System.Collections.Generic;

namespace RZEngine.Core.Tasking
{
    public class TaskManager
    {
        #region STATIC TASK

        public static void CreateTask()
        {

        }

        #endregion

        #region STATIC QUEUE



        #endregion

        #region TASK

        private Dictionary<string, Task> _allTask;

        #endregion

        #region QUEUE

        private Dictionary<string, TaskQueue> _allQueues;

        public TaskQueue GetQueue(string id)
        {
            if(_allQueues.TryGetValue(id, out TaskQueue queue))
                return queue;

            return null;
        }

        public void AddQueue(TaskQueue queue)
        {
            _allQueues.Add(queue.Id, queue);
        }

        #endregion
    }
}

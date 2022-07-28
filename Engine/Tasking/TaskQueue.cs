using System;
using System.Collections.Generic;

namespace RZEngine.Core.Tasking
{
    public enum QueueState
    {
        Open,
        Closed,
        Finished
    }

    public class TaskQueue
    {
        public static TaskQueue Get(string id)
        {
            return Game.Instance.Tasks.GetQueue(id);
        }

        public static string New()
        {
            TaskQueue queue = new();
            Game.Instance.Tasks.AddQueue(queue);

            return queue.Id;
        }

        private readonly SortedDictionary<int, Task> _queue;

        private int _queueIndex;
        private int _activeTaskIndex = -1;
        private Task _activeTask;

        public string Id;
        public QueueState State;
        public string CurrentRunningTaskId = "";

        public TaskQueue()
        {
            Id = Guid.NewGuid().ToString();
            _queueIndex = 0;
            _queue = new();
            State = QueueState.Open;
        }

        public (string, int)? Add(Task task)
        {
            if (State == QueueState.Open)
            {
                int currentQueueIndex = _queueIndex;

                _queueIndex++;
                _queue.Add(currentQueueIndex, task);
                return (Id, currentQueueIndex);
            }
            return null;
        }

        public bool Kick(int taskQueueIndex)
        {
            if (_activeTaskIndex == taskQueueIndex)
                return false;

            return _queue.Remove(taskQueueIndex);
        }

        public void Run()
        {
            State = QueueState.Closed;
        }

        public void Update()
        {
            if (State != QueueState.Closed)
                return;

            if(_queue.Count == 0)
            {
                State = QueueState.Finished;
                return;
            }

            if(_activeTask == null)
            {
                _activeTaskIndex++;
                if (_queue.TryGetValue(_activeTaskIndex, out Task task))
                    _activeTask = task;
            }

            _activeTask.Update();
            if (_activeTask.State == TaskState.Finished)
            {
                Kick(_activeTaskIndex);
                _activeTask = null;
            }
        }
    }
}

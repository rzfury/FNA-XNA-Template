using System;
using System.Collections.Generic;

namespace RZEngine.Core.Tasking
{
    public enum TaskState
    {
        StandBy,
        Running,
        Paused,
        Finished
    }

    public delegate void TaskAction(TaskData data, Task task);

    public class Task
    {
        private TaskAction _action;
        private Dictionary<string, object> _initialData;
        private TaskData _data;

        public string Id;
        public TaskState State;

        public Task(Dictionary<string, object> data, TaskAction action)
        {
            Id = "task_" + Guid.NewGuid().ToString();
            State = TaskState.StandBy;

            _data = new(data);
            _initialData = new(data);

            _action = action;
        }

        public Task(string id, Dictionary<string, object> data, TaskAction action)
        {
            Id = id;
            State = TaskState.StandBy;

            _data = new(data);
            _initialData = new(data);

            _action = action;
        }

        public void Start()
        {
            if (State == TaskState.StandBy)
                State = TaskState.Running;
        }

        public void Pause()
        {
            if (State == TaskState.Running)
                State = TaskState.Paused;
        }

        public void Continue()
        {
            if (State == TaskState.Paused)
                State = TaskState.Running;
        }

        public void Stop()
        {
            if (State == TaskState.Running)
                State = TaskState.Finished;
        }

        public void Reset()
        {
            if (State == TaskState.Finished)
            {
                State = TaskState.StandBy;
                _data = new(_initialData);
            }
        }

        public void Update()
        {
            if (State == TaskState.Paused)
                return;

            if (State == TaskState.Running)
                _action(_data, this);
        }
    }
}

namespace JISAAssignment.Models

{
    public class TaskDal
    {
        List<Tasks> list;
        public TaskDal()
        {
            list = new List<Tasks>()
            {
             new Tasks{TaskId=1,TaskName="send Email"},
             new Tasks{TaskId=2,TaskName="Add new record"},
             new Tasks{TaskId=3,TaskName="Add student"}
            };
        }
        public List<Tasks> AddTask(Tasks t)
        {
           list.Add(t);
            return list;
        }
        public List<Tasks> DeleteTask(Tasks t)
        {
            foreach(Tasks t1 in list)
            {
                if(t1.TaskId == t.TaskId)
                {
                    list.Remove(t1);
                    break;
                }
            }
            return list;
        }
      
        public List<Tasks> UpdateTask(Tasks t)
        {
          foreach(Tasks t1 in list)
            {
                if(t1.TaskId == t.TaskId)
                {
                    t1.TaskName = t.TaskName;
                    break;
                }
            }
            return list;
        }
        public List<Tasks> GetAllTasks()
        {
            return list;
        }


    }
}

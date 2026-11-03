namespace WebApplication2.Models
{
    public class TaskItem
    {
        public int Id { get; set; }         // رقم المهمة
        public string Title { get; set; }   // اسم المهمة 
        public bool IsDone { get; set; }    // خلصت ولا لأ
    }
}
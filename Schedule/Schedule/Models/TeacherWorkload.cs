﻿namespace Schedule.Models
{
    public class TeacherWorkload
    {
        public int Id { get; set; }  
        public int TeacherId { get; set; }  

        //TODO: Уточнить
        public int PerWeek { get; set; }  
        public int PerYear { get; set; }  
    }
}
using System;

namespace SelfTest
{
    public class Degree
    {
        public string DegreeName {get; set; }
        public Course[] courses = new Course[4];


        public Degree (string _degreeName)
        {
            this.DegreeName = _degreeName;
        }

    }
}
using System;

namespace SelfTest
{
    public class UProgram
    {
        public string UProgramName {get; set; }
        public Degree[] degrees = new Degree[3];


        public UProgram(string _programName)
        {
            this.UProgramName = _programName;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SelfTest
{
    // Abstract class
    abstract class Person  : IDisposable
    {

        // bool _isDisposed;

        // public void Dispose()
        // {
        //   throw new NotImplementedException();
        // }
        // Defining properties
        public string gender { get; set; }
        public string eyeColor { get; set; }
        public string nationality { get; set; }

        // //Adding another Constructor
        // public Person(string gender, string eyeColor, string nationality)
        // {
        //     this.gender = gender;
        //     this.eyeColor = eyeColor;
        //     this.nationality = nationality;

        // }




        private StreamReader m_Stream;
        private StreamWriter newFile;
 
        public void LogWriter(string logFile)
        {
            m_Stream = new StreamReader(logFile);

        }
    
        public void WriteLine(string message)
        {
            newFile = new StreamWriter(message);
            newFile.WriteLine(newFile);
        }
    
        // #region IDisposable implementation
    
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
        private bool is_Disposed = false;
    
        protected virtual void Dispose(bool disposing)
        {
            if (!is_Disposed)
            {
                if (disposing)
                {
                    m_Stream.Dispose();
                }
    
                // Unmanaged resources are released here.
    
                is_Disposed = true;
            }
        }
    
        ~Person()    
        {        
            Dispose(false);
        }

    }



}
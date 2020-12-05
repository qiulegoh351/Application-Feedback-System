using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ApplicationFeedbackSystem
{
    class completeFeedbackList
    {
        private string fileName;
        private string email;

        
        

        public completeFeedbackList()
        {

        }

        public string FileNmae
        {
            get { return fileName; }
            set { fileName = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        
        
    }
}


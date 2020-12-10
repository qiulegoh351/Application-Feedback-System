using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFeedbackSystem
{
    public class completeFeedback
    {
        private int file_name;
        private string email;
        private string status;

        public int File_name { get => file_name; set => file_name = value; }

        public string Email { get => email; set => email = value; }

        public string Status { get => status; set => status = value; }
    }
}

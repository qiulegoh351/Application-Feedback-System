using System;

namespace ApplicationFeedbackSystem
{
    public class TemplateList
    {
        private int code;
        private string interviewee;
        private string email;
        private string interviewer;
        private string type;
        private string positionApplication;

        public TemplateList()
        {
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Interviewer
        {
            get { return interviewer; }
            set { interviewer = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Interviewee
        {
            get { return interviewee; }
            set { interviewee = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Position
        {
            get { return positionApplication; }
            set { positionApplication = value; }
        }
    }
}

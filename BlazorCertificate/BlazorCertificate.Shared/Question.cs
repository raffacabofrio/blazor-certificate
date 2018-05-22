using System;

namespace BlazorCertificate.Shared
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string SourceUrl { get; set; }
    }
}

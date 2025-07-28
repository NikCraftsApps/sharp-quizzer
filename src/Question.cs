namespace QuizGame
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; } 
        public string CorrectAnswer { get; set; } 
        public int Difficulty { get; set; }
    }
}

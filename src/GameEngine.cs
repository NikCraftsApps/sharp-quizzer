using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizGame
{
    public enum GameMode
    {
        FixedDifficulty,
        ProgressiveDifficulty
    }

    public class GameEngine
    {
        private List<Question> allQuestions;
        private List<Question> remainingQuestions;
        private int questionsAnswered;
        public int Score { get; private set; }
        public int Lives { get; private set; }
        private int currentDifficulty;
        private readonly GameMode mode;
        private readonly int fixedDifficulty;
        private readonly Random random = new Random();

        public GameEngine(GameMode mode, int fixedDifficulty = 1)
        {
            this.mode = mode;
            this.fixedDifficulty = fixedDifficulty;
            allQuestions = Questions.GetAllQuestions();
            remainingQuestions = new List<Question>(allQuestions);
            Score = 0;
            Lives = 3;
            questionsAnswered = 0;
            currentDifficulty = (mode == GameMode.FixedDifficulty) ? fixedDifficulty : 1;
        }

        public bool IsGameOver()
        {
            return Lives <= 0 || remainingQuestions.Count == 0;
        }

        public Question GetNextQuestion()
        {
            List<Question> availableQuestions;

            if (mode == GameMode.FixedDifficulty)
            {
                availableQuestions = remainingQuestions
                    .Where(q => q.Difficulty == fixedDifficulty)
                    .ToList();
            }
            else
            {
                availableQuestions = remainingQuestions
                    .Where(q => q.Difficulty == currentDifficulty)
                    .ToList();

                if (availableQuestions.Count == 0)
                    availableQuestions = remainingQuestions; // fallback jeśli brak pytań na tym poziomie
            }

            if (availableQuestions.Count == 0) return null;

            var selected = availableQuestions[random.Next(availableQuestions.Count)];

            selected.Choices = selected.Choices.OrderBy(c => random.Next()).ToArray();

            remainingQuestions.Remove(selected);
            return selected;
        }

        public void CheckAnswer(Question question, string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
            {
                Lives--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wrong! Correct answer: {question.CorrectAnswer}");
                Console.ResetColor();
                return;
            }

            int index = answer.Trim().ToUpper() switch
            {
                "A" => 0,
                "B" => 1,
                "C" => 2,
                "D" => 3,
                _ => -1
            };

            bool correct = index >= 0 &&
                           index < question.Choices.Length &&
                           question.Choices[index] == question.CorrectAnswer;

            if (correct)
            {
                int points = question.Difficulty == 1 ? 10 :
                             question.Difficulty == 2 ? 20 : 30;
                Score += points;
                questionsAnswered++;

                if (mode == GameMode.ProgressiveDifficulty && questionsAnswered % 5 == 0 && currentDifficulty < 3)
                {
                    currentDifficulty++;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
            }
            else
            {
                Lives--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wrong! Correct answer: {question.CorrectAnswer}");
            }

            Console.ResetColor();
        }
    }
}

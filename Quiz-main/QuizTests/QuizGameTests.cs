using Xunit;
using Quiz; 

namespace Quiz.Tests
{
        [Fact]
        public void Restart_WhenCalled_ShouldResetAllStats()
        {
            var game = new QuizGame();
            game.GiveAnswer(true, 10);
            game.GiveAnswer(false, 15);
            game.GiveAnswer(true, 5);

            game.Restart();

            Assert.Equal(0, game.Score);
            Assert.Equal(0, game.CorrectAnswers);
            Assert.Equal(0, game.TotalQuestionsAnswered);
            Assert.Equal(0.0, game.CorrectAnswerPercentage);
        }
}

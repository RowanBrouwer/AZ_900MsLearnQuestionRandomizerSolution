using AZ_900MsLearnQuestionRandomizerSolution.Data.ExtensionMethods;
using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data.Logic
{
    public interface IAnswerLogic
    {
        public Task<bool> AnswerCheck(Answer answer, Question question);
        public Task<List<Question>> GetRandomizedList();
    }
    public class AnswerLogic : IAnswerLogic
    {
        private readonly ApplicationDbContext context; 
        public AnswerLogic(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<bool> AnswerCheck(Answer answer, Question question)
        {
            var correctAnswer = question.CorrectAnswer;

            if (correctAnswer == answer)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public Task<List<Question>> GetRandomizedList()
        {
            var questionList = context.Questions.ToList();

            questionList.Shuffle();

            return Task.FromResult(questionList);
        }
    }
}

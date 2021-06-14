using AZ_900MsLearnQuestionRandomizerSolution.Data.ExtensionMethods;
using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data.Logic
{
    public class AwnserLogic : IAwnserLogic
    {
        private readonly ApplicationDbContext context; 
        public AwnserLogic(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<bool> AwnserCheck(Awnser awnser, Question question)
        {
            var correctAwnser = question.CorrectAwnser;

            if (correctAwnser == awnser)
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

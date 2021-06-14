using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data.Logic
{
    public interface IAwnserLogic
    {
        public Task<bool> AwnserCheck(Awnser awnser, Question question);
        public Task<List<Question>> GetRandomizedList();
    }
}

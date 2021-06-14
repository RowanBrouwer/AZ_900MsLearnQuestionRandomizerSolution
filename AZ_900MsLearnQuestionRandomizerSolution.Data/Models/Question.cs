using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string ActualQuestion { get; set; }
        public IEnumerable<Awnser> Awnsers { get; set; }
        public Awnser CorrectAwnser { get; set; }
        public ChapterEnum Chapter { get; set; }
    }
}

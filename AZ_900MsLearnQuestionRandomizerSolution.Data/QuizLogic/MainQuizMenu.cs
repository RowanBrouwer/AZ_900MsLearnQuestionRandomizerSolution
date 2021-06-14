using AZ_900MsLearnQuestionRandomizerSolution.Data.Logic;
using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data.QuizLogic
{
    public class MainQuizMenu
    {
        private ApplicationDbContext context;
        private IAwnserLogic awnserlogic;
        private int amount_Correct;
        private int total_Amount;
        private bool quit = false;
        private int question = 0;
        private List<Question> azure_Core_Concepts_Questions = new List<Question>();
        private int azure_Core_Concepts_Questions_Correct = 0;
        private List<Question> Azure_Core_Services_Questions = new List<Question>();
        private int azure_Core_Services_Questions_Correct = 0;
        private List<Question> azure_Core_Solutions_and_Management_tools = new List<Question>();
        private int azure_Core_Solutions_and_Management_tools_Correct = 0;
        private List<Question> General_Security_and_Network_security = new List<Question>();
        private int general_Security_and_Network_security_Correct = 0;
        private List<Question> Identity_Governance_Privacy_and_Compliance_Features = new List<Question>();
        private int identity_Governance_Privacy_and_Compliance_Features_Correct = 0;
        private List<Question> Azure_Cost_Management_and_service_Level_Agreements = new List<Question>();
        private int Azure_Cost_Management_and_service_Level_Agreements_Correct = 0;

        public List<Question> questions { get; set; }
        public MainQuizMenu(ApplicationDbContext context, IAwnserLogic awnserlogic)
        {
            this.context = context;
            this.awnserlogic = awnserlogic;
        }

        public async Task MainLoop()
        {
            questions = await awnserlogic.GetRandomizedList();
            total_Amount = questions.Count();

            foreach (var question in questions)
            {
                if (question != null)
                {
                    switch (question.Chapter)
                    {
                        case ChapterEnum.Azure_Core_Concepts:
                            azure_Core_Concepts_Questions.Add(question);
                            break;
                        case ChapterEnum.Azure_Core_Services:
                            Azure_Core_Services_Questions.Add(question);
                            break;
                        case ChapterEnum.Azure_Core_Solutions_and_Management_tools:
                            azure_Core_Solutions_and_Management_tools.Add(question);
                            break;
                        case ChapterEnum.General_Security_and_Network_security:
                            General_Security_and_Network_security.Add(question);
                            break;
                        case ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features:
                            Identity_Governance_Privacy_and_Compliance_Features.Add(question);
                            break;
                        case ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements:
                            Azure_Cost_Management_and_service_Level_Agreements.Add(question);
                            break;
                        default:
                            break;
                    }
                }
            }

            while (quit == false)
            {
                if (question >= questions.Count())
                {
                    int TotalPercentCorrect = (int)Math.Round((double)(100 * amount_Correct) / total_Amount);

                    int Azure_Core_Concepts_Percentage = (int)Math.Round((double)(100 * azure_Core_Concepts_Questions_Correct) / azure_Core_Concepts_Questions.Count());
                    int Azure_Core_Services_Percentage = (int)Math.Round((double)(100 * azure_Core_Services_Questions_Correct) / Azure_Core_Services_Questions.Count());
                    int Azure_Core_Solutions_and_Management_tools_Percentage = (int)Math.Round((double)(100 * azure_Core_Solutions_and_Management_tools_Correct) / azure_Core_Solutions_and_Management_tools.Count());
                    int General_Security_and_Network_security_Percentage = (int)Math.Round((double)(100 * general_Security_and_Network_security_Correct) / General_Security_and_Network_security.Count());
                    int Identity_Governance_Privacy_and_Compliance_Features_Percentage = (int)Math.Round((double)(100 * identity_Governance_Privacy_and_Compliance_Features_Correct) / Identity_Governance_Privacy_and_Compliance_Features.Count());
                    int Azure_Cost_Management_and_service_Level_Agreements_Percentage = (int)Math.Round((double)(100 * Azure_Cost_Management_and_service_Level_Agreements_Correct) / Azure_Cost_Management_and_service_Level_Agreements.Count());

                    Console.WriteLine($"\nYou got overall {TotalPercentCorrect}% Correct || {amount_Correct} correct out of {total_Amount}");

                    Console.WriteLine($"\nYou got {Azure_Core_Concepts_Percentage}% of {ChapterEnum.Azure_Core_Concepts} Correct");
                    Console.WriteLine($"\nYou got {Azure_Core_Services_Percentage}% of {ChapterEnum.Azure_Core_Services} Correct");
                    Console.WriteLine($"\nYou got {Azure_Core_Solutions_and_Management_tools_Percentage}% of {ChapterEnum.Azure_Core_Solutions_and_Management_tools} Correct");
                    Console.WriteLine($"\nYou got {General_Security_and_Network_security_Percentage}% of {ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements} Correct");
                    Console.WriteLine($"\nYou got {Identity_Governance_Privacy_and_Compliance_Features_Percentage}% of {ChapterEnum.General_Security_and_Network_security} Correct");
                    Console.WriteLine($"\nYou got {Azure_Cost_Management_and_service_Level_Agreements_Percentage}% of {ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features} Correct");

                    Console.WriteLine($"Press any button to exit");

                    Console.ReadLine();
                    break;
                }

                var current_question = questions.Skip(question).First();

                Console.WriteLine(current_question.ActualQuestion);
                int count = 1;

                foreach (var awnserInList in current_question.Awnsers)
                {
                    Console.WriteLine($"\n{count} : {awnserInList.ActualAwnser}");
                    count++;
                }

                bool parsed = false;
                int actualIndexAwnser = 0;
                int parsedAwnser = 0;

                do
                {
                    Console.WriteLine($"\n\nawnser with 1 - {count - 1}");
                    var awnser = Console.ReadLine();

                    if (awnser == "q")
                    {
                        quit = true;
                    }

                    try
                    {
                        parsedAwnser = int.Parse(awnser);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex);
                    }


                    actualIndexAwnser = parsedAwnser - 1;
                    if (!(actualIndexAwnser < 0))
                    {
                        parsed = true;
                    }
                } while (!parsed);

                var full_awnser = current_question.Awnsers.ToList()[actualIndexAwnser];

                var check = await awnserlogic.AwnserCheck(full_awnser, current_question);

                if (check == true)
                {
                    switch (current_question.Chapter)
                    {
                        case ChapterEnum.Azure_Core_Concepts:
                            azure_Core_Concepts_Questions_Correct++;
                            break;
                        case ChapterEnum.Azure_Core_Services:
                            azure_Core_Services_Questions_Correct++;
                            break;
                        case ChapterEnum.Azure_Core_Solutions_and_Management_tools:
                            azure_Core_Solutions_and_Management_tools_Correct++;
                            break;
                        case ChapterEnum.General_Security_and_Network_security:
                            general_Security_and_Network_security_Correct++;
                            break;
                        case ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features:
                            identity_Governance_Privacy_and_Compliance_Features_Correct++;
                            break;
                        case ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements:
                            Azure_Cost_Management_and_service_Level_Agreements_Correct++;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Correct");
                    amount_Correct++;
                    question++;
                }
                else
                {
                    question++;
                    Console.WriteLine("InCorrect");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}

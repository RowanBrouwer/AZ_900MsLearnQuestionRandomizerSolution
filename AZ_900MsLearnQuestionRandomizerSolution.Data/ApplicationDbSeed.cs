using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data
{
    public class ApplicationDbSeed
    {
        public static void Seed(ApplicationDbContext db)
        {
            if (db.Questions.Count() == 0)
            {
                var question1 = new Question
                {
                    ActualQuestion = "Which of the following choices isn't a cloud computing category?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ1 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Networking-as-a-Service (NaaS)"},
                        new Awnser{ActualAwnser = "Platform-as-a-Service (PaaS)"},
                        new Awnser{ActualAwnser = "Infrastructure-as-a-Service (IaaS)"},
                        new Awnser{ActualAwnser = "Software-as-a-Service (SaaS)"}
                };
                db.Awnsers.AddRange(AwnsersOfQ1);

                question1.Awnsers = AwnsersOfQ1;
                question1.CorrectAwnser = AwnsersOfQ1.FirstOrDefault(a => a.ActualAwnser == "Networking-as-a-Service (NaaS)");

                db.Add(question1);

                var question2 = new Question
                {
                    ActualQuestion = "Which of the following statements is true??",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ2 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "With Operating Expenses (OpEx), you are responsible for purchasing and maintaining your computing resources."},
                        new Awnser{ActualAwnser = "With Operating Expenses (OpEx), you are only responsible for the computing resources that you use."},
                        new Awnser{ActualAwnser = "With Capital Expenses (CapEx), you are only responsible for the computing resources that you use."},
                };
                db.Awnsers.AddRange(AwnsersOfQ2);

                question2.Awnsers = AwnsersOfQ2;
                question2.CorrectAwnser = AwnsersOfQ2.FirstOrDefault(a => a.ActualAwnser == "With Operating Expenses (OpEx), you are only responsible for the computing resources that you use.");

                db.Add(question2);

                var question3 = new Question
                {
                    ActualQuestion = "Which of the following options isn't a type of cloud computing?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ3 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Distributed cloud"},
                        new Awnser{ActualAwnser = "Hybrid cloud"},
                        new Awnser{ActualAwnser = "Private cloud"},
                        new Awnser{ActualAwnser = "Public cloud"}
                };
                db.Awnsers.AddRange(AwnsersOfQ3);

                question3.Awnsers = AwnsersOfQ3;
                question3.CorrectAwnser = AwnsersOfQ3.FirstOrDefault(a => a.ActualAwnser == "Distributed cloud");

                db.Add(question3);


                var question4 = new Question
                {
                    ActualQuestion = "Which of the following choices isn't a benefit of using cloud services?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ4 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Scalability"},
                        new Awnser{ActualAwnser = "Disaster recovery"},
                        new Awnser{ActualAwnser = "High availability"},
                        new Awnser{ActualAwnser = "Geographic isolation"}
                };
                db.Awnsers.AddRange(AwnsersOfQ4);

                question4.Awnsers = AwnsersOfQ4;
                question4.CorrectAwnser = AwnsersOfQ4.FirstOrDefault(a => a.ActualAwnser == "Geographic isolation");

                db.Add(question4);

                var question5 = new Question
                {
                    ActualQuestion = "True or false: You need to purchase an Azure account before you can use any Azure resources.",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ5 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "False"},
                        new Awnser{ActualAwnser = "True"},
                };
                db.Awnsers.AddRange(AwnsersOfQ5);

                question5.Awnsers = AwnsersOfQ5;
                question5.CorrectAwnser = AwnsersOfQ5.FirstOrDefault(a => a.ActualAwnser == "False");

                db.Add(question5);

                var question6 = new Question
                {
                    ActualQuestion = "What is meant by cloud computing?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ6 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Delivery of computing services over the internet."},
                        new Awnser{ActualAwnser = "Setting up your own datacenter."},
                        new Awnser{ActualAwnser = "Using the internet."},   
                };
                db.Awnsers.AddRange(AwnsersOfQ6);

                question6.Awnsers = AwnsersOfQ6;
                question6.CorrectAwnser = AwnsersOfQ6.FirstOrDefault(a => a.ActualAwnser == "Delivery of computing services over the internet.");

                db.Add(question6);

                var question7 = new Question
                {
                    ActualQuestion = "What is not a reason to move to the cloud?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ7 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Faster innovation"},
                        new Awnser{ActualAwnser = "A limited pool of services"},
                        new Awnser{ActualAwnser = "Speech recognition and other cognitive services"},
                };
                db.Awnsers.AddRange(AwnsersOfQ7);

                question7.Awnsers = AwnsersOfQ7;
                question7.CorrectAwnser = AwnsersOfQ7.FirstOrDefault(a => a.ActualAwnser == "A limited pool of services");

                db.Add(question7);

                var question8 = new Question
                {
                    ActualQuestion = "Which of the following can be used to manage governance across multiple Azure subscriptions?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ8 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure initiatives"},
                        new Awnser{ActualAwnser = "Management groups"},
                        new Awnser{ActualAwnser = "Resource groups"},
                };
                db.Awnsers.AddRange(AwnsersOfQ8);

                question8.Awnsers = AwnsersOfQ8;
                question8.CorrectAwnser = AwnsersOfQ8.FirstOrDefault(a => a.ActualAwnser == "Management groups");

                db.Add(question8);

                var question9 = new Question
                {
                    ActualQuestion = "Which of the following is a logical unit of Azure services that links to an Azure account?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ9 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure subscription"},
                        new Awnser{ActualAwnser = "Management group"},
                        new Awnser{ActualAwnser = "Resource group"},
                        new Awnser{ActualAwnser = "Public cloud"},
                };
                db.Awnsers.AddRange(AwnsersOfQ9);

                question9.Awnsers = AwnsersOfQ9;
                question9.CorrectAwnser = AwnsersOfQ9.FirstOrDefault(a => a.ActualAwnser == "Azure subscription");

                db.Add(question9);

                var question10 = new Question
                {
                    ActualQuestion = "Which of the following features doesn't apply to resource groups?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ10 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Resources can be in only one resource group."},
                        new Awnser{ActualAwnser = "Role-based access control can be applied to the resource group."},
                        new Awnser{ActualAwnser = "Resource groups can be nested."},
                };
                db.Awnsers.AddRange(AwnsersOfQ10);

                question10.Awnsers = AwnsersOfQ10;
                question10.CorrectAwnser = AwnsersOfQ10.FirstOrDefault(a => a.ActualAwnser == "Resource groups can be nested.");

                db.Add(question10);

                var question11 = new Question
                {
                    ActualQuestion = "Which of the following statements is a valid statement about an Azure subscription?",
                    Chapter = ChapterEnum.Azure_Core_Concepts,
                };

                var AwnsersOfQ11 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Using Azure doesn't require a subscription."},
                        new Awnser{ActualAwnser = "An Azure subscription is a logical unit of Azure services."},
                };
                db.Awnsers.AddRange(AwnsersOfQ11);

                question11.Awnsers = AwnsersOfQ11;
                question11.CorrectAwnser = AwnsersOfQ11.FirstOrDefault(a => a.ActualAwnser == "An Azure subscription is a logical unit of Azure services.");

                db.Add(question11);

                var question12 = new Question
                {
                    ActualQuestion = "Which Azure compute resource can be deployed to manage a set of identical virtual machines?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ12 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Virtual machine scale sets"},
                        new Awnser{ActualAwnser = "Virtual machine availability sets"},
                        new Awnser{ActualAwnser = "Virtual machine availability zones"},
                };
                db.Awnsers.AddRange(AwnsersOfQ12);

                question12.Awnsers = AwnsersOfQ12;
                question12.CorrectAwnser = AwnsersOfQ12.FirstOrDefault(a => a.ActualAwnser == "Virtual machine scale sets");

                db.Add(question12);

                var question13 = new Question
                {
                    ActualQuestion = "Which of the following services should be used when the primary concern is to perform work in response to an event (often via a REST command) that needs a response in a few seconds?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ13 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Functions"},
                        new Awnser{ActualAwnser = "Azure App Service"},
                        new Awnser{ActualAwnser = "Azure Container Instances"},
                };
                db.Awnsers.AddRange(AwnsersOfQ13);

                question13.Awnsers = AwnsersOfQ13;
                question13.CorrectAwnser = AwnsersOfQ13.FirstOrDefault(a => a.ActualAwnser == "Azure Functions");

                db.Add(question13);

                var question14 = new Question
                {
                    ActualQuestion = "Your company has a team of remote workers that need to use Windows-based software to develop your company's applications, but your team members are using various operating systems like MacOS, Linux, and Windows. Which Azure compute service would help resolve this scenario?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ14 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure App Service"},
                        new Awnser{ActualAwnser = "Windows Virtual Desktop"},
                        new Awnser{ActualAwnser = "Azure Container Instances"},
                };
                db.Awnsers.AddRange(AwnsersOfQ14);

                question14.Awnsers = AwnsersOfQ14;
                question14.CorrectAwnser = AwnsersOfQ14.FirstOrDefault(a => a.ActualAwnser == "Windows Virtual Desktop");

                db.Add(question14);

                var question15 = new Question
                {
                    ActualQuestion = "Tailwind Traders wants to create a secure communication tunnel between its branch offices. Which of the following technologies can't be used?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ15 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Point-to-site virtual private network"},
                        new Awnser{ActualAwnser = "Implicit FTP over SSL"},
                        new Awnser{ActualAwnser = "Azure ExpressRoute"},
                        new Awnser{ActualAwnser = "Site-to-site virtual private network"},
                };
                db.Awnsers.AddRange(AwnsersOfQ15);

                question15.Awnsers = AwnsersOfQ15;
                question15.CorrectAwnser = AwnsersOfQ15.FirstOrDefault(a => a.ActualAwnser == "Implicit FTP over SSL");

                db.Add(question15);

                var question16 = new Question
                {
                    ActualQuestion = "Tailwind Traders wants to use Azure ExpressRoute to connect its on-premises network to the Microsoft cloud. Which of the following choices isn't an ExpressRoute model that Tailwind Traders can use?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ16 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Any-to-any connection"},
                        new Awnser{ActualAwnser = "Site-to-site virtual private network"},
                        new Awnser{ActualAwnser = "Point-to-point Ethernet connection"},
                        new Awnser{ActualAwnser = "CloudExchange colocation"},
                };
                db.Awnsers.AddRange(AwnsersOfQ16);

                question16.Awnsers = AwnsersOfQ16;
                question16.CorrectAwnser = AwnsersOfQ16.FirstOrDefault(a => a.ActualAwnser == "Site-to-site virtual private network");

                db.Add(question16);

                var question17 = new Question
                {
                    ActualQuestion = "Which of the following options can you use to link virtual networks?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ17 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Network address translation"},
                        new Awnser{ActualAwnser = "Multi-chassis link aggregation"},
                        new Awnser{ActualAwnser = "Dynamic Host Configuration Protocol"},
                        new Awnser{ActualAwnser = "Virtual network peering"},
                };
                db.Awnsers.AddRange(AwnsersOfQ17);

                question17.Awnsers = AwnsersOfQ17;
                question17.CorrectAwnser = AwnsersOfQ17.FirstOrDefault(a => a.ActualAwnser == "Virtual network peering");

                db.Add(question17);

                var question18 = new Question
                {
                    ActualQuestion = "Which of the following options isn't a benefit of ExpressRoute?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ18 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Redundant connectivity"},
                        new Awnser{ActualAwnser = "Consistent network throughput"},
                        new Awnser{ActualAwnser = "Encrypted network communication"},
                        new Awnser{ActualAwnser = "Access to Microsoft cloud services"},
                };
                db.Awnsers.AddRange(AwnsersOfQ18);

                question18.Awnsers = AwnsersOfQ18;
                question18.CorrectAwnser = AwnsersOfQ18.FirstOrDefault(a => a.ActualAwnser == "Encrypted network communication");

                db.Add(question18);

                var question19 = new Question
                {
                    ActualQuestion = "What is the first step that you would take in order to share an image file as a blob in Azure Storage?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ19 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Create an Azure Storage container to store the image."},
                        new Awnser{ActualAwnser = "Create an Azure Storage account."},
                        new Awnser{ActualAwnser = "Upload the image file and create a container."},
                        new Awnser{ActualAwnser = "Use a Shared Access Signature (SAS) token to restrict access to the image."},
                };
                db.Awnsers.AddRange(AwnsersOfQ19);

                question19.Awnsers = AwnsersOfQ19;
                question19.CorrectAwnser = AwnsersOfQ19.FirstOrDefault(a => a.ActualAwnser == "Create an Azure Storage account.");

                db.Add(question19);

                var question20 = new Question
                {
                    ActualQuestion = "Which Azure Storage option is better for storing data for backup and restore, disaster recovery, and archiving?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ20 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Files Storage"},
                        new Awnser{ActualAwnser = "Azure Disk Storage"},
                        new Awnser{ActualAwnser = "Azure Blob Storage"},
                };
                db.Awnsers.AddRange(AwnsersOfQ20);

                question20.Awnsers = AwnsersOfQ20;
                question20.CorrectAwnser = AwnsersOfQ20.FirstOrDefault(a => a.ActualAwnser == "Azure Blob Storage");

                db.Add(question20);

                var question21 = new Question
                {
                    ActualQuestion = "Your development team is interested in writing Graph-based applications that take advantage of the Gremlin API. Which option would be ideal for that scenario?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ21 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Cosmos DB"},
                        new Awnser{ActualAwnser = "Azure SQL Database"},
                        new Awnser{ActualAwnser = "Azure Databricks"},
                        new Awnser{ActualAwnser = "Azure Database for PostgreSQL"},
                };
                db.Awnsers.AddRange(AwnsersOfQ21);

                question21.Awnsers = AwnsersOfQ21;
                question21.CorrectAwnser = AwnsersOfQ21.FirstOrDefault(a => a.ActualAwnser == "Azure Cosmos DB");

                db.Add(question21);

                var question22 = new Question
                {
                    ActualQuestion = "Tailwind Traders uses the LAMP stack for several of its websites. Which option would be ideal for migration?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ22 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Cosmos DB"},
                        new Awnser{ActualAwnser = "Azure Database for MySQL"},
                        new Awnser{ActualAwnser = "Azure Database for PostgreSQL"},
                };
                db.Awnsers.AddRange(AwnsersOfQ22);

                question22.Awnsers = AwnsersOfQ22;
                question22.CorrectAwnser = AwnsersOfQ22.FirstOrDefault(a => a.ActualAwnser == "Azure Database for MySQL");

                db.Add(question22);

                var question23 = new Question
                {
                    ActualQuestion = "Tailwind Traders has millions of log entries that it wants to analyze. Which option would be ideal for analysis?",
                    Chapter = ChapterEnum.Azure_Core_Services,
                };

                var AwnsersOfQ23 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Cosmos DB"},
                        new Awnser{ActualAwnser = "Azure SQL Database"},
                        new Awnser{ActualAwnser = "Azure Database for PostgreSQL"},
                        new Awnser{ActualAwnser = "Azure Synapse Analytics"},
                };
                db.Awnsers.AddRange(AwnsersOfQ23);

                question23.Awnsers = AwnsersOfQ23;
                question23.CorrectAwnser = AwnsersOfQ23.FirstOrDefault(a => a.ActualAwnser == "Azure Synapse Analytics");

                db.Add(question23);

                var question24 = new Question
                {
                    ActualQuestion = "A company wants to build a new voting kiosk for sales to governments around the world. Which IoT technologies should the company choose to ensure the highest degree of security?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ24 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "IoT Hub"},
                        new Awnser{ActualAwnser = "IoT Central"},
                        new Awnser{ActualAwnser = "Azure Sphere"},
                };
                db.Awnsers.AddRange(AwnsersOfQ24);

                question24.Awnsers = AwnsersOfQ24;
                question24.CorrectAwnser = AwnsersOfQ24.FirstOrDefault(a => a.ActualAwnser == "Azure Sphere");

                db.Add(question24);

                var question25 = new Question
                {
                    ActualQuestion = "A company wants to build a new voting kiosk for sales to governments around the world. Which IoT technologies should the company choose to ensure the highest degree of security?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ25 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "IoT Hub"},
                        new Awnser{ActualAwnser = "IoT Central"},
                        new Awnser{ActualAwnser = "Azure Sphere"},
                };
                db.Awnsers.AddRange(AwnsersOfQ25);

                question25.Awnsers = AwnsersOfQ25;
                question25.CorrectAwnser = AwnsersOfQ25.FirstOrDefault(a => a.ActualAwnser == "IoT Central");

                db.Add(question25);

                var question26 = new Question
                {
                    ActualQuestion = "You want to send messages from the IoT device to the cloud and vice versa. Which IoT technology can send and receive messages?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ26 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "IoT Hub"},
                        new Awnser{ActualAwnser = "IoT Central"},
                        new Awnser{ActualAwnser = "Azure Sphere"},
                };
                db.Awnsers.AddRange(AwnsersOfQ26);

                question26.Awnsers = AwnsersOfQ26;
                question26.CorrectAwnser = AwnsersOfQ26.FirstOrDefault(a => a.ActualAwnser == "IoT Hub");

                db.Add(question26);

                var question27 = new Question
                {
                    ActualQuestion = "You need to predict future behavior based on previous actions. Which product option should you select as a candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ27 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Machine Learning"},
                        new Awnser{ActualAwnser = "Azure Bot Service"},
                        new Awnser{ActualAwnser = "Azure Cognitive Services"},
                };
                db.Awnsers.AddRange(AwnsersOfQ27);

                question27.Awnsers = AwnsersOfQ27;
                question27.CorrectAwnser = AwnsersOfQ27.FirstOrDefault(a => a.ActualAwnser == "Azure Machine Learning");

                db.Add(question27);

                var question28 = new Question
                {
                    ActualQuestion = "You need to create a human-computer interface that uses natural language to answer customer questions. Which product option should you select as a candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ28 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Machine Learning"},
                        new Awnser{ActualAwnser = "Azure Cognitive Services"},
                        new Awnser{ActualAwnser = "Azure Bot Service"},
                };
                db.Awnsers.AddRange(AwnsersOfQ28);

                question28.Awnsers = AwnsersOfQ28;
                question28.CorrectAwnser = AwnsersOfQ28.FirstOrDefault(a => a.ActualAwnser == "Azure Bot Service");

                db.Add(question28);

                var question29 = new Question
                {
                    ActualQuestion = "You need to identify the content of product images to automatically create alt tags for images formatted properly. Which product option is the best candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ29 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Machine Learning"},
                        new Awnser{ActualAwnser = "Azure Cognitive Services"},
                        new Awnser{ActualAwnser = "Azure Bot Service"},
                };
                db.Awnsers.AddRange(AwnsersOfQ29);

                question29.Awnsers = AwnsersOfQ29;
                question29.CorrectAwnser = AwnsersOfQ29.FirstOrDefault(a => a.ActualAwnser == "Azure Bot Service");

                db.Add(question29);

                var question30 = new Question
                {
                    ActualQuestion = "You need to identify the content of product images to automatically create alt tags for images formatted properly. Which product option is the best candidate?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ30 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Machine Learning"},
                        new Awnser{ActualAwnser = "Azure Cognitive Services"},
                        new Awnser{ActualAwnser = "Azure Bot Service"},
                };
                db.Awnsers.AddRange(AwnsersOfQ30);

                question30.Awnsers = AwnsersOfQ30;
                question30.CorrectAwnser = AwnsersOfQ30.FirstOrDefault(a => a.ActualAwnser == "Azure Cognitive Services");

                db.Add(question30);

                var question31 = new Question
                {
                    ActualQuestion = "You need to process messages from a queue, parse them by using some existing imperative logic written in Java, and then send them to a third-party API. Which serverless option should you choose?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ31 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Functions"},
                        new Awnser{ActualAwnser = "Azure Logic Apps"},
                };
                db.Awnsers.AddRange(AwnsersOfQ31);

                question31.Awnsers = AwnsersOfQ31;
                question31.CorrectAwnser = AwnsersOfQ31.FirstOrDefault(a => a.ActualAwnser == "Azure Functions");

                db.Add(question31);

                var question32 = new Question
                {
                    ActualQuestion = "You want to orchestrate a workflow by using APIs from several well-known services. Which is the best option for this scenario?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ32 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Functions"},
                        new Awnser{ActualAwnser = "Azure Logic Apps"},
                };
                db.Awnsers.AddRange(AwnsersOfQ32);

                question32.Awnsers = AwnsersOfQ32;
                question32.CorrectAwnser = AwnsersOfQ32.FirstOrDefault(a => a.ActualAwnser == "Azure Logic Apps");

                db.Add(question32);

                var question33 = new Question
                {
                    ActualQuestion = "Your team has limited experience with writing custom code, but it sees tremendous value in automating several important business processes. Which of the following options is your team's best option?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ33 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Functions"},
                        new Awnser{ActualAwnser = "Azure Logic Apps"},
                };
                db.Awnsers.AddRange(AwnsersOfQ33);

                question33.Awnsers = AwnsersOfQ33;
                question33.CorrectAwnser = AwnsersOfQ33.FirstOrDefault(a => a.ActualAwnser == "Azure Logic Apps");

                db.Add(question33);

                var question34 = new Question
                {
                    ActualQuestion = "Which of the following choices would not be used to automate a CI/CD process?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ34 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Pipelines"},
                        new Awnser{ActualAwnser = "GitHub Actions"}, 
                        new Awnser{ActualAwnser = "Azure Boards"},
                };
                db.Awnsers.AddRange(AwnsersOfQ34);

                question34.Awnsers = AwnsersOfQ34;
                question34.CorrectAwnser = AwnsersOfQ34.FirstOrDefault(a => a.ActualAwnser == "Azure Boards");

                db.Add(question34);

                var question35 = new Question
                {
                    ActualQuestion = "Which service could help you manage the VMs that your developers and testers need to ensure that your new app works across various operating systems?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ35 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure DevTest Labs"},
                        new Awnser{ActualAwnser = "Azure Test Labs"},
                        new Awnser{ActualAwnser = "Azure Repos"},
                };
                db.Awnsers.AddRange(AwnsersOfQ35);

                question35.Awnsers = AwnsersOfQ35;
                question35.CorrectAwnser = AwnsersOfQ35.FirstOrDefault(a => a.ActualAwnser == "Azure DevTest Labs");

                db.Add(question35);

                var question36 = new Question
                {
                    ActualQuestion = "Which service lacks features to assign individual developers tasks to work on?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ36 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Boards"},
                        new Awnser{ActualAwnser = "GitHub"},
                        new Awnser{ActualAwnser = "Azure Pipelines"},
                };
                db.Awnsers.AddRange(AwnsersOfQ36);

                question36.Awnsers = AwnsersOfQ36;
                question36.CorrectAwnser = AwnsersOfQ36.FirstOrDefault(a => a.ActualAwnser == "Azure Pipelines");

                db.Add(question36);

                var question37 = new Question
                {
                    ActualQuestion = "As an administrator, you need to retrieve the IP address from a particular VM by using Bash. Which of the following tools should you use?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ37 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "ARM templates"},
                        new Awnser{ActualAwnser = "Azure PowerShell"},
                        new Awnser{ActualAwnser = "The Azure portal"},
                        new Awnser{ActualAwnser = "The Azure CLI"},
                };
                db.Awnsers.AddRange(AwnsersOfQ37);

                question37.Awnsers = AwnsersOfQ37;
                question37.CorrectAwnser = AwnsersOfQ37.FirstOrDefault(a => a.ActualAwnser == "The Azure CLI");

                db.Add(question37);

                var question38 = new Question
                {
                    ActualQuestion = "You're a developer who needs to set up your first VM to host a process that runs nightly. Which of the following tools is your best choice?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ38 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "ARM templates"},
                        new Awnser{ActualAwnser = "Azure PowerShell"},
                        new Awnser{ActualAwnser = "The Azure portal"},
                        new Awnser{ActualAwnser = "The Azure CLI"},
                };
                db.Awnsers.AddRange(AwnsersOfQ38);

                question38.Awnsers = AwnsersOfQ38;
                question38.CorrectAwnser = AwnsersOfQ38.FirstOrDefault(a => a.ActualAwnser == "The Azure portal");

                db.Add(question38);

                var question39 = new Question
                {
                    ActualQuestion = "What is the best infrastructure-as-code option for quickly and reliably setting up your entire cloud infrastructure declaratively?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ39 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "ARM templates"},
                        new Awnser{ActualAwnser = "Azure PowerShell"},
                        new Awnser{ActualAwnser = "The Azure portal"},
                        new Awnser{ActualAwnser = "The Azure CLI"},
                };
                db.Awnsers.AddRange(AwnsersOfQ39);

                question39.Awnsers = AwnsersOfQ39;
                question39.CorrectAwnser = AwnsersOfQ39.FirstOrDefault(a => a.ActualAwnser == "ARM templates");

                db.Add(question39);

                var question40 = new Question
                {
                    ActualQuestion = "You want to be alerted when new recommendations to improve your cloud environment are available. Which service will do this?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ40 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Advisor"},
                        new Awnser{ActualAwnser = "Azure Monitor"},
                        new Awnser{ActualAwnser = "Azure Service Health"},
                };
                db.Awnsers.AddRange(AwnsersOfQ40);

                question40.Awnsers = AwnsersOfQ40;
                question40.CorrectAwnser = AwnsersOfQ40.FirstOrDefault(a => a.ActualAwnser == "Azure Advisor");

                db.Add(question40);

                var question41 = new Question
                {
                    ActualQuestion = "Which service provides official outage root cause analyses (RCAs) for Azure incidents?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ41 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Advisor"},
                        new Awnser{ActualAwnser = "Azure Monitor"},
                        new Awnser{ActualAwnser = "Azure Service Health"},
                };
                db.Awnsers.AddRange(AwnsersOfQ41);

                question41.Awnsers = AwnsersOfQ41;
                question41.CorrectAwnser = AwnsersOfQ41.FirstOrDefault(a => a.ActualAwnser == "Azure Service Health");

                db.Add(question41);

                var question42 = new Question
                {
                    ActualQuestion = "Which service is a platform that powers Application Insights, monitoring for VMs, containers, and Kubernetes?",
                    Chapter = ChapterEnum.Azure_Core_Solutions_and_Management_tools,
                };

                var AwnsersOfQ42 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Advisor"},
                        new Awnser{ActualAwnser = "Azure Monitor"},
                        new Awnser{ActualAwnser = "Azure Service Health"},
                };
                db.Awnsers.AddRange(AwnsersOfQ42);

                question42.Awnsers = AwnsersOfQ42;
                question42.CorrectAwnser = AwnsersOfQ42.FirstOrDefault(a => a.ActualAwnser == "Azure Monitor");

                db.Add(question42);

                db.SaveChanges();
            }
        }
    }
}

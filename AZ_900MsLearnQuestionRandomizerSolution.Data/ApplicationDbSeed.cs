using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;

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
                    ActualQuestion = "A company wants to quickly manage its individual IoT devices by using a web-based user interface. Which IoT technology should it choose?",
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
                question29.CorrectAwnser = AwnsersOfQ29.FirstOrDefault(a => a.ActualAwnser == "Azure Cognitive Services");

                db.Add(question29);

                var question30 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nHow can Tailwind Traders enforce having only certain applications run on its VMs?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AwnsersOfQ30 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Connect your VMs to Azure Sentinel."},
                        new Awnser{ActualAwnser = "Create an application control rule in Azure Security Center."},
                        new Awnser{ActualAwnser = "Periodically run a script that lists the running processes on each VM. The IT manager can then shut down any applications that shouldn't be running."},
                };
                db.Awnsers.AddRange(AwnsersOfQ30);

                question30.Awnsers = AwnsersOfQ30;
                question30.CorrectAwnser = AwnsersOfQ30.FirstOrDefault(a => a.ActualAwnser == "Create an application control rule in Azure Security Center.");

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

                var question43 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nWhat's the easiest way for Tailwind Traders to combine security data from all of its monitoring tools into a single report that it can take action on?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AwnsersOfQ43 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Collect security data in Azure Sentinel."},
                        new Awnser{ActualAwnser = "Build a custom tool that collects security data, and displays a report through a web application."},
                        new Awnser{ActualAwnser = "Look through each security log daily and email a summary to your team."},
                };
                db.Awnsers.AddRange(AwnsersOfQ43);

                question43.Awnsers = AwnsersOfQ43;
                question43.CorrectAwnser = AwnsersOfQ43.FirstOrDefault(a => a.ActualAwnser == "Collect security data in Azure Sentinel.");

                db.Add(question43);

                var question44 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nWhich is the best way for Tailwind Traders to safely store its certificates so that they're accessible to cloud VMs?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AwnsersOfQ44 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Place the certificates on a network share."},
                        new Awnser{ActualAwnser = "Store them on a VM that's protected by a password."},
                        new Awnser{ActualAwnser = "Store the certificates in Azure Key Vault."},
                };
                db.Awnsers.AddRange(AwnsersOfQ44);

                question44.Awnsers = AwnsersOfQ44;
                question44.CorrectAwnser = AwnsersOfQ44.FirstOrDefault(a => a.ActualAwnser == "Store the certificates in Azure Key Vault.");

                db.Add(question44);

                var question45 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system from its datacenter to the cloud. The payment system consists of virtual machines (VMs) and SQL Server databases." +
                                     "\nHere are a few security requirements that the company identifies as it plans the migration:" + "\nIt wants to ensure a good security posture across all of its systems, both on Azure and on - premises." +
                                     "\nIn the datacenter, access to VMs requires a TLS certificate.The company needs a place to safely store and manage its certificates." + "\nHere are some additional requirements that relate to regulatory compliance:" +
                                     "\nTailwind Traders must store certain customer data on-premises, in its datacenter." +
                                     "\nFor certain workloads, the company must be the only customer running VMs on the physical hardware." +
                                     "\nThe company must only run approved business applications on each VM." + "\n On Azure, Tailwind Traders will use both standard VMs and VMs that run on dedicated physical hardware." +
                                     "\nIn the datacenter, the company will run VMs that can connect to databases within its internal network." +
                                     "\n\nHow can Tailwind Traders ensure that certain VM workloads are physically isolated from workloads being run by other Azure customers?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };

                var AwnsersOfQ45 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Configure the network to ensure that VMs on the same physical host are isolated."},
                        new Awnser{ActualAwnser = "This is not possible. These workloads need to be run on-premises."},
                        new Awnser{ActualAwnser = "Run the VMs on Azure Dedicated Host."},
                };
                db.Awnsers.AddRange(AwnsersOfQ45);

                question45.Awnsers = AwnsersOfQ45;
                question45.CorrectAwnser = AwnsersOfQ45.FirstOrDefault(a => a.ActualAwnser == "Store the certificates in Azure Key Vault.");

                db.Add(question45);

                var question46 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nAn attacker can bring down your website by sending a large volume of network traffic to your servers."+
                                     "\nWhich Azure service can help Tailwind Traders protect its App Service instance from this kind of attack?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AwnsersOfQ46 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Azure Firewall"},
                        new Awnser{ActualAwnser = "Network security groups"},
                        new Awnser{ActualAwnser = "Azure DDoS Protection"},
                };
                db.Awnsers.AddRange(AwnsersOfQ46);

                question46.Awnsers = AwnsersOfQ46;
                question46.CorrectAwnser = AwnsersOfQ46.FirstOrDefault(a => a.ActualAwnser == "Azure DDoS Protection");

                db.Add(question46);

                var question47 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nWhat's the best way for Tailwind Traders to limit all outbound traffic from VMs to known hosts?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AwnsersOfQ47 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Configure Azure DDoS Protection to limit network access to trusted ports and hosts."},
                        new Awnser{ActualAwnser = "Create application rules in Azure Firewall."},
                        new Awnser{ActualAwnser = "Ensure that all running applications communicate with only trusted ports and hosts."},
                };
                db.Awnsers.AddRange(AwnsersOfQ47);

                question47.Awnsers = AwnsersOfQ47;
                question47.CorrectAwnser = AwnsersOfQ47.FirstOrDefault(a => a.ActualAwnser == "Create application rules in Azure Firewall.");

                db.Add(question47);

                var question48 = new Question
                {
                    ActualQuestion = "Tailwind Traders is moving its online payment system to Azure. The processing of online orders begins through a website," +
                                     "\nwhich Tailwind Traders manages through Azure App Service. (App Service is a way to host web applications on Azure.)" +
                                     "\nThe web application that runs the website passes order information to virtual machines(VMs)," +
                                     "\nwhich further process each order.These VMs exist on an Azure virtual network," +
                                     "\nbut they need to access the internet to retrieve software packages and system updates." +
                                     "\nThe security team wants to ensure that only valid network traffic reaches the company's Azure resources." +
                                     "\nAs an extra layer of defense, the team also wants to ensure that the VMs can reach only trusted hosts on specific ports." +
                                     "\n\nHow can Tailwind Traders most easily implement a deny by default policy so that VMs can't connect to each other?",
                    Chapter = ChapterEnum.General_Security_and_Network_security,
                };
                var AwnsersOfQ48 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Allocate each VM on its own virtual network."},
                        new Awnser{ActualAwnser = "Create a network security group rule that prevents access from another VM on the same network."},
                        new Awnser{ActualAwnser = "Configure Azure DDoS Protection to limit network access within the virtual network."},
                };
                db.Awnsers.AddRange(AwnsersOfQ48);

                question48.Awnsers = AwnsersOfQ48;
                question48.CorrectAwnser = AwnsersOfQ48.FirstOrDefault(a => a.ActualAwnser == "Create a network security group rule that prevents access from another VM on the same network.");

                db.Add(question48);

                var question49 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department ensure that employees at the company's retail stores can access company applications only from approved tablet devices?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ49 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "SSO"},
                        new Awnser{ActualAwnser = "Conditional Access"},
                        new Awnser{ActualAwnser = "Multifactor authentication"},
                };
                db.Awnsers.AddRange(AwnsersOfQ49);

                question49.Awnsers = AwnsersOfQ49;
                question49.CorrectAwnser = AwnsersOfQ49.FirstOrDefault(a => a.ActualAwnser == "Conditional Access");

                db.Add(question49);

                var question50 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department use biometric properties, such as facial recognition, to enable delivery drivers to prove their identities?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ50 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "SSO"},
                        new Awnser{ActualAwnser = "Conditional Access"},
                        new Awnser{ActualAwnser = "Multifactor authentication"},
                };
                db.Awnsers.AddRange(AwnsersOfQ50);

                question50.Awnsers = AwnsersOfQ50;
                question50.CorrectAwnser = AwnsersOfQ50.FirstOrDefault(a => a.ActualAwnser == "Multifactor authentication");

                db.Add(question50);

                var question51 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, recall that retail employees are issued tablet devices from which they can track orders and plan their work schedules." +
                                    "\nTailwind Traders also allows delivery drivers to use their own mobile devices to access scheduling and logistics applications." +
                                    "\nA stolen password might allow unauthorized access to company and customer data." +
                                    "\nTailwind Traders wants to extend its investments in Active Directory to secure all of its applications," +
                                    "\n when accessed both from the intranet and from public networks." +
                                    "\nThe company is looking into how Azure Active Directory (Azure AD), single sign-on (SSO), multifactor authentication," +
                                    "\nand Conditional Access can help it achieve those goals." +
                                    "\n\nHow can the IT department reduce the number of times users must authenticate to access multiple applications?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ51 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "SSO"},
                        new Awnser{ActualAwnser = "Conditional Access"},
                        new Awnser{ActualAwnser = "Multifactor authentication"},
                };
                db.Awnsers.AddRange(AwnsersOfQ51);

                question51.Awnsers = AwnsersOfQ51;
                question51.CorrectAwnser = AwnsersOfQ51.FirstOrDefault(a => a.ActualAwnser == "SSO");

                db.Add(question51);

                var question52 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nHow can Tailwind Traders allow some users to control the virtual machines in each environment but prevent them from modifying networking and other resources in the same resource group or Azure subscription?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ52 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Create a role assignment through Azure role-based access control (Azure RBAC)."},
                        new Awnser{ActualAwnser = "Create a policy in Azure Policy that audits resource usage."},
                        new Awnser{ActualAwnser = "Split the environment into separate resource groups."},
                };
                db.Awnsers.AddRange(AwnsersOfQ52);

                question52.Awnsers = AwnsersOfQ52;
                question52.CorrectAwnser = AwnsersOfQ52.FirstOrDefault(a => a.ActualAwnser == "Create a role assignment through Azure role-based access control (Azure RBAC).");

                db.Add(question52);

                var question53 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nWhich is the best way for Tailwind Traders to ensure that the team deploys only cost-effective virtual machine SKU sizes?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ53 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Create a policy in Azure Policy that specifies the allowed SKU sizes."},
                        new Awnser{ActualAwnser = "Periodically inspect the deployment manually to see which SKU sizes are used."},
                        new Awnser{ActualAwnser = "Create an Azure RBAC role that defines the allowed virtual machine SKU sizes."},
                };
                db.Awnsers.AddRange(AwnsersOfQ53);

                question53.Awnsers = AwnsersOfQ53;
                question53.CorrectAwnser = AwnsersOfQ53.FirstOrDefault(a => a.ActualAwnser == "Create a policy in Azure Policy that specifies the allowed SKU sizes.");

                db.Add(question53);

                var question54 = new Question
                {
                    ActualQuestion = "Tailwind Traders has created environments for development and testing for its e-commerce system." +
                                    "\nAlthough the development and test teams report to different departments, " +
                                    "\nboth environments exist under the same Azure subscription." +
                                    "\nThe IT manager wants to implement governance controls to help ensure that only authorized users can access these systems. " +
                                    "\nHaving these controls in place will also help them track and manage operating costs." +
                                    "\n\nWhich is likely the best way for Tailwind Traders to identify which billing department each Azure resource belongs to?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ54 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Track resource usage in a spreadsheet."},
                        new Awnser{ActualAwnser = "Split the deployment into separate Azure subscriptions, where each subscription belongs to its own billing department."},
                        new Awnser{ActualAwnser = "Apply a tag to each resource that includes the associated billing department."},
                };
                db.Awnsers.AddRange(AwnsersOfQ54);

                question54.Awnsers = AwnsersOfQ54;
                question54.CorrectAwnser = AwnsersOfQ54.FirstOrDefault(a => a.ActualAwnser == "Apply a tag to each resource that includes the associated billing department.");

                db.Add(question54);

                var question55 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                    "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                    "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                    "\n\nWhere can the team access details about the personal data Microsoft processes and how the company processes it, including for Cortana?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ55 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Microsoft Privacy Statement"},
                        new Awnser{ActualAwnser = "The Azure compliance documentation"},
                        new Awnser{ActualAwnser = "Microsoft compliance offerings"},
                };
                db.Awnsers.AddRange(AwnsersOfQ55);

                question55.Awnsers = AwnsersOfQ55;
                question55.CorrectAwnser = AwnsersOfQ55.FirstOrDefault(a => a.ActualAwnser == "Microsoft Privacy Statement");

                db.Add(question55);

                var question56 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                   "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                   "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                   "\n\nWhere can the legal team access information around how the Microsoft cloud helps them secure sensitive data and comply with applicable laws and regulations?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ56 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Microsoft Privacy Statement"},
                        new Awnser{ActualAwnser = "Trust Center"},
                        new Awnser{ActualAwnser = "Online Services Terms"},
                };
                db.Awnsers.AddRange(AwnsersOfQ56);

                question56.Awnsers = AwnsersOfQ56;
                question56.CorrectAwnser = AwnsersOfQ56.FirstOrDefault(a => a.ActualAwnser == "Trust Center");

                db.Add(question56);

                var question57 = new Question
                {
                    ActualQuestion = "At Tailwind Traders, the legal and IT departments want to better understand how Microsoft handles personal data." +
                                   "\nThey also want to better understand how Azure services can help them meet their compliance goals." +
                                   "\nTheir needs go beyond just Azure. For example, applications in their retail stores use Cortana to help store employees quickly locate items." +
                                   "\n\nWhere can the IT department find reference blueprints that it can apply directly to its Azure subscriptions?",
                    Chapter = ChapterEnum.Identity_Governance_Privacy_and_Compliance_Features,
                };
                var AwnsersOfQ57 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Online Services Terms"},
                        new Awnser{ActualAwnser = "Azure compliance documentation"},
                        new Awnser{ActualAwnser = "Microsoft Privacy Statement"},
                };
                db.Awnsers.AddRange(AwnsersOfQ57);

                question57.Awnsers = AwnsersOfQ57;
                question57.CorrectAwnser = AwnsersOfQ57.FirstOrDefault(a => a.ActualAwnser == "Azure compliance documentation");

                db.Add(question57);

                var question58 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhich is the best first step the team should take to compare the cost of running these environments on Azure versus in their datacenter?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ58 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "They're just test environments. Spin them up and check the bill at the end of the month."},
                        new Awnser{ActualAwnser = "Assume that running in the cloud costs about the same as running in the datacenter."},
                        new Awnser{ActualAwnser = "Run the Total Cost of Ownership Calculator."},
                };
                db.Awnsers.AddRange(AwnsersOfQ58);

                question58.Awnsers = AwnsersOfQ58;
                question58.CorrectAwnser = AwnsersOfQ58.FirstOrDefault(a => a.ActualAwnser == "Run the Total Cost of Ownership Calculator.");

                db.Add(question58);

                var question59 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhat's the best way to ensure that the development team doesn't provision too many virtual machines at the same time?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ59 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Do nothing. Let the development team use what they need."},
                        new Awnser{ActualAwnser = "Apply spending limits to the development team's Azure subscription."},
                        new Awnser{ActualAwnser = "Verbally give the development lead a budget and hold them accountable for overages."},
                };
                db.Awnsers.AddRange(AwnsersOfQ59);

                question59.Awnsers = AwnsersOfQ59;
                question59.CorrectAwnser = AwnsersOfQ59.FirstOrDefault(a => a.ActualAwnser == "Apply spending limits to the development team's Azure subscription.");

                db.Add(question59);

                var question60 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                   "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                   "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                   "\nBecause developers can't always run the entire service from their local development environment," +
                                   "\nthe Dev environment is the first place where everything the app needs comes together." +
                                   "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                   "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                   "\nor breaks to existing features, happen as new features are added." +
                                   "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                   "\n\nWhich is the most efficient way for the testing team to save costs on virtual machines on weekends, when testers are not at work?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ60 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Delete the virtual machines before the weekend and create a new set the following week."},
                        new Awnser{ActualAwnser = "Deallocate virtual machines when they're not in use."},
                        new Awnser{ActualAwnser = "Just let everything run. Azure bills you only for the CPU time that you use."},
                };
                db.Awnsers.AddRange(AwnsersOfQ60);

                question60.Awnsers = AwnsersOfQ60;
                question60.CorrectAwnser = AwnsersOfQ60.FirstOrDefault(a => a.ActualAwnser == "Deallocate virtual machines when they're not in use.");

                db.Add(question60);

                var question61 = new Question
                {
                    ActualQuestion = "Before they migrate their existing e-commerce system from their datacenter to production environments on Azure," +
                                  "\nthe Tailwind Traders team wants to first set up environments for development and testing." +
                                  "\nAn e-commerce system might require a website, the products database, a payment system, and so on." +
                                  "\nBecause developers can't always run the entire service from their local development environment," +
                                  "\nthe Dev environment is the first place where everything the app needs comes together." +
                                  "\nAfter the development team verifies changes to the Dev environment, they promote changes to the Test environment." +
                                  "\nThe Test environment is where the testing team verifies new app features and also verifies that no regressions," +
                                  "\nor breaks to existing features, happen as new features are added." +
                                  "\nThe team will map each component in their existing infrastructure to the appropriate Azure service." +
                                  "\n\nResources in the Dev and Test environments are each paid for by different departments. What's the best way to categorize costs by department?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ61 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Apply a tag to each virtual machine that identifies the appropriate billing department."},
                        new Awnser{ActualAwnser = "Split the cost evenly between departments."},
                        new Awnser{ActualAwnser = "Keep a spreadsheet that lists each team's resources."},
                };
                db.Awnsers.AddRange(AwnsersOfQ61);

                question61.Awnsers = AwnsersOfQ61;
                question61.CorrectAwnser = AwnsersOfQ61.FirstOrDefault(a => a.ActualAwnser == "Apply a tag to each virtual machine that identifies the appropriate billing department.");

                db.Add(question61);

                var question62 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\nyou can access SLAs from : https://azure.microsoft.com/nl-nl/support/legal/sla/" +
                                  "\n\nWhat's the SLA for Azure Maps in terms of guaranteed uptime?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ62 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "99 percent"},
                        new Awnser{ActualAwnser = "99.9 percent"},
                        new Awnser{ActualAwnser = "99.99 percent"},
                };
                db.Awnsers.AddRange(AwnsersOfQ62);

                question62.Awnsers = AwnsersOfQ62;
                question62.CorrectAwnser = AwnsersOfQ62.FirstOrDefault(a => a.ActualAwnser == "99.9 percent");

                db.Add(question62);

                var question63 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\nyou can access SLAs from : https://azure.microsoft.com/nl-nl/support/legal/sla/" +
                                  "\n\nWhat's the new composite SLA? Remember, the new SLA includes a third virtual machine and Azure Maps.",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ63 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "99.58 percent"},
                        new Awnser{ActualAwnser = "99.78 percent"},
                        new Awnser{ActualAwnser = "99.99 percent"},
                };
                db.Awnsers.AddRange(AwnsersOfQ63);

                question63.Awnsers = AwnsersOfQ63;
                question63.CorrectAwnser = AwnsersOfQ63.FirstOrDefault(a => a.ActualAwnser == "99.58 percent");

                db.Add(question63);

                var question64 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\n\nAdding a third virtual machine reduces the composite SLA. How can Tailwind Traders offset this reduction?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ64 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "Increase the size of each virtual machine."},
                        new Awnser{ActualAwnser = "Deploy extra instances of the same virtual machines across the different availability zones in the same Azure region."},
                        new Awnser{ActualAwnser = "Do nothing. Using Azure Load Balancer increases the SLA for virtual machines."},
                };
                db.Awnsers.AddRange(AwnsersOfQ64);

                question64.Awnsers = AwnsersOfQ64;
                question64.CorrectAwnser = AwnsersOfQ64.FirstOrDefault(a => a.ActualAwnser == "Deploy extra instances of the same virtual machines across the different availability zones in the same Azure region.");

                db.Add(question64);

                var question65 = new Question
                {
                    ActualQuestion = "Tailwind Traders' Special Orders application includes two virtual machines, Azure Load Balancer, and Azure SQL Database." +
                                  "\nHere's the service-level agreement (SLA) for each service:" +
                                  "\nAzure Virtual Machines :       	99.9 percent" +
                                  "\nAzure SQL Database	:             99.99 percent" +
                                  "\nAzure Load Balancer :             99.99 percent" +
                                  "\nTo compute the composite SLA for a set of services, you multiply the SLA of each individual service. Recall that the existing composite SLA is:" +
                                  "\n\n99.9% X 99.9% X 99.99% X 99.99% = 99.78% " +
                                  "\n\nThe team wants to add a mapping feature so that it can calculate routes between nearby suppliers and each retail store. For that, the team will use Azure Maps." +
                                  "\nThe team also needs more processing power to keep up with demand. For that, it will add a third virtual machine to the pool." +
                                  "\nTailwind Traders is also considering using an augmented reality service in the Special Orders app to help customers visualize their customizations." +
                                  "\nThis Azure service is currently in the public preview phase." +
                                  "\n\nWhat approach might the company take in adding the augmented reality (AR) preview service to its architecture?",
                    Chapter = ChapterEnum.Azure_Cost_Management_and_service_Level_Agreements,
                };
                var AwnsersOfQ65 = new List<Awnser>()
                {
                        new Awnser{ActualAwnser = "The Special Orders app is already in production. The company shouldn't look into the AR service until the service reaches general availability (GA)."},
                        new Awnser{ActualAwnser = "The Special Orders app is mainly for use by retail employees. The company can integrate the AR service now because potential downtime or failures aren't an important factor."},
                        new Awnser{ActualAwnser = "The development team can create a prototype version of the app that includes the AR service that it tests out with select retail employees."},
                };
                db.Awnsers.AddRange(AwnsersOfQ65);

                question65.Awnsers = AwnsersOfQ65;
                question65.CorrectAwnser = AwnsersOfQ65.FirstOrDefault(a => a.ActualAwnser == "The development team can create a prototype version of the app that includes the AR service that it tests out with select retail employees.");

                db.Add(question65);

                db.SaveChanges();
            }
        }
    }
}

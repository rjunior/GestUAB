using Raven.Client;
using Raven.Client.Embedded;
using System.Linq;
using GestUAB.Models;
using Raven.Abstractions.Indexing;
using Raven.Client.Indexes;
using System;

namespace GestUAB
{
    public static partial class PopulateDatabaseExtensions
    {
        public static void PopulateMemorandum (this IDocumentStore ds)
        {


            using (var session = ds.OpenSession()) {
                // Operations against session
                session.Store (new Memorandum{
                    Observation = "First Travel Test",
                    Destiny = "Neverland",
                    StartDate = DateTime.Now,
                    FinishDate = DateTime.Now.AddDays(10),
                    RequesterName = "Hild",
                    BankAccount = "0123456",
                    CovenantNumber = "123asd",
                    Type = 0
                });
                session.Store (new Memorandum{
                    Observation = "Second Travel Test",
                    Destiny = "Neverland",
                    StartDate = DateTime.Now,
                    FinishDate = DateTime.Now.AddDays(10),
                    RequesterName = "Hild",
                    BankAccount = "0123456",
                    CovenantNumber = "123asd",
                    Type = 0
                });
                //session.Store (new Memorandum{Name = "Geografia"});
                // Flush those changes
                session.SaveChanges ();
            }

<<<<<<< HEAD
            ds.DatabaseCommands.PutIndex("MemorandumById", new IndexDefinitionBuilder<Course>
=======
            ds.DatabaseCommands.PutIndex("MemorandumById", new IndexDefinitionBuilder<Memorandum>
>>>>>>> 4ecf3330985035e0b554cac0c1da3926a12adea3
            {
                Map = memorandums => from memorandum in memorandums
                               select new { memorandum.Id },
                Indexes =
                    {
                        { x => x.Id, FieldIndexing.Analyzed}
                    }
            });
        }
    }
}

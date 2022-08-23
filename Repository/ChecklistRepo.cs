using AuditChecklistModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistModule.Repository
{
    public class ChecklistRepo : IChecklistRepo
    {
        
        readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ChecklistRepo));

        private AuditChecklistContext _auditChecklist = new AuditChecklistContext();
       


        public List<Questions> GetQuestions(string auditType)
        {
            try
            {
                _log4net.Info("Log from " + nameof(ChecklistRepo));
                List<Questions> listOfQuestions = new List<Questions>();

                if (auditType == "Internal")
                    listOfQuestions = _auditChecklist.Questions.ToList();

                return listOfQuestions;
            }
            catch (Exception e)
            {
                _log4net.Error("Exception " + e.Message + nameof(ChecklistRepo));
                return null;

            }

        }

    }
}

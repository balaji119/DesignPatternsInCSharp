using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Template
{
    public abstract class Task
    {
        private AuditTrial auditTrial;
        public Task()
        {
            auditTrial = new AuditTrial();
        }

        public Task(AuditTrial auditTrial)
        {
            this.auditTrial = auditTrial;
        }

        public void Execute()
        {
            auditTrial.Record();
            doExecute();
        }

        protected abstract void doExecute();
    }
}

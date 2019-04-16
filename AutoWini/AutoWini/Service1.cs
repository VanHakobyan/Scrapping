using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoWini
{
    public partial class Service1 : ServiceBase
    {
        private Task _task;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Parser parser = new Parser();
            _task = Task.Run(() => parser.GetAndAnalyzeData());
        }

        protected override void OnStop()
        {
            _task.Dispose();
        }

        public void TestStartupAndStop(string [] args)
        {
            Parser parser = new Parser();
            parser.GetAndAnalyzeData();
        }
    }
}

using OsobyApp.Repository.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OsobyApp.Service
{
    public class Services
    {
        // singleton OsobyService
        private static OsobyService osobyService;

        public static OsobyService OsobyService
        {
            get
            {
                if (osobyService == null)
                {
                    osobyService = new OsobyService(new OsobyRepository());
                }
                return osobyService;
            }
            set
            {
                osobyService = value;
            }
        }
    }
}

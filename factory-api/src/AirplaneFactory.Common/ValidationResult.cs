using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneFactory.Common
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; set; }

        public bool IsValid
        {
            get
            {
                return Errors.Count == 0;
            }
        }

        public void Add(string error)
        {
            if (Errors.Any(x => x == error)) return;
            Errors.Add(error);
        }

    }
}

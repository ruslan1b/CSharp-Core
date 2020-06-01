using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task7_1
    {
        public void AnnType()
        {
            var student = new
            {
                Id = 1,
                FirstName = "Jonn",
                LastName = "Lenon",
                Lists = new List<string> {                    }

            };
        }
    }
}

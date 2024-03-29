﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public abstract void AddGrade(float grade);
        public abstract IEnumerator GetEnumerator();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be null or empty.");
                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    NameChanged(this, args);
                }
                _name = value;

            }
        }

        public object Current => throw new NotImplementedException();

        public event NameChangedDelegat NameChanged;
        protected string _name;
    }
}

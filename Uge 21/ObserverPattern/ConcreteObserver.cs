﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        public int State { get; set; } = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            this.State = subject.State;
        }
    }
}

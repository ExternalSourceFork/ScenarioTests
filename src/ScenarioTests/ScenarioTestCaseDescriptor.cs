﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioTests
{
    public readonly struct ScenarioTestCaseDescriptor
    {
        public ScenarioTestCaseDescriptor(string name, object? argument, ScenarioTestCaseFlags flags, Func<Task> invocation)
        {
            Name = name;
            Argument = argument;
            Flags = flags;
            Invocation = invocation;
        }

        public string Name { get; }
        public object? Argument { get; }
        public ScenarioTestCaseFlags Flags { get; }
        public Func<Task> Invocation { get; }
    }
}

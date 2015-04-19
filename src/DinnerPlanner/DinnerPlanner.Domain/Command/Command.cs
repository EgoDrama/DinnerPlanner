﻿using System;

namespace DinnerPlanner.Domain.Command
{
    public abstract class Command : ICommand
    {
        protected Command(Guid id, int version)
        {
            Id = id;
            Version = version;
        }

        public Guid Id { get; private set; }
        public int Version { get; private set; }
    }
}
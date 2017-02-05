using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Commands
{
    public enum CommandResultEnum { Succes, Error }

    public class CommandResult
    {
        public string OutcomeMessage { get; set; }
        public CommandResultEnum ResultType { get; set; }

        public CommandResult(string message, CommandResultEnum result)
        {
            OutcomeMessage = message;
            ResultType = result;
        }
    }
}
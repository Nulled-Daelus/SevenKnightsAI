using System;

namespace SevenKnightsAI.Classes
{
    internal class AISettingsException : Exception
    {
        public AISettingsException()
        { }

        public AISettingsException(string message, int code) : base(message)
        {
            this.ErrorCode = code;
        }

        public AISettingsException(string message, Exception inner, int code) : base(message, inner)
        {
            this.ErrorCode = code;
        }

        public int ErrorCode;
    }
}
using System;
using System.Drawing;

namespace SevenKnightsAI.Classes
{
	internal class ProgressArgs
	{
		public ProgressArgs(ProgressType type, object message) : this(type, message, Color.Black)
		{ }

		public ProgressArgs(ProgressType type, object message, Color color)
		{
			this.Type = type;
			this.Message = message;
			this.Color = color;
		}

        public Color Color
		{
			get;
			private set;
		}

		public object Message
		{
			get;
			private set;
		}

		public ProgressType Type
		{
			get;
			private set;
		}
	}
}

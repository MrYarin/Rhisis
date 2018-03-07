using System;

namespace Rhisis.World.Systems.Events.Trade
{
    public class TradeEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the <see cref="TradeActionType"/> action type to execute.
        /// </summary>
        public TradeActionType ActionType { get; }

        /// <summary>
        /// Gets the <see cref="TradeActionType"/> optional arguments.
        /// </summary>
        public object[] Arguments { get; }

        /// <summary>
        /// Creates a new <see cref="TradeActionType"/> instance.
        /// </summary>
        /// <param name="type">Action type to execute</param>
        /// <param name="args">Optional arguments</param>
        public TradeEventArgs(TradeActionType type, params object[] args)
        {
            this.ActionType = type;
            this.Arguments = args;
        }
    }
}
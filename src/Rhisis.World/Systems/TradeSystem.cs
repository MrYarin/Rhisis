using Microsoft.Extensions.Logging;
using Rhisis.Core.IO;
using Rhisis.World.Game.Core;
using Rhisis.World.Game.Core.Interfaces;
using Rhisis.World.Game.Entities;
using Rhisis.World.Systems.Events.Trade;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Rhisis.World.Systems
{
    internal sealed class TradeSystem : NotifiableSystemBase
    {
        /// <summary>
        /// Gets the <see cref="TradeSystem"/> match filter.
        /// </summary>
        protected override Expression<Func<IEntity, bool>> Filter => x => x.Type == WorldEntityType.Player;

        public TradeSystem(IContext context) :
            base(context)
        {
        }

        /// <summary>
        /// Executes the <see cref="TradeSystem"/> logic.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="e"></param>
        public override void Execute(IEntity entity, EventArgs e)
        {
            if (!(e is TradeEventArgs tradeEvent))
                return;

            var playerEntity = entity as IPlayerEntity;

            Logger.Debug("Execute statistics action: {0}", tradeEvent.ActionType.ToString());

            switch (tradeEvent.ActionType)
            {
                case TradeActionType.Unknown:
                    // Nothing to do.
                    break;
                default:
                    Logger.Warning("Unknown trade action type: {0} for player {1} ",
                        tradeEvent.ActionType.ToString(), entity.ObjectComponent.Name);
                    break;
            }
        }
    }
}

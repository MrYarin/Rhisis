﻿using Ether.Network.Common;
using Rhisis.World.Game.Components;
using Rhisis.World.Game.Core.Interfaces;

namespace Rhisis.World.Game.Entities
{
    public interface IPlayerEntity : IEntity, IMovableEntity
    {
        HumanComponent HumanComponent { get; set; }

        PlayerComponent PlayerComponent { get; set; }

        ItemContainerComponent Inventory { get; set; }

        StatisticsComponent StatisticsComponent { get; set; }
        
        NetUser Connection { get; set; }
    }
}

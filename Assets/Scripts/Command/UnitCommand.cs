using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Command.Player;

namespace Command
{
    public abstract class UnitCommand : ICommand
    {
        protected UnitController actorUnit;
        protected UnitController targetUnit;

        public CommandData commandData;

        public abstract void Execute();
        public abstract void Undo();
        public abstract bool WillHitTarget();
        
        public void SetActorUnit(UnitController actorUnit) => this.actorUnit = actorUnit;

        public void SetTargetUnit(UnitController targetUnit) => this.targetUnit = targetUnit;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace xlj
{
    public class Attack : State<EnemyTank>
    {
        public override void Enter(EnemyTank entity_type)
        {
            Vector3 targetPos = entity_type.Gettarget().transform.position;
            path.InitByNavMeshPath(transform.position, targetPos);
        }
        public override void Execute(EnemyTank entity_type)
        {
            
        }
        public override void Exit(EnemyTank entity_type)
        {
            
        }
    }
    public class Patrol : State<EnemyTank>
    {
        public override void Enter(EnemyTank entity_type)
        {

        }
        public override void Execute(EnemyTank entity_type)
        {

        }
        public override void Exit(EnemyTank entity_type)
        {

        }

    }
}

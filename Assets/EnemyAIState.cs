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
            Vector3 targetPos = EnemyTank.m_target.transform.position;
            entity_type.m_path.InitByNavMeshPath(entity_type.transform.position, targetPos);
        }
        public override void Execute(EnemyTank entity_type)
        {
            if (EnemyTank.m_target == null)
                entity_type.GetFSM().ChangeState(Singleton<Patrol>.Instance);
            //更新巡逻点
            float interval = Time.time - entity_type.m_lastUpdateWaypointTime;
            if (interval < entity_type.m_updateWaypointtInterval)
                return;
            entity_type.m_lastUpdateWaypointTime = Time.time;

            Vector3 targetPos = EnemyTank.m_target.transform.position;
            entity_type.m_path.InitByNavMeshPath(entity_type.transform.position, targetPos);
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
            if (EnemyTank.m_target != null)
                entity_type.GetFSM().ChangeState(Singleton<Attack>.Instance);
                //更新巡逻点
                float interval = Time.time - entity_type.m_lastUpdateWaypointTime;
            if (interval < entity_type.m_updateWaypointtInterval)
                return;
            entity_type.m_lastUpdateWaypointTime = Time.time;

            if (entity_type.m_path.waypoints == null || entity_type.m_path.isFinish)
            {
                GameObject obj = GameObject.Find("WaypointContainer");
                {
                    int count = obj.transform.childCount;
                    if (count == 0) return;
                    int index = UnityEngine.Random.Range(0, count); 
                    Vector3 targetPos = obj.transform.GetChild(index).position;
                    entity_type.m_path.InitByNavMeshPath(entity_type.transform.position, targetPos);
                }
            }
        }
        public override void Exit(EnemyTank entity_type)
        {

        }

    }
}

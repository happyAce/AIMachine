using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xlj
{
    public class State<T> where T : class
    {
        public virtual void Enter(T entity_type)
        {

        }
        public virtual void Execute(T entity_type)
        {

        }
        public virtual void Exit(T entity_type)
        {


        }
    }
}

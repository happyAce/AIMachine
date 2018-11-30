using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace xlj
{
    public class StateMathine<T> where T : class
    {
        private T m_pOwner;
        private State<T> m_pCurrentState;
        private State<T> m_pPreviousState;
        private State<T> m_pGlobalState;

        public StateMathine(T owner)
        {
            m_pOwner = owner;
            m_pCurrentState = null;
            m_pPreviousState = null;
            m_pGlobalState = null;
        }
        public void SetCurrentState(State<T> s)
        {
            m_pCurrentState = s;
        }
        public void SetPreviousState(State<T> s)
        {
            m_pPreviousState = s;
        }
        public void SetGlobalState(State<T> s)
        {
            m_pGlobalState = s;
        }
        public void update()
        {
            if(m_pGlobalState != null )
            {
                m_pGlobalState.Execute(m_pOwner);
            }
            if(m_pCurrentState != null)
            {
                m_pCurrentState.Execute(m_pOwner);
            }
        }
        public void ChangeState(State<T> pNewState)
        {
            if (pNewState != null)
            {
                m_pPreviousState = m_pCurrentState;
                m_pCurrentState.Exit(m_pOwner);
                m_pCurrentState = pNewState;
                m_pCurrentState.Enter(m_pOwner);
            }
        }
        public void RevertToPreviousState()
        {
            ChangeState(m_pPreviousState);
        }
        public bool isInState(State<T> pNewState)
        {
            return m_pCurrentState.GetType() == pNewState.GetType();
        }
        public State<T> CurrentState()
        {
            return m_pCurrentState;
        }
        public State<T> GlobalState()
        {
            return m_pGlobalState;
        }
        public State<T> PreviousState()
        {
            return m_pPreviousState;
        }     
    }
}

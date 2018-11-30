using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameEntity : MonoBehaviour
{

    private int m_ID;
    private static int m_iNextValidID = 0;
    private void setID(int val)
    {
        m_ID = val;
        m_iNextValidID = m_ID + 1;
    }
    public BaseGameEntity(int id)
    {
        setID(id);
    }
	public int ID()
    {
        return m_ID;
    }
    public virtual void update()
    {

    }
     
}

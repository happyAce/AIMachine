using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameEntity : MonoBehaviour
{
    private int id;
    private string name;
    public int m_id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    public string m_name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public virtual void update()
    {

    }
     
}

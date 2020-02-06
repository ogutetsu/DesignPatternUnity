using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class EggEvent : ScriptableObject
{
    private  List<EggEventListener> elisteners = new List<EggEventListener>();

    public void Register(EggEventListener listener)
    {
        elisteners.Add(listener);
    }

    public void Unregister(EggEventListener listener)
    {
        elisteners.Remove(listener);
    }

    public void Occurred()
    {
        for (int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs();
        }
    }

}

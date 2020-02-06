using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject> { }

public class EggEventListener : MonoBehaviour
{
    public EggEvent gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }

    public void OnEventOccurs(GameObject go)
    {
        response.Invoke(go);
    }

}

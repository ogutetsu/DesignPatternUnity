using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.Events;

public class EggEventListener : MonoBehaviour
{
    public EggEvent gEvent;
    public UnityEvent response;

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }

    public void OnEventOccurs()
    {
        response.Invoke();
    }

}

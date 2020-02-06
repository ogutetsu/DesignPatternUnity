using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg : MonoBehaviour
{
    public EggEvent dropped;

    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        dropped.Occurred(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

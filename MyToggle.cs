
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MyToggle : UdonSharpBehaviour
{
    public GameObject target;
    public GameObject[] targets;
    void Start()
    {
        
    }

    public override void Interact()
    {
        foreach(var x in targets)
        {
            x.SetActive(!x.activeSelf);
        }
        if (target != null)
        {
            target.SetActive(!target.activeSelf);
        }
    }
}

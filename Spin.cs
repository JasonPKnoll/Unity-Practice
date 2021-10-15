
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Spin : UdonSharpBehaviour
{
    public float rotationX = 0f;
    public float rotationY = 0f;
    public float rotationZ = 0f;
    void Start()
    {
        
    }
    private void Update()
    {
        transform.Rotate(new Vector3(rotationX, rotationY, rotationZ) * Time.deltaTime);
    }
}

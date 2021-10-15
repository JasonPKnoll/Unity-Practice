
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerConfig : UdonSharpBehaviour
{
    public float jumpHeight = 3f;
    public float runSpeed = 4f;
    void Start()
    {
        SetDefaults();
    }
    public void SetDefaults() 
    {
        if (Networking.LocalPlayer == null)
        {
            return;
        }
        Networking.LocalPlayer.SetJumpImpulse(jumpHeight);
        Networking.LocalPlayer.SetRunSpeed(runSpeed);
    }
}

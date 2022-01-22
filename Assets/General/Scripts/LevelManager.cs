using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Base Manager of Level.
public abstract class LevelManager
{
    protected PlayerController Controller = null;

    protected LevelManager(PlayerController playerController)
    {
        Controller = playerController;
    }

    public abstract void GotoNext();

    public abstract void PressW();
    public abstract void PressS();
    public abstract void PressA();
    public abstract void PressD();
    public abstract void SetIdle();

    public virtual void PressM() {}
    public virtual void PressingM() {}
    
    public virtual void Turn(float direction) {}
}
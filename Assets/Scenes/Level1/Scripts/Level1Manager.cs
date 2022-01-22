using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Manager of Level1.
public class Level1Manager : LevelManager
{
    public Level1Manager(PlayerController playerController) : base(playerController)
    {
        // Nothing at the present.
    }

    public override void GotoNext()
    {
        // TODO: Enter Level 2.
    }

    public override void PressW()
    {
        // Nothing.
    }

    public override void PressS()
    {
        // Nothing.
    }

    public override void PressA()
    {
        Controller.Move(2);
    }

    public override void PressD()
    {
        Controller.Move(3);
    }

    public override void SetIdle()
    {
        Controller.SetIdle();
    }
}
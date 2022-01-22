using System;

// The Manager of Level2.
public class Level2Manager : LevelManager
{
    public String LastTouched = null;
    
    public Level2Manager(PlayerController playerController) : base(playerController)
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

    public override void PressM()
    {
        Controller.Jump();
    }
}
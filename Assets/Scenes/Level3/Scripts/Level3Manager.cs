// The Manager of Level3.

public class Level3Manager : LevelManager
{
    public Level3Manager(PlayerController playerController) : base(playerController)
    {
        // Nothing at the present.
    }

    public override void GotoNext()
    {
        // TODO: Enter Level 2.
    }

    public override void PressW()
    {
        Controller.Move(0);
    }

    public override void PressS()
    {
        Controller.Move(1);
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
// The Manager of Level5.

public class Level5Manager : LevelManager
{
    private PlayerUniversalController UniversalController;
    public Level5Manager(PlayerController playerController) : base(playerController)
    {
        UniversalController = (PlayerUniversalController)playerController;
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

    public override void Turn(float direction)
    {
        UniversalController.Turn(direction);
    }
}
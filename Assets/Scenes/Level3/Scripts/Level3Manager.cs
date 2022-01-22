using UnityEngine;

// The Manager of Level3.
public class Level3Manager : LevelManager
{
    public DetectDive SecondController;
    
    public Level3Manager(PlayerController playerController) : base(playerController)
    {
        SecondController = playerController.GetComponent<DetectDive>();
    }

    public override void GotoNext()
    {
        // TODO: Enter Level 4.
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
        SecondController.SetIdle();
    }

    public override void PressingM()
    {
        SecondController.Dive();
    }
}
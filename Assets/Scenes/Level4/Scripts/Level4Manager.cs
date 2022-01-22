// The Manager of Level3.

using UnityEngine.SceneManagement;

public class Level4Manager : LevelManager
{
    public InteractThings CurrentInteractItem = null;
    public int WoodNumber = 0;

    public Level4Manager(PlayerController playerController) : base(playerController)
    {
        // Nothing at the present.
    }

    public override void GotoNext()
    {
        // TODO: Enter Level 5.
        SceneManager.LoadScene("Level5");
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
        if (CurrentInteractItem != null)
            CurrentInteractItem.Interact();
    }
}
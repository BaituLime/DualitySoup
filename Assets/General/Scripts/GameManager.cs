using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Only one GameManager.

    public LevelManager CurrentLevelManager { get; private set; }
    private PlayerInput InputEntry;
    private Keyboard TheKeyboard;
    private Mouse TheMouse;
    private bool Controlling;

    private void Awake()
    {
        // Only one GameManager.
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        InputEntry = GetComponent<PlayerInput>();
        TheKeyboard = Keyboard.current;
        TheMouse = Mouse.current;
    }

    private void Update()
    {
        if (CurrentLevelManager == null)
            return;

        Controlling = false;
        if (TheKeyboard.aKey.IsPressed())
        {
            Controlling = true;
            CurrentLevelManager.PressA();
        }
        else if (TheKeyboard.dKey.IsPressed())
        {
            Controlling = true;
            CurrentLevelManager.PressD();
        }
        else if (TheKeyboard.wKey.IsPressed())
        {
            Controlling = true;
            CurrentLevelManager.PressW();
        }
        else if (TheKeyboard.sKey.IsPressed())
        {
            Controlling = true;
            CurrentLevelManager.PressS();
        }
        
        if (TheMouse.leftButton.IsPressed())
        {
            Controlling = true;
            CurrentLevelManager.PressingM();
        }

        if (!Controlling)
            CurrentLevelManager.SetIdle();
    }

    public void RegisterLevelManager(PlayerController mainPlayer, String number)
    {
        if (number == "Level1")
            CurrentLevelManager = new Level1Manager(mainPlayer);
        else if (number == "Level2")
            CurrentLevelManager = new Level2Manager(mainPlayer);
        else if (number == "Level3")
            CurrentLevelManager = new Level3Manager(mainPlayer);
        else if (number == "Level4")
            CurrentLevelManager = new Level3Manager(mainPlayer);

        InputEntry.camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public void PressM(InputAction.CallbackContext callbackContext)
    {
        CurrentLevelManager.PressM();
    }
}
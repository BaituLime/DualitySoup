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
    }

    private void Update()
    {
        if (CurrentLevelManager == null)
            return;
        if(TheKeyboard.aKey.IsPressed())
            CurrentLevelManager.PressA();
        else if (TheKeyboard.dKey.IsPressed())
            CurrentLevelManager.PressD();
        else if (TheKeyboard.wKey.IsPressed())
            CurrentLevelManager.PressW();
        else if (TheKeyboard.sKey.IsPressed())
            CurrentLevelManager.PressS();
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
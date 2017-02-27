﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerUI : NetworkBehaviour {

    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    public Radar radar;

    [SerializeField]
    GameObject respawnScreen;

    public GameObject timer;

    public Image energyBar;
    public Image chargeEnergyBar;
    public Image healthBar;
    public Image comboCounterTimer;
    public Text comboCounterText;
    public static Vector3 playerPos;

    // Android stuff
    [SerializeField]
    public GameObject joystick;
    [SerializeField]
    public GameObject pauseButton;

    void Start()
    {
        NetworkManager.singleton.GetComponent<MatchTimer>().enabled = true;
        OverlayActive.SetOverlayActive(false);
        //PauseMenu.isOn = false;

#if !UNITY_ANDROID
        joystick.SetActive(false);
        pauseButton.SetActive(false);
#endif
    }
	
	// Update is called once per frame
	void Update () 
    {
#if !UNITY_ANDROID
        if (Input.GetKeyDown(KeyBoardBindings.GetPauseKey()))
        {
            TogglePauseMenu();
        }
#endif
	}

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        OverlayActive.SetOverlayActive(!OverlayActive.IsOverlayActive());
        //PauseMenu.isOn = pauseMenu.activeSelf;
    }

    public void ToggleRespawnScreen()
    {
        respawnScreen.SetActive(!respawnScreen.activeSelf);
        OverlayActive.SetOverlayActive(!OverlayActive.IsOverlayActive());
        Debug.Log("toggled");
    }

    public RespawnScreen GetRespawnScreen()
    {
        return respawnScreen.GetComponent<RespawnScreen>();
    }

    public GetMatchTimer GetMatchTimer_()
    {
        return timer.GetComponent<GetMatchTimer>();
    }
}

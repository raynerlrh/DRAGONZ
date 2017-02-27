﻿using UnityEngine;
using System.Collections;

public static class KeyBoardBindings {

    // Move forward key
    public static KeyCode GetForwardKey()
    {
        return (KeyCode)PlayerPrefs.GetInt("ForwardKey", (int)KeyCode.W);
    }
    public static void SetForwardKey(KeyCode key)
    {
        PlayerPrefs.SetInt("ForwardKey", (int)key);
    }

    // Move backward key
    public static KeyCode GetBackwardKey()
    {
        return (KeyCode)PlayerPrefs.GetInt("BackwardKey", (int)KeyCode.S);
    }
    public static void SetBackwardKey(KeyCode key)
    {
        PlayerPrefs.SetInt("BackwardKey", (int)key);
    }

    // Release Fireball key
    public static KeyCode GetAttackKey()
    {
        return (KeyCode)PlayerPrefs.GetInt("AttackKey", (int)KeyCode.Mouse0);
    }
    public static void SetAttackKey(KeyCode key)
    {
        PlayerPrefs.SetInt("AttackKey", (int)key);
    }

    // Release Charged Fireball key
    public static KeyCode GetChargedAttackKey()
    {
        return (KeyCode)PlayerPrefs.GetInt("ChargedAttackKey", (int)KeyCode.Mouse1);
    }
    public static void SetChargedAttackKey(KeyCode key)
    {
        PlayerPrefs.SetInt("ChargedAttackKey", (int)key);
    }

    // Pause key
    public static KeyCode GetPauseKey()
    {
        return (KeyCode)PlayerPrefs.GetInt("PauseKey", (int)KeyCode.Escape);
    }

    public static void SetPauseKey(KeyCode key)
    {
        PlayerPrefs.SetInt("PauseKey", (int)key);
    }

}

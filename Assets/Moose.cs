﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moose : MonoBehaviour
{
    public string playerName2;
    public int playerLegal;

    public Text tellPlayer;
    public Slider mooseColor;
    public Slider mooseSize;
    public Slider mooseRotate;
    public GameObject Mose;
   

    Color32[] Colors;
    private void Awake()
    {
        Colors = new Color32[4];
        Colors[0] = new Color32(185, 0, 185, 255);
        Colors[1] = new Color32(0, 127, 255, 255);
        Colors[2] = new Color32(0, 0, 255, 255);
        Colors[3] = new Color32(0, 255, 255, 255);

        playerName2 = PlayerPrefs.GetString("ThisPlayer", "playerName");
        playerLegal = PlayerPrefs.GetInt("ThisAge");
        tellPlayer.text = "Hi " + playerName2 + " your age is " + playerLegal;
    }

    public void changeColor()
    {
        float newMooseColor = mooseColor.value;
        Mose.GetComponent<SpriteRenderer>().color = Colors[(int)newMooseColor];
    }
    public void changeSize()
    {
        float newMooseSize = mooseSize.value;
        Mose.transform.localScale = new Vector2(newMooseSize, newMooseSize);
    }
    public void changeRotation()
    {
        float mooseRotValue = (mooseRotate.value * 90f) - 45;

        Mose.transform.eulerAngles = new Vector3(0, 0, mooseRotValue);
    }
}

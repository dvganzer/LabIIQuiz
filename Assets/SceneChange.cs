using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public InputField playerHandle;
    public InputField playerAge;
    public string playerName;
    public int myAge; 
    public void setName()
    {
        playerName = playerHandle.text;
        

        Debug.Log("name and age of player is " + playerName + myAge);

        PlayerPrefs.SetString("ThisPlayer", playerName);
       
    } 
    public void setAge()
    {
        myAge = int.Parse(playerAge.text);
        PlayerPrefs.SetInt("ThisAge", myAge);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene2");
    }
}

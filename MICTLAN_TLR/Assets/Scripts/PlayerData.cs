using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.Events;

public class PlayerData : MonoBehaviour
{
    public string fileName;
    private StreamWriter sw;
    private StreamReader sr;
    private string fileContent;
    private Player myPlayer;
    private List<Player> players;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Application.persistentDataPath);
        if (File.Exists(Application.persistentDataPath + "/" + fileName))
        {
            sr = new StreamReader(Application.persistentDataPath + "/" + fileName);
            Debug.Log(Application.persistentDataPath + "/" + fileName);
            fileContent = sr.ReadToEnd();
            Debug.Log("File Content" + fileContent);
            myPlayer = new Player();
            //myPlayer = JsonUtility.FromJson<Player> (fileContent);
            players = JsonUtility.FromJson<List<Player>>(fileContent);
        }
        else
        {
            myPlayer = new Player();
            myPlayer.lifes = 3;
            myPlayer.kills = 0;
            myPlayer.lvlExp = 1;
            myPlayer.coins = 0;
            players = new List<Player>();
            players.Add(myPlayer);
            players.Add (myPlayer);
            players.Add(myPlayer);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            sw = new StreamWriter(fileName, false);
            fileContent = JsonUtility.ToJson(players); //Mandar un objeto cuya clase sea Serializable
            sw.Write(fileContent);
            sw.Close();
        }
        
    }

}

[Serializable]
public class Player
{
    public int lifes;
    public int kills;
    public int lvlExp;
    public int coins;

}

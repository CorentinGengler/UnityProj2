using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Player : MonoBehaviour
{
    #region Public Members
    public Text m_interfacePlayername;
    public Text m_interfaceLives;
    public Text m_interfaceHealth;
    #endregion

    public PlayerInfo info;
    public PlayerInfo info2;

    [System.Serializable]
    public class PlayerInfo {

        public string playerName;
        public int lives;
        public float health;
    }



    #region Public Void
    public string GenerateJson()
    {
        return JsonUtility.ToJson(info);
    }

    public void ImportFromJson(string jsonString)
    {
        info2 = JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
    #endregion

    #region System

    void Start()
    {
        m_jsonGenerated = GenerateJson();

    }
    public void ImportTheJsonAndPutInText()
    {
        ImportFromJson(m_jsonGenerated);
        m_interfacePlayername.text = info2.playerName;
        m_interfaceLives.text = info2.lives.ToString();
        m_interfaceHealth.text = info2.health.ToString();
    }

    void Awake () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Private Void
    string m_jsonGenerated;
    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

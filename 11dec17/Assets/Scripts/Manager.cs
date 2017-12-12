using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager  : MonoBehaviour
{

    #region Public Members
    
    public List<AvatarAndQuestions> ReignEvent;

    [System.Serializable]
    public struct AvatarAndQuestions
    {
        public string m_dialogue;
        public string m_imageName;
        public Sprite m_avatar;
        public Sprite m_Background;
        public string m_leftAnswer;
        public string m_rightAnswer;
        public string m_middleAnswer;
        public float m_changeToCrossIfYes;
        public float m_changeToPersonIfYes;
        public float m_changeToSwordIfYes;
        public float m_changeToMoneyIfYes;
        public float m_changeToCrossIfNo;
        public float m_changeToPersonIfNo;
        public float m_changeToSwordIfNo;
        public float m_changeToMoneyIfNo;

    }

    #endregion


    #region Public Void

    #endregion


    #region System

    void Start () 
    {
		
	}
    void Awake () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReignUIv1  : ReignsUI
{

    #region Public Members
    public Image m_backgroundImage;

    [Header("Panel Top")]

    public IconFill m_crossFill;
    public UpperDotActivate m_crossDot;
    public IconFill m_personFill;
    public UpperDotActivate m_personDot;
    public IconFill m_swordFill;
    public UpperDotActivate m_swordDot;
    public IconFill m_moneyFill;
    public UpperDotActivate m_moneyDot;

    [Header("Panel Middle")]
    public Text m_upperText;
    public Image m_image;
    public Text m_leftOption;
    public Text m_rightOption;
    public Text m_middleOption;
    public Text m_lowerText;

    [Header("Panel Bottom")]
    public Text m_kingName;
    public Text m_kingYearsOfReign;
    public Text m_score;

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

    public override void SetKingName(string kingName)
    {
        m_kingName.text = kingName;
    }

    public override void SetScoreTo(int score)
    {
        m_score.text = score.ToString();
    }

    public override void SetYearOfReigns(int years)
    {
        m_kingYearsOfReign.text = years.ToString();
    }

    public override void SetDialogue(string dialogue)
    {
        m_upperText.text = dialogue;
    }

    public override void SetImageName(string imageIdName)
    {
        throw new System.NotImplementedException();
    }

    public override void SetAvatarImage(Sprite texture)
    {
        m_image.sprite = texture;
    }

    public override void SetBonusStatus(int index, bool isComplete)
    {
        throw new System.NotImplementedException();
    }

    public override void SetBonusStatus(string questId, bool isComplete)
    {
        throw new System.NotImplementedException();
    }

    public override void SetBonusIcon(int index, Sprite iconTexture)
    {
        throw new System.NotImplementedException();
    }

    public override void SetBonusIcon(string questId, Sprite iconTexture)
    {
        throw new System.NotImplementedException();
    }

    public override void SetObjectiveStatus(int index, float pourcentageStatus)
    {
        throw new System.NotImplementedException();
    }

    public override void SetObjectiveStatus(string objectiveId, float pourcentageStatus)
    {
        throw new System.NotImplementedException();
    }

    public override void SetLeftAnswer(string text)
    {
        m_leftOption.text = text;
    }

    public override void SetRightAnswer(string text)
    {
        m_rightOption.text = text;
    }

    public override void SetContextBackground(string idToLoad)
    {
        throw new System.NotImplementedException();
    }

    public override void SetContextBackground(Sprite texture)
    {
        m_backgroundImage.sprite = texture;
    }

    public override void HighlighStatusPossiblity(int index, float pourcentageStatus, float nextPourcentStatus)
    {
        throw new System.NotImplementedException();
    }

    public override void HighlighStatusPossiblity(string objectiveName, float pourcentageStatus, float nextPourcentStatus)
    {
        throw new System.NotImplementedException();
    }

    public override void SetAvatarName(string dialogue)
    {
        m_lowerText.text = dialogue;
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainButton  : MonoBehaviour
{

    #region Public Members
    [Header ("Contenu possible")]
    public List<Sprite> m_listOfSprites = new List<Sprite>();
    public List<string> m_listOfUpperText = new List<string>();
    public List<string> m_listOfLowerText = new List<string>();

    [Header ("Emplacement contenu")]
    public Image m_CanvasImage;
    public Text m_CanvasUpperText;
    public Text m_CanvasLowerText;


    #endregion


    #region Public Void
    public void SwitchToNextImageAndText()
    {
        if(m_positionImage < (m_listOfSprites.Count)-1)
        {
            m_positionImage++;
        }
        else
        {
            m_positionImage = 0;
        }
        m_CanvasImage.sprite = m_listOfSprites[m_positionImage];
        m_CanvasUpperText.text= m_listOfUpperText[m_positionImage];
        m_CanvasLowerText.text= m_listOfLowerText[m_positionImage];
}
    #endregion


    #region System

    void Awake () 
    {
        m_positionImage = 0;
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
    private int m_positionImage;
    #endregion

}

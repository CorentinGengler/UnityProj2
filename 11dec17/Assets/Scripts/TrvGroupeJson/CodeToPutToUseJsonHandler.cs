using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeToPutToUseJsonHandler  : MonoBehaviour
{

    #region Public Members
    public string m_pathImages;
    public string m_Resolution;
    public int m_nbrScreen;
    
    #endregion


    #region Public Void
    public void SavePreferencesOnJson()
    {
        JsonStruct anyName = new JsonStruct(m_pathImages, m_Resolution, m_nbrScreen);
        string temp = JsonHandler.GenerateJsonStringFromClass(anyName);
        JsonHandler.WriteStringOnDrive(temp);
    }
    public void GetPreferencesFromJson()
    {
        string temp = JsonHandler.ReadStringFromFile();
        Debug.Log(temp);
        JsonStruct anyName2 = JsonHandler.ImportClassFromJsonString(temp);
        m_pathImages = anyName2.m_datapathImages;
        m_Resolution = anyName2.m_chosenResolution;
        m_nbrScreen = anyName2.m_nbrScreenPerCapture;
    }
    #endregion


    #region System
    
	
    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

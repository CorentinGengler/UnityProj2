
[System.Serializable]
public class JsonStruct //ne dois PAS prendre monobehaviour ou il plante a la conversion string->class
{
    public string m_datapathImages;
    public int m_chosenResolution;
    public int m_nbrScreenPerCapture;

    public JsonStruct(string m_datapathImages, int m_chosenResolution, int m_nbrScreenPerCapture)
    {
        this.m_datapathImages = m_datapathImages;
        this.m_chosenResolution = m_chosenResolution;
        this.m_nbrScreenPerCapture = m_nbrScreenPerCapture;
    }
}

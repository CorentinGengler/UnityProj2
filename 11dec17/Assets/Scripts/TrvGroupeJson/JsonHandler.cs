using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonHandler : MonoBehaviour
{
    public static string GenerateJsonStringFromClass(JsonStruct jsonS)
    {
        return JsonUtility.ToJson(jsonS);
    }

    public static JsonStruct ImportClassFromJsonString(string jsonString)
    {
        return JsonUtility.FromJson<JsonStruct>(jsonString);
    }

    
    public static string ReadStringFromFile()
    {
        return File.ReadAllText("Assets/JsonHolder");
    }
    public static string ReadStringFromFile(string filePathFromAsset)
    {
        return File.ReadAllText("Assets/" + filePathFromAsset);
    }

    public static void WriteStringOnDrive(string jsonStringToWrite)
    {
        File.WriteAllText("Assets/JsonHolder", jsonStringToWrite);
    }

    public static void WriteStringOnDrive(string jsonStringToWrite, string filePathFromAsset)
    {
        File.WriteAllText("Assets/" + filePathFromAsset, jsonStringToWrite);
    }
}

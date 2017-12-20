using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class FenêtreRèglages : EditorWindow
{

    public static FenêtreRèglages WindowsInstance;
    private static int pixelsEcart = 20;
    private static int nbreImages;
    private static string path;
    private static string pathjson;
    private static string pathjson2;
    private static bool night = false;
    private static string[] options = new string[]
    {
        "Résolution 1","Résolution 2","Résolution 3","Résolution 4",
    };
    private static int selected;
    public string[] selStrings = new string[] { "Résolution 1", "Résolution 2", "Résolution 3", "Résolution 4" };
    public Object source;

    [MenuItem("Window/Custom Window/Capture 306°")]
    public static void OpenWindow()
    {
        WindowsInstance = GetWindow<FenêtreRèglages>(false, "Capture 360°");
        WindowsInstance.Focus();
        WindowsInstance.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Capture");

        GUILayout.Space(pixelsEcart);




        // Choix objet a cibler
        GUILayout.Label("Objet à cibler :");
        source = EditorGUILayout.ObjectField(source, typeof(Object), true);


        GUILayout.Space(pixelsEcart);

        GUILayout.BeginHorizontal();
        {



            // Choix nombre photo
            GUILayout.Label("Nombre Photo");
            nbreImages = (int)EditorGUILayout.Slider(nbreImages, 4, 360);
        }
        GUILayout.EndHorizontal();


        GUILayout.Space(pixelsEcart);


        GUILayout.BeginVertical();
        {



            // choix jour-nuit
            night = GUILayout.Toggle(night, "Nuit");

            GUILayout.Space(pixelsEcart);

            GUILayout.BeginHorizontal();
            {


                // Choix résolution
                GUILayout.Label("Résolution");
                selected = EditorGUILayout.Popup(selected, options);

            }
            GUILayout.EndHorizontal();

            GUILayout.Space(pixelsEcart);




            // Chemin accès
            GUILayout.Label("Chemin d'accès :");
            bool choseFolderImage = GUILayout.Button("Image Folder");

            if (choseFolderImage == true)
                {
                    path = PickFolder();
                }
            GUILayout.Label("path : " + path, EditorStyles.whiteLargeLabel);


            bool loadFilePref = GUILayout.Button("Load Préférences");

            if (loadFilePref == true)
            {
                pathjson = LoadFile();
                GetPreferencesFromJson();
            }


            bool saveFilePref = GUILayout.Button("Save Préférences");

            if (saveFilePref == true)
            {
                pathjson2 = PickFile();
                Debug.Log(pathjson2.ToString());
                SavePreferencesOnJson();
            }



            GUILayout.Space(pixelsEcart);




            // Boutton GO
            if (GUILayout.Button(new GUIContent("GO", "clic pour lancer la capture")))
            {
                Debug.Log("Capture lancée");

                GameObject source2 = (GameObject)source;
                CreateLab lab = new CreateLab(source2.transform, 5);//2eme donnée = distance
                GameObject cam = lab.cameraMan;
                GameObject target = lab.cameraTarget;
            }

            GUILayout.Space(pixelsEcart);

            
        }
        GUILayout.EndVertical();
        


    }




    string PickFolder()
    {
        return EditorUtility.SaveFolderPanel("Save images to folder", "", "");
    }

    string LoadFile()
    {
        return EditorUtility.OpenFilePanel("Save images to folder", "", "");
    }

    string PickFile()
    {
        return EditorUtility.SaveFilePanel("Save images to folder", "", "", "");
    }

    public void SavePreferencesOnJson()
    {
        JsonStruct anyName = new JsonStruct(path, selected, nbreImages);
        string temp = JsonHandler.GenerateJsonStringFromClass(anyName);
        JsonHandler.WriteStringOnDrive(temp, pathjson2);
    }
    public void GetPreferencesFromJson()
    {
        string temp = JsonHandler.ReadStringFromFile(pathjson);
        JsonStruct anyName2 = JsonHandler.ImportClassFromJsonString(temp);
        path = anyName2.m_datapathImages;
        selected = anyName2.m_chosenResolution;
        nbreImages = anyName2.m_nbrScreenPerCapture;
    }
}

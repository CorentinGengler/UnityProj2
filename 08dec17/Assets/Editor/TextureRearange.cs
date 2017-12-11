using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Windows;
using System.IO;

public class TextureRearange : AssetPostprocessor
{

    #region Public Members
    
    #endregion

    void OnPreprocessTexture()
    {
        TextureImporter TextureImporter = (TextureImporter)assetImporter;
        TextureImporter.textureType = TextureImporterType.Sprite;
        TextureImporter.spriteImportMode = SpriteImportMode.Single;
        TextureImporter.filterMode = FilterMode.Point;

        m_texName = assetPath;
    }

    void OnPostprocessTexture(Texture2D _texture)
    {

        if(m_texName.StartsWith("Assets/TEX_") && !m_texName.StartsWith(m_ChangeToName))
        {

            int sizeOf1Tile = _texture.width / 4;
            Texture2D temp = new Texture2D(sizeOf1Tile * 2, sizeOf1Tile * 2);

            //greenToTopLeft
            temp.SetPixels(0, 0, sizeOf1Tile, sizeOf1Tile, _texture.GetPixels(sizeOf1Tile + 3, 0, sizeOf1Tile, sizeOf1Tile));
            //yellowToTopRight
            temp.SetPixels(sizeOf1Tile, 0, sizeOf1Tile, sizeOf1Tile, _texture.GetPixels(sizeOf1Tile * 2, 0, sizeOf1Tile, sizeOf1Tile));
            //redToBottomLeft
            temp.SetPixels(0, sizeOf1Tile, sizeOf1Tile, sizeOf1Tile, _texture.GetPixels(3, 0, sizeOf1Tile, sizeOf1Tile));
            //blueToBottomRight
            temp.SetPixels(sizeOf1Tile, sizeOf1Tile, sizeOf1Tile, sizeOf1Tile, _texture.GetPixels(sizeOf1Tile * 3, 0, sizeOf1Tile, sizeOf1Tile));


            string partOfOldName = m_texName.Substring(11);
            string newName = m_ChangeToName + partOfOldName;
            File.WriteAllBytes(newName, temp.EncodeToPNG());
        }
        else if(!m_texName.StartsWith(m_ChangeToName))
            {
                EditorUtility.DisplayDialog("Wrong File Name", "Try to start with TEX_", "ok", "cancel");
            }
            

        
    }


        #region Public Void

        #endregion


        #region System

        void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Private Void
    private string m_texName;
    private string m_ChangeToName = "Assets/TEX_Squared_";
    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/*
public class SpriteImportTest : AssetPostprocessor
{

    #region Public Members

    #endregion


    #region Public Void

    #endregion

    
    #region System

    void OnPreprocessTexture()
    {
        TextureImporter TextureImporter = (TextureImporter)assetImporter;
        TextureImporter.textureType = TextureImporterType.Sprite;
        TextureImporter.spriteImportMode = SpriteImportMode.Multiple;
        TextureImporter.filterMode = FilterMode.Point;

    }//ici on click sur apply en gros
    void OnPostprocessTexture(Texture2D _texture)
    {
        Debug.Log("Texture2D" + _texture.width + " ... " + _texture.height);

        int spriteSize = 10;
        int colCount = _texture.width / spriteSize;
        int rowCount = _texture.height/ spriteSize;
        List<SpriteMetaData> metas = new List<SpriteMetaData>();

        for(int r=0;r<rowCount;++r)
        {
            for(int c=0;c<colCount;++c)
            {
                SpriteMetaData meta = new SpriteMetaData();
                meta.rect = new Rect(c * spriteSize, r * spriteSize, spriteSize, spriteSize);
                meta.name = c + " - " + r;
                metas.Add(meta);
            }
        }
        TextureImporter TextureImporter = (TextureImporter)assetImporter;
        TextureImporter.spritesheet = metas.ToArray();
    
    }
    
    void Start()
    {

    }

    void Update()
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
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera  : DualBehaviour
{

    #region Public Members
    public GameObject target;
    public float xOffset = 0;
    public float yOffset = 3;
    public float zOffset = -3;

    void LateUpdate()
    {
        
    }
    #endregion


    #region Public Void

    #endregion


    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
        this.transform.position = new Vector3(target.transform.position.x + xOffset, yOffset , zOffset );
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}

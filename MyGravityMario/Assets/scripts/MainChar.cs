using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChar : DualBehaviour
{

    #region Public Members
    public float m_gravityForce=2f;
    public float m_movementSpeed = 1f;
    #endregion


    #region Public Void

    #endregion


    #region System

    void Awake()
    {
        m_body = m_transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
        ApplyMove();
        ApplyGravity();
        
    }

    #endregion

    #region Private Void
    private void ApplyGravity()
    {
        RaycastHit hit;
        if (Physics.Raycast(m_transform.position, Vector3.down, out hit))
        {
            
        }
        m_normal = hit.normal;
        m_Velocity.y = Mathf.Clamp(m_normal.y, -m_gravityForce, m_gravityForce);
        m_body.AddForce(-m_Velocity);
    }
    private void ApplyMove()
    {
        m_body.AddForce(new Vector3(m_speedV * m_movementSpeed, 0f, m_speedH * m_movementSpeed));

    }

    private void GetInput()
    {
        m_speedV = Input.GetAxis("Vertical");
        m_speedH = Input.GetAxis("Horizontal");
    }

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members
    private Vector3 m_Velocity = new Vector3();
    private Vector3 m_normal= new Vector3();
    private Rigidbody m_body;
    private float m_speedV;
    private float m_speedH;
    #endregion

}

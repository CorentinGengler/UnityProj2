using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualBehaviour : MonoBehaviour
{
    public Transform m_transform;

    private void Awake()
    {
        m_transform = GetComponent<Transform>();
    }
}

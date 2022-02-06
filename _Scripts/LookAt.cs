using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    public Transform target;
    private Vector3 correctedTarget;
    Camera m_MainCamera;


    void Start()
    {
        m_MainCamera = Camera.main;
        target = m_MainCamera.transform;

    }

    void Update()
    {
        Vector3 targetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z);
        transform.LookAt(targetPostition);

        //transform.LookAt(target);
    }
}

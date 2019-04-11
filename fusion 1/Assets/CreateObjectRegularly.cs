using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectRegularly : MonoBehaviour
{
    public float m_chrono = 0f;
    public GameObject m_objectToCreate;
    public float m_maxTime = 5f;
    public GameObject m_objectToCreate2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_chrono += Time.deltaTime;

        if (m_chrono > m_maxTime)
        {
            Instantiate(m_objectToCreate, Vector3.zero, Quaternion.identity);
            Instantiate(m_objectToCreate2, Vector3.zero, Quaternion.identity);
            m_chrono = 0f;
        }
    }
}

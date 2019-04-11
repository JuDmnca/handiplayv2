using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjectRegularly : MonoBehaviour
{

    public float m_timeSinceBeginning = 0f;
    public float m_chrono = 0f;
    public GameObject m_objectToCreate;
    public float m_maxTime = 5f;
    public GameObject m_objectToCreate2;
    public float speed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
        m_chrono += Time.deltaTime;
        m_timeSinceBeginning += Time.deltaTime;

        if (m_chrono > m_maxTime)
        {
            ScoreScript.scoreValue += 100;
            GameObject firstAsteroid = Instantiate(m_objectToCreate, Vector3.zero, Quaternion.identity);
            GameObject secondAsteroid = Instantiate(m_objectToCreate2, Vector3.zero, Quaternion.identity);
            m_chrono = 0f;

            AsteroidBehavior firstBehavior = firstAsteroid.GetComponent<AsteroidBehavior>();
            AsteroidBehavior secondBehavior = secondAsteroid.GetComponent<AsteroidBehavior>();

            if (m_timeSinceBeginning > 3)
            {
                firstBehavior.m_speed += 400f;
                secondBehavior.m_speed += 400f;
            }


        }

    }
}

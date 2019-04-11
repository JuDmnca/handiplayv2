using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public float m_speed = 200f;
    public Rigidbody2D m_rb2D;
    public float m_chrono = 0f;
    public float Number;
    public GameObject m_pos1;
    public GameObject m_pos2;
    public GameObject m_pos3;

    // Start is called before the first frame update
    void Start()
    {
        //m_chrono = 0f;

        Number = Random.Range(0, 3);
        if (Number == 1)
        {
            transform.position = m_pos1.transform.position;
        }

        if (Number == 2)
        {
            transform.position = m_pos2.transform.position;
        }

        if (Number == 0)
        {
            transform.position = m_pos3.transform.position;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // m_chrono = m_chrono + Time.fixedDeltaTime;
        transform.position += Vector3.down * m_speed * Time.fixedDeltaTime;

       // m_chrono = m_chrono + Time.fixedDeltaTime;
       // if (m_chrono > 5f)
       // {
          //  return voidStart;
       // }


    }
}


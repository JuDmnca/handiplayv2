using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public float m_speed = 200f;
    public Rigidbody2D m_rb2D;
    public float m_chrono = 0f;
    
    public float Number;
    public static float PrevNumber = -1f;
    public AudioClip Sound = null;
    
    public GameObject m_pos1;
    public GameObject m_pos2;
    public GameObject m_pos3;


    // Start is called before the first frame update
    void Start()
    {

        m_chrono = 0f;

        //Prends un nombre entre 0, 1 et 2
        Number = Random.Range(0, 3);

        //Change le nombre de l'astéroide 1 pour qu'il ne soit pas le même que celui du 2
        while (Number == PrevNumber)
        {
            Number = Random.Range(0,3);
        }
        
       
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

      PrevNumber = Number;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_chrono = m_chrono + Time.fixedDeltaTime;
        transform.position += Vector3.down * m_speed * Time.fixedDeltaTime;
        
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioPlayer : MonoBehaviour
{
	
public static AudioPlayer instance = null;
public AudioSource m_sound;



// Start is called before the first frame update
	void Start()
	{
		if (instance == null)
		{
		instance = this;
		}
		else
		{
		Destroy(gameObject);
		}
	}

	public void PlaySound(AudioClip soundClipToPlay)
	{
		m_sound.clip = soundClipToPlay;
		m_sound.Play();
	}

	// Update is called once per frame
	void Update()
	{
	}

}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public string SceneName = "";

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneName);
        }

    }
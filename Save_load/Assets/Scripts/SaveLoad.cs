﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour {

public void Save()
    {
        GameController.control.SaveGame();
        SceneController.sceneControl.SaveGame();
    }
    public void Load()
    {
        GameController.control.LoadGame();
        SceneController.sceneControl.LoadGame();
    }
}

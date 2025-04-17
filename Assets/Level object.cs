using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelobject : MonoBehaviour
{
        public string nextLevel;

        public void MoveToNextLevel()
        {
            SceneManager.LoadScene(nextLevel);
        }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{

    void Start(){
        
    }

    public void continueButton(){
        SceneManager.LoadScene(1);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ButtonControl : MonoBehaviour {

    public TMP_InputField textField;
    public GameObject thePanel;


    public void clearTextField(){
        textField.text = "";
    }

    public void cancelButton(){
        thePanel.SetActive(false);
    }

    public void closeButton(){
        thePanel.SetActive(true);
    }

    public void quitButton(){
        Application.Quit();
    }

}

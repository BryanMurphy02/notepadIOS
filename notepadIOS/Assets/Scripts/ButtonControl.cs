using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ButtonControl : MonoBehaviour {

    public TMP_InputField textField;


    public void clearTextField(){
        textField.text = "";
    }

}

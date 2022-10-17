using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveLoad : MonoBehaviour
{
    public string theText;
    // public GameObject ourNote;
    public GameObject placeholder;
    public TextMeshProUGUI ourNote;
    public TMP_InputField userField;

    void Start(){
        theText = PlayerPrefs.GetString("NoteContents");
        placeholder.GetComponent<TMP_InputField>().text = theText;
    }

    public void saveNote(){
        theText = ourNote.text;
        PlayerPrefs.SetString("NoteContents", theText);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
    public string ShowName;
    public GameObject EText;
    public GameObject SShow;
    

    
    public void Showname()
    {
        ShowName = EText.GetComponent<Text>().text;
        SShow.GetComponent<Text>().text =  "เจอ  "+ShowName;
    }
}

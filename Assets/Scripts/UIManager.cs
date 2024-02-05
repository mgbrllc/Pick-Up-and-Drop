using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI uiText;
    public string text;

    void Start()
    {
        uiText.text = text;
        text = "";
    }

    void Update()
    {
        uiText.text = text;
    }

}


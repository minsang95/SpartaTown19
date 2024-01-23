using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTxt : MonoBehaviour
{
    [SerializeField] private Text time;
    private void Update()
    {
        time.text = DateTime.Now.ToString("HH:mm");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This means the script requires the component to have a text object added
[RequireComponent(typeof(Text))]
public class CourseTtle : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        text.text = "COURSE " + GameState.Currentcourse;
    }
}

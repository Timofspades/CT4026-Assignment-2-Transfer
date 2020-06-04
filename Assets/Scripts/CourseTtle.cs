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

    //this changes the name of the course depending on what the currnet coure numbert is
    private void OnEnable()
    {
        text.text = "COURSE " + GameState.Currentcourse;
    }
}

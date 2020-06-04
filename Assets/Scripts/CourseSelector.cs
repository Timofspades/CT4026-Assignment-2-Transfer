using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject CourseCanvas;

    //this makes the menu systems a lot more efficent because it sets the name of the course to the current coure number this is changed depending what course you have selected on the course selection canvas 
    public void SelectCourse(int CourseNum)
    {
        GameState.Currentcourse = CourseNum;
        CourseCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

}

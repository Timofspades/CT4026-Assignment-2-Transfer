using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject CourseCanvas;

    public void SelectCourse(int CourseNum)
    {
        GameState.Currentcourse = CourseNum;
        CourseCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleButtonStats : MonoBehaviour
{
    [SerializeField]
    private int CourseNum = 0;
    [SerializeField]
    private int HoleNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        Score.GetHighScore(CourseNum, HoleNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

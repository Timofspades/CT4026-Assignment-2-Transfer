using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleButtonStats : MonoBehaviour
{
    [SerializeField]
    private int HoleNum = 0;
    [SerializeField]
    private Text Scoretext = null;
    // Start is called before the first frame update
    void OnEnable()
    {
        Scoretext.text = Score.GetHighScore(GameState.Currentcourse, HoleNum).ToString();
    }

    // Updated per frame
    void Update()
    {
        
    }
}

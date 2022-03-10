using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{   
    //simple variables
    public int currentAge = 20;
    public int addedAge  = 1;
    public float money = 2.00f;
    public string name = "Jason";
    public bool walk = true;

    /* Start is called before the first frame update
        When the play button is pressed it will print the following the console log
    */
    void Start()
    {   
        ComputeAge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    ///  Computes a modified age integer
    /// </summary>
    void ComputeAge(){
        Debug.Log(currentAge + addedAge);
    }
}

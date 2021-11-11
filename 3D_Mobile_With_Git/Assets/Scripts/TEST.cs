using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

// Attached to TestPanel object to test behaviour by printng Debug.Log() statements

public class TEST : MonoBehaviour
{
    public Text textField; 
    public string testText = "Initial test"; 

    HandleCSV csvHandling = new HandleCSV(); 

    void Start()
    {
    // Tetsing CSV handling     
        // csvHandling.appendToCSV(); 
        // textField.text = testText;
        List<CSVInfo> readInInfo = csvHandling.readCSV(); 
        // string combindedString = string.Join( ",", readInInfo);
        // testText.Equals(combindedString); 
        // textField.text = testText; 
         foreach (CSVInfo z in readInInfo){
            testText = z.printCSVInfo(); 
        }
        textField.text = testText; 

        // Debug.Log("TEST" + readInInfo.Count); 
        CSVInfo test = new CSVInfo("25"); 
        Debug.Log(test.printCSVInfo()); 

        Debug.Log("FROM TEST.CS " + HashClass.toSHA256("1111"));


    // Testing Hashing     
    // //*** Generates the same hash which is good: 
    //     Debug.Log(HashClass.toSHA256("Hello"));
    //     Debug.Log(HashClass.toSHA256("Hello"));



    }

    
}

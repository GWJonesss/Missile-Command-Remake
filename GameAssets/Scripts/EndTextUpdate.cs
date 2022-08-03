using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTextUpdate : MonoBehaviour
{

    public static int FinalScore;
    [SerializeField] private TextMeshProUGUI myEndText;




    public void UpdateEndText()
    {
        myEndText.text = "Your Final Score: " + FinalScore;
    }

    // Start is called before the first frame update

    void Awake()
    {
        UpdateEndText();
    }

    void Start()
    {
        
    }
    
    

    
}

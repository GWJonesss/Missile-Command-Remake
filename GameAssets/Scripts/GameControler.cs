using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControler : MonoBehaviour
{

    
    public int score = 0;
    public float ammo = 50.0f;
    public int progress = 0;
    public int level = 1;
    public int buildingsAlive = 0;

    [SerializeField] private TextMeshProUGUI myScoreText;
    [SerializeField] private TextMeshProUGUI myAmmoText;
    [SerializeField] private TextMeshProUGUI myBuildingText;
    [SerializeField] private TextMeshProUGUI myBuyAmmoText;
    [SerializeField] private TextMeshProUGUI myProgressText;
    [SerializeField] private TextMeshProUGUI myLevelText;
    

    private int missileDestroyPoints = 25;
    private int ammoUse = -1;
    
    

    ///////////////////////////// Start is called before the first frame update
    void Start()
    {
        myAmmoText.text = " " + ammo;
    }

    //////////////////////////////////////this changes the Score Text
    public void UpdateScoreText()
    {
        myScoreText.text = "Score: " + score;
        

    }
    ///////////////////////////////////this has the buy ammo message pop up
    public void UpdateBuyAmmoText()
    {
        myBuyAmmoText.text = " PRESS 'R' to Buy 10 More Missiles for 100 Score Points";


    }

    ////////////////////////////////////method to clear buy ammo text
    public void NotEnough()
    {
        myBuyAmmoText.text = " ";


    }

    //////////////////////////////////////this changes LEVEL text
    public void UpdateLevelText()
    {

        myLevelText.text = "Level :  " + level;
    }

    ///////////////////////////////////this changes PROGRESS text
    public void UpdateProgressText()
    {
        myProgressText.text = "Progress: " + progress + "%";

    }

    ////////////////////////////////////this changes ammo text
    public void UpdateAmmoText()
    {
        myAmmoText.text = " " + ammo;
    }

    ////////////////////////////////////this changes building text
    public void UpdateBuildingText()
    {
        myBuildingText.text = "Buildings Destroyed: " + buildingsAlive;
        if (buildingsAlive >= 6)
        {
            EndTextUpdate.FinalScore = score;
            SceneManager.LoadScene("End-Scene");
        }
    }

    // Update is called once per frame
    void Update()
    {

        

            ///////////////////// if the score goes over 100 it displays message from buy ammo function
        if (score >= 100)
        {
            UpdateBuyAmmoText();
        }
        if (score < 100) //// when it goes under 100 it clears the message
        {
            NotEnough();
        }


        //////////////////////////////////This Does Stuff when the R key is pushed down
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (score >= 100)
            {
                ammo = ammo + 10f;
                score = score - 100;
                UpdateAmmoText();
                UpdateScoreText();
            }
            
        }

    }


    public void AmmoUse()
    {
        ///////////////////////this updates the number of ammo that is left
        ammo += ammoUse;
        UpdateAmmoText();
    }

    ////////////////////////////////////////////adds points for every destoyed enemy
    public void AddMissileDestDestroyedScore()
    {
        score += missileDestroyPoints;
        UpdateScoreText();
        progress++;
        UpdateProgressText();

        if (progress >= 100)
        {
            level++;
            UpdateLevelText();
            UpdateLevelText();
            progress = 0;
            if (level >= 4)
            {
                EndTextUpdate.FinalScore = score;
                SceneManager.LoadScene("End-Scene");
            }
        }

    }

    /////////////////////////////////This Updates building destroyed text
    public void BuildingKilled()
    {
        buildingsAlive++;
        UpdateBuildingText();


    }



    
}

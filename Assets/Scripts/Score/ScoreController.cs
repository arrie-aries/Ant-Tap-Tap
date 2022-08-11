using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text killed;
    public Text missed;
    public Text waves;
    public Text lives;
    

    public ScoreManager manager;
   
    

   


    private void Update()
    {
        killed.text = "Killed: "+ manager.killedScore.ToString();
        missed.text = "Missed: "+ manager.missedScore.ToString();
        waves.text = "Waves: " + manager.wavesScoreresult.ToString();
        lives.text = "Lives: " + manager.livesScore.ToString();
    }

   
}

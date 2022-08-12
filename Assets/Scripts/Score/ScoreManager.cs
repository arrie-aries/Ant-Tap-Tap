using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int missedScore;
    public int livesScore;
    public int killedScore;
    public int wavesScore;
    public int wavesScoreresult;
    public GameOverScreen gameover;
  
    public void PlayermissedScore(int increment)
    {
        missedScore += increment;
    }
    public void PlayerkilledScore(int increment)
    {
        killedScore += increment;
    }
    public void PlayerwavesScore(int increment)
    {
        
     
        if ( wavesScore == 10 )
        {
            wavesScore = 0;
            wavesScoreresult+= increment; ;
        }
       else
        {
            wavesScore += increment;
        }
    }
    public void PlayerlivesScore(int increment)
    {
        if (livesScore <= 0)
        {
            gameover.Setup(killedScore);
        }
        else
        {
            livesScore += increment;
        }
        //void Setup(bool);
    }
}

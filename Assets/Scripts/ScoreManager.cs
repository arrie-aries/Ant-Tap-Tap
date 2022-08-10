using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int missedScore;
    public int livesScore = 10;
    public int killedScore;
    public int wavesScore;
    public int wavesScoreresult;


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
        livesScore = livesScore -1 ;

        if (livesScore == 0)
        {
            //GameOver();
        }
    }
}

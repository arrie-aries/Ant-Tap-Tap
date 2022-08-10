using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int missedScore;
    public int killedScore;
    public int wavesScore;


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
        wavesScore += increment;
    }
}

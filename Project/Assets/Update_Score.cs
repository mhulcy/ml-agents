using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Update_Score : MonoBehaviour
{
    public Text PPOScore;
    public Text POCAScore;
    private int ppo_score;
    private int poca_score;
    // Start is called before the first frame update
    void Start()
    {
        ppo_score = 0;
        poca_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PPOScore.text = "PPO: " + ppo_score;
        POCAScore.text = "POCA: " + poca_score;
    }

    public void AddOneToPPOScore()
    {
        ppo_score++;
    }

    public void AddOneToPOCAScore()
    {
        poca_score++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    [SerializeField] float baseLives = 4;
    [SerializeField] int damage = 1;
    Text hitPointsText;
    float lives;



    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        hitPointsText = GetComponent<Text>();
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        hitPointsText.text = lives.ToString();
    }

    public void BaseHit()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();            
        }
    }
}

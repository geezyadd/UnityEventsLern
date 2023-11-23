using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score = 0;
    private void Start()
    {
        EventManager.AddEventListener(AddPoints);
    }

    private void AddPoints(int points) 
    {
        _score += points;
        _scoreText.text = "score: " + _score;
    }
}

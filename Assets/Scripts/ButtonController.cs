using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
/// <summary>
/// Такой подход позволяет добиться того что код кнопки не знает про ScoreController, и ScoreController не знает про код кнопки
/// </summary>
public class ButtonController : MonoBehaviour
{
    PointsAddedEvent pointsAddedEvent = new PointsAddedEvent();
    [SerializeField] private Button _button;
    [SerializeField] private int _pointsForOneClick;
    private void Start()
    {
        _button.onClick.AddListener(() => AddPoints());
        EventManager.AddEventInvoker(this);
    }

    private void AddPoints() 
    {
        pointsAddedEvent.Invoke(_pointsForOneClick);
    }

    public void AddPointsAddedEventListener(UnityAction<int> listener)
    {
        pointsAddedEvent.AddListener(listener);
    }
}

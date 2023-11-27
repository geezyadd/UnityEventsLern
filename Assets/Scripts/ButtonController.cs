using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
/// <summary>
/// ����� ������ ��������� �������� ���� ��� ��� ������ �� ����� ��� ScoreController, � ScoreController �� ����� ��� ��� ������
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

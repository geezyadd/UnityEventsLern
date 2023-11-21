using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
/// <summary>
/// ����� ������ ��������� �������� ���� ��� ��� ������ �� ����� ��� ScoreController, � ScoreController ������ �� �������
/// </summary>
public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button _button;
    PointsAddedEvent pointsAddedEvent = new PointsAddedEvent();
    [SerializeField] private int _pointsForOneClick;
    private void Start()
    {
        _button.onClick.AddListener(() => AddPoints());
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

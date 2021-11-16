using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class Animation : MonoBehaviour
{
    [SerializeField] private RectTransform _targetRectTransform;
    [SerializeField] private float _endScale = .05f;
    [SerializeField] private float _endPositionx = 0f;
    [SerializeField] private float _endPositiony = -110f;


    public void StartAnim()
    {
        _targetRectTransform
            .DOLocalMoveX(endValue: _endPositionx, duration: .01f, snapping: false)
            .OnComplete(() =>
        {
            _targetRectTransform
            .DOScale(endValue: _endScale, duration: .01f);
        });
        
        _targetRectTransform
            .DOLocalMoveY(endValue: _endPositiony, duration: .01f, snapping: false)
            .OnComplete(() =>
        {
            _targetRectTransform
            .DOScale(endValue: _endScale, duration: .01f);
        });
    }
}
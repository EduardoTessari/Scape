using UnityEngine;
using System;

public class CheckColor : MonoBehaviour
{
    [SerializeField] private GameObject _leftColor, _middleColor, _rightColor;
    private bool _leftOK, _middleOK, _rightOK, sequenceWasCorrect = false;

    public event Action OnSequenceComplete;
    private void Update()
    {
        CheckLeft();
        CheckMiddle();
        CheckRight();

        bool sequenceNowCorrect = _leftOK && _middleOK && _rightOK;

        if (sequenceNowCorrect && !sequenceWasCorrect)
        {
            sequenceWasCorrect = true;
            OnSequenceComplete?.Invoke();  // Dispara o evento
        }
        else if (!sequenceNowCorrect)
        {
            sequenceWasCorrect = false;  // Reseta quando sequência não está correta
        }
    }

    private void CheckLeft()
    {
        if (_leftColor.transform.childCount > 0)
        {
            if (_leftColor.transform.GetChild(0).name == "ColorInstance - Blue")
            {
                _leftOK = true;
            }
            else
            {
                _leftOK = false;
            }
        }
        else
        {
            return;
        }

    }

    private void CheckRight()
    {
        if (_rightColor.transform.childCount > 0)
        {
            if (_rightColor.transform.GetChild(0).name == "ColorInstance - Green")
            {
                _rightOK = true;
            }
            else
            {
                _rightOK = false;
            }
        }
        else
        {
            return;
        }


    }
    private void CheckMiddle()
    {
        if (_middleColor.transform.childCount > 0)
        {
            if (_middleColor.transform.GetChild(0).name == "ColorInstance - Orange")
            {
                _middleOK = true;
            }
            else
            {
                _middleOK = false;
            }
        }
        else
        {
            return;
        }

    }

    
}


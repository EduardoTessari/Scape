using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class SelecNumerPadLock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numero;
    private int _valor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void changeNumberUp()
    {
        if (_valor < 9)
        {
            _valor++;
        }
        else
        {
            _valor = 0;
        }

        _numero.text = _valor.ToString();

    }

    public void changeNumberDown()
    {
        if (_valor > 0)
        {
            _valor--;
        }
        else
        {
            _valor = 9;
        }

        _numero.text = _valor.ToString();

    }

}

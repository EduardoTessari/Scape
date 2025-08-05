using TMPro;
using UnityEngine;

public class OpenPadlock : MonoBehaviour
{
    [SerializeField] private GameObject _padLockPanel, _desf3;
    //[SerializeField] private GameObject _clickBlocker;
    [SerializeField] private TextMeshProUGUI _num1, _num2, _num3;

    private void OnMouseDown()
    {
        if (_padLockPanel != null)
        {
            _padLockPanel.SetActive(true);
        }
        //if (_clickBlocker != null)
        //{
        //   _clickBlocker.SetActive(true);
        //}
        else { return; }
    }

    private void CheckNumbers()
    {
        if (_num1 && _num2 && _num3 != null)
        {
            if (_num1.text == "7" && _num2.text == "6" && _num3.text == "3")
            {
                if (_desf3 != null)
                {
                    _desf3.SetActive(true);

                }
                else 
                {
                    Debug.LogError("Desf3 GameObject is not assigned.");
                    return;
                }
                
                if (_padLockPanel != null)
                {
                    _padLockPanel.SetActive(false);
                }
                else
                {
                    Debug.LogError("Padlock panel is not assigned.");
                    return;
                }

                Destroy(this);

            }
            else
            {
                Debug.Log("Combinação incorreta");
            }
        }
        else
        {
            Debug.LogError("Um ou mais campos de numeros nao foram designados");
        }

    }

}

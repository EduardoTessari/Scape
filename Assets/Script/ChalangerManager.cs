using System.Collections;
using UnityEngine;

public class ChalangerManager : MonoBehaviour
{
    [SerializeField]private CheckColor _checkColorScript; // Arraste no Inspector
    [SerializeField] private GameObject _colorPanel, _tmResult;

    private void Start()
    {
        _checkColorScript.OnSequenceComplete += HandleSequenceComplete;
    }

    private void HandleSequenceComplete()
    {
        Debug.Log("Parabéns! Você completou a sequência!");
        Destroy(_colorPanel);
        StartCoroutine(ActivateFloor(1f)); // Ativa o chão após 1 segundo
        
    }

    private void OnDestroy()
    {
        // Para evitar erros, remova o listener quando destruir o objeto
        _checkColorScript.OnSequenceComplete -= HandleSequenceComplete;
    }

     IEnumerator ActivateFloor(float delay)
    {
        yield return new WaitForSeconds(delay);
        _tmResult.SetActive(true);
    }
}

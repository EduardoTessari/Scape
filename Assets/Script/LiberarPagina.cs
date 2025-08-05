using UnityEngine;
using UnityEngine.UI;

public class LiberarPagina : MonoBehaviour
{

    [SerializeField] private GameObject _btnPagina, _panelPaginas;
    private void OnMouseDown()
    {
        LiberaPagina(_btnPagina);
    }

    private void LiberaPagina(GameObject paginaLiberada)
    {
        if (paginaLiberada != null)
        {
            var botao = paginaLiberada.GetComponent<Button>();
            if (botao != null)
            {
                botao.interactable = true;
            }
        }

        if (_panelPaginas != null)
        {
            _panelPaginas.SetActive(true);
        }

        Destroy(gameObject);
    }
}

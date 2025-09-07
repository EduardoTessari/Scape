using UnityEngine;

public class OpenPage : MonoBehaviour
{
    [SerializeField] private GameObject _page1, _page2, _page3, _page4, _page5, _page6, _page7;
    [SerializeField] private GameObject[] _liberarPagina;
    private GameObject _actualPage;


    private void Start()
    {
        // Inicializa a primeira página como a página ativa
        _page1.SetActive(true);
        _liberarPagina[0].SetActive(true);
        _actualPage = _page1;
    }

    private void OpenPageGeneric(GameObject pageToOpen, GameObject pageToDisplay)
    {
        if (_actualPage != null) _actualPage.SetActive(false);

        if (pageToDisplay != null)
        {
            pageToDisplay.SetActive(true);
        }
        pageToOpen.SetActive(true);
        _actualPage = pageToOpen;
    }

    public void OpenPage1() => OpenPageGeneric(_page1, _liberarPagina[0]);
    public void OpenPage2() => OpenPageGeneric(_page2, _liberarPagina[1]);
    public void OpenPage3() => OpenPageGeneric(_page3, _liberarPagina[2]);
    public void OpenPage4() => OpenPageGeneric(_page4, _liberarPagina[3]);
    public void OpenPage5() => OpenPageGeneric(_page5, _liberarPagina[4]);
    public void OpenPage6() => OpenPageGeneric(_page6, null);
    public void OpenPage7() => OpenPageGeneric(_page7, null);

    public void ClosePage()
    {
        gameObject.SetActive(false);
    }
}


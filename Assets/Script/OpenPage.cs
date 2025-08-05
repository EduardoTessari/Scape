using UnityEngine;

public class OpenPage : MonoBehaviour
{
    [SerializeField] private GameObject _page1, _page2, _page3, _page4, _page5, _page6, _page7;
    private GameObject _actualPage;


    private void Start()
    {
        // Inicializa a primeira página como a página ativa
        _page1.SetActive(true);
        _actualPage= _page1;
    }

    private void OpenPageGeneric(GameObject pageToOpen)
    {
        if (_actualPage != null) _actualPage.SetActive(false);
        pageToOpen.SetActive(true);
        _actualPage = pageToOpen;
    }

    public void OpenPage1() => OpenPageGeneric(_page1);
    public void OpenPage2() => OpenPageGeneric(_page2);
    public void OpenPage3() => OpenPageGeneric(_page3);
    public void OpenPage4() => OpenPageGeneric(_page4);
    public void OpenPage5() => OpenPageGeneric(_page5);
    public void OpenPage6() => OpenPageGeneric(_page6);
    public void OpenPage7() => OpenPageGeneric(_page7);

    public void ClosePage()
    {
        gameObject.SetActive(false);
    }
}


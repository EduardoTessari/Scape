using UnityEngine;

public class OpenPanel : MonoBehaviour
{

    [SerializeField] private GameObject _colorPanel, _pagePanel;
    [SerializeField] private SelectColor selectColorScript;
    private Vector3 _location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void OnMouseDown()
    {
        if(gameObject.tag == "Chama")
        {
            if (_colorPanel != null)
            {
                _colorPanel.SetActive(true);
                _location = gameObject.transform.position;
                selectColorScript.LocationSpawn(_location, transform);
            }
            else
            {
                return;
            }
        }

        if (gameObject.tag == "Livro")
        {
            if (_pagePanel != null)
            {
                _pagePanel.SetActive(true);
            }
            else
            {
                return;
            }
        }



    }
}

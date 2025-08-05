using Unity.VisualScripting;
using UnityEngine;

public class SelectColor : MonoBehaviour
{
    [SerializeField] private GameObject _colorBlue, _colorGreen, _colorOrange;
    private GameObject _actualColor; //Cor do objeto clicado.
    private Vector3 _spawnPosition;
    private Transform _parentTransform;


    public void SetTargetObject(GameObject obj)
    {
        _actualColor = obj;
    }

    public void ClosePanel()
    {

        this.gameObject.SetActive(false);
    }

    public void InstantiateBlue()
    {
        DestroyExistingColor();

        _actualColor = Instantiate(_colorBlue, _spawnPosition, Quaternion.identity, _parentTransform);
        _actualColor.name = "ColorInstance - Blue";
        ClosePanel();
    }
    public void InstantiateGreen()
    {
        DestroyExistingColor();
        _actualColor = Instantiate(_colorGreen, _spawnPosition, Quaternion.identity, _parentTransform);
        _actualColor.name = "ColorInstance - Green";
        ClosePanel();

    }
    public void InstantiateOrange()
    {
        DestroyExistingColor();
        _actualColor = Instantiate(_colorOrange, _spawnPosition, Quaternion.identity, _parentTransform);
        _actualColor.name = "ColorInstance - Orange";
        ClosePanel();
    }

    public void LocationSpawn(Vector3 position, Transform parent)
    {
        _spawnPosition = position;
        _parentTransform = parent;
    }

    private void DestroyExistingColor()
    {
        foreach (Transform child in _parentTransform)
        {
            if (child.name.Contains("ColorInstance"))
            {
                Destroy(child.gameObject);
            }
        }
    }
}

using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Close()
    {
        gameObject.SetActive(false);
    }
    
}

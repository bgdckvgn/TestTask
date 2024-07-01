using TMPro;
using UnityEngine;

public class ScrollViewButtonItemScript : MonoBehaviour
{
    private int index = 0;
    public GameObject ButtonTextMeshPro;
    public void SetIndex(int index)
    {
        this.index = index;
    }
    public int GetIndex()
    {
        return index;
    }
    public void Start()
    {
        ButtonTextMeshPro.GetComponent<TextMeshProUGUI>().SetText("Button " + index);
    }

    public  void SelfDestroy()
    {
        Destroy(gameObject);
    }
}

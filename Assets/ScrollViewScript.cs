using UnityEngine;

public class ScrollViewScript : MonoBehaviour
{
    public GameObject listItemPrefab;
    private int count = 10;
    public GameObject listViewContent;

    public void Start()
    {
        GenerateListItems();
        gameObject.SetActive(false);
    }

    public void GenerateListItems()
    {
        //Generating items
        for (int index = 0; index < count; index++)
        {
            GameObject newItemScrollView = Instantiate(listItemPrefab);
            newItemScrollView.GetComponent<ScrollViewButtonItemScript>().SetIndex(index);
            newItemScrollView.transform.SetParent(listViewContent.transform);
            Debug.Log(newItemScrollView.GetComponent<ScrollViewButtonItemScript>().GetIndex() + " item generated.");
        }
    }
}

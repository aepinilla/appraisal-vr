using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button excitement;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = excitement.GetComponent<Button>();
        btn.onClick.AddListener(ToggleExcitement);
    }

    // Update is called once per frame
    void ToggleExcitement()
    {
        Debug.Log("Exct");
    }
}

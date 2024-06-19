using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
    }

    private void Update()
    {
        m_TextMeshPro.SetText(GameManager.instance.score.ToString());
    }
}

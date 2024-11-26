using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchOnly : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject estaImagem;


    void Start()
    {
        StartCoroutine("tempoDeletar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator tempoDeletar()
    {
        yield return new WaitForSeconds(8f);
        Destroy(estaImagem);
    }

}

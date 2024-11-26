using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eventosAnimacao : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;
    public Slider slider6;
    public Slider slider7;

    public Text tslider1;
    public Text tslider2;
    public Text tslider3;
    public Text tslider4;
    public Text tslider5;
    public Text tslider6;
    public Text tslider7;

    public GameObject imagem1;
    public GameObject imagem2;
    public GameObject imagem3;
    public GameObject imagem4;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;

    public GameObject imageminicial;

    void Start()
    {
        imagem1.SetActive(false);
        imagem2.SetActive(false);
        imagem3.SetActive(false);
        imagem4.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(false);
        texto3.SetActive(false);
        texto4.SetActive(false);

        slider1.value = Random.Range(1, 100);
        slider2.value = Random.Range(1, 100);
        slider3.value = Random.Range(1, 100);
        slider4.value = Random.Range(1, 100);
        slider5.value = Random.Range(1, 100);
        slider6.value = Random.Range(1, 100);
        slider7.value = Random.Range(1, 100);

        tslider1.text = slider1.value.ToString();
        tslider2.text = slider2.value.ToString();
        tslider3.text = slider3.value.ToString();
        tslider4.text = slider4.value.ToString();
        tslider5.text = slider5.value.ToString();
        tslider6.text = slider6.value.ToString();
        tslider7.text = slider7.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void mudarSliders()
    {
        slider1.value = Random.Range(1, 100);
        slider2.value = Random.Range(1, 100);
        slider3.value = Random.Range(1, 100);
        slider4.value = Random.Range(1, 100);
        slider5.value = Random.Range(1, 100);
        slider6.value = Random.Range(1, 100);
        slider7.value = Random.Range(1, 100);

        tslider1.text = slider1.value.ToString();
        tslider2.text = slider2.value.ToString();
        tslider3.text = slider3.value.ToString();
        tslider4.text = slider4.value.ToString();
        tslider5.text = slider5.value.ToString();
        tslider6.text = slider6.value.ToString();
        tslider7.text = slider7.value.ToString();

    }
    public void amostra1()
    {
        imagem1.SetActive(true);
        imagem2.SetActive(false);
        imagem3.SetActive(false);
        imagem4.SetActive(false);
        texto1.SetActive(true);
        texto2.SetActive(false);
        texto3.SetActive(false);
        texto4.SetActive(false);

    }
    public void amostra2()
    {
        imagem1.SetActive(false);
        imagem2.SetActive(true);
        imagem3.SetActive(false);
        imagem4.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(true);
        texto3.SetActive(false);
        texto4.SetActive(false);
    }
    public void amostra3()
    {
        imagem1.SetActive(false);
        imagem2.SetActive(false);
        imagem3.SetActive(true);
        imagem4.SetActive(false);
        texto1.SetActive(false);
        texto2.SetActive(false);
        texto3.SetActive(true);
        texto4.SetActive(false);
    }
    public void amostra4()
    {
        imagem1.SetActive(false);
        imagem2.SetActive(false);
        imagem3.SetActive(false);
        imagem4.SetActive(true);
        texto1.SetActive(false);
        texto2.SetActive(false);
        texto3.SetActive(false);
        texto4.SetActive(true);
    }
}

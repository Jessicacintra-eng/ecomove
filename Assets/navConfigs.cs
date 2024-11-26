using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navConfigs: MonoBehaviour
{
    // Scripts de navegabilidade do aplicativo.
    public GameObject grupo1;
    public GameObject grupo2;
    public GameObject grupo3;
    public GameObject grupo4;
    public GameObject telaBoasVindas1;
    public GameObject telaBoasVindas2;
    public GameObject telaBoasVindas3;
    public GameObject telaprincipalAPP;
    public GameObject posicaoCentral;
    public GameObject posicaoReserva;
    public GameObject background;
    public GameObject telaINFO;

    public GameObject telaSono;
    public GameObject telaPassos;
    public GameObject telaCiclo;
    public GameObject telaAlimentação;

    public GameObject telaHabitos;
    public GameObject telaConsultas;
    //public GameObject posLogin;


    public bool testarAPP = false;



    private void Start()
    {

        if (testarAPP == false)
        {
            

            grupo1.transform.position = posicaoCentral.transform.position;
            grupo2.transform.position = posicaoReserva.transform.position;
            grupo3.transform.position = posicaoReserva.transform.position;
            grupo4.transform.position = posicaoReserva.transform.position;
            telaBoasVindas1.transform.position = posicaoReserva.transform.position;
            telaBoasVindas2.transform.position = posicaoReserva.transform.position;
            telaBoasVindas3.transform.position = posicaoReserva.transform.position;
            telaBoasVindas3.transform.position = posicaoReserva.transform.position;
            telaprincipalAPP.transform.position = posicaoReserva.transform.position;
            telaINFO.transform.position = posicaoReserva.transform.position;
        }

    }
    public void TelaInicial()
    {
        hideAll();
        grupo1.transform.position = posicaoCentral.transform.position;
        grupo2.transform.position = posicaoReserva.transform.position;
        grupo3.transform.position = posicaoReserva.transform.position;
        grupo4.transform.position = posicaoReserva.transform.position;

    }
    public void TelaCadastro()
    {
     
        grupo1.transform.position = posicaoReserva.transform.position;
        grupo2.transform.position = posicaoCentral.transform.position;
        grupo3.transform.position = posicaoReserva.transform.position;
        grupo4.transform.position = posicaoReserva.transform.position;

    }
    public void TelaBoasVindas1()
    {
        // PlayerPrefs.SetString(username + "_aniversario", aniversario);
        // PlayerPrefs.SetString(username + "_telefone", telefone);
        // PlayerPrefs.SetString(username + "_aniversario", genero);
        // PlayerPrefs.SetString(username + "_telefone", nomeusuario);


       
        /*if (gameObject.GetComponent<UserManager>().nomeUsuario != "" && gameObject.GetComponent<UserManager>().genderRegisterInput.text != "" && gameObject.GetComponent<UserManager>().telephoneInput.text != "" && gameObject.GetComponent<UserManager>().ageRegisterInput.text != "")
        {
            // gameObject.GetComponent<UserManager>().registroInformacoes();
            gameObject.GetComponent<UserManager>().telephoneInput.text = gameObject.GetComponent<UserManager>().telefoneNumero;
            gameObject.GetComponent<UserManager>().ageRegisterInput.text = gameObject.GetComponent<UserManager>().age;
            gameObject.GetComponent<UserManager>().genderRegisterInput.text = gameObject.GetComponent<UserManager>().gender;
            gameObject.GetComponent<UserManager>().nomeInput.text = gameObject.GetComponent<UserManager>().nomeUsuario;
            hideAll();

            telaBoasVindas1.transform.position = posicaoCentral.transform.position; // tela de preferencias
            gameObject.GetComponent<UserManager>().botaoAvancarMove.SetActive(false);

            //  gameObject.GetComponent<UserManager>().ageRegisterInput.text = "";
            //   gameObject.GetComponent<UserManager>().genderRegisterInput.text = "";
            //  gameObject.GetComponent<UserManager>().telephoneInput.text = "";
            // gameObject.GetComponent<UserManager>().nomeInput.text = "";
            Debug.Log("ooo");
        }*/

        /*if (gameObject.GetComponent<UserManager>().nomeUsuario == "" || gameObject.GetComponent<UserManager>().gender == "" || gameObject.GetComponent<UserManager>().telefoneNumero == "" || gameObject.GetComponent<UserManager>().age == "" )
        {
            Debug.Log("eeee");
            gameObject.GetComponent<UserManager>().ShowMessageBOX("Por favor, preencha os todos os campos com as informações necessárias.");
        }*/
        hideAll();
        telaBoasVindas1.transform.position = posicaoCentral.transform.position; // tela de preferencias
        gameObject.GetComponent<UserManager>().botaoAvancarMove.SetActive(false);




    }

    //public void 
    public void telaBoasVindas2ALT()// chama a tela novamente para alterar dados, preenchendo eles antes
    {
        hideAll();
        telaBoasVindas2.transform.position = posicaoCentral.transform.position;

        gameObject.GetComponent<UserManager>().nomeInput.text = gameObject.GetComponent<UserManager>().nomeUsuario;
        gameObject.GetComponent<UserManager>().ageRegisterInput.text = gameObject.GetComponent<UserManager>().age;
        gameObject.GetComponent<UserManager>().genderRegisterInput.text = gameObject.GetComponent<UserManager>().gender;
        gameObject.GetComponent<UserManager>().telephoneInput.text = gameObject.GetComponent<UserManager>().telefoneNumero;
    }
    public void TelaBoasVindas2() // tela de preenchmento de dados
    {

        hideAll();
        telaBoasVindas2.transform.position = posicaoCentral.transform.position;
    }
    public void TelaBoasVindas3()
    {
        hideAll();
        telaBoasVindas3.transform.position = posicaoCentral.transform.position;
        
    }


    public void TelaMudarDados()
    {
        gameObject.GetComponent<UserManager>().ShowUserInfo();
        grupo1.transform.position = posicaoReserva.transform.position;
        grupo2.transform.position = posicaoReserva.transform.position;
        grupo3.transform.position = posicaoReserva.transform.position;
        grupo4.transform.position = posicaoCentral.transform.position;
        telaINFO.transform.position = posicaoReserva.transform.position;
       
    }

    public void TelaOpcoesLogout()
    {

        telaINFO.transform.position = posicaoReserva.transform.position;
        grupo1.transform.position = posicaoReserva.transform.position;
        grupo2.transform.position = posicaoReserva.transform.position;
        grupo3.transform.position = posicaoCentral.transform.position;
        grupo4.transform.position = posicaoReserva.transform.position;
        telaprincipalAPP.transform.position = posicaoReserva.transform.position;
        gameObject.GetComponent<UserManager>().ShowUserInfo();
        
    }

    public void hideAll()
    {

        grupo1.transform.position = posicaoReserva.transform.position;
        grupo2.transform.position = posicaoReserva.transform.position;
        grupo3.transform.position = posicaoReserva.transform.position;
        grupo4.transform.position = posicaoReserva.transform.position;
        telaBoasVindas1.transform.position = posicaoReserva.transform.position;
        telaBoasVindas2.transform.position = posicaoReserva.transform.position;
        telaBoasVindas3.transform.position = posicaoReserva.transform.position;
        telaBoasVindas3.transform.position = posicaoReserva.transform.position;
        telaprincipalAPP.transform.position = posicaoReserva.transform.position;


        telaINFO.transform.position = posicaoReserva.transform.position;
        telaSono.transform.position = posicaoReserva.transform.position; 
        telaPassos.transform.position = posicaoReserva.transform.position; 
        telaCiclo.transform.position = posicaoReserva.transform.position; 
        telaAlimentação.transform.position = posicaoReserva.transform.position; 

        telaHabitos.transform.position = posicaoReserva.transform.position;
        telaConsultas.transform.position = posicaoReserva.transform.position;
    }
    public void telaINFOS()
    {
        hideAll();
        telaINFO.transform.position = posicaoCentral.transform.position;
    }

    public void telaSONO()
    {
        hideAll();
        telaSono.transform.position = posicaoCentral.transform.position;
       
    }
    public void telaPASSOS()
    {
        hideAll();
        telaPassos.transform.position = posicaoCentral.transform.position;
        
    }
    public void telaCICLO()
    {
        hideAll();
        telaCiclo.transform.position = posicaoCentral.transform.position;
        
    }
    public void telaALIMENTACAO()
    {
        hideAll();
        telaAlimentação.transform.position = posicaoCentral.transform.position;
      
    }

    public void telaHABITOS()
    {
        hideAll();
        telaHabitos.transform.position = posicaoCentral.transform.position;
    }
    public void telaCONSULTAS()
    {
        hideAll();
        telaConsultas.transform.position = posicaoCentral.transform.position;
    }
    //public void telaLogin
    public void TelaPrincipalAPP()
    {
        hideAll();
       
        telaprincipalAPP.transform.position = posicaoCentral.transform.position;
        gameObject.GetComponent<UserManager>().ShowUserInfo();

    }

    


}

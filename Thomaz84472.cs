using System.Collections;
using System.Collections.Generic;
using UnityEngine;

echo "# jokenpo" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/Thomaz-Peres/jokenpo.git
git push -u origin master
                
public class Thomaz84472 : MonoBehaviour
{
    //0 = pedra
    //1 = papel 
    //2 = tesoura
    int[] jogadas = new int[2];
    string[] alternativa = new string[] {"Pedra", "Papel", "Tesoura"};
    int pontosA,pontosB,pontosE;
        // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i <= jogadas.Length; i++){
            string jogadorA = alternativa[Random.Range(0, alternativa.Length)];
            print("Escolha jogador A: " + jogadorA);
            string jogadorB = alternativa[Random.Range(0, alternativa.Length)];
            print("Escolha jogador B: " + jogadorB);

            if((jogadorA == "Pedra" && jogadorB == "Tesoura") || (jogadorA == "Papel" && jogadorB == "Pedra") || (jogadorA == "Tesoura" && jogadorB == "Papel"))
            { //verificando se o jogador ganhou
                print("Jogador A venceu");
                pontosA++;
            }
            else if ((jogadorB == "Pedra" && jogadorA == "Tesoura") || (jogadorB == "Papel" && jogadorA == "Pedra") || (jogadorB == "Tesoura" && jogadorA == "Papel"))
            { //verificando se o jogador ganhou
                print("Jogador B venceu");
                pontosB++;
            }
            else
            {
                print("empate");
                pontosE++;
            }
            print("--------------------");
        }
        print("Jogador A teve " + pontosA + " virtória(s).");
        print("Jogador B teve " + pontosB + " virtória(s).");
        print("Número(s) de empates: " + pontosE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

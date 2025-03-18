using UnityEngine;

public class TelaInicialGameState : GameBaseState
{
    private GameObject telaInicialJogo;
    public override void enterState(GameStateManager gameState)      {
        telaInicialJogo = GameObject.Find("tela_inicial_Snake_1280_1060_0");
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Entramos na Tela inicial.");
    }
    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.playingState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        telaInicialJogo.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Saindo da Tela inicial.");
    }
}

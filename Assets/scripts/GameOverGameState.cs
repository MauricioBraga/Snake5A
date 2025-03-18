using UnityEngine;



public class GameOverGameState : GameBaseState
{
    private GameObject telaGameOver;
    public override void enterState(GameStateManager gameState)   {
        telaGameOver = GameObject.Find("tela_Game_Over_Snake_1280_1060_0");
        telaGameOver.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Entramos no game over.");
    }
    public override void updateState(GameStateManager gameState)   {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaCreditosState);
        }
    }

    public override void leaveState(GameStateManager gameState)     {
        telaGameOver.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Saindo do game over.");
    }
}

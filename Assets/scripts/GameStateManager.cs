using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;
    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();

    public GameOverGameState telaGameOverState = new GameOverGameState();

    public PlayingGameState playingState = new PlayingGameState();

     void Start()   {
        currentState = telaInicialState;
        // inicia o estado.
        currentState.enterState(this);
    }
    void Update()   {
        currentState.updateState(this);
    }

    public void switchState(GameBaseState state)    {
      // sai do estado anterior
      currentState.leaveState(this);

      // muda o estado atual
      currentState = state;

      // entra no novo estado
      currentState.enterState(this);
  }

}

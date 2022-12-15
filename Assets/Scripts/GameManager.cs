using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [field: SerializeField] public float Lives { get; set; }
    [SerializeField] private float timer;
    [SerializeField] private AnswerSet answerSet;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private RivalScript[] rivalScript = new RivalScript[3];
    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject winnerUI;
    [SerializeField] private Image balloonUI;
    [SerializeField] private float startTimer;
    [SerializeField] private Image startTimerImage;
    [SerializeField] private GameObject startTimerPanel;
    [SerializeField] private Sprite[] sprite = new Sprite[4];
    [SerializeField] private Sprite winnerSprite;
    [SerializeField] private TextMeshProUGUI winnerName;
    [SerializeField] private PlaceTracker placeTracker;
    [SerializeField] private ButtonDeactivator buttonDeactivator;
    private GameStateMachine _currentState;
    private GameStateMachine _previousState;
    private float _tempTimer;
    private float _tempStartTimer;
    public float StartTimer
    {
        get => startTimer;
        set => startTimer = value;
    }

    public TextMeshProUGUI WinnerName
    {
        get => winnerName;
        set => winnerName = value;
    }
    public Sprite[] NewSprite
    {
        get => sprite;
        set => sprite = value;
    }

    public Sprite WinnerSprite
    {
        get => winnerSprite;
        set => winnerSprite = value;
    }
    public Image StartTimerImage
    {
        get => startTimerImage;
        set => startTimerImage = value;
    }
    
    public Image BalloonUI
    {
        get => balloonUI;
        set => balloonUI = value;
    }

    public GameObject StartTimerPanel
    {
        get => startTimerPanel;
        set => startTimerPanel = value;
    }

    public GameObject PlayerUI => playerUI;
    public GameObject Winner => winnerUI;
    public GameStateMachine CurrentState => _currentState;
    public readonly GameStateMachine _startMenu = new StartMenuState();
    public readonly GameStateMachine PlayState = new PlayState();
    private readonly GameStateMachine _pauseState = new PauseState();
    public readonly GameStateMachine WinState = new WinState();
    public readonly GameStateMachine LoseState = new LoseState();
    public AnswerSet AnswerSet => answerSet;
    public PlayerController PlayerController => playerController;
    public ButtonDeactivator ButtonDeactivator => buttonDeactivator;

    public RivalScript[] RivalScript => rivalScript;
    public float Timer { get; set; }
    public float TempTimer { get=>_tempTimer; set=>_tempTimer = value; }

    public PlaceTracker PlaceTracker => placeTracker;
    
    private void Start()
    {
        _tempTimer = timer;
        _tempStartTimer = startTimer;
    }
    
    public  void Update()
    {
        if (_currentState != null)
        {
            _currentState.UpdateGameState(this);
        }
    }
    public void StartState()
    {
        startTimerPanel.SetActive(true);
        startTimerImage.gameObject.SetActive(true);
        startTimer = _tempStartTimer;
        SwitchState(_startMenu);
    }

    public void EndState()
    {
        _currentState.EndState(this);
    }

    public void PauseState()
    {
        _previousState = _currentState;
        SwitchState(_pauseState);
    }

    public void ReturnState()
    {
        _currentState = _previousState;
        _currentState.TransitionState(this);
    }

    public void SwitchState(GameStateMachine state)
    {
        _currentState = state;
        state.EnterState(this);
    }
    
  
}


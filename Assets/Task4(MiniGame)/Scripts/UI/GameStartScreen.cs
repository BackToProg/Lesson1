using System;
using UnityEngine;
using UnityEngine.UI;

namespace Task4_MiniGame_.Scripts.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class GameStartScreen : MonoBehaviour
    {
        [SerializeField] private Button _oneTypeBallButton;
        [SerializeField] private Button _allBallsButton;

        private CanvasGroup _canvasGroup;

        public event Action<IGame> GameWinCondition;

        private void OnEnable()
        {
            _oneTypeBallButton.onClick.AddListener(OnGameTillOneTypeDestroy);
            _allBallsButton.onClick.AddListener(OnGameAllOneTypeDestroy);
        }

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        private void OnDisable()
        {
            _oneTypeBallButton.onClick.RemoveListener(OnGameTillOneTypeDestroy);
            _allBallsButton.onClick.RemoveListener(OnGameAllOneTypeDestroy);
        }

        private void OnGameAllOneTypeDestroy()
        {
            GameWinCondition?.Invoke(new AllBallDestroyPattern());
            StartGame();
        }

        private void OnGameTillOneTypeDestroy()
        {
            GameWinCondition?.Invoke(new OneTypeBallDestroyPattern());
            StartGame();
        }

        private void StartGame()
        {
            _canvasGroup.alpha = 0;
        }
    }
}
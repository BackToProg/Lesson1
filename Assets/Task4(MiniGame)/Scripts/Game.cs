using System.Collections.Generic;
using System.Linq;
using Task4_MiniGame_.Scripts.Models;
using Task4_MiniGame_.Scripts.UI;
using UnityEngine;

namespace Task4_MiniGame_.Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameStartScreen _gameStartScreen;
        [SerializeField] private Camera _camera;
        [SerializeField] private List<Ball> _ballsOnScene;

        private IGame _gameCondition;
        private List<Ball> _ballsInPlay;
        private bool _isOneBallTypeExist;

        private void OnEnable()
        {
            _gameStartScreen.GameWinCondition += GameCondition;
        }

        private void Awake()
        {
            _ballsInPlay = _ballsOnScene;
        }

        private void Update()
        {
            if (!Input.GetMouseButtonDown(0)) return;

            TryToDestroyBall();
            
            Debug.Log(_ballsInPlay.Count);

            if (_gameCondition is OneTypeBallDestroyPattern && _isOneBallTypeExist == false)
            {
                _gameCondition.GameOver();
            }
            else
            {
                if (_ballsInPlay.Count == 0)
                {
                    _gameCondition.GameOver();
                }
            }
        }
        
        private void OnDisable()
        {
            _gameStartScreen.GameWinCondition -= GameCondition;
        }

        private void TryToDestroyBall()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (!Physics.Raycast(ray, out var hit)) return;

            IBall targetBall = hit.collider.gameObject.GetComponent<IBall>();

            switch (targetBall)
            {
                case GreenBall:
                    _ballsInPlay.Remove(hit.collider.gameObject.GetComponent<GreenBall>());
                    targetBall.Destroy();
                    _isOneBallTypeExist = _ballsInPlay.Any(ball => ball is GreenBall);
                    break;
                case WhiteBall:
                    _ballsInPlay.Remove(hit.collider.gameObject.GetComponent<WhiteBall>());
                    targetBall.Destroy();
                    _isOneBallTypeExist = _ballsInPlay.Any(ball => ball is WhiteBall);
                    break;
                case RedBall:
                    _ballsInPlay.Remove(hit.collider.gameObject.GetComponent<RedBall>());
                    targetBall.Destroy();
                    _isOneBallTypeExist = _ballsInPlay.Any(ball => ball is RedBall);
                    break;
            }
        }
        
        private void GameCondition(IGame game)
        {
            _gameCondition = game;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace RPG.Units.Player
{
    //[RequireComponent(typeof(Rigidbody))] // создает компонент Rigidbody на объекте при добавлении компонента и не разрешает его удаление
    public class PlayerController : MonoBehaviour
    {
        private StatsAssistant _stats;
        private PlayerControls _controls;

        private Rigidbody _rigidBody;
        #region
        private void Awake()
        {
            _controls = new PlayerControls();
            _controls.GameMap.FastAttack.performed += OnFastAttack;
            _controls.GameMap.StrongAttack.performed += OnStrongAttack;
        }

        private void Update()
        {
            OnMovement();
        }

        private void OnMovement()
        {
            var direction = _controls.GameMap.Movement.ReadValue<Vector2>();
            
            var velocity = new Vector3(direction.x, 0f, direction.y);
            transform.position += velocity * _stats.GetSpeed() * Time.deltaTime;
        }

        private void OnEnable()
        {
            _controls.Enable();
        }
        
        private void OnDisable()
        {
            _controls.Disable();
        }

        private void OnDestroy()
        {
            _controls.Dispose();
        }
        #endregion

        private void OnFastAttack(CallbackContext context)
        {
            Debug.Log("Быстрая атака");
        }

        private void OnStrongAttack(CallbackContext context)
        {
            Debug.Log("Сильная атака");
        }
    }
}
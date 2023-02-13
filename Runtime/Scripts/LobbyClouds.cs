using UnityEngine;

//namespace Borderless.Lobbies
//{
    public class LobbyClouds : MonoBehaviour
    {
        [SerializeField] float CloudSpeed = 1;

        private void Update()
        {
            transform.Rotate(0, CloudSpeed * Time.deltaTime, 0);
        }
    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace Borderless.Lobbies
//{
    public class LobbyView : MonoBehaviour
    {
        [SerializeField] private List<LobbyModuleView> moduleViews;

        public void UpdateModuleViews(List<ILobbyModule> modules)
        {
            foreach(var moduleView in moduleViews)
            {
                moduleView.Hide();
            }

            foreach(var module in modules)
            {
                var index = (int)module.Placement;
                moduleViews[index].Init(module);
            }
        }

        public void Show()
        {

        }

        public void Hide()
        {

        }
    }
//}

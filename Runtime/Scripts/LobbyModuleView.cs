using TMPro;
using UnityEngine;
using UnityEngine.UI;

//namespace Borderless.Lobbies
//{
    public enum ModulePlacement
    {
        L3,
        L2,
        L1,
        C,
        R1,
        R2,
        R3
    }

    public interface ILobbyModule
    {
        public string Name { get; }
        public Texture Image { get; }
        public ModulePlacement Placement { get; }
    }

    public class LobbyModuleView : MonoBehaviour
    {
        [Header("UI References")]
        [SerializeField] private TextMeshProUGUI moduleNameText;
        [SerializeField] private RawImage moduleImage;

        public ILobbyModule Module { get; private set; }

        public void Init(ILobbyModule module)
        {
            Module = module;
            moduleNameText.text = module.Name;
            moduleImage.texture = module.Image;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
//}


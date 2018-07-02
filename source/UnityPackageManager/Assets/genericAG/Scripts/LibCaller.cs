using TMPro;
using UnityDotNetLibrary;
using UnityEngine;

namespace genericAG.Scripts
{
    [ExecuteInEditMode]
    public class LibCaller : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _constantContent;
        [SerializeField]
        private TextMeshProUGUI _methodContent;


        private void OnEnable()
        {
            _constantContent.text = Library.Constant;
            _methodContent.text = $"10 + 5 = {Library.Add(10, 5)}";
        }
    }
}

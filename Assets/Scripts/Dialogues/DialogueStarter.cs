using cherrydev;
using UnityEngine;

namespace Dialogues
{
    public class DialogueStarter : MonoBehaviour
    {
        [SerializeField] private DialogBehaviour dialogBehaviour;
        [SerializeField] private DialogNodeGraph dialogNode;

        public void StartDialog()
        {
            dialogBehaviour.StartDialog(dialogNode);
        }
    }
}

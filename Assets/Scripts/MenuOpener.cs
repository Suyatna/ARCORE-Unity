using UnityEngine;

public class MenuOpener : MonoBehaviour
{
    public GameObject menu;

    public void OpenPanelMenu()
    {
        if(menu != null)
        {
            Animator animator = menu.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOPen = animator.GetBool("Open");
                animator.SetBool("Open", !isOPen);
            }
        }
    }
}

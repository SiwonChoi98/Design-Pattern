using UnityEngine;

public class Composite : MonoBehaviour
{
    private void Rander()
    {
        Panel mainPanel = new Panel();
        mainPanel.Add(new Button());
        mainPanel.Add(new Text());

        Panel subPanel = new Panel();
        subPanel.Add(new Button());

        mainPanel.Add(subPanel);

        mainPanel.Render();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class Panel : UIElement
{
    private List<UIElement> _children = new List<UIElement>();

    public void Add(UIElement element)
    {
        _children.Add(element);
    }

    public override void Render()
    {
        Debug.Log("패널 렌더링 시작");
        foreach (var child in _children)
        {
            child.Render();
        }
    }
}

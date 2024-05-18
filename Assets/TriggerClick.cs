using UnityEngine;

public class TriggerClick : MonoBehaviour
{
    public GameObject targetObject; // ������, ������� ����� ���������
    public float offsetX = 0f; // �������� �� ��� X
    public float offsetY = 0f; // �������� �� ��� Y
    public float offsetZ = 0f; // �������� �� ��� Z

    void OnMouseDown()
    {
            Mover mover = targetObject.GetComponent<Mover>();
            if (mover != null)
            {
                Vector3 destination = targetObject.transform.position + new Vector3(offsetX, offsetY, offsetZ);
                mover.MoveTo(destination);
            }

    }
}

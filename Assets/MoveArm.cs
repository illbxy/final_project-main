using UnityEngine;

public class MoveArm : MonoBehaviour
{
    public float speed = 10f; // �������� ��������
    public bool moveAlongX = true; // ���� ��� ����������� �������� ������ �� ��� X

    void Update()
    {
        if (Input.GetMouseButton(0)) // ���������, ������ �� ������ ���� (����� ������)
        {
            // �������� ������� ���������� ����
            Vector3 mousePosition = Input.mousePosition;
            // ����������� �������� ���������� � ������� ����������
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z - Camera.main.transform.position.z));

            // ���������� ����� ������� ������ �� ��� X ��� Y � ����������� �� ��������
            Vector3 newPosition = transform.position;
            if (moveAlongX)
            {
                newPosition.x = worldPosition.x;
            }
            else
            {
                newPosition.y = worldPosition.y;
            }

            // ������ ���������� ������ � ����� �������
            transform.position = Vector3.Lerp(transform.position, newPosition, speed * Time.deltaTime);
        }
    }
}

using UnityEngine; // �ޥ�Unity ���� ���ڭ̥i�H�ϥ� API

// ���O ���O�W�� �ݤj�p�g�@�P
public class Car : MonoBehaviour
{
    //�����O���e

    #region ��� Field
    // �� ���y�k
    // ������� ���W�� ���w�w�]�� ����
    // ���|�j�`�θ������
    // ��  �� ing
    // �B�I�� float
    // �r  �� string
    // ���L�� bool
    // ���׹���
    // �p�H�G�����~�����O�s���A����� private
    // ���}�G���\�~�����O�s���A��ܡ@ bublic
    public int cc = 1000; 
    public float weight = 3.5f;     // s����F/f
    public string brand = "���h";   // "" ���޸�
    public bool hsaWindow = true;   // true/false s

    // *Unity���`�θ������
    // �C�� Color
    public Color ColorA; 
    public Color rde = Color.red; //���w
    public Color ColorB = new Color(0.8f, 1, 0.9f, 0.8f);  // +nwe R,G,B,�z���� �Ʀr0~1

    // �V�q Vector 2 ~ 4
    // �y�� X���� Y���� 
    public Vector2 vector2; //�����w
    public Vector2 v2Right = Vector2.right; //���w�w�]
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f); //�s�W�s�y��


    #endregion
}

//�D���O�����e
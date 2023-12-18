using UnityEngine;
using UnityEngine.SceneManagement;

namespace Builds
{
    public class GameBehaviour : MonoBehaviour
    {
        public bool _isPlayedWin = true;
        public string _labelText = "�������� � ������� ������� ����� �����, ����� ���������� ���� ��� ������� ������ ������� ����������� �������������, ��������, �� ����� ������ ����� ����������, ���������� ����� ������ �����������������!";
        private int maxBunner = 1;
       
        private int _bunnerCollected = 0;
        private int _weaponsCollected = 0;

        [SerializeField]
        private AudioSource _gameWin;

        private int _maxItems = 6;
        public bool _showWinScreen = false;

        public int Weapons
        {
            get { return _weaponsCollected; }
            set
            {
                _weaponsCollected = value;
                Debug.LogFormat("Weapons:{0}", _weaponsCollected);
                if (_weaponsCollected >= _maxItems)
                {
                    _labelText = "��������� ������ �������� ���� ����� ������ �������������!";
                    _showWinScreen = true;
                    Time.timeScale = 0f;
                }
                else
                {
                    _labelText = "����� ���� ��� ������ " +
                    (_maxItems - _weaponsCollected) + ". ������, ������!";
                }
            }
        }


        public int Bunner
        {
            get { return _bunnerCollected; }
            set
            {
                _bunnerCollected = value;
                Debug.LogFormat("The symbol is sacred:{0}", _bunnerCollected);
                if (_bunnerCollected >= maxBunner)
                {
                    _labelText = "������ ������ ���������!";
                    _showWinScreen = true;
                    Time.timeScale = 0f;
                }
            }
        }
        void OnGUI()
        {
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = 30;
            myStyle.fontStyle = FontStyle.BoldAndItalic;
            myStyle.normal.textColor = Color.white;
            GUI.Box(new Rect(1350, 90, 250, 50),
            "������ ��������������������: " + Weapons, myStyle);
            GUI.Label(new Rect(Screen.width / 2 - 125, Screen.height - 100,
            300, 150), _labelText);

            WinScreen();

            if (GUI.Button(new Rect(Screen.width / 2 - 650,
             Screen.height / 2 - 500, 150, 50), "����� �� ����"))
            {
                Application.Quit();
            }
        }
        public void WinScreen()
        {
            if (_showWinScreen)
            {
                if (_isPlayedWin)
                {
                    _gameWin.Play();
                }
                _isPlayedWin = false;
                if (GUI.Button(new Rect(Screen.width / 2 - 250,
                Screen.height / 2 - 50, 400, 100), "������� ����-�������! �� ��������!"))
                {
                    SceneManager.LoadScene(0);
                    Time.timeScale = 1.0f;
                }
            }
        }
    }
}

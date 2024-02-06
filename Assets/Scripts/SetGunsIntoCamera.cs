using UnityEngine;
using Mirror;
using System.Collections.Generic;

namespace Builds
{
    public class SetGunsIntoCamera : NetworkBehaviour
    {
        [SerializeField]
        private GameObject[] guns;
        private List<Weapon> weapons = new List<Weapon>();
        [SerializeField]
        private GameObject _cam;
        private GameObject _currentGun;

        private void OnTriggerEnter(Collider other)
        {
            if (isLocalPlayer)
            {
                if (other.gameObject.name == "Rail Gun")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[0], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }

                if (other.gameObject.name == "Shotgun")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[1], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }

                if (other.gameObject.name == "Beam Gun")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[2], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }

                if (other.gameObject.name == "M4")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[3], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }

                if (other.gameObject.name == "Pistol")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[4], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }

                if (other.gameObject.name == "Rocket Launcher")
                {
                    DestroyGun();
                    _cam.transform.localPosition = new Vector3(0, 1.7f, 0.7f);
                    _currentGun = Instantiate(guns[5], _cam.transform);
                    weapons.Add(_currentGun.GetComponent<Weapon>());
                }
            }
        }

        private void DestroyGun()
        {
            Destroy(_currentGun);
        }

        public void DisableFireGun()
        {
            _currentGun.GetComponent<Weapon>().enabled = false;
        }
    }
}

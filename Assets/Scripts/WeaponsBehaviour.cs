using System.Collections.Generic;
using UnityEngine;
namespace Builds
{
    public class WeaponsBehaviour : MonoBehaviour
    {
        [SerializeField]
        private PlayerControl _weapons;
        private List<string> players = new List<string>();

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (!players.Contains(collision.gameObject.name))
                {
                    _weapons = collision.gameObject.GetComponent<PlayerControl>();
                    DestroyMethod(collision.gameObject);
                }
            }
        }       
        public void DestroyMethod(GameObject player)
        {
            players.Add(gameObject.name);
            Debug.Log("Here it is the weapon of the Russian land, in your hands!");
            _weapons.Weapons += 1;
        }
    }
}

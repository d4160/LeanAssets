// UltEvents // Copyright 2019 Kybernetik //

using Lean.Pool;
using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D collision events:
    /// <see cref="OnCollisionEnter2D"/>, <see cref="OnCollisionStay2D"/>, and <see cref="OnCollisionExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Poolable Events")]
    [DisallowMultipleComponent]
    public class PoolableEvents : MonoBehaviour, IPoolable
    {
        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _OnSpawnEvent;

        public UltEvent OnSpawnEvent
        {
            get
            {
                if (_OnSpawnEvent == null)
                    _OnSpawnEvent = new UltEvent();
                return _OnSpawnEvent;
            }
            set { _OnSpawnEvent = value; }
        }

        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _OnDespawnEvent;

        public UltEvent OnDespawnEvent
        {
            get
            {
                if (_OnDespawnEvent == null)
                    _OnDespawnEvent = new UltEvent();
                return _OnDespawnEvent;
            }
            set { _OnDespawnEvent = value; }
        }

        /************************************************************************************************************************/


        public void OnSpawn()
        {
            OnSpawnEvent.Invoke();
        }

        public void OnDespawn()
        {
            OnDespawnEvent.Invoke();
        }
    }
}
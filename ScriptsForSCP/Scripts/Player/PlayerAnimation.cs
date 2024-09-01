using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{


    public class PlayerAnimation : MonoBehaviour
    {
        public AnimationClip[] animationClips;

        public AnimationClip Search(string name)
        {
            try
            {
                foreach (var clip in animationClips)
                {
                    if (clip.name == name)
                    {
                        return clip;
                    }
                }
            }
            catch 
            {
                return null;
            }
            return null;
        }


    }


}

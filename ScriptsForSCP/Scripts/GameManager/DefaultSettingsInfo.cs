using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ForButtonInMenu
{
    public class DefaultSettingsInfo : MonoBehaviour
    {
        [Header("Sound")]
        public static float volumeMain = 50;
        public static float volumeMusic = 50;
        public static float volumeMainMenu = 50;
        public static float volumeGame = 50;
        private void SetVolumeGame(float slider)
        {
            volumeGame = slider;
        }
        private void SetVolumeMusic(float slider)
        {
            volumeGame = slider;
        }
        private void SetVolumeMainMenu(float slider)
        {
            volumeGame = slider;
        }
        private void SetVolumeMain(float slider)
        {
            volumeGame = slider;
        }
        [Header("Video")]
        public static Resolution[] rsl;
        public static float qualityVideo;


        [Header("Code Button")]
        public static KeyCode Take = KeyCode.E;

        public static KeyCode w = KeyCode.W;
        public static KeyCode a = KeyCode.A;
        public static KeyCode s = KeyCode.S;
        public static KeyCode d = KeyCode.D;

        public static KeyCode space = KeyCode.Space;
        public static KeyCode flashLight = KeyCode.F;
        public static KeyCode run = KeyCode.LeftShift;

        public static float sensMouse = 50f;


    }
}
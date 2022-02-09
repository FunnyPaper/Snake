using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Settings
{
    public static class SettingsManager
    {
        public static Settings CurrentState { get; private set; }
        public static Settings TemporaryState { get; private set; }
        public static Settings DefaultState { get; private set; }

        public static void Save()
        {
            CurrentState = TemporaryState.DeepClone();
        }

        public static void Cancel()
        {
            TemporaryState = CurrentState.DeepClone();
        }

        public static void Default()
        {
            TemporaryState = DefaultState.DeepClone();
        }

        static SettingsManager()
        {
            DefaultState = new Settings();
            CurrentState = DefaultState.DeepClone();
            TemporaryState = DefaultState.DeepClone();
        }
    }
}

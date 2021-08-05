using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ThisIsWin11.Lucent11.Assessment
{
    ///check whether registry values equal
    internal class RegistryHelper
    {
        public AssessmentBase Assessment { get; }

        public static bool IntEquals(string keyName, string valueName, int expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);
                return (value != null && (int)value == expectedValue);
            }
            catch (Exception ex)

            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }

        ///check whether registry strings equal
        public static bool StringEquals(string keyName, string valueName, string expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);
                return (value != null && (string)value == expectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
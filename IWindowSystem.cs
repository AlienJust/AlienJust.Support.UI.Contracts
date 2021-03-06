﻿namespace AlienJust.Support.UI.Contracts
{
    public interface IWindowSystem
    {
        string ShowOpenFileDialog(string dialogTitle, string filter);
        string[] ShowOpenFilesDialog(string dialogTitle, string filter);
        string ShowSaveFileDialog(string dialogTitle, string filter);
        void ShowMessageBox(string message, string caption);
        BinaryChoise ShowYesNoDialog(string message, string caption);
        string ShowOpenFolderDialog(string dialogTitle, string defaultDirectory = null);
    }
}
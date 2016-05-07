using System.Windows.Forms;

namespace UILibrary
{
    internal class ShellTextBox : TextBox
    {
        private string prompt = ">>>";
        private CommandHistory commandHistory = new CommandHistory();
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        internal ShellTextBox()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            printPrompt();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        // Overridden to protect against deletion of contents
        // cutting the text and deleting it from the context menu
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0302: //WM_PASTE
                case 0x0300: //WM_CUT
                case 0x000C: //WM_SETTEXT
                    if (!IsCaretAtWritablePosition())
                        MoveCaretToEndOfText();
                    break;
                case 0x0303: //WM_CLEAR
                    return;
            }
            base.WndProc(ref m);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // ShellTextBox
            // 
            AcceptsReturn = true;
            AcceptsTab = true;
            BackColor = System.Drawing.Color.Black;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            Dock = System.Windows.Forms.DockStyle.Fill;
            ForeColor = System.Drawing.Color.LawnGreen;
            MaxLength = 0;
            Multiline = true;
            ScrollBars = ScrollBars.Both;
            Size = new System.Drawing.Size(400, 176);
            KeyDown += new System.Windows.Forms.KeyEventHandler(ShellControl_KeyDown);
            KeyPress += new System.Windows.Forms.KeyPressEventHandler(shellTextBox_KeyPress);
            ResumeLayout(false);

        }
        #endregion

        private void printPrompt()
        {
            string currentText = Text;
            if (currentText.Length != 0 && currentText[currentText.Length - 1] != '\n')
                printLine();
            AddText(prompt);
        }

        private void printLine()
        {
            AddText(System.Environment.NewLine);
        }

        // Handle Backspace and Enter keys in KeyPress. A bug in .NET 1.1
        // prevents the e.Handled = true from having the desired effect in KeyDown
        private void shellTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle backspace
            if (e.KeyChar == (char)8 && IsCaretJustBeforePrompt())
            {
                e.Handled = true;
                return;
            }

            if (IsTerminatorKey(e.KeyChar))
            {
                e.Handled = true;
                string currentCommand = GetTextAtPrompt();
                if (currentCommand.Length != 0)
                {
                    printLine();
                    ((ShellControl)Parent).FireCommandEntered(currentCommand);
                    commandHistory.Add(currentCommand);
                }
                printPrompt();
            }
        }

        private void ShellControl_KeyDown(object sender, KeyEventArgs e)
        {
            // If the caret is anywhere else, set it back when a key is pressed.
            if (!IsCaretAtWritablePosition() && !(e.Control || IsTerminatorKey(e.KeyCode)))
            {
                MoveCaretToEndOfText();
            }

            // Prevent caret from moving before the prompt
            if (e.KeyCode == Keys.Left && IsCaretJustBeforePrompt())
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (commandHistory.DoesNextCommandExist())
                {
                    ReplaceTextAtPrompt(commandHistory.GetNextCommand());
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (commandHistory.DoesPreviousCommandExist())
                {
                    ReplaceTextAtPrompt(commandHistory.GetPreviousCommand());
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                // Performs command completion
                string currentTextAtPrompt = GetTextAtPrompt();
                string lastCommand = commandHistory.LastCommand;

                if (lastCommand != null && (currentTextAtPrompt.Length == 0 || lastCommand.StartsWith(currentTextAtPrompt)))
                {
                    if (lastCommand.Length > currentTextAtPrompt.Length)
                    {
                        AddText(lastCommand[currentTextAtPrompt.Length].ToString());
                    }
                }
            }
        }

        private string GetCurrentLine()
        {
            if (Lines.Length > 0)
            {
                if((string)Lines.GetValue(Lines.GetLength(0) - 1) == "")
                {
                    return (string)Lines.GetValue(Lines.GetLength(0) - 2);
                }
                return (string)Lines.GetValue(Lines.GetLength(0) - 1);
            }
            else
            {
                return "";
            }
        }

        private string GetTextAtPrompt()
        {
            var l = GetCurrentLine();
            return l.Substring(prompt.Length);
        }

        private void ReplaceTextAtPrompt(string text)
        {
            string currentLine = GetCurrentLine();
            int charactersAfterPrompt = currentLine.Length - prompt.Length;

            if (charactersAfterPrompt == 0)
                AddText(text);
            else
            {
                Select(TextLength - charactersAfterPrompt, charactersAfterPrompt);
                SelectedText = text;
            }
        }

        private bool IsCaretAtCurrentLine() =>
            TextLength - SelectionStart <= GetCurrentLine().Length;

        private void MoveCaretToEndOfText()
        {
            SelectionStart = TextLength;
            ScrollToCaret();
        }

        private bool IsCaretJustBeforePrompt() =>
            IsCaretAtCurrentLine() && GetCurrentCaretColumnPosition() == prompt.Length;

        private int GetCurrentCaretColumnPosition()
        {
            string currentLine = GetCurrentLine();
            int currentCaretPosition = SelectionStart;
            return (currentCaretPosition - TextLength + currentLine.Length);
        }

        private bool IsCaretAtWritablePosition() =>
            IsCaretAtCurrentLine() && GetCurrentCaretColumnPosition() >= prompt.Length;

        private void SetPromptText(string val)
        {
            string currentLine = GetCurrentLine();
            Select(0, prompt.Length);
            SelectedText = val;

            prompt = val;
        }

        public string Prompt
        {
            get { return prompt; }
            set { SetPromptText(value); }
        }

        public string[] GetCommandHistory() => commandHistory.GetCommandHistory();

        public void WriteText(string text)
        {
            AddText(text);
        }

        private bool IsTerminatorKey(Keys key) => key == Keys.Enter;

        private bool IsTerminatorKey(char keyChar) => ((int)keyChar) == 13;

        private void AddText(string text)
        {
            Text += text;
            MoveCaretToEndOfText();
        }
    }
}
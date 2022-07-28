using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RZEngine.Core.Utilities
{
    public class ErrorUtil
    {
        public static void CreateErrorWindow(
            string stack)
        {
            Form form = CreateForm(
                stack,
                () =>
                {
                    Game.Instance.Exit();
                });
        }

        private static Form CreateForm(
            string errorMessage,
            Action onOk
        )
        {
            Form form = new Form();

            GroupBox groupBox1;
            RichTextBox richTextBox1;
            Button okBtn;

            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            okBtn = new Button();
            groupBox1.SuspendLayout();
            form.SuspendLayout();

            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new System.Drawing.Point(19, 12);
            groupBox1.Margin = new Padding(10, 3, 10, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(584, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Message";

            richTextBox1.Location = new System.Drawing.Point(13, 26);
            richTextBox1.Margin = new Padding(10, 3, 10, 10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(558, 351);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = errorMessage;

            okBtn.Location = new System.Drawing.Point(216, 432);
            okBtn.Name = "okBtn";
            okBtn.Size = new System.Drawing.Size(176, 32);
            okBtn.TabIndex = 1;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += new EventHandler(
                delegate (object sender, EventArgs e)
                {
                    onOk.Invoke();
                });

            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            form.AutoScaleMode = AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(622, 492);
            form.Controls.Add(okBtn);
            form.Controls.Add(groupBox1);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.Name = "Form2";
            form.Text = "Error Window";
            form.FormClosed += new FormClosedEventHandler(
                delegate (object sender, FormClosedEventArgs e)
                {
                    onOk.Invoke();
                });
            groupBox1.ResumeLayout(false);
            form.ResumeLayout(false);

            return form;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSO1.Model;


namespace PSO1.Model
{
    public class FormElementsDisplay
    {
        public static void DisplayNewLabel(Label label, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = SystemColors.HotTrack;
            label.BackColor = Color.LightGray;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            Form.ActiveForm.Controls.Add(label);
        }
        public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = SystemColors.HotTrack;
            label.BackColor = Color.LightGray;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
        }
        //public static void DisplayNewLabelRelativeOnPanel(Label label, Panel panel, Control controlForRelativePosition, int[] spacers, int[] size, string labelText, Font font)
        public static void DisplayNewLabelOnPanel(Label label, Panel panel, Control parentItem, int[] spacers, int[] size, string labelText, Font font)
        {

            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }

            int[] pointPos = new int[2];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            label.Font = font;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
        }

        //public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText, Font font, Color color)
        public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText, Font font)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            //label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Font = font;
            //label.ForeColor = SystemColors.HotTrack;
            //label.BackColor = Color.LightGray;
            //label.BackColor = color;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
        }

        public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText, Font font, Color foreColor, Color backColor)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            //label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Font = font;
            label.ForeColor = foreColor;
            label.BackColor = backColor;
            //label.BackColor = color;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
        }
        public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText, Font font, Color foreColor)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            //label.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Font = font;
            label.ForeColor = foreColor;
            //label.BackColor = color;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
        }


        public static void DisplayNewDataGridView(DataGridView dataGridView, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            dataGridView.Anchor = (AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right));
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(posX, posY);
            dataGridView.Size = new Size(length, hight);
            dataGridView.TabIndex = 0;
            Form.ActiveForm.Controls.Add(dataGridView);
        }
        public static void DisplayNewDataGridViewOnPanel(DataGridView dataGridView, Panel panel, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            dataGridView.Anchor = (AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right));
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(posX, posY);
            dataGridView.Size = new Size(length, hight);
            dataGridView.TabIndex = 0;
            panel.Controls.Add(dataGridView);
        }


        public static void DisplayNewTextBox(TextBox textBox, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            textBox.Location = new Point(posX, posY);
            textBox.Name = labelText;
            textBox.Size = new Size(length, hight);
            textBox.TabIndex = 0;
            textBox.Text = labelText;
            Form.ActiveForm.Controls.Add(textBox);
        }
        public static void DisplayNewTextBoxOnPanel(TextBox textBox, Panel panel, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            textBox.Location = new Point(posX, posY);
            //textBox.Name = labelText;
            textBox.Size = new Size(length, hight);
            textBox.TabIndex = 0;
            //textBox.Text = labelText;
            panel.Controls.Add(textBox);
        }
        public static void DisplayNewTextBoxOnPanel(TextBox textBox, Panel panel, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            textBox.Location = new Point(posX, posY);
            textBox.Name = labelText;
            textBox.Size = new Size(length, hight);
            textBox.TabIndex = 0;
            textBox.Text = labelText;
            panel.Controls.Add(textBox);
        }

        public static void DisplayNewTextBoxOnPanel(TextBox textBox, Panel panel, Control parentItem, int[] spacers, int[] size, string labelText)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }
            if (labelText != String.Empty)
            {
                textBox.Name = labelText;
                textBox.Text = labelText;
            }
            textBox.Location = new Point(posX, posY);
            textBox.Size = new Size(size[0], size[1]);
            panel.Controls.Add(textBox);

        }

        public static void DisplayNewButton(Button button, int[] position, int[] size, string name, string buttonText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = name;
            button.Size = new Size(length, hight);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            //
            //this.Controls.Add(this.button1);
            //Form.ActiveForm.Controls.Add(button);
        }
        public static void DisplayNewButton(Button button, int[] position, int[] size, string name, string buttonText, Font font)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = name;
            button.Size = new Size(length, hight);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            //this.Controls.Add(this.button1);
            //Form.ActiveForm.Controls.Add(button);
        }

        public static void DisplayNewButtonOnPanel(Button button, Panel panel, int[] position, int[] size, string name, string buttonText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = name;
            button.Size = new Size(length, hight);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            panel.Controls.Add(button);
        }

        public static void DisplayNewButtonOnPanel(Button button, Panel panel, int[] position, int[] size, string buttonText, Font font)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = buttonText;
            button.Size = new Size(length, hight);
            button.Font = font;
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            panel.Controls.Add(button);
        }

        //public static void DisplayNewLabelOnPanel(Label label, Panel panel, Control parentItem, int[] spacers,  int[] size, string labelText, Font font)
        public static void DisplayNewButtonOnPanel(Button button, Panel panel, Control parentItem, int[] spacers, int[] size, string buttonText, Font font)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }

            //int[] pointPos = new int[2];
            int length = size[0];
            int hight = size[1];
            button.AutoSize = true;
            button.Font = font;
            button.Location = new Point(posX, posY);
            button.Name = buttonText;
            button.Size = new Size(length, hight);
            //button.TabIndex = 0;
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            panel.Controls.Add(button);

        }



        public static void DisplayNewPanel(Panel panel, int[] position, int[] size, string name, bool withBorder)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            panel.Location = new Point(posX, posY);
            panel.Name = name;
            panel.Size = new Size(length, hight);
            if (withBorder)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
            //Form.ActiveForm.Controls.Add(panel);
        }

        public static void DisplayNewPanel(Panel panel, Panel parentPanel, int[] position, int[] size, string name, bool withBorder)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            panel.Location = new Point(posX, posY);
            panel.Name = name;
            panel.Size = new Size(length, hight);
            if (withBorder)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
            parentPanel.Controls.Add(panel);
        }

        public static void DisplayListBox(ListBox listbox, Panel panel, int[] position, int[] size, string name, BindingSource source)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            listbox.FormattingEnabled = true;
            listbox.Location = new Point(posX, posY);
            listbox.Name = name;
            listbox.Size = new Size(length, hight);
            listbox.DataSource = source;
            panel.Controls.Add(listbox);
        }

        public static void DisplayListBox(ListBox listbox, Panel panel, Control parentItem, int[] spacers, int[] size, string name, BindingSource source)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }

            int length = size[0];
            int hight = size[1];

            listbox.FormattingEnabled = true;
            listbox.Location = new Point(posX, posY);
            listbox.Name = name;
            listbox.Size = new Size(length, hight);
            listbox.DataSource = source;
            panel.Controls.Add(listbox);

        }

        public static void DisplayListBox(ListBox listbox, Panel panel, Control parentItem, List<int[]> SizeAndSpace, string name, BindingSource source)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;
            int[] size = SizeAndSpace[0];
            int[] spacers = SizeAndSpace[1];
            int[] spaceFactor = SizeAndSpace[2];

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0] * spaceFactor[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1] * spaceFactor[1];
            }
            listbox.FormattingEnabled = true;
            listbox.Location = new Point(posX, posY);
            listbox.Name = name;
            listbox.Size = new Size(size[0], size[1]);
            listbox.DataSource = source;
            panel.Controls.Add(listbox);

        }

        public static void DisplayListBox(ListBox listbox, Panel panel, Control parentItem, List<int[]> SizeAndSpace, string name, BindingSource source, string defaultText)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;
            int[] size = SizeAndSpace[0];
            int[] spacers = SizeAndSpace[1];
            int[] spaceFactor = SizeAndSpace[2];

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0] * spaceFactor[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1] * spaceFactor[1];
            }
            listbox.SelectedItem = null;
            listbox.SelectedIndex = -1;
            //listbox.Text = defaultText;
            listbox.FormattingEnabled = true;
            listbox.Location = new Point(posX, posY);
            listbox.Name = name;
            listbox.Size = new Size(size[0], size[1]);

            listbox.DataSource = source;
            panel.Controls.Add(listbox);

        }

        public static void DisplayCheckBox(CheckBox checkbox, Panel panel, Control parentItem, int[] spacers, int[] size, string checkBoxText, Font font)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }
            checkbox.AutoSize = true;
            checkbox.Font = font;
            checkbox.Location = new Point(posX, posY);
            checkbox.Name = checkBoxText;
            checkbox.Text = checkBoxText;
            checkbox.Size = new Size(size[0], size[1]);
            checkbox.UseVisualStyleBackColor = true;

            panel.Controls.Add(checkbox);
        }

        public static void DisplayNewRichTextBoxOnPanel(RichTextBox rTextBox, Panel panel, int[] position, int[] size, string rTextBoxText, Font font)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            rTextBox.Location = new Point(posX, posY);
            rTextBox.Font = font;
            rTextBox.Name = rTextBoxText;
            rTextBox.Text = "";
            rTextBox.Size = new Size(length, hight);
            panel.Controls.Add(rTextBox);
        }

        public static void DisplayNewRichTextBoxOnPanel(RichTextBox rTextBox, Panel panel, Control parentItem, int[] spacers, int[] size, string checkBoxText, Font font)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }
            rTextBox.Font = font;
            rTextBox.Location = new Point(posX, posY);
            rTextBox.Name = checkBoxText;
            rTextBox.Text = "";
            rTextBox.Size = new Size(size[0], size[1]);
            panel.Controls.Add(rTextBox);
        }

        public static void clearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }


        public static int CalculateLabelLenght(string labelText)
        {
            int length = labelText.Length * 5;
            return length;
        }
        public delegate bool EcryptionCheck(string user, int selection);
        public delegate void DBupdate(string user, int selection);
        public static void DisplayClickedMessage(int selection, RichTextBox MessagePage, Panel panel, string rawMessage, EcryptionCheck encryptionCheck, DBupdate update, string crtUser)
        {
            bool encryption;
            if (!encryptionCheck(crtUser, selection))
            {
                encryption = false;
            }
            else
            {
                encryption = true;
            }

            if (!encryption)
            {
                MessagePage.Text = rawMessage;
            }
            else
            {
                string key = "abracadabra";
                string decryptedMessage = Encryption.StringDecrypt(rawMessage, key);
                MessagePage.Text = decryptedMessage;
            }
            update(crtUser, selection);
            panel.Show();
        }

        public static void DisplayNumericUpDownOnPanel(NumericUpDown numUpDown, Panel panel, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            numUpDown.Location = new Point(posX, posY);
            numUpDown.Name = labelText;
            numUpDown.Size = new Size(length, hight);
            //rTextBox.TabIndex = 0;
            //rTextBox.Text = labelText;
            panel.Controls.Add(numUpDown);
        }

        public static void DisplayNumericUpDownOnPanel(NumericUpDown numUpDown, Panel panel, Control parentItem, int[] spacers, int[] size, string numUpDownText, Font font)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }
            numUpDown.Font = font;
            numUpDown.Location = new Point(posX, posY);
            numUpDown.Name = numUpDownText;
            numUpDown.Text = "";
            numUpDown.Size = new Size(size[0], size[1]);
            panel.Controls.Add(numUpDown);
        }

        public static void DisplayNumericUpDownOnPanel(NumericUpDown numUpDown, Panel panel, int[] position, int[] size, string numUpDownText, Font font)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            numUpDown.Location = new Point(posX, posY);
            numUpDown.Size = new Size(length, hight);
            numUpDown.Font = font;
            numUpDown.Name = numUpDownText;
            numUpDown.Text = "";
            panel.Controls.Add(numUpDown);
        }

        public static Bitmap GetBitmap(byte[] pData)
        {
            MemoryStream mStream = new MemoryStream();
            Bitmap bm = null;
            try
            {
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                bm = new Bitmap(mStream, false);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("no picture");
            }

            mStream.Dispose();
            return bm;
        }

        public static void DisplayPicture(PictureBox pictureBox, Panel panel, Control parentItem, int[] spacers, int[] size)
        {
            int posX = parentItem.Location.X;
            int posY = parentItem.Location.Y;

            if (spacers[0] != 0)
            {
                posX += parentItem.Width + spacers[0];
            }
            if (spacers[1] != 0)
            {
                posY += parentItem.Height + spacers[1];
            }

            pictureBox.Location = new Point(posX, posY);
            pictureBox.Size = new Size(size[0], size[1]);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(pictureBox);


        }

    }
}

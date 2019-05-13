using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBKInterface
{
    class RuleTextPanelPreset
    {

        public TableLayoutPanel Table { get; } = new TableLayoutPanel()
        {
            Size = new Size(200,100),
            ColumnCount = 1,
            RowCount = 2,
            BackColor = SystemColors.ControlLight
        };

        private Label _label = new Label()
        {
            Anchor = AnchorStyles.None,
            AutoSize = true,
            Font = new Font("Microsoft Sans Serif", 12)
        };

        private Button _button1 = new Button()
        {
            Anchor = AnchorStyles.None,
            AutoSize = true,
            Text = "Изменить",
            Enabled = false,
            BackColor = SystemColors.ControlLight
        };

        private Button _button2 = new Button()
        {
            Anchor = AnchorStyles.None,
            AutoSize = true,
            Text = "Удалить",
            Enabled = false,
            BackColor = SystemColors.ControlLight
        };

        TableLayoutPanel ButtonsPanel = new TableLayoutPanel()
        {
            Anchor = AnchorStyles.None,
            AutoSize = true,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = SystemColors.ControlLight,
        };

        string Id { get; set; }

        public RuleTextPanelPreset(string text, string id)
        {
            _label.Text = text;
            Id = id;

            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 58));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 42));

            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            Table.Controls.Add(_label);

            ButtonsPanel.Controls.Add(_button1);
            ButtonsPanel.Controls.Add(_button2);

            Table.Controls.Add(ButtonsPanel);
        }
    }
}

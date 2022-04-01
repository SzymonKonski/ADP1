namespace SoundAnalysis1
{
    partial class IntervalStatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.number = new System.Windows.Forms.ColumnHeader();
            this.from = new System.Windows.Forms.ColumnHeader();
            this.to = new System.Windows.Forms.ColumnHeader();
            this.duration = new System.Windows.Forms.ColumnHeader();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.from,
            this.to,
            this.duration});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(3, 24);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(564, 450);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "Number";
            this.number.Width = 30;
            // 
            // from
            // 
            this.from.Text = "From";
            this.from.Width = 100;
            // 
            // to
            // 
            this.to.Text = "To";
            this.to.Width = 100;
            // 
            // duration
            // 
            this.duration.Text = "Duration in milliseconds";
            this.duration.Width = 100;
            // 
            // statisticLabel
            // 
            this.statisticLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Location = new System.Drawing.Point(266, 6);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(38, 15);
            this.statisticLabel.TabIndex = 1;
            this.statisticLabel.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.statisticLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.402516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.59748F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 477);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // IntervalStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IntervalStatisticsForm";
            this.Text = "Interval statistics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView;
        private ColumnHeader number;
        private ColumnHeader from;
        private ColumnHeader to;
        private ColumnHeader duration;
        private Label statisticLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
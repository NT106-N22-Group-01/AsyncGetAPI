namespace AsyncGetAPI
{
	partial class API
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBoxOutput = new GroupBox();
			dataGridViewAPIResult = new DataGridView();
			buttonGetAPI = new Button();
			groupBoxOutput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewAPIResult).BeginInit();
			SuspendLayout();
			// 
			// groupBoxOutput
			// 
			groupBoxOutput.Controls.Add(dataGridViewAPIResult);
			groupBoxOutput.Location = new Point(24, 25);
			groupBoxOutput.Name = "groupBoxOutput";
			groupBoxOutput.Size = new Size(1003, 464);
			groupBoxOutput.TabIndex = 0;
			groupBoxOutput.TabStop = false;
			groupBoxOutput.Text = "Output";
			// 
			// dataGridViewAPIResult
			// 
			dataGridViewAPIResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewAPIResult.Location = new Point(15, 30);
			dataGridViewAPIResult.Name = "dataGridViewAPIResult";
			dataGridViewAPIResult.RowHeadersWidth = 62;
			dataGridViewAPIResult.RowTemplate.Height = 33;
			dataGridViewAPIResult.Size = new Size(972, 416);
			dataGridViewAPIResult.TabIndex = 5;
			// 
			// buttonGetAPI
			// 
			buttonGetAPI.Font = new Font("Open Sans", 11F, FontStyle.Bold, GraphicsUnit.Point);
			buttonGetAPI.Location = new Point(470, 515);
			buttonGetAPI.Name = "buttonGetAPI";
			buttonGetAPI.Size = new Size(119, 39);
			buttonGetAPI.TabIndex = 1;
			buttonGetAPI.Text = "Get API";
			buttonGetAPI.UseVisualStyleBackColor = true;
			buttonGetAPI.Click += buttonGetAPI_Click;
			// 
			// API
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1051, 578);
			Controls.Add(buttonGetAPI);
			Controls.Add(groupBoxOutput);
			Name = "API";
			Text = "Week 06";
			groupBoxOutput.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewAPIResult).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxOutput;
		private DataGridView dataGridViewAPIResult;
		private Button buttonGetAPI;
	}
}
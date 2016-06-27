using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SevenKnightsAI.Classes;

namespace SevenKnightsAI
{
	
	public partial class StageSequencerForm : Form
	{
		
		public StageSequencerForm(AISettings settings, bool readOnlyMode)
		{
			this.InitializeComponent();
			this.AISettings = settings;
			this.ReadOnlyMode = readOnlyMode;
		}

		
		private void clearButton_Click(object sender, EventArgs e)
		{
			this.DataTable.Clear();
			this.UpdateDataSource();
		}

		
		private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.editingRow = e.RowIndex;
			this.editingColumn = e.ColumnIndex;
		}

		
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (dataGridView.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0 && this.DataTable.Rows.Count > 0 && rowIndex < this.DataTable.Rows.Count)
			{
				this.DataTable.Rows.RemoveAt(rowIndex);
				this.UpdateDataSource();
			}
		}

		
		private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this.UpdateDataSource();
		}

		
		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			if (rowIndex % 2 == 1)
			{
				dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;
			}
			else
			{
				dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
			}
			DataGridViewButtonCell dataGridViewButtonCell = dataGridView.Rows[rowIndex].Cells[columnIndex] as DataGridViewButtonCell;
			if (rowIndex < this.DataTable.Rows.Count && dataGridView.Columns[columnIndex] is DataGridViewButtonColumn && dataGridViewButtonCell != null)
			{
				dataGridViewButtonCell.FlatStyle = FlatStyle.Popup;
				dataGridViewButtonCell.Style.Font = new Font(this.Font.SystemFontName, 7f, FontStyle.Bold);
				dataGridViewButtonCell.Style.ForeColor = Color.White;
				dataGridViewButtonCell.Style.BackColor = this.COLOR_DELETE_BUTTON;
			}
		}

		
		private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			int arg_0D_0 = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			dataGridView.ClearSelection();
			if (rowIndex >= 0)
			{
				dataGridView.Rows[rowIndex].Selected = true;
			}
		}

		
		private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				int num;
				if (!int.TryParse(Convert.ToString(e.FormattedValue), out num))
				{
					e.Cancel = true;
					return;
				}
				if (num == 0)
				{
					e.Cancel = true;
				}
			}
		}

		
		private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			int stageCount = 10;
			string value = dataGridView.Rows[this.editingRow].Cells["World"].Value.ToString();
			if (Array.IndexOf<string>(this.worldConverter, value) == 7)
			{
				stageCount = 20;
			}
            else if (Array.IndexOf<string>(this.worldConverter, value) == 8)
            {
                stageCount = 15;
            }
			if (this.editingColumn == 3 && stageCount < 20)
			{
				ComboBox comboBox = e.Control as ComboBox;
				int num = stageCount;
				while (comboBox.Items.Count > num)
				{
					comboBox.Items.RemoveAt(num);
				}
			}
		}

		
		private void dataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			this.UpdateDataSource();
			int num = dataGridView.RowCount - 1;
			dataGridView.FirstDisplayedScrollingRowIndex = num;
			dataGridView.ClearSelection();
			dataGridView.Rows[num].Selected = true;
		}

		
		private void dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			this.UpdateDataSource();
		}

		
		private void doneButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		
		private void Init()
		{
			if (this.ReadOnlyMode)
			{
				this.dataGridView.Enabled = false;
				this.dataGridView.ReadOnly = true;
				this.clearButton.Enabled = false;
				this.runningWarningLabel.Visible = true;
			}
			this.DataTable = new DataTable();
			this.DataTable.Columns.Add("Index", typeof(int));
			this.DataTable.Columns.Add("World", typeof(string));
			this.DataTable.Columns.Add("Stage", typeof(string));
			this.DataTable.Columns.Add("Amount", typeof(int));
			this.LoadSettings();
		}

		
		private void LoadSettings()
		{
			if (this.AISettings.AD_WorldSequence != null && this.AISettings.AD_StageSequence != null && this.AISettings.AD_AmountSequence != null)
			{
				int num = this.AISettings.AD_WorldSequence.Length;
				for (int i = 0; i < num; i++)
				{
					string text = this.worldConverter[this.AISettings.AD_WorldSequence[i] - 2];
					string text2 = this.stageConverter[this.AISettings.AD_StageSequence[i]];
					int num2 = this.AISettings.AD_AmountSequence[i];
					this.DataTable.Rows.Add(new object[]
					{
						i + 1,
						text,
						text2,
						num2
					});
				}
			}
			this.UpdateDataSource();
		}

		
		private void SaveSettings()
		{
			int count = this.DataTable.Rows.Count;
			int[] array = new int[count];
			int[] array2 = new int[count];
			int[] array3 = new int[count];
			int num = 0;
			foreach (DataRow dataRow in this.DataTable.Rows)
			{
				int num2 = Array.IndexOf<string>(this.worldConverter, dataRow["World"].ToString()) + 2;
				int num3 = Array.IndexOf<string>(this.stageConverter, dataRow["Stage"].ToString());
				int num4 = Convert.ToInt32(dataRow["Amount"]);
				array[num] = num2;
				array2[num] = num3;
				array3[num] = num4;
				num++;
			}
			this.AISettings.AD_WorldSequence = array;
			this.AISettings.AD_StageSequence = array2;
			this.AISettings.AD_AmountSequence = array3;
		}

		
		private void StageSequencerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.dataGridView.EndEdit();
		}

		
		private void StageSequencerForm_Load(object sender, EventArgs e)
		{
			this.Init();
		}

		
		private void UpdateDataSource()
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.DataTable;
			try
			{
				this.dataGridView.DataSource = bindingSource;
				this.dataGridView.Refresh();
				if (this.ReadOnlyMode)
				{
					this.dataGridView.ClearSelection();
				}
			}
			catch (Exception)
			{ }
			int num = 0;
			foreach (DataRow dataRow in this.DataTable.Rows)
			{
				dataRow["Index"] = num + 1;
				if (dataRow["World"] == DBNull.Value)
				{
					dataRow["World"] = this.worldConverter[0];
				}
				if (dataRow["Stage"] == DBNull.Value)
				{
					dataRow["Stage"] = this.stageConverter[0];
				}
				if (dataRow["Amount"] == DBNull.Value)
				{
					dataRow["Amount"] = 1;
				}
				num++;
			}
			this.SaveSettings();
		}

        private AISettings AISettings;
        private DataTable DataTable;
        private bool ReadOnlyMode;
		private readonly Color COLOR_DELETE_BUTTON = Color.FromArgb(253, 78, 68);
		private int editingColumn = -1;
		private int editingRow = -1;
		private string[] stageConverter = new string[]
		{
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"11",
			"12",
			"13",
			"14",
			"15",
			"16",
			"17",
			"18",
			"19",
			"20"
		};
		private string[] worldConverter = new string[]
		{
			"1 - Mystic Woods",
			"2 - Silent Mine",
			"3 - Blazing Desert",
			"4 - Dark Grave",
			"5 - Dragon Ruins",
			"6 - Frozen Land",
			"7 - Revenger's Hell",
			"8 - Moonlit Isle",
            "9 - Western Emperors Land"
        };
	}
}

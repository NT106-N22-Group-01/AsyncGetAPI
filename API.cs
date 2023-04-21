using System.Text.Json;

namespace AsyncGetAPI
{
	public partial class API : Form
	{
		public API()
		{
			InitializeComponent();
		}

		public class TodoTask
		{
			public int userID { get; set; }
			public int id { get; set; }
			public string title { get; set; }
			public bool completed { get; set; }

		}

		private async Task<List<TodoTask>> GetTasksAsync()
		{
			using HttpClient client = new();
			HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");

			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				List<TodoTask> tasks = JsonSerializer.Deserialize<List<TodoTask>>(content);
				return tasks;
			}
			else
			{
				throw new Exception($"Failed to get tasks. Status code: {response.StatusCode}");
			}
		}

		private void DisplayTask(List<TodoTask> tasks)
		{
			dataGridViewAPIResult.DataSource = null;
			dataGridViewAPIResult.Rows.Clear();
			dataGridViewAPIResult.DataSource = tasks;
		}

		private async void buttonGetAPI_Click(object sender, EventArgs e)
		{
			var tasks = await GetTasksAsync();
			DisplayTask(tasks);
		}
	}
}
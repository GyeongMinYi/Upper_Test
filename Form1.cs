namespace Upper_Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string test_str = "NaH4B";
			List<string> result_strs = get_upper_result(test_str);
		}

		private List<string> get_upper_result(string src_str)
		{
			List<string> result = new List<string>();

			int i = 0;
			foreach (char chr in src_str)
			{
				if (char.IsUpper(chr))
				{
					result.Add(chr.ToString());
					i++;
				}
				else
				{
					result[i - 1] += chr;
				}
			}

			return result;
		}
	}
}
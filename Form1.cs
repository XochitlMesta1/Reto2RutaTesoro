using System.Xml.Linq;

namespace Reto2RutaTesoro
{
    public partial class Form1 : Form
    {
        private readonly ListaSimple route = new ListaSimple();

        public Form1()
        {
            InitializeComponent();
            ConfigureGrid();
            LoadSampleData();
        }

        private void ConfigureGrid()
        {
            dgvMap.AutoGenerateColumns = false;
            dgvMap.Columns.Clear();

            dgvMap.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 60
            });
            dgvMap.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Location",
                DataPropertyName = "Name",
                Width = 220
            });
            dgvMap.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHint",
                HeaderText = "Hint",
                DataPropertyName = "Hint",
                Width = 320
            });
            dgvMap.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDangerLevel",
                HeaderText = "Danger Level",
                DataPropertyName = "DangerLevel",
                Width = 80
            });
        }

        private void LoadSampleData()
        {
            route.Insert(1, "Shipwreck Beach", "Look under the sunken boat", 5);
            route.Insert(2, "Kraken Cove", "The echo keeps a secret", 9);
            route.Insert(3, "Skull Island", "Follow the shadow at noon", 7);
            route.Insert(4, "Lost Temple", "The door opens under a full moon", 8);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgvMap.DataSource = null;
            dgvMap.DataSource = route.Traverse();
            lblTotal.Text = $"Registered locations: {route.Count()}";
        }

        private void ClearFields()
        {
            numid.Value = numid.Minimum;
            txtName.Clear();
            txtHint.Clear();
            numDanger.Value = numDanger.Minimum;

            lblResult.Text = string.Empty;
            lblResult.ForeColor = Color.Black;
        }

        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Location name is required.", "Incomplete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHint.Text))
            {
                MessageBox.Show("Hint is required.", "Incomplete Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
                return;

            int id = (int)numid.Value;
            try
            {
                route.Insert(id, txtName.Text.Trim(), txtHint.Text.Trim(), (int)numDanger.Value);
                UpdateGrid();
                ClearFields();
                MessageBox.Show("Location added to the route.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Could not add",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
                return;

            int id = (int)numid.Value;
            bool success = route.Update(id, txtName.Text.Trim(), txtHint.Text.Trim(), (int)numDanger.Value);

            if (success)
            {
                UpdateGrid();
                MessageBox.Show("Location updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No location found with ID {id}.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)numid.Value;

            var confirmation = MessageBox.Show(
                $"Delete location with ID {id} from the route?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool success = route.Delete(id);

            if (success)
            {
                UpdateGrid();
                ClearFields();
                MessageBox.Show("Location removed from the route.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No location found with ID {id}.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = (int)numid.Value;
            Node? foundNode = route.Find(id);

            if (foundNode != null)
            {
                lblResult.ForeColor = Color.DarkGreen;
                lblResult.Text =
                    $"✔ Found: {foundNode.Name} | Hint: {foundNode.Hint} | Danger: {foundNode.DangerLevel}";

                txtName.Text = foundNode.Name;
                txtHint.Text = foundNode.Hint;
                numDanger.Value = foundNode.DangerLevel;
            }
            else
            {
                lblResult.ForeColor = Color.Firebrick;
                lblResult.Text = $"✘ No location found with ID {id}.";
            }
        }
    }
}

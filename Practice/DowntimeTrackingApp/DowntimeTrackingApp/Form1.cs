using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace DowntimeTrackingApp
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            // Obtener la cadena de conexión del archivo App.config
            connectionString = ConfigurationManager.ConnectionStrings["DowntimeTrackingDB"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión no está configurada correctamente.");
            }
            connection = new SqlConnection(connectionString);
        }

        private void MostrarDatos()
        {
            try
            {
                if (connection == null)
                {
                    throw new InvalidOperationException("La conexión no ha sido inicializada.");
                }

                connection.Open();
                string query = "SELECT * FROM Downtimes";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDatos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int equipmentId = Convert.ToInt32(txtEquipmentId.Text);
                int downtimeTypeId = Convert.ToInt32(txtDowntimeTypeId.Text);
                int employeeId = Convert.ToInt32(txtEmployeeId.Text);
                DateTime startDate = DateTime.Parse(txtStartDate.Text);
                DateTime? plannedEndDate = string.IsNullOrEmpty(txtPlannedEndDate.Text) ? (DateTime?)null : DateTime.Parse(txtPlannedEndDate.Text);
                DateTime? actualEndDate = string.IsNullOrEmpty(txtActualEndDate.Text) ? (DateTime?)null : DateTime.Parse(txtActualEndDate.Text);
                float plannedDowntimeHours = float.Parse(txtPlannedDowntimeHours.Text);
                float actualDowntimeHours = float.Parse(txtActualDowntimeHours.Text);
                string comments = txtComments.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Downtimes 
                                     (EquipmentId, DowntimeTypeId, EmployeeId, StartDate, PlannedEndDate, ActualEndDate, PlannedDowntimeHours, ActualDowntimeHours, Comments) 
                                     VALUES (@EquipmentId, @DowntimeTypeId, @EmployeeId, @StartDate, @PlannedEndDate, @ActualEndDate, @PlannedDowntimeHours, @ActualDowntimeHours, @Comments)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);
                        cmd.Parameters.AddWithValue("@DowntimeTypeId", downtimeTypeId);
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@PlannedEndDate", plannedEndDate.HasValue ? (object)plannedEndDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ActualEndDate", actualEndDate.HasValue ? (object)actualEndDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@PlannedDowntimeHours", plannedDowntimeHours);
                        cmd.Parameters.AddWithValue("@ActualDowntimeHours", actualDowntimeHours);
                        cmd.Parameters.AddWithValue("@Comments", comments);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datos insertados correctamente.");
                MostrarDatos();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["Id"].Value);
                    int equipmentId = Convert.ToInt32(txtEquipmentId.Text);
                    int downtimeTypeId = Convert.ToInt32(txtDowntimeTypeId.Text);
                    int employeeId = Convert.ToInt32(txtEmployeeId.Text);
                    DateTime startDate = DateTime.Parse(txtStartDate.Text);
                    DateTime? plannedEndDate = string.IsNullOrEmpty(txtPlannedEndDate.Text) ? (DateTime?)null : DateTime.Parse(txtPlannedEndDate.Text);
                    DateTime? actualEndDate = string.IsNullOrEmpty(txtActualEndDate.Text) ? (DateTime?)null : DateTime.Parse(txtActualEndDate.Text);
                    float plannedDowntimeHours = float.Parse(txtPlannedDowntimeHours.Text);
                    float actualDowntimeHours = float.Parse(txtActualDowntimeHours.Text);
                    string comments = txtComments.Text;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"UPDATE Downtimes 
                                         SET EquipmentId = @EquipmentId, 
                                             DowntimeTypeId = @DowntimeTypeId, 
                                             EmployeeId = @EmployeeId, 
                                             StartDate = @StartDate, 
                                             PlannedEndDate = @PlannedEndDate, 
                                             ActualEndDate = @ActualEndDate, 
                                             PlannedDowntimeHours = @PlannedDowntimeHours, 
                                             ActualDowntimeHours = @ActualDowntimeHours, 
                                             Comments = @Comments 
                                         WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@EquipmentId", equipmentId);
                            cmd.Parameters.AddWithValue("@DowntimeTypeId", downtimeTypeId);
                            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                            cmd.Parameters.AddWithValue("@StartDate", startDate);
                            cmd.Parameters.AddWithValue("@PlannedEndDate", plannedEndDate.HasValue ? (object)plannedEndDate.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@ActualEndDate", actualEndDate.HasValue ? (object)actualEndDate.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@PlannedDowntimeHours", plannedDowntimeHours);
                            cmd.Parameters.AddWithValue("@ActualDowntimeHours", actualDowntimeHours);
                            cmd.Parameters.AddWithValue("@Comments", comments);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos actualizados correctamente.");
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para actualizar.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Downtimes WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos eliminados correctamente.");
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}

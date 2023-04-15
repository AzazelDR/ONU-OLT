using Octokit;
using System.Net;
using Firebase.Database;
using System.Diagnostics;
using System.Drawing;

namespace OLT_ONU

{
    public partial class Form1 : Form
    {
        private FirebaseClient firebaseClient;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            timer1.Interval = 3000;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        public string command1, serial;
        private int slot, pon, onu = 0;




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    command1 = "show discovery slot all  pon all";
                    break;
                case 1:
                    command1 = "display ont autofind 0\r\ndisplay ont autofind 1\r\ndisplay ont autofind 2\r\ndisplay ont autofind 3\r\ndisplay ont autofind 4\r\ndisplay ont autofind 5\r\ndisplay ont autofind 6\r\ndisplay ont autofind 7\r\ndisplay ont autofind 8\r\ndisplay ont autofind 9\r\ndisplay ont autofind 10\r\ndisplay ont autofind 11\r\ndisplay ont autofind 12\r\ndisplay ont autofind 13\r\ndisplay ont autofind 14\r\ndisplay ont autofind 15";
                    break;
                case 2:
                    command1 = "display ont autofind 0\r\ndisplay ont autofind 1\r\ndisplay ont autofind 2\r\ndisplay ont autofind 3\r\ndisplay ont autofind 4\r\ndisplay ont autofind 5\r\ndisplay ont autofind 6\r\ndisplay ont autofind 7\r\ndisplay ont autofind 8\r\ndisplay ont autofind 9\r\ndisplay ont autofind 10\r\ndisplay ont autofind 11\r\ndisplay ont autofind 12\r\ndisplay ont autofind 13\r\ndisplay ont autofind 14\r\ndisplay ont autofind 15";
                    break;
                case 3:
                    command1 = "show discovery slot all  pon all";
                    break;
                case 4:
                    command1 = "show discovery slot all  pon all";
                    break;
                default:
                    break;
            }
            Clipboard.SetText(command1);
            msgCopy();

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    marsellaNSO();
                    break;
                case 1:
                    sgSP00();
                    break;
                case 2:
                    sgSP01();
                    break;
                case 3:
                    smNSO();
                    break;
                case 4:
                    usuNSO();
                    break;
                default:

                    break;
            }
        }
        public void marsellaNSO()
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Ingresa slot y pon de la nueva ONU", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    string command3 = "show authorization slot " + slot + " pon " + pon;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot y pon", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        public void sgSP00()
        {
            Clipboard.SetText("display current-configuration");
            msgCopy();

        }
        public void sgSP01()
        {
            Clipboard.SetText("display current-configuration");
            msgCopy();
        }
        public void smNSO()
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Ingresa slot y pon de la nueva ONU", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    string command3 = "show authorization slot " + slot + " pon " + pon;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot y pon", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        public void usuNSO()
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Ingresa slot y pon de la nueva ONU", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    string command3 = "show authorization slot " + slot + " pon " + pon;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot y pon", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    marsellaADD();
                    break;
                case 1:
                    sg00ADD();
                    // Recuperar el valor numérico actual de la base de datos Firebase en tiempo real
                    var currentValue = await firebaseClient.Child("").OnceSingleAsync<int>();

                    // Incrementar el valor numérico en 1
                    var newValue = currentValue + 1;

                    // Actualizar el valor numérico en la base de datos Firebase
                    await firebaseClient.Child("").PutAsync(newValue);

                    // Mostrar un mensaje de éxito en un MessageBox
                    MessageBox.Show($"El Service-Port ahora es: {newValue}");
                    break;
                case 2:
                    sg01ADD();
                    // Recuperar el valor numérico actual de la base de datos Firebase en tiempo real
                    currentValue = await firebaseClient.Child("").OnceSingleAsync<int>();

                    // Incrementar el valor numérico en 1
                    newValue = currentValue + 1;

                    // Actualizar el valor numérico en la base de datos Firebase
                    await firebaseClient.Child("").PutAsync(newValue);

                    // Mostrar un mensaje de éxito en un MessageBox
                    MessageBox.Show($"El Service-Port ahora es: {newValue}");
                    break;
                case 3:
                    smADD();
                    break;
                case 4:
                    usuADD();
                    break;
                default:

                    break;
            }
        }
        public void marsellaADD()
        {
            if (textBox1.Text.Length != 13 && textBox1.Text.Length != 12)
            {
                MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")

                {
                    MessageBox.Show("Ingresa los datos faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;
                        slot = int.Parse(textBox2.Text);
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        command1 = "set whitelist phy_add address " + serial + " password 123456789 action add slot " + slot + " pon " + pon + " onu " + onu + " type 5506-SFU\r\ncd lan\r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service number 1 \r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service 1 vlan_mode tag 0 33024 200 \r\napply onu " + slot + " " + pon + " " + onu + " vlan";

                        Clipboard.SetText(command1);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }
        public void sg00ADD()
        {
            if (textBox1.Text.Length != 13 && textBox1.Text.Length != 12)
            {
                MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")

                {
                    MessageBox.Show("Ingresa los datos faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;

                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);
                        string duic = textBox6.Text;
                        command1 = "ont add " + pon + " " + onu + " sn-auth " + serial + " omci ont-lineprofile-id 10 ont-srvprofile-id 10 desc " + duic + "\r\n\r\nont port native-vlan " + pon + " " + onu + " eth 1 vlan 200 priority 0\r\n\r\nquit\r\n\r\nService-port " + sPort + " vlan 200 gpon 0/0/" + pon + " ont " + onu + " gemport 1 multi-service user-vlan 200 tag-transform translate";

                        Clipboard.SetText(command1);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }

        }
        public void sg01ADD()
        {
            if (textBox1.Text.Length != 13 && textBox1.Text.Length != 12)
            {
                MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")

                {
                    MessageBox.Show("Ingresa los datos faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;

                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);
                        string duic = textBox6.Text;
                        command1 = "ont add " + pon + " " + onu + " sn-auth " + serial + " omci ont-lineprofile-id 10 ont-srvprofile-id 10 desc " + duic + "\r\n\r\nont port native-vlan " + pon + " " + onu + " eth 1 vlan 200 priority 0\r\n\r\nquit\r\n\r\nService-port " + sPort + " vlan 200 gpon 0/1/" + pon + " ont " + onu + " gemport 1 multi-service user-vlan 200 tag-transform translate";
                        Clipboard.SetText(command1);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }
        public void smADD()
        {

            if (textBox1.Text.Length != 13 && textBox1.Text.Length != 12)
            {
                MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")

                {
                    MessageBox.Show("Ingresa los datos faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;
                        slot = int.Parse(textBox2.Text);
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        command1 = "set whitelist phy_add address " + serial + " password 123456789 action add slot " + slot + " pon " + pon + " onu " + onu + " type HG260\r\ncd lan\r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service number 1 \r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service 1 vlan_mode tag 0 33024 100 \r\napply onu " + slot + " " + pon + " " + onu + " vlan";

                        Clipboard.SetText(command1);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }
        public void usuADD()
        {
            if (textBox1.Text.Length != 13 && textBox1.Text.Length != 12)
            {
                MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")

                {
                    MessageBox.Show("Ingresa los datos faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;
                        slot = int.Parse(textBox2.Text);
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        command1 = "set whitelist phy_add address " + serial + " password 123456789 action add slot " + slot + " pon " + pon + " onu " + onu + " type 5506-SFU\r\ncd lan\r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service number 1 \r\nset epon slot " + slot + " pon " + pon + " onu " + onu + " port 1 service 1 vlan_mode tag 0 33024 250 \r\napply onu " + slot + " " + pon + " " + onu + " vlan";

                        Clipboard.SetText(command1);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }

        }


        private void btnPotencia_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    marsellaPotencia();
                    break;
                case 1:
                    sgPotencia00();
                    break;
                case 2:
                    sgPotencia01();
                    break;
                case 3:
                    smPotencia();
                    break;
                case 4:
                    usuPotencia();
                    break;
                default:
                    break;
            }
        }
        public void marsellaPotencia()
        {
            if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Ingresa slot, pon y onu para ver potencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    onu = int.Parse(textBox4.Text);

                    string command3 = "show optic_module slot " + slot + " pon " + pon + " onu " + onu;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void sgPotencia00()
        {
            if (textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Ingresa pon y onu para ver potencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    pon = int.Parse(textBox3.Text);
                    onu = int.Parse(textBox4.Text);

                    string command3 = "display ont optical-info " + pon + " " + onu;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void sgPotencia01()
        {
            if (textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Ingresa pon y onu para ver potencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    pon = int.Parse(textBox3.Text);
                    onu = int.Parse(textBox4.Text);

                    string command3 = "display ont optical-info " + pon + " " + onu;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void smPotencia()
        {
            if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Ingresa slot, pon y onu para ver potencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    onu = int.Parse(textBox4.Text);

                    string command3 = "show optic_module slot " + slot + " pon " + pon + " onu " + onu;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void usuPotencia()
        {
            if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Ingresa slot, pon y onu para ver potencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    slot = int.Parse(textBox2.Text);
                    pon = int.Parse(textBox3.Text);
                    onu = int.Parse(textBox4.Text);

                    string command3 = "show optic_module slot " + slot + " pon " + pon + " onu " + onu;
                    Clipboard.SetText(command3);
                    msgCopy();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingresa solo numeros en slot, pon y onu", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    marsellaDLT();
                    break;
                case 1:
                    sg00DLT();
                    break;
                case 2:
                    sg01DLT();
                    break;
                case 3:
                    smDLT();
                    break;
                case 4:
                    usuDLT();
                    break;
                default:

                    break;
            }
        }
        public void marsellaDLT()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12 && textBox1.Text.Length != 13)
                {
                    MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    serial = textBox1.Text;
                    string command2 = "set whitelist phy_addr address " + serial + " password null action delete";
                    Clipboard.SetText(command2);
                    msgCopy();
                }
            }
        }
        public void sg00DLT()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12 && textBox1.Text.Length != 13)
                {
                    MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);

                        string command3 = "undo  service-port " + sPort + "\r\ninterface gpon 0/0\r\nont delete " + pon + " " + onu;
                        Clipboard.SetText(command3);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon, onu y service port", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public void sg01DLT()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12 && textBox1.Text.Length != 13)
                {
                    MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);

                        string command3 = "undo  service-port " + sPort + "\r\ninterface gpon 0/1\r\nont delete " + pon + " " + onu;
                        Clipboard.SetText(command3);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon, onu y service port", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public void smDLT()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12 && textBox1.Text.Length != 13)
                {
                    MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    serial = textBox1.Text;
                    string command2 = "set whitelist phy_addr address " + serial + " password null action delete";
                    Clipboard.SetText(command2);
                    msgCopy();
                }
            }
        }
        public void usuDLT()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12 && textBox1.Text.Length != 13)
                {
                    MessageBox.Show("Ingresa serial de la ONU a eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    serial = textBox1.Text;
                    string command2 = "set whitelist phy_addr address " + serial + " password null action delete";
                    Clipboard.SetText(command2);
                    msgCopy();
                }
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = "";
            timer1.Stop();
        }

        public void msgCopy()
        {
            label6.Text = "Comando copiado";
            timer1.Start();
        }
        public void gponTxt()
        {
            textBox2.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            btnSP.Enabled = false;
            btnSPD.Enabled = false;
        }
        public void donadminTxt()
        {
            textBox2.Enabled = false;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            btnSP.Enabled = true;
            btnSPD.Enabled = true;
        }
        public async void SGsp()
        {
            var result = await firebaseClient.Child("ServicePort/SG").OnceSingleAsync<int>();

            // Mostrar el valor recuperado en un MessageBox
            int spn = (result + 1);
            textBox5.Text = spn.ToString();
        }
        public async void Ecosp()
        {
            var result = await firebaseClient.Child("ServicePort/Ecoterra").OnceSingleAsync<int>();

            // Mostrar el valor recuperado en un MessageBox
            int spn = (result + 1);
            textBox5.Text = spn.ToString();
        }
        public async void Medisp()
        {
            var result = await firebaseClient.Child("ServicePort/Mediterraneo").OnceSingleAsync<int>();

            // Mostrar el valor recuperado en un MessageBox
            int spn = (result + 1);
            textBox5.Text = spn.ToString();
        }
        public async void Pinaressp()
        {
            var result = await firebaseClient.Child("ServicePort/Pinares").OnceSingleAsync<int>();

            // Mostrar el valor recuperado en un MessageBox
            int spn = (result + 1);
            textBox5.Text = spn.ToString();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    gponTxt();
                    break;
                case 1:
                    gponTxt();
                    break;
                case 2:
                    gponTxt();
                    break;
                case 3:
                    donadminTxt();
                    SGsp();
                    break;
                case 4:
                    donadminTxt();
                    Ecosp();
                    break;
                case 5:
                    donadminTxt();
                    Medisp();
                    break;
                case 6:
                    donadminTxt();
                    Pinaressp();
                    break;
                case 7:
                    donadminTxt();
                    SGsp();
                    break;
                case 8:
                    donadminTxt();
                    Ecosp();
                    break;
                case 9:
                    donadminTxt();
                    Medisp();
                    break;
                case 10:
                    donadminTxt();
                    Pinaressp();
                    break;
                default:
                    break;
            }

        }

        private void btnInfoTec_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Esta info se copia en OLT", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    inf00();
                    break;
                case 2:
                    inf01();
                    break;
                case 3:
                    MessageBox.Show("Esta info se copia en OLT", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Esta info se copia en OLT", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        public void inf00()
        {
            if (textBox7.Text == "" && textBox1.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
            {
                MessageBox.Show("Ingresa datos Faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 13)
                {
                    MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;
                        string ipcliente = textBox7.Text;
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);
                        string command2 = ipcliente + " ont add " + pon + " " + onu + " sn-auth " + serial + " Service-port " + sPort + " 0/0";
                        Clipboard.SetText(command2);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon, onu y service port", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        public void inf01()
        {
            if (textBox7.Text == "" && textBox1.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
            {
                MessageBox.Show("Ingresa datos Faltantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text.Length != 12)
                {
                    MessageBox.Show("La serial es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        serial = textBox1.Text;
                        string ipcliente = textBox7.Text;
                        pon = int.Parse(textBox3.Text);
                        onu = int.Parse(textBox4.Text);
                        int sPort = int.Parse(textBox5.Text);
                        string command2 = ipcliente + " ont add " + pon + " " + onu + " sn-auth " + serial + " Service-port " + sPort + " 0/1";
                        Clipboard.SetText(command2);
                        msgCopy();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ingresa solo numeros en pon, onu y service port", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var firebaseConnectionString = "https://serviceportont-default-rtdb.firebaseio.com/";
            firebaseClient = new FirebaseClient(firebaseConnectionString);
            this.BringToFront();


        }

        private async void btnSP_Click(object sender, EventArgs e)

        {
            // Recuperar el Service-Port de la base de datos Firebase en tiempo real
            var result = await firebaseClient.Child("/SG").OnceSingleAsync<int>();

            // Mostrar el valor recuperado en un MessageBox
            MessageBox.Show($"Service-Port siguiente: {result + 1}");
            int spn = (result + 1);
            textBox5.Text = spn.ToString();
        }

        private async void btnSPD_Click(object sender, EventArgs e)
        {
            // Recuperar el Service-Port actual de la base de datos Firebase en tiempo real
            var currentValue = await firebaseClient.Child("").OnceSingleAsync<int>();

            var result = MessageBox.Show($"¿Desea actualizar el Service-Port {currentValue} a {currentValue - 1}?",
                                 "Confirmar actualización",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // Si el usuario confirma la actualización, continuar con el código de actualización
            if (result == DialogResult.Yes)
            {
                // Decrementar el Service-Port en 1
                var newValue = currentValue - 1;

                // Actualizar el Service-Port en la base de datos Firebase
                await firebaseClient.Child("").PutAsync(newValue);

                // Mostrar un mensaje de éxito en un MessageBox
                MessageBox.Show($"Service-Port actualizado correctamente. Nuevo Service-Port actual: {newValue}");
            }
            // Si el usuario cancela la actualización, no hacer nada
            else
            {
                return;
            }


        }

        private async void btnUpdateSoft_Click(object sender, EventArgs e)
        {
            //    var cliente = new GitHubClient(new ProductHeaderValue("Setup_Configuracion_de_ONU"));
            //    var releases = await cliente.Repository.Release.GetAll("AzazelDR", "Conf-ONU-OLT");

            //    var ultimaVersion = releases[0].TagName;

            //    if (ultimaVersion != "v" + System.Windows.Forms.Application.ProductVersion)
            //    {
            //        var assets = releases[0].Assets;
            //        var asset = assets.FirstOrDefault(a => a.Name.EndsWith("Setup_Configuracion_de_ONU.exe"));

            //        if (asset != null)
            //        {
            //            var uri = asset.BrowserDownloadUrl;
            //            using (var httpClient = new HttpClient())
            //            {
            //                var response = await httpClient.GetAsync(uri);
            //                response.EnsureSuccessStatusCode();

            //                var tempPath = Path.GetTempFileName();

            //                using (var stream = await response.Content.ReadAsStreamAsync())
            //                using (var fileStream = new FileStream(tempPath, System.IO.FileMode.Create))
            //                {
            //                    await stream.CopyToAsync(fileStream);
            //                }

            //                var procesoActual = Process.GetCurrentProcess();
            //                var info = new ProcessStartInfo(tempPath);
            //                info.UseShellExecute = true;
            //                info.Verb = "runas";
            //                procesoActual.WaitForExit();

            //                Process.Start(info);
            //                System.Windows.Forms.Application.Exit();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No hay actualizaciones disponibles.", "Setup_Configuracion_de_ONU");
            //    }
            //}
        }
    }
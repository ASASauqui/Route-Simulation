using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreRoutes
{
    public partial class BinnacleForm : Form
    {
        // ----------------------Variables a utilizar----------------------
        private Dictionary<string, AbstractObserver> checkBoxes;
        private Subject subject;



        // ----------------------Constructores----------------------

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public BinnacleForm()
        {
            InitializeComponent();

            InitializeDictionaries();

            this.subject = new Subject();
        }




        // ----------------------Inicialización de variables----------------------

        /// <summary>
        /// Inicialización de los diccionarios.
        /// </summary>
        private void InitializeDictionaries()
        {
            // Inicialización del diccionario.
            checkBoxes = new Dictionary<string, AbstractObserver>();

            // Añadir componentes del diccionario.
            checkBoxes.Add("TXTCheckBox", new TXTObserver());
            checkBoxes.Add("GridCheckBox", new GridObserver());
            checkBoxes.Add("TextBoxCheckBox", new TextBoxObserver());
        }




        // ----------------------Controles del Form----------------------

        /// <summary>
        /// Mostrar los tipos de archivos que se seleccionarion en los checkboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowButtonBinnacleForm_Click(object sender, EventArgs e)
        {
            // Obtener los checkbox del groupbox.
            var checkBoxesEnumerable = GroupBoxBinnacleForm.Controls.OfType<CheckBox>();

            // Convertir Enumerable a list.
            List<CheckBox> checkBoxesList = checkBoxesEnumerable.ToList();

            // Obtener la cantidad de checkboxes marcados.
            int numberOfCheckBoxes = checkBoxesList.FindAll(element => element.Checked == true).Count;

            // Si no hay ningún checkbox marcado entonces mostrar mensaje de error.
            if (numberOfCheckBoxes == 0)
            {
                Message.ShowNoCheckBoxesSelected();
                return;
            }

            // Mandar a llamar a los listeners.
            subject.ExchangeTypeChanged(numberOfCheckBoxes);
        }

        /// <summary>
        /// Presionar el checkbox de .txt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TXTCheckBox.Checked == true)
            {
                Binnacle.AddMessageToBinnacle("Se seleccionó abrir en .txt");
                subject.OnNotify += checkBoxes["TXTCheckBox"].Update;
            }
            else
            {
                Binnacle.AddMessageToBinnacle("Se deseleccionó abrir en .txt");
                subject.OnNotify -= checkBoxes["TXTCheckBox"].Update;
            }
        }

        /// <summary>
        /// Presionar el checkbox de Grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GridCheckBox.Checked == true)
            {
                Binnacle.AddMessageToBinnacle("Se seleccionó abrir en Grid");
                subject.OnNotify += checkBoxes["GridCheckBox"].Update;
            }
            else
            {
                Binnacle.AddMessageToBinnacle("Se deseleccionó abrir en Grid");
                subject.OnNotify -= checkBoxes["GridCheckBox"].Update;
            }
        }

        /// <summary>
        /// Presionar el checkbox de TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TextBoxCheckBox.Checked == true)
            {
                Binnacle.AddMessageToBinnacle("Se seleccionó abrir en TextBox");
                subject.OnNotify += checkBoxes["TextBoxCheckBox"].Update;
            }
            else
            {
                Binnacle.AddMessageToBinnacle("Se deseleccionó abrir en TextBox");
                subject.OnNotify -= checkBoxes["TextBoxCheckBox"].Update;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Reflection : Form
    {
        public Reflection()
        {
            InitializeComponent();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            lstConstructors.Items.Clear();
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();

            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);


            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString());
            }
        }
    }
}

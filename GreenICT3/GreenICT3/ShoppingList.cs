using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GreenICT3
{
    public partial class ShoppingList : Form
    {
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        //OleDbCommand myCommand2;
        OleDbDataReader myReader;
        //OleDbDataReader myReader2;
        List<Recipe> collection;
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection();
            myConnection.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data source=" + Environment.CurrentDirectory + "\\ShoppingList.mdb;";
            myCommand = new OleDbCommand();
            myCommand.CommandText = "SELECT * FROM Recipe";
            //myCommand2.CommandText = "SELECT * FROM IngredientsList";

            myCommand.Connection = myConnection;
            myConnection.Open();
            myReader = myCommand.ExecuteReader();

            collection = new List<Recipe>();
            while (myReader.Read())
            {
                //List<Ingredient> ingr = new List<Ingredient>();

                collection.Add(new Recipe(myReader["RecipeName"].ToString(), int.Parse(myReader["RecipePortions"].ToString())));
            }
            foreach(Recipe r in collection) lbxCollection.Items.Add(r.ToString());

            myConnection.Close();
            myReader.Close();
        }

        private void lbxCollection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

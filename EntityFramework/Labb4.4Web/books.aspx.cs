using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Labb4._4Lib;
using System.Data;

namespace Labb4._4Web
{
    public partial class books : System.Web.UI.Page
    {
        MediaDAL db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new MediaDAL();

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }

        }

        private void BindGrid()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Id"), new DataColumn("Name") });

                db.GetAllBooks().ForEach(x => dt.Rows.Add(x.ID, x.Name));

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                exceptionLable.Text = ex.Message;
            }

        }

        protected void Insert(object sender, EventArgs e)
        {
            try
            {
                db.AddBook(new Book { Name = txtName.Text });
                this.BindGrid();
            }
            catch (Exception ex)
            {
                exceptionLable.Text = ex.Message;
            }
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                string id = (row.FindControl("lblId") as Label).Text;
                string name = (row.FindControl("txtName") as TextBox).Text;


                db.EditBook(int.Parse(id), name);


            }
            catch (Exception ex)
            {
                exceptionLable.Text = ex.Message;
            }
            finally
            {
                GridView1.EditIndex = -1;
                this.BindGrid();
            }
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                string id = (row.FindControl("lblId") as Label).Text;

                db.DeleteBook(int.Parse(id));

            }
            catch (Exception ex)
            {
                exceptionLable.Text = ex.Message;
            }
            finally
            {
                GridView1.EditIndex = -1;
                this.BindGrid();
            }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != GridView1.EditIndex)
            {
                (e.Row.Cells[2].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
            }
        }


    }
}

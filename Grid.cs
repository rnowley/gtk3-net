using Gtk3.Native;

namespace Gtk3
{
    public class Grid : Widget
    {

        public Grid() {
            Instance = GtkGrid.gtk_grid_new();
        }

        public void Attach(Widget child, int left, int top, int width, int height) {
            GtkGrid.gtk_grid_attach(Handle, child.Handle, left, top, width, height);
        }

        public virtual void InsertRow(int position)
        {
            GtkGrid.gtk_grid_insert_row(Handle, position);
        }

        public virtual void InsertColumn(int position)
        {
            GtkGrid.gtk_grid_insert_column(Handle, position);
        }

        public virtual void RemoveRow(int position)
        {
            GtkGrid.gtk_grid_remove_row(Handle, position);
        }

        public virtual void RemoveColumn(int position)
        {
            GtkGrid.gtk_grid_remove_column(Handle, position);
        }

        public virtual void SetRowHomogeneous(bool homogeneous)
        {
            GtkGrid.gtk_grid_set_row_homogeneous(Handle, homogeneous);
        }

        public virtual bool GetRowHomogeneous()
        {
            return GtkGrid.gtk_grid_get_row_homogeneous(Handle);
        }

        public virtual void SetRowSpacing(uint spacing)
        {
            GtkGrid.gtk_grid_set_row_spacing(Handle, spacing);
        }

        public virtual uint GetRowSpacing()
        {
            return GtkGrid.gtk_grid_get_row_spacing(Handle);
        }

        public virtual void SetColumnHomogeneous(bool homogeneous)
        {
            GtkGrid.gtk_grid_set_column_homogeneous(Handle, homogeneous);
        }

        public virtual bool GetColumnHomogeneous()
        {
            return GtkGrid.gtk_grid_get_column_homogeneous(Handle);
        }

        public virtual void SetColumnSpacing(uint spacing)
        {
            GtkGrid.gtk_grid_set_column_spacing(Handle, spacing);
        }

        public virtual uint GetColumnSpacing()
        {
            return GtkGrid.gtk_grid_get_column_spacing(Handle);
        }

        public virtual void SetBaselineRow(int row)
        {
            GtkGrid.gtk_grid_set_baseline_row(Handle, row);
        }

        public virtual int GetBaselineRow()
        {
            return GtkGrid.gtk_grid_get_baseline_row(Handle);
        }

        public virtual void SetRowBaselinePosition(int row, GtkBaselinePosition pos)
        {
            GtkGrid.gtk_grid_set_row_baseline_position(Handle, row, pos);
        }

        public virtual GtkBaselinePosition GetBaselineRow(int row)
        {
            return GtkGrid.gtk_grid_get_row_baseline_position(Handle, row);
        }
    }
}

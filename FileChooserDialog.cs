using System;
using System.Collections.Generic;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// Defines a button pair for setting buttons in a Dialog.
    /// </summary>
    public class ButtonData
    {
        /// <summary>
        /// The text to go in the button.
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// The response ID for the button.
        /// </summary>
        public int ResponseId { get; set; }
    }

    /// <summary>
    /// GtkFileChooserDialog is a dialog box suitable for use with "File/Open" or "File/Save as" commands. This widget
    /// works by putting a GtkFileChooserWidget inside a GtkDialog. It exposes the GtkFileChooserIface interface,
    /// so you can use all of the GtkFileChooser functions on the file chooser dialog as well as those for GtkDialog.
    /// </summary>
    public class FileChooserDialog : Dialog
    {
        /// <summary>
        /// Creates a new GtkFileChooserDialog.
        /// </summary>
        /// <param name="title">Title of the dialog, or null.</param>
        /// <param name="parent">Transient parent of the dialog, or null.</param>
        /// <param name="action">Open or save mode for the dialog</param>
        /// <param name="buttonData"></param>
        public FileChooserDialog(string title, Window parent, GtkFileChooserAction action, IEnumerable<ButtonData> buttonData)
        {
            Instance = GtkFileChooserDialog.gtk_file_chooser_dialog_new(title, parent?.Handle ?? IntPtr.Zero,
                action, IntPtr.Zero);

            foreach (var button in buttonData)
            {
                AddButton(button.ButtonText, button.ResponseId);
            }
        }

        /// <summary>
        /// Adds filter to the list of filters that the user can select between. When a filter
        /// is selected, only files that are passed by that filter are displayed.
        /// Note that the chooser takes ownership of the filter, so you have to ref and sink it
        /// if you want to keep a reference.
        /// </summary>
        /// <param name="filter">a GtkFileFilter</param>
        public void AddFilter(FileFilter filter)
        {
            GtkFileChooserDialog.gtk_file_chooser_add_filter(Instance, filter.Instance);
        }

        /// <summary>
        /// Removes filter from the list of filters that the user can select between.
        /// </summary>
        /// <param name="filter">a GtkFileFilter</param>
        public void RemoveFilter(FileFilter filter)
        {
            GtkFileChooserDialog.gtk_file_chooser_remove_filter(Instance, filter.Instance);
        }

        /// <summary>
        /// Selects the file to by uri. If the URI doesn't refer to a file in the current
        /// folder of chooser, then the current folder of chooser will be changed to the folder
        /// containing filename.
        /// </summary>
        /// <param name="uri">the URI to select.</param>
        public void SelectUri(string uri)
        {
            GtkFileChooserDialog.gtk_file_chooser_select_uri(Instance, uri);
        }

        /// <summary>
        /// Unselects the file referred to by uri. If the file is not in the current directory,
        /// does not exist, or is otherwise not currently selected, does nothing.
        /// </summary>
        /// <param name="uri">the URI to unselect.</param>
        public void UnselectUri(string uri)
        {
            GtkFileChooserDialog.gtk_file_chooser_unselect_uri(Instance, uri);
        }

        /// <summary>
        /// Sets the current folder for chooser from a local filename. The user will be shown
        /// the full contents of the current folder, plus user interface elements for navigating
        /// to other folders.
        ///
        /// In general, you should not use this function. See the section on setting up a file
        /// chooser dialog for the rationale behind this.
        /// </summary>
        /// <param name="filename">the full path of the new current folder.</param>
        public void SetCurrentFolder(string filename)
        {
            GtkFileChooserDialog.gtk_file_chooser_set_current_folder(Instance, filename);
        }

        /// <summary>
        /// Sets the current name in the file selector, as if entered by the user. Note that
        /// the name passed in here is a UTF-8 string rather than a filename. This function is
        /// meant for such uses as a suggested name in a "Save As..." dialog. You can pass
        /// "Untitled.doc" or a similarly suitable suggestion for the name. If you want to
        /// preselect a particular existing file, you should use gtk_file_chooser_set_filename()
        /// or gtk_file_chooser_set_uri() instead. Please see the documentation for those
        /// functions for an example of using gtk_file_chooser_set_current_name() as well.
        /// </summary>
        /// <param name="name">The currently selected filename, or null if no file is selected,
        /// or the selected file can't be represented with a local filename. </param>
        public void SetCurrentName(string name)
        {
            GtkFileChooserDialog.gtk_file_chooser_set_current_name(Instance, name);
        }

        /// <summary>
        /// Sets the file referred to by uri as the current file for the file chooser, by
        /// changing to the URI's parent folder and actually selecting the URI in the list. If
        /// the chooser is GTK_FILE_CHOOSER_ACTION_SAVE mode, the URI's base name will also
        /// appear in the dialog's file name entry. Note that the URI must exist, or nothing
        /// will be done except for the directory change.You should use this function only when
        /// implementing a File/Save As... dialog for which you already have a file name to
        /// which the user may save. For example, when the user opens an existing file and then
        /// does File/Save As... on it to save a copy or a modified version. If you don't have a
        /// file name already — for example, if the user just created a new file and is saving
        /// it for the first time, do not call this function.
        /// </summary>
        /// <param name="uri">the URI to set as current.</param>
        public void SetUri(string uri)
        {
            GtkFileChooserDialog.gtk_file_chooser_set_uri(Instance, uri);
        }

        /// <summary>
        /// Selects all the files in the current folder of a file chooser.
        /// </summary>
        public void SelectAll()
        {
            GtkFileChooserDialog.gtk_file_chooser_select_all(Instance);
        }

        /// <summary>
        /// Unselects all the files in the current folder of a file chooser.
        /// </summary>
        public void UnselectAll()
        {
            GtkFileChooserDialog.gtk_file_chooser_unselect_all(Instance);
        }

        /// <summary>
        /// Gets or Sets whether file choser will offer to create new folders. This is only
        /// relevant if the action is not set to be GTK_FILE_CHOOSER_ACTION_OPEN.
        /// </summary>
        public bool CreateFolders
        {
            get => GtkFileChooserDialog.gtk_file_chooser_get_create_folders(Instance);
            set => GtkFileChooserDialog.gtk_file_chooser_set_create_folders(Instance, value);
        }

        /// <summary>
        /// Gets or Sets whether a file chooser in GTK_FILE_CHOOSER_ACTION_SAVE mode will
        /// present a confirmation dialog if the user types a file name that already exists.
        /// This is false by default. Regardless of this setting, the chooser will emit the
        /// "confirm-overwrite" signal when appropriate. If all you need is the stock
        /// confirmation dialog, set this property to true. You can override the way
        /// confirmation is done by actually handling the "confirm-overwrite" signal; please
        /// refer to its documentation for the details.
        /// </summary>
        public bool DoOverwriteConfirmation
        {
            get => GtkFileChooserDialog.gtk_file_chooser_get_do_overwrite_confirmation(Instance);
            set => GtkFileChooserDialog.gtk_file_chooser_set_do_overwrite_confirmation(Instance, value);
        }
    }
}

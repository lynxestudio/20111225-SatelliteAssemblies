using System;
using Gtk;
using System.Resources;
using System.Collections;
using System.Drawing;


public partial class MainWindow: Gtk.Window
{	
	//This class as a global variable
	ResourceWriter rw = null;
	Hashtable _values = new Hashtable();
	Hashtable _imgValues = new Hashtable();
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnAddClicked (object sender, System.EventArgs e)
	{
		//we add values, if they have values
		if(!string.IsNullOrEmpty(txtName.Text) &&
			!string.IsNullOrEmpty(txtValue.Text))
		{
			if(chkIsImage.Active)
				_imgValues.Add(txtName.Text,txtValue.Text);
			else
				_values.Add (txtName.Text,txtValue.Text);
		lbMsg.Text = "Item added";
		Clear(false);
		}
		else
			lbError.Text = "Null values";
			
	}

	protected void OnBtnBuildClicked (object sender, System.EventArgs e)
	{
		try
		{
		//Ok, we create the Object
		using(rw = new ResourceWriter("demo.resources")){
		//iterate for the strings
		foreach(DictionaryEntry entry in _values)
		rw.AddResource(entry.Key.ToString(),entry.Value.ToString());
		//iterate for the images
		foreach(DictionaryEntry entry in _imgValues)
		rw.AddResource(entry.Key.ToString(),new Bitmap(entry.Value.ToString()));
		//Generate
		rw.Generate();
		Clear(true);
		lbError.Text = string.Empty;
		lbMsg.Text = "Resources file generated";
		}
		}catch(Exception ex){
			lbMsg.Text = string.Empty;
			lbError.Text = ex.Message;
		}
				
	}
	
	void Clear(bool clearMsg)
	{
		txtName.Text = txtValue.Text = string.Empty;
		chkIsImage.Active = false;
		if(clearMsg)
			lbMsg.Text = string.Empty;
	}
}

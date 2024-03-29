
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label1;

	private global::Gtk.Entry txtName;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label2;

	private global::Gtk.Entry txtValue;

	private global::Gtk.CheckButton chkIsImage;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button btnAdd;

	private global::Gtk.Button btnBuild;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label lbMsg;

	private global::Gtk.Label lbError;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Generate resources");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(2));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Homogeneous = true;
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(4));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.txtName = new global::Gtk.Entry ();
		this.txtName.CanFocus = true;
		this.txtName.Name = "txtName";
		this.txtName.IsEditable = true;
		this.txtName.InvisibleChar = '●';
		this.hbox1.Add (this.txtName);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txtName]));
		w2.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Value");
		this.hbox2.Add (this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtValue = new global::Gtk.Entry ();
		this.txtValue.CanFocus = true;
		this.txtValue.Name = "txtValue";
		this.txtValue.IsEditable = true;
		this.txtValue.InvisibleChar = '●';
		this.hbox2.Add (this.txtValue);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtValue]));
		w5.Position = 1;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.chkIsImage = new global::Gtk.CheckButton ();
		this.chkIsImage.CanFocus = true;
		this.chkIsImage.Name = "chkIsImage";
		this.chkIsImage.Label = global::Mono.Unix.Catalog.GetString ("Is image");
		this.chkIsImage.DrawIndicator = true;
		this.chkIsImage.UseUnderline = true;
		this.vbox1.Add (this.chkIsImage);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.chkIsImage]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btnAdd = new global::Gtk.Button ();
		this.btnAdd.CanFocus = true;
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.UseUnderline = true;
		this.btnAdd.Label = global::Mono.Unix.Catalog.GetString ("Add Item");
		this.hbox3.Add (this.btnAdd);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btnAdd]));
		w8.Position = 0;
		w8.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btnBuild = new global::Gtk.Button ();
		this.btnBuild.CanFocus = true;
		this.btnBuild.Name = "btnBuild";
		this.btnBuild.UseUnderline = true;
		this.btnBuild.Label = global::Mono.Unix.Catalog.GetString ("Build Resource");
		this.hbox3.Add (this.btnBuild);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btnBuild]));
		w9.Position = 1;
		w9.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lbMsg = new global::Gtk.Label ();
		this.lbMsg.Name = "lbMsg";
		this.lbMsg.LabelProp = global::Mono.Unix.Catalog.GetString ("Running");
		this.hbox4.Add (this.lbMsg);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lbMsg]));
		w11.Position = 0;
		w11.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lbError = new global::Gtk.Label ();
		this.lbError.Name = "lbError";
		this.lbError.UseMarkup = true;
		this.hbox4.Add (this.lbError);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lbError]));
		w12.Position = 1;
		w12.Fill = false;
		this.vbox1.Add (this.hbox4);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w13.PackType = ((global::Gtk.PackType)(1));
		w13.Position = 4;
		w13.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 248;
		this.DefaultHeight = 171;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnAdd.Clicked += new global::System.EventHandler (this.OnBtnAddClicked);
		this.btnBuild.Clicked += new global::System.EventHandler (this.OnBtnBuildClicked);
	}
}

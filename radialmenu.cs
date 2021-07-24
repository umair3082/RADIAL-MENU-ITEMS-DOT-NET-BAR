public Add_Purchase()
        {
            InitializeComponent();
            radialMenu1.ItemClick += new EventHandler(RadialMenuItemClick);
        }
        
        private void RadialMenuItemClick(object sender, EventArgs e)
        {
            RadialMenuItem item = sender as RadialMenuItem;
            if (item != null && !string.IsNullOrEmpty(item.Text))
            {
                if (item.Name=="add")
                {
                   MessageBox.Show("Add Button Pressed")
                }
                if (item.Name=="search")
                {
                    MessageBox.Show("Search Button Pressed")
                }
            }
        }

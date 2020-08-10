namespace App9.ItemTemplates
{
    using Xamarin.Forms;

    public partial class MonkeyTemplate : ItemTemplateBase
    {
        public MonkeyTemplate()
        {
            InitializeComponent();
        }

        protected override void SetupItem()
        {
            if (this.BindingContext is Animal item)
            {
                this.AnimalName.Text = item.Category + " # " + item.Name;
            }
        }
    }
}
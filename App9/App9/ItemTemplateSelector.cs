using App9.ItemTemplates;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace App9
{
    public class ItemTemplateSelector : DataTemplateSelector
    {
        private readonly Lazy<DataTemplate> lazyBearTemplate = new Lazy<DataTemplate>(() => new BearDataTemplate(), isThreadSafe: true);
        private readonly Lazy<DataTemplate> lazyDogTemplate = new Lazy<DataTemplate>(() => new DogDataTemplate(), isThreadSafe: true);
        private readonly Lazy<DataTemplate> lazyCatTemplate = new Lazy<DataTemplate>(() => new CatDataTemplate(), isThreadSafe: true);
        private readonly Lazy<DataTemplate> lazyMonkeyTemplate = new Lazy<DataTemplate>(() => new MonkeyDataTemplate(), isThreadSafe: true);
        private readonly Lazy<DataTemplate> lazyElephantTemplate = new Lazy<DataTemplate>(() => new ElephantDataTemplate(), isThreadSafe: true);

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(item is Animal animal)
            {
                switch (animal.Category)
                {
                    case "Bear":
                        return this.lazyBearTemplate.Value;

                    case "Dog":
                        return this.lazyDogTemplate.Value;

                    case "Cat":
                        return this.lazyCatTemplate.Value;

                    case "Monkey":
                        return this.lazyMonkeyTemplate.Value;

                    case "Elephant":
                        return this.lazyElephantTemplate.Value;

                    default:
                        throw new NotSupportedException();
                }
            }
            else
            {
                // something fishy going on... why is the "item" a list of items?
                Debugger.Break();

                return new DataTemplate();
            }
        }
    }

    public class BearDataTemplate : DataTemplate
    {
        public BearDataTemplate() : base(() => CreateDataTemplate())
        { }

        static View CreateDataTemplate() => new BearTemplate();
    }
    public class DogDataTemplate : DataTemplate
    {
        public DogDataTemplate() : base(() => CreateDataTemplate())
        { }

        static View CreateDataTemplate() => new DogTemplate();
    }
    public class MonkeyDataTemplate : DataTemplate
    {
        public MonkeyDataTemplate() : base(() => CreateDataTemplate())
        { }

        static View CreateDataTemplate() => new MonkeyTemplate();
    }
    public class ElephantDataTemplate : DataTemplate
    {
        public ElephantDataTemplate() : base(() => CreateDataTemplate())
        { }

        static View CreateDataTemplate() => new ElephantTemplate();
    }
    public class CatDataTemplate : DataTemplate
    {
        public CatDataTemplate() : base(() => CreateDataTemplate())
        { }

        static View CreateDataTemplate() => new CatTemplate();
    }
}

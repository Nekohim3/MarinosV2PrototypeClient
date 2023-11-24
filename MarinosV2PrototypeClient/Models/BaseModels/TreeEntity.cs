using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Utils;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models.BaseModels
{
    public abstract class TreeEntity<T> : Entity where T : TreeEntity<T>
    {
        private ObservableCollectionWithSelectedItem<T> _childs = new();
        [JsonProperty]
        public ObservableCollectionWithSelectedItem<T> Childs
        {
            get => _childs;
            set => this.RaiseAndSetIfChanged(ref _childs, value);
        }

        private Guid? _idParent;
        [JsonProperty]
        public Guid? IdParent
        {
            get => _idParent;
            set => this.RaiseAndSetIfChanged(ref _idParent, value);
        }
        private T? _parent;
        [JsonProperty]
        public T? Parent
        {
            get => _parent;
            set => this.RaiseAndSetIfChanged(ref _parent, value);
        }

        public virtual void AddChild(T child)
        {
            Childs.Add(child);
            child.Parent   = (T)this;
            //child.IdParent = Id;
        }

        public virtual void AddChilds(IEnumerable<T> list)
        {
            foreach (var x in list)
                AddChild(x);
        }
    }
}

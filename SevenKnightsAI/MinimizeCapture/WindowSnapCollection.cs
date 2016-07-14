using System;
using System.Collections.Generic;

namespace MinimizeCapture
{
    public class WindowSnapCollection : List<WindowSnap>
    {
        public WindowSnapCollection()
        {
            this.asReadonly = false;
        }

        public WindowSnapCollection(WindowSnap[] items, bool asReadOnly)
        {
            base.AddRange(items);
            base.TrimExcess();
            this.asReadonly = asReadOnly;
        }

        public new void Add(WindowSnap item)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Add(item);
        }

        public new void AddRange(IEnumerable<WindowSnap> collection)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.AddRange(collection);
        }

        public new void Clear()
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Clear();
        }

        public bool Contains(IntPtr hWnd)
        {
            return this.GetWindowSnap(hWnd) != null;
        }

        public WindowSnapCollection GetAllMinimized()
        {
            return (WindowSnapCollection)base.FindAll(new Predicate<WindowSnap>(WindowSnapCollection.IsMinimizedPredict));
        }

        public WindowSnap GetWindowSnap(IntPtr hWnd)
        {
            WindowSnapCollection.checkHWnd = hWnd;
            return base.Find(new Predicate<WindowSnap>(WindowSnapCollection.IshWndPredict));
        }

        public new void Insert(int index, WindowSnap item)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Insert(index, item);
        }

        public new void InsertRange(int index, IEnumerable<WindowSnap> collection)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.InsertRange(index, collection);
        }

        private static bool IshWndPredict(WindowSnap ws)
        {
            return ws.Handle == WindowSnapCollection.checkHWnd;
        }

        private static bool IsMinimizedPredict(WindowSnap ws)
        {
            return ws.IsMinimized;
        }

        public new void Remove(WindowSnap item)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Remove(item);
        }

        public new void RemoveAll(Predicate<WindowSnap> match)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.RemoveAll(match);
        }

        public new void RemoveAt(int index)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.RemoveAt(index);
        }

        public new void RemoveRange(int index, int count)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.RemoveRange(index, count);
        }

        public new void Reverse()
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Reverse();
        }

        public new void Reverse(int index, int count)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Reverse(index, count);
        }

        public new void Sort()
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Sort();
        }

        public new void Sort(Comparison<WindowSnap> comparison)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Sort(comparison);
        }

        public new void Sort(IComparer<WindowSnap> compare)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Sort(compare);
        }

        public new void Sort(int index, int count, IComparer<WindowSnap> compare)
        {
            if (this.asReadonly)
            {
                this.ThrowAReadonlyException();
            }
            base.Sort(index, count, compare);
        }

        private void ThrowAReadonlyException()
        {
            throw new Exception("The Collection is marked as Read-Only and it cannot be modified");
        }

        public void Update(WindowSnap item)
        {
            lock (this)
            {
                WindowSnap windowSnap = this.GetWindowSnap(item.Handle);
                this.Remove(windowSnap);
                this.Add(item);
            }
        }

        public bool ReadOnly
        {
            get
            {
                return this.asReadonly;
            }
        }

        private readonly bool asReadonly;

        [ThreadStatic]
        private static IntPtr checkHWnd;

        private const string READONLYEXCEPTIONTEXT = "The Collection is marked as Read-Only and it cannot be modified";
    }
}
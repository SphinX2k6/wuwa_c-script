using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200009B RID: 155
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[DebuggerTypeProxy(typeof(ConfigurationList<>.ConfigurationListDebugView))]
	internal abstract class ConfigurationList<TItem> : IList<TItem>, ICollection<TItem>, IEnumerable<TItem>, IEnumerable
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x00028392 File Offset: 0x00026592
		public ConfigurationList(IEnumerable<TItem> source = null)
		{
			this._list = ((source == null) ? new List<TItem>() : new List<TItem>(source));
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000915 RID: 2325
		public abstract bool IsReadOnly { get; }

		// Token: 0x06000916 RID: 2326
		protected abstract void OnCollectionModifying();

		// Token: 0x06000917 RID: 2327 RVA: 0x000148D8 File Offset: 0x00012AD8
		protected virtual void OnCollectionModified()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000148D8 File Offset: 0x00012AD8
		protected virtual void ValidateAddedValue(TItem item)
		{
		}

		// Token: 0x170001D9 RID: 473
		public TItem this[int index]
		{
			get
			{
				return this._list[index];
			}
			set
			{
				if (value == null)
				{
					ThrowHelper.ThrowArgumentNullException("value");
				}
				this.OnCollectionModifying();
				this.ValidateAddedValue(value);
				this._list[index] = value;
				this.OnCollectionModified();
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000283F2 File Offset: 0x000265F2
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000283FF File Offset: 0x000265FF
		public void Add(TItem item)
		{
			if (item == null)
			{
				ThrowHelper.ThrowArgumentNullException("item");
			}
			this.OnCollectionModifying();
			this.ValidateAddedValue(item);
			this._list.Add(item);
			this.OnCollectionModified();
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00028432 File Offset: 0x00026632
		public void Clear()
		{
			this.OnCollectionModifying();
			this._list.Clear();
			this.OnCollectionModified();
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002844B File Offset: 0x0002664B
		public bool Contains(TItem item)
		{
			return this._list.Contains(item);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00028459 File Offset: 0x00026659
		public void CopyTo(TItem[] array, int arrayIndex)
		{
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00028468 File Offset: 0x00026668
		public List<TItem>.Enumerator GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00028475 File Offset: 0x00026675
		public int IndexOf(TItem item)
		{
			return this._list.IndexOf(item);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00028483 File Offset: 0x00026683
		public void Insert(int index, TItem item)
		{
			if (item == null)
			{
				ThrowHelper.ThrowArgumentNullException("item");
			}
			this.OnCollectionModifying();
			this.ValidateAddedValue(item);
			this._list.Insert(index, item);
			this.OnCollectionModified();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000284B7 File Offset: 0x000266B7
		public bool Remove(TItem item)
		{
			this.OnCollectionModifying();
			bool flag = this._list.Remove(item);
			if (flag)
			{
				this.OnCollectionModified();
			}
			return flag;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000284D4 File Offset: 0x000266D4
		public void RemoveAt(int index)
		{
			this.OnCollectionModifying();
			this._list.RemoveAt(index);
			this.OnCollectionModified();
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000284EE File Offset: 0x000266EE
		IEnumerator<TItem> IEnumerable<!0>.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000284EE File Offset: 0x000266EE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00028500 File Offset: 0x00026700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Count = ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Count);
				defaultInterpolatedStringHandler.AppendLiteral(", IsReadOnly = ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsReadOnly);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x0400029D RID: 669
		protected readonly List<TItem> _list;

		// Token: 0x0200009C RID: 156
		private sealed class ConfigurationListDebugView
		{
			// Token: 0x06000928 RID: 2344 RVA: 0x00028550 File Offset: 0x00026750
			public ConfigurationListDebugView(ConfigurationList<TItem> collection)
			{
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002855F File Offset: 0x0002675F
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public TItem[] Items
			{
				get
				{
					return this.<collection>P._list.ToArray();
				}
			}

			// Token: 0x0400029E RID: 670
			[CompilerGenerated]
			private ConfigurationList<TItem> <collection>P = collection;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C6 RID: 198
	internal sealed class PropertyRefCacheBuilder
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0002CEE9 File Offset: 0x0002B0E9
		public PropertyRefCacheBuilder(PropertyRef[] originalCache)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002CF0E File Offset: 0x0002B10E
		public int TotalCount
		{
			get
			{
				return this.OriginalCache.Length + this._propertyRefs.Count;
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002CF24 File Offset: 0x0002B124
		public PropertyRef[] ToArray()
		{
			PropertyRef[] originalCache = this.OriginalCache;
			List<PropertyRef> propertyRefs = this._propertyRefs;
			int num = 0;
			PropertyRef[] array = new PropertyRef[originalCache.Length + propertyRefs.Count];
			ReadOnlySpan<PropertyRef> readOnlySpan = new ReadOnlySpan<PropertyRef>(originalCache);
			readOnlySpan.CopyTo(new Span<PropertyRef>(array).Slice(num, readOnlySpan.Length));
			num += readOnlySpan.Length;
			Span<PropertyRef> span = CollectionsMarshal.AsSpan<PropertyRef>(propertyRefs);
			span.CopyTo(new Span<PropertyRef>(array).Slice(num, span.Length));
			num += span.Length;
			return array;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002CFB2 File Offset: 0x0002B1B2
		public void TryAdd(PropertyRef propertyRef)
		{
			if (this._added.Add(propertyRef))
			{
				this._propertyRefs.Add(propertyRef);
			}
		}

		// Token: 0x04000311 RID: 785
		private readonly List<PropertyRef> _propertyRefs = new List<PropertyRef>();

		// Token: 0x04000312 RID: 786
		private readonly HashSet<PropertyRef> _added = new HashSet<PropertyRef>();

		// Token: 0x04000313 RID: 787
		public readonly PropertyRef[] OriginalCache = originalCache;
	}
}

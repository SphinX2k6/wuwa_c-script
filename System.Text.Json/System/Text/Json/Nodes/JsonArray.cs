using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;
using System.Threading;

namespace System.Text.Json.Nodes
{
	// Token: 0x02000069 RID: 105
	[NullableContext(2)]
	[Nullable(0)]
	[DebuggerDisplay("JsonArray[{List.Count}]")]
	[DebuggerTypeProxy(typeof(JsonArray.DebugView))]
	public sealed class JsonArray : JsonNode, IList<JsonNode>, ICollection<JsonNode>, IEnumerable<JsonNode>, IEnumerable
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000243C9 File Offset: 0x000225C9
		internal override JsonElement? UnderlyingElement
		{
			get
			{
				return this._jsonElement;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000243D1 File Offset: 0x000225D1
		public JsonArray(JsonNodeOptions? options = null) : base(options)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000243DA File Offset: 0x000225DA
		public JsonArray(JsonNodeOptions options, [Nullable(new byte[]
		{
			1,
			2
		})] params JsonNode[] items) : base(new JsonNodeOptions?(options))
		{
			this.InitializeFromArray(items);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000243EF File Offset: 0x000225EF
		public JsonArray(JsonNodeOptions options, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<JsonNode> items) : base(new JsonNodeOptions?(options))
		{
			this.InitializeFromSpan(items);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00024404 File Offset: 0x00022604
		public JsonArray([Nullable(new byte[]
		{
			1,
			2
		})] params JsonNode[] items) : base(null)
		{
			this.InitializeFromArray(items);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00024428 File Offset: 0x00022628
		public JsonArray([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<JsonNode> items) : base(null)
		{
			this.InitializeFromSpan(items);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0002444B File Offset: 0x0002264B
		private protected override JsonValueKind GetValueKindCore()
		{
			return JsonValueKind.Array;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00024450 File Offset: 0x00022650
		internal override JsonNode DeepCloneCore()
		{
			List<JsonNode> list;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out list, out jsonElement);
			if (list != null)
			{
				JsonArray jsonArray = new JsonArray(base.Options)
				{
					_list = new List<JsonNode>(list.Count)
				};
				for (int i = 0; i < list.Count; i++)
				{
					JsonArray jsonArray2 = jsonArray;
					JsonNode jsonNode = list[i];
					jsonArray2.Add((jsonNode != null) ? jsonNode.DeepCloneCore() : null);
				}
				return jsonArray;
			}
			if (jsonElement == null)
			{
				return new JsonArray(base.Options);
			}
			return new JsonArray(jsonElement.Value.Clone(), base.Options);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000244E8 File Offset: 0x000226E8
		internal override bool DeepEqualsCore(JsonNode node)
		{
			if (node is JsonObject)
			{
				return false;
			}
			JsonValue jsonValue = node as JsonValue;
			if (jsonValue != null)
			{
				return jsonValue.DeepEqualsCore(this);
			}
			JsonArray jsonArray = node as JsonArray;
			if (jsonArray == null)
			{
				return false;
			}
			List<JsonNode> list = this.List;
			List<JsonNode> list2 = jsonArray.List;
			if (list.Count != list2.Count)
			{
				return false;
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (!JsonNode.DeepEquals(list[i], list2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0002456C File Offset: 0x0002276C
		internal int GetElementIndex(JsonNode node)
		{
			return this.List.IndexOf(node);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0002457A File Offset: 0x0002277A
		[NullableContext(1)]
		public IEnumerable<T> GetValues<[Nullable(2)] T>()
		{
			foreach (JsonNode jsonNode in this.List)
			{
				yield return (jsonNode == null) ? ((T)((object)null)) : jsonNode.GetValue<T>();
			}
			List<JsonNode>.Enumerator enumerator = default(List<JsonNode>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002458C File Offset: 0x0002278C
		private void InitializeFromArray(JsonNode[] items)
		{
			List<JsonNode> list = new List<JsonNode>(items);
			for (int i = 0; i < list.Count; i++)
			{
				JsonNode jsonNode = list[i];
				if (jsonNode != null)
				{
					jsonNode.AssignParent(this);
				}
			}
			this._list = list;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000245CC File Offset: 0x000227CC
		private void InitializeFromSpan(ReadOnlySpan<JsonNode> items)
		{
			List<JsonNode> list = new List<JsonNode>(items.Length);
			list.AddRange(items);
			for (int i = 0; i < list.Count; i++)
			{
				JsonNode jsonNode = list[i];
				if (jsonNode != null)
				{
					jsonNode.AssignParent(this);
				}
			}
			this._list = list;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00024618 File Offset: 0x00022818
		public static JsonArray Create(JsonElement element, JsonNodeOptions? options = null)
		{
			JsonValueKind valueKind = element.ValueKind;
			JsonArray result;
			if (valueKind != JsonValueKind.Array)
			{
				if (valueKind != JsonValueKind.Null)
				{
					throw new InvalidOperationException(SR.Format(SR.NodeElementWrongType, "Array"));
				}
				result = null;
			}
			else
			{
				result = new JsonArray(element, options);
			}
			return result;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00024659 File Offset: 0x00022859
		internal JsonArray(JsonElement element, JsonNodeOptions? options = null) : base(options)
		{
			this._jsonElement = new JsonElement?(element);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00024670 File Offset: 0x00022870
		[RequiresUnreferencedCode("Creating JsonValue instances with non-primitive types is not compatible with trimming. It can result in non-primitive types being serialized, which may have their members trimmed.")]
		[RequiresDynamicCode("Creating JsonValue instances with non-primitive types requires generating code at runtime.")]
		public void Add<T>(T value)
		{
			JsonNode item = JsonNode.ConvertFromValue<T>(value, base.Options);
			this.Add(item);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00024691 File Offset: 0x00022891
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<JsonNode> List
		{
			get
			{
				return this._list ?? this.InitializeList();
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000246A3 File Offset: 0x000228A3
		private protected override JsonNode GetItem(int index)
		{
			return this.List[index];
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000246B1 File Offset: 0x000228B1
		private protected override void SetItem(int index, JsonNode value)
		{
			if (value != null)
			{
				value.AssignParent(this);
			}
			JsonArray.DetachParent(this.List[index]);
			this.List[index] = value;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000246DC File Offset: 0x000228DC
		internal unsafe override void GetPath(ref ValueStringBuilder path, JsonNode child)
		{
			JsonNode parent = base.Parent;
			if (parent != null)
			{
				parent.GetPath(ref path, this);
			}
			if (child != null)
			{
				int num = this.List.IndexOf(child);
				path.Append('[');
				Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)20], 10);
				uint num2 = (uint)num;
				int length;
				num2.TryFormat(destination, out length, default(ReadOnlySpan<char>), null);
				path.Append(destination.Slice(0, length));
				path.Append(']');
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00024758 File Offset: 0x00022958
		[NullableContext(1)]
		public override void WriteTo(Utf8JsonWriter writer, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			List<JsonNode> list;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out list, out jsonElement);
			if (list == null && jsonElement != null)
			{
				jsonElement.Value.WriteTo(writer);
				return;
			}
			writer.WriteStartArray();
			foreach (JsonNode jsonNode in this.List)
			{
				if (jsonNode == null)
				{
					writer.WriteNullValue();
				}
				else
				{
					jsonNode.WriteTo(writer, options);
				}
			}
			writer.WriteEndArray();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000247FC File Offset: 0x000229FC
		private List<JsonNode> InitializeList()
		{
			List<JsonNode> list;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out list, out jsonElement);
			if (list == null)
			{
				if (jsonElement != null)
				{
					JsonElement value = jsonElement.Value;
					list = new List<JsonNode>(value.GetArrayLength());
					using (JsonElement.ArrayEnumerator enumerator = value.EnumerateArray().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							JsonElement element = enumerator.Current;
							JsonNode jsonNode = JsonNodeConverter.Create(element, base.Options);
							if (jsonNode != null)
							{
								jsonNode.AssignParent(this);
							}
							list.Add(jsonNode);
						}
						goto IL_88;
					}
				}
				list = new List<JsonNode>();
				IL_88:
				this._list = list;
				Interlocked.MemoryBarrier();
				this._jsonElement = null;
			}
			return list;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000248BC File Offset: 0x00022ABC
		private void GetUnderlyingRepresentation(out List<JsonNode> list, out JsonElement? jsonElement)
		{
			jsonElement = this._jsonElement;
			Interlocked.MemoryBarrier();
			list = this._list;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000248D7 File Offset: 0x00022AD7
		public int Count
		{
			get
			{
				return this.List.Count;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000248E4 File Offset: 0x00022AE4
		public void Add(JsonNode item)
		{
			if (item != null)
			{
				item.AssignParent(this);
			}
			this.List.Add(item);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000248FC File Offset: 0x00022AFC
		public void Clear()
		{
			List<JsonNode> list = this._list;
			if (list == null)
			{
				this._jsonElement = null;
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				JsonArray.DetachParent(list[i]);
			}
			list.Clear();
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00024943 File Offset: 0x00022B43
		public bool Contains(JsonNode item)
		{
			return this.List.Contains(item);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0002456C File Offset: 0x0002276C
		public int IndexOf(JsonNode item)
		{
			return this.List.IndexOf(item);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00024951 File Offset: 0x00022B51
		public void Insert(int index, JsonNode item)
		{
			if (item != null)
			{
				item.AssignParent(this);
			}
			this.List.Insert(index, item);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0002496A File Offset: 0x00022B6A
		public bool Remove(JsonNode item)
		{
			if (this.List.Remove(item))
			{
				JsonArray.DetachParent(item);
				return true;
			}
			return false;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00024983 File Offset: 0x00022B83
		public void RemoveAt(int index)
		{
			JsonNode item = this.List[index];
			this.List.RemoveAt(index);
			JsonArray.DetachParent(item);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000249A2 File Offset: 0x00022BA2
		void ICollection<JsonNode>.CopyTo(JsonNode[] array, int index)
		{
			this.List.CopyTo(array, index);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000249B1 File Offset: 0x00022BB1
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public IEnumerator<JsonNode> GetEnumerator()
		{
			return this.List.GetEnumerator();
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000249C3 File Offset: 0x00022BC3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this.List).GetEnumerator();
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000249D0 File Offset: 0x00022BD0
		bool ICollection<JsonNode>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000249D3 File Offset: 0x00022BD3
		private static void DetachParent(JsonNode item)
		{
			if (item != null)
			{
				item.Parent = null;
			}
		}

		// Token: 0x0400022C RID: 556
		private JsonElement? _jsonElement;

		// Token: 0x0400022D RID: 557
		private List<JsonNode> _list;

		// Token: 0x0200006A RID: 106
		[ExcludeFromCodeCoverage]
		private sealed class DebugView
		{
			// Token: 0x0600078E RID: 1934 RVA: 0x000249DF File Offset: 0x00022BDF
			public DebugView(JsonArray node)
			{
				this._node = node;
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600078F RID: 1935 RVA: 0x000249EE File Offset: 0x00022BEE
			public string Json
			{
				get
				{
					return this._node.ToJsonString(null);
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000790 RID: 1936 RVA: 0x000249FC File Offset: 0x00022BFC
			public string Path
			{
				get
				{
					return this._node.GetPath();
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x06000791 RID: 1937 RVA: 0x00024A0C File Offset: 0x00022C0C
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private JsonArray.DebugView.DebugViewItem[] Items
			{
				get
				{
					JsonArray.DebugView.DebugViewItem[] array = new JsonArray.DebugView.DebugViewItem[this._node.List.Count];
					for (int i = 0; i < this._node.List.Count; i++)
					{
						array[i].Value = this._node.List[i];
					}
					return array;
				}
			}

			// Token: 0x0400022E RID: 558
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly JsonArray _node;

			// Token: 0x0200006B RID: 107
			[DebuggerDisplay("{Display,nq}")]
			private struct DebugViewItem
			{
				// Token: 0x17000195 RID: 405
				// (get) Token: 0x06000792 RID: 1938 RVA: 0x00024A68 File Offset: 0x00022C68
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				public string Display
				{
					get
					{
						if (this.Value == null)
						{
							return "null";
						}
						if (this.Value is JsonValue)
						{
							return this.Value.ToJsonString(null);
						}
						JsonObject jsonObject = this.Value as JsonObject;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						if (jsonObject != null)
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
							defaultInterpolatedStringHandler.AppendLiteral("JsonObject[");
							defaultInterpolatedStringHandler.AppendFormatted<int>(jsonObject.Count);
							defaultInterpolatedStringHandler.AppendLiteral("]");
							return defaultInterpolatedStringHandler.ToStringAndClear();
						}
						JsonArray jsonArray = (JsonArray)this.Value;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
						defaultInterpolatedStringHandler.AppendLiteral("JsonArray[");
						defaultInterpolatedStringHandler.AppendFormatted<int>(jsonArray.List.Count);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}

				// Token: 0x0400022F RID: 559
				[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
				public JsonNode Value;
			}
		}
	}
}

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
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("JsonObject[{Count}]")]
	[DebuggerTypeProxy(typeof(JsonObject.DebugView))]
	public sealed class JsonObject : JsonNode, IDictionary<string, JsonNode>, ICollection<KeyValuePair<string, JsonNode>>, IEnumerable<KeyValuePair<string, JsonNode>>, IEnumerable, IList<KeyValuePair<string, JsonNode>>
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000260EF File Offset: 0x000242EF
		internal override JsonElement? UnderlyingElement
		{
			get
			{
				return this._jsonElement;
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000243D1 File Offset: 0x000225D1
		public JsonObject(JsonNodeOptions? options = null) : base(options)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000260F8 File Offset: 0x000242F8
		public JsonObject([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] IEnumerable<KeyValuePair<string, JsonNode>> properties, JsonNodeOptions? options = null) : this(options)
		{
			ICollection<KeyValuePair<string, JsonNode>> collection = properties as ICollection<KeyValuePair<string, JsonNode>>;
			int capacity = (collection != null) ? collection.Count : 0;
			OrderedDictionary<string, JsonNode> orderedDictionary = JsonObject.CreateDictionary(options, capacity);
			foreach (KeyValuePair<string, JsonNode> keyValuePair in properties)
			{
				orderedDictionary.Add(keyValuePair.Key, keyValuePair.Value);
				JsonNode value = keyValuePair.Value;
				if (value != null)
				{
					value.AssignParent(this);
				}
			}
			this._dictionary = orderedDictionary;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0002618C File Offset: 0x0002438C
		[NullableContext(2)]
		public static JsonObject Create(JsonElement element, JsonNodeOptions? options = null)
		{
			JsonValueKind valueKind = element.ValueKind;
			JsonObject result;
			if (valueKind != JsonValueKind.Object)
			{
				if (valueKind != JsonValueKind.Null)
				{
					throw new InvalidOperationException(SR.Format(SR.NodeElementWrongType, "Object"));
				}
				result = null;
			}
			else
			{
				result = new JsonObject(element, options);
			}
			return result;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000261CD File Offset: 0x000243CD
		internal JsonObject(JsonElement element, JsonNodeOptions? options = null) : this(options)
		{
			this._jsonElement = new JsonElement?(element);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000261E2 File Offset: 0x000243E2
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private OrderedDictionary<string, JsonNode> Dictionary
		{
			get
			{
				return this._dictionary ?? this.InitializeDictionary();
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000261F4 File Offset: 0x000243F4
		private protected override JsonNode GetItem(int index)
		{
			return this.GetAt(index).Value;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00026210 File Offset: 0x00024410
		private protected override void SetItem(int index, JsonNode value)
		{
			this.SetAt(index, value);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0002621C File Offset: 0x0002441C
		internal override JsonNode DeepCloneCore()
		{
			OrderedDictionary<string, JsonNode> orderedDictionary;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out orderedDictionary, out jsonElement);
			if (orderedDictionary != null)
			{
				JsonObject jsonObject = new JsonObject(base.Options)
				{
					_dictionary = JsonObject.CreateDictionary(base.Options, this.Count)
				};
				foreach (KeyValuePair<string, JsonNode> keyValuePair in orderedDictionary)
				{
					JsonObject jsonObject2 = jsonObject;
					string key = keyValuePair.Key;
					JsonNode value = keyValuePair.Value;
					jsonObject2.Add(key, (value != null) ? value.DeepCloneCore() : null);
				}
				return jsonObject;
			}
			if (jsonElement == null)
			{
				return new JsonObject(base.Options);
			}
			return new JsonObject(jsonElement.Value.Clone(), base.Options);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000262E8 File Offset: 0x000244E8
		internal string GetPropertyName(JsonNode node)
		{
			KeyValuePair<string, JsonNode>? keyValuePair = this.FindValue(node);
			if (keyValuePair == null)
			{
				return string.Empty;
			}
			return keyValuePair.Value.Key;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0002631B File Offset: 0x0002451B
		public bool TryGetPropertyValue(string propertyName, [Nullable(2)] out JsonNode jsonNode)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			return this.Dictionary.TryGetValue(propertyName, out jsonNode);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00026338 File Offset: 0x00024538
		public override void WriteTo(Utf8JsonWriter writer, [Nullable(2)] JsonSerializerOptions options = null)
		{
			if (writer == null)
			{
				ThrowHelper.ThrowArgumentNullException("writer");
			}
			OrderedDictionary<string, JsonNode> orderedDictionary;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out orderedDictionary, out jsonElement);
			if (orderedDictionary == null && jsonElement != null)
			{
				jsonElement.Value.WriteTo(writer);
				return;
			}
			writer.WriteStartObject();
			foreach (KeyValuePair<string, JsonNode> keyValuePair in this.Dictionary)
			{
				writer.WritePropertyName(keyValuePair.Key);
				if (keyValuePair.Value == null)
				{
					writer.WriteNullValue();
				}
				else
				{
					keyValuePair.Value.WriteTo(writer, options);
				}
			}
			writer.WriteEndObject();
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00003363 File Offset: 0x00001563
		private protected override JsonValueKind GetValueKindCore()
		{
			return JsonValueKind.Object;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000263F4 File Offset: 0x000245F4
		internal override bool DeepEqualsCore(JsonNode node)
		{
			if (node is JsonArray)
			{
				return false;
			}
			JsonValue jsonValue = node as JsonValue;
			if (jsonValue != null)
			{
				return jsonValue.DeepEqualsCore(this);
			}
			JsonObject jsonObject = node as JsonObject;
			if (jsonObject == null)
			{
				return false;
			}
			OrderedDictionary<string, JsonNode> dictionary = this.Dictionary;
			OrderedDictionary<string, JsonNode> dictionary2 = jsonObject.Dictionary;
			if (dictionary.Count != dictionary2.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, JsonNode> keyValuePair in dictionary)
			{
				JsonNode node2;
				dictionary2.TryGetValue(keyValuePair.Key, out node2);
				if (!JsonNode.DeepEquals(keyValuePair.Value, node2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000264B0 File Offset: 0x000246B0
		internal JsonNode GetItem(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			JsonNode result;
			if (this.TryGetPropertyValue(propertyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000264D8 File Offset: 0x000246D8
		internal override void GetPath(ref ValueStringBuilder path, JsonNode child)
		{
			JsonNode parent = base.Parent;
			if (parent != null)
			{
				parent.GetPath(ref path, this);
			}
			if (child != null)
			{
				string key = this.FindValue(child).Value.Key;
				if (key.AsSpan().ContainsSpecialCharacters())
				{
					path.Append("['");
					path.Append(key);
					path.Append("']");
					return;
				}
				path.Append('.');
				path.Append(key);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00026550 File Offset: 0x00024750
		internal void SetItem(string propertyName, JsonNode value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			OrderedDictionary<string, JsonNode> dictionary = this.Dictionary;
			if (!dictionary.TryAdd(propertyName, value))
			{
				int index = dictionary.IndexOf(propertyName);
				JsonNode value2 = dictionary.GetAt(index).Value;
				if (value == value2)
				{
					return;
				}
				this.DetachParent(value2);
				dictionary.SetAt(index, value);
			}
			if (value != null)
			{
				value.AssignParent(this);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000265B1 File Offset: 0x000247B1
		private void DetachParent(JsonNode item)
		{
			if (item != null)
			{
				item.Parent = null;
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000265C0 File Offset: 0x000247C0
		private KeyValuePair<string, JsonNode>? FindValue(JsonNode value)
		{
			foreach (KeyValuePair<string, JsonNode> value2 in this.Dictionary)
			{
				if (value2.Value == value)
				{
					return new KeyValuePair<string, JsonNode>?(value2);
				}
			}
			return null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002662C File Offset: 0x0002482C
		public void Add(string propertyName, [Nullable(2)] JsonNode value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.Dictionary.Add(propertyName, value);
			if (value != null)
			{
				value.AssignParent(this);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00026652 File Offset: 0x00024852
		public void Add([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JsonNode> property)
		{
			this.Add(property.Key, property.Value);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00026668 File Offset: 0x00024868
		public void Clear()
		{
			OrderedDictionary<string, JsonNode> dictionary = this._dictionary;
			if (dictionary == null)
			{
				this._jsonElement = null;
				return;
			}
			foreach (JsonNode item in dictionary.Values)
			{
				this.DetachParent(item);
			}
			dictionary.Clear();
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000266D8 File Offset: 0x000248D8
		public bool ContainsKey(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			return this.Dictionary.ContainsKey(propertyName);
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000266F3 File Offset: 0x000248F3
		public int Count
		{
			get
			{
				return this.Dictionary.Count;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00026700 File Offset: 0x00024900
		public bool Remove(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			JsonNode item;
			bool flag = this.Dictionary.Remove(propertyName, out item);
			if (flag)
			{
				this.DetachParent(item);
			}
			return flag;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00026732 File Offset: 0x00024932
		bool ICollection<KeyValuePair<string, JsonNode>>.Contains(KeyValuePair<string, JsonNode> item)
		{
			return ((ICollection<KeyValuePair<string, JsonNode>>)this.Dictionary).Contains(item);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00026740 File Offset: 0x00024940
		void ICollection<KeyValuePair<string, JsonNode>>.CopyTo(KeyValuePair<string, JsonNode>[] array, int index)
		{
			((ICollection<KeyValuePair<string, JsonNode>>)this.Dictionary).CopyTo(array, index);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002674F File Offset: 0x0002494F
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		public IEnumerator<KeyValuePair<string, JsonNode>> GetEnumerator()
		{
			return this.Dictionary.GetEnumerator();
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00026761 File Offset: 0x00024961
		bool ICollection<KeyValuePair<string, JsonNode>>.Remove(KeyValuePair<string, JsonNode> item)
		{
			return this.Remove(item.Key);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00026770 File Offset: 0x00024970
		ICollection<string> IDictionary<string, JsonNode>.Keys
		{
			get
			{
				return this.Dictionary.Keys;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0002677D File Offset: 0x0002497D
		[Nullable(new byte[]
		{
			1,
			2
		})]
		ICollection<JsonNode> IDictionary<string, JsonNode>.Values
		{
			get
			{
				return this.Dictionary.Values;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0002631B File Offset: 0x0002451B
		bool IDictionary<string, JsonNode>.TryGetValue(string propertyName, out JsonNode jsonNode)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			return this.Dictionary.TryGetValue(propertyName, out jsonNode);
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x000249D0 File Offset: 0x00022BD0
		bool ICollection<KeyValuePair<string, JsonNode>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0002674F File Offset: 0x0002494F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Dictionary.GetEnumerator();
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002678C File Offset: 0x0002498C
		private OrderedDictionary<string, JsonNode> InitializeDictionary()
		{
			OrderedDictionary<string, JsonNode> orderedDictionary;
			JsonElement? jsonElement;
			this.GetUnderlyingRepresentation(out orderedDictionary, out jsonElement);
			if (orderedDictionary == null)
			{
				orderedDictionary = JsonObject.CreateDictionary(base.Options, 0);
				if (jsonElement != null)
				{
					foreach (JsonProperty jsonProperty in jsonElement.Value.EnumerateObject())
					{
						JsonNode jsonNode = JsonNodeConverter.Create(jsonProperty.Value, base.Options);
						if (jsonNode != null)
						{
							jsonNode.Parent = this;
						}
						orderedDictionary.Add(jsonProperty.Name, jsonNode);
					}
				}
				this._dictionary = orderedDictionary;
				Interlocked.MemoryBarrier();
				this._jsonElement = null;
			}
			return orderedDictionary;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00026854 File Offset: 0x00024A54
		private static OrderedDictionary<string, JsonNode> CreateDictionary(JsonNodeOptions? options, int capacity = 0)
		{
			StringComparer comparer = (options != null && options.GetValueOrDefault().PropertyNameCaseInsensitive) ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;
			return new OrderedDictionary<string, JsonNode>(capacity, comparer);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00026892 File Offset: 0x00024A92
		private void GetUnderlyingRepresentation(out OrderedDictionary<string, JsonNode> dictionary, out JsonElement? jsonElement)
		{
			jsonElement = this._jsonElement;
			Interlocked.MemoryBarrier();
			dictionary = this._dictionary;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000268AD File Offset: 0x00024AAD
		[return: Nullable(new byte[]
		{
			0,
			1,
			2
		})]
		public KeyValuePair<string, JsonNode> GetAt(int index)
		{
			return this.Dictionary.GetAt(index);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000268BC File Offset: 0x00024ABC
		public void SetAt(int index, string propertyName, [Nullable(2)] JsonNode value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			OrderedDictionary<string, JsonNode> dictionary = this.Dictionary;
			KeyValuePair<string, JsonNode> at = dictionary.GetAt(index);
			dictionary.SetAt(index, propertyName, value);
			this.DetachParent(at.Value);
			if (value != null)
			{
				value.AssignParent(this);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00026904 File Offset: 0x00024B04
		[NullableContext(2)]
		public void SetAt(int index, JsonNode value)
		{
			OrderedDictionary<string, JsonNode> dictionary = this.Dictionary;
			KeyValuePair<string, JsonNode> at = dictionary.GetAt(index);
			dictionary.SetAt(index, value);
			this.DetachParent(at.Value);
			if (value != null)
			{
				value.AssignParent(this);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0002693D File Offset: 0x00024B3D
		public int IndexOf(string propertyName)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			return this.Dictionary.IndexOf(propertyName);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00026958 File Offset: 0x00024B58
		public void Insert(int index, string propertyName, [Nullable(2)] JsonNode value)
		{
			if (propertyName == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyName");
			}
			this.Dictionary.Insert(index, propertyName, value);
			if (value != null)
			{
				value.AssignParent(this);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00026980 File Offset: 0x00024B80
		public void RemoveAt(int index)
		{
			KeyValuePair<string, JsonNode> at = this.Dictionary.GetAt(index);
			this.Dictionary.RemoveAt(index);
			this.DetachParent(at.Value);
		}

		// Token: 0x170001A6 RID: 422
		[Nullable(new byte[]
		{
			0,
			1,
			2
		})]
		KeyValuePair<string, JsonNode> IList<KeyValuePair<string, JsonNode>>.this[int index]
		{
			get
			{
				return this.GetAt(index);
			}
			set
			{
				this.SetAt(index, value.Key, value.Value);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000269D3 File Offset: 0x00024BD3
		int IList<KeyValuePair<string, JsonNode>>.IndexOf(KeyValuePair<string, JsonNode> item)
		{
			return ((IList<KeyValuePair<string, JsonNode>>)this.Dictionary).IndexOf(item);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000269E1 File Offset: 0x00024BE1
		void IList<KeyValuePair<string, JsonNode>>.Insert(int index, KeyValuePair<string, JsonNode> item)
		{
			this.Insert(index, item.Key, item.Value);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000269F8 File Offset: 0x00024BF8
		void IList<KeyValuePair<string, JsonNode>>.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x04000240 RID: 576
		private JsonElement? _jsonElement;

		// Token: 0x04000241 RID: 577
		private OrderedDictionary<string, JsonNode> _dictionary;

		// Token: 0x02000072 RID: 114
		[ExcludeFromCodeCoverage]
		private sealed class DebugView
		{
			// Token: 0x06000840 RID: 2112 RVA: 0x00026A01 File Offset: 0x00024C01
			public DebugView(JsonObject node)
			{
				this._node = node;
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000841 RID: 2113 RVA: 0x00026A10 File Offset: 0x00024C10
			public string Json
			{
				get
				{
					return this._node.ToJsonString(null);
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000842 RID: 2114 RVA: 0x00026A1E File Offset: 0x00024C1E
			public string Path
			{
				get
				{
					return this._node.GetPath();
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000843 RID: 2115 RVA: 0x00026A2C File Offset: 0x00024C2C
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private JsonObject.DebugView.DebugViewProperty[] Items
			{
				get
				{
					JsonObject.DebugView.DebugViewProperty[] array = new JsonObject.DebugView.DebugViewProperty[this._node.Count];
					int num = 0;
					foreach (KeyValuePair<string, JsonNode> keyValuePair in this._node)
					{
						array[num].PropertyName = keyValuePair.Key;
						array[num].Value = keyValuePair.Value;
						num++;
					}
					return array;
				}
			}

			// Token: 0x04000242 RID: 578
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly JsonObject _node;

			// Token: 0x02000073 RID: 115
			[DebuggerDisplay("{Display,nq}")]
			private struct DebugViewProperty
			{
				// Token: 0x170001AA RID: 426
				// (get) Token: 0x06000844 RID: 2116 RVA: 0x00026AB0 File Offset: 0x00024CB0
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				public string Display
				{
					get
					{
						if (this.Value == null)
						{
							return this.PropertyName + " = null";
						}
						if (this.Value is JsonValue)
						{
							return this.PropertyName + " = " + this.Value.ToJsonString(null);
						}
						JsonObject jsonObject = this.Value as JsonObject;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						if (jsonObject != null)
						{
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
							defaultInterpolatedStringHandler.AppendFormatted(this.PropertyName);
							defaultInterpolatedStringHandler.AppendLiteral(" = JsonObject[");
							defaultInterpolatedStringHandler.AppendFormatted<int>(jsonObject.Count);
							defaultInterpolatedStringHandler.AppendLiteral("]");
							return defaultInterpolatedStringHandler.ToStringAndClear();
						}
						JsonArray jsonArray = (JsonArray)this.Value;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
						defaultInterpolatedStringHandler.AppendFormatted(this.PropertyName);
						defaultInterpolatedStringHandler.AppendLiteral(" = JsonArray[");
						defaultInterpolatedStringHandler.AppendFormatted<int>(jsonArray.Count);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						return defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}

				// Token: 0x04000243 RID: 579
				[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
				public JsonNode Value;

				// Token: 0x04000244 RID: 580
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				public string PropertyName;
			}
		}
	}
}

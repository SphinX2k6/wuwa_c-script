using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json.Nodes
{
	// Token: 0x0200006E RID: 110
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonNode
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x000253AC File Offset: 0x000235AC
		internal virtual JsonElement? UnderlyingElement
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000253C2 File Offset: 0x000235C2
		public JsonNodeOptions? Options
		{
			get
			{
				if (this._options == null && this.Parent != null)
				{
					this._options = this.Parent.Options;
				}
				return this._options;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000253F0 File Offset: 0x000235F0
		internal JsonNode(JsonNodeOptions? options = null)
		{
			this._options = options;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00025400 File Offset: 0x00023600
		public JsonArray AsArray()
		{
			JsonArray jsonArray = this as JsonArray;
			if (jsonArray == null)
			{
				string text = "JsonArray";
				ThrowHelper.ThrowInvalidOperationException_NodeWrongType(new ReadOnlySpan<string>(ref text));
			}
			return jsonArray;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00025428 File Offset: 0x00023628
		public JsonObject AsObject()
		{
			JsonObject jsonObject = this as JsonObject;
			if (jsonObject == null)
			{
				string text = "JsonObject";
				ThrowHelper.ThrowInvalidOperationException_NodeWrongType(new ReadOnlySpan<string>(ref text));
			}
			return jsonObject;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00025450 File Offset: 0x00023650
		public JsonValue AsValue()
		{
			JsonValue jsonValue = this as JsonValue;
			if (jsonValue == null)
			{
				string text = "JsonValue";
				ThrowHelper.ThrowInvalidOperationException_NodeWrongType(new ReadOnlySpan<string>(ref text));
			}
			return jsonValue;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00025478 File Offset: 0x00023678
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00025480 File Offset: 0x00023680
		[Nullable(2)]
		public JsonNode Parent
		{
			[NullableContext(2)]
			get
			{
				return this._parent;
			}
			internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002548C File Offset: 0x0002368C
		public unsafe string GetPath()
		{
			if (this.Parent == null)
			{
				return "$";
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.Append('$');
			this.GetPath(ref valueStringBuilder, null);
			return valueStringBuilder.ToString();
		}

		// Token: 0x060007AD RID: 1965
		internal abstract void GetPath(ref ValueStringBuilder path, JsonNode child);

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000254E4 File Offset: 0x000236E4
		public JsonNode Root
		{
			get
			{
				JsonNode parent = this.Parent;
				if (parent == null)
				{
					return this;
				}
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				return parent;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00025510 File Offset: 0x00023710
		public virtual T GetValue<[Nullable(2)] T>()
		{
			throw new InvalidOperationException(SR.Format(SR.NodeWrongType, "JsonValue"));
		}

		// Token: 0x1700019D RID: 413
		[Nullable(2)]
		public JsonNode this[int index]
		{
			[NullableContext(2)]
			get
			{
				return this.GetItem(index);
			}
			[NullableContext(2)]
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00025544 File Offset: 0x00023744
		private protected unsafe virtual JsonNode GetItem(int index)
		{
			<>y__InlineArray2<string> <>y__InlineArray = default(<>y__InlineArray2<string>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 0) = "JsonArray";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 1) = "JsonObject";
			ThrowHelper.ThrowInvalidOperationException_NodeWrongType(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<string>, string>(<>y__InlineArray, 2));
			return null;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00025584 File Offset: 0x00023784
		private protected unsafe virtual void SetItem(int index, JsonNode node)
		{
			<>y__InlineArray2<string> <>y__InlineArray = default(<>y__InlineArray2<string>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 0) = "JsonArray";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<string>, string>(ref <>y__InlineArray, 1) = "JsonObject";
			ThrowHelper.ThrowInvalidOperationException_NodeWrongType(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<string>, string>(<>y__InlineArray, 2));
		}

		// Token: 0x1700019E RID: 414
		[Nullable(2)]
		public JsonNode this[string propertyName]
		{
			[return: Nullable(2)]
			get
			{
				return this.AsObject().GetItem(propertyName);
			}
			[param: Nullable(2)]
			set
			{
				this.AsObject().SetItem(propertyName, value);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000255DF File Offset: 0x000237DF
		public JsonNode DeepClone()
		{
			return this.DeepCloneCore();
		}

		// Token: 0x060007B7 RID: 1975
		internal abstract JsonNode DeepCloneCore();

		// Token: 0x060007B8 RID: 1976 RVA: 0x000255E7 File Offset: 0x000237E7
		public JsonValueKind GetValueKind()
		{
			return this.GetValueKindCore();
		}

		// Token: 0x060007B9 RID: 1977
		private protected abstract JsonValueKind GetValueKindCore();

		// Token: 0x060007BA RID: 1978 RVA: 0x000255EF File Offset: 0x000237EF
		public string GetPropertyName()
		{
			JsonObject jsonObject = this._parent as JsonObject;
			if (jsonObject == null)
			{
				ThrowHelper.ThrowInvalidOperationException_NodeParentWrongType("JsonObject");
			}
			return jsonObject.GetPropertyName(this);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002560F File Offset: 0x0002380F
		public int GetElementIndex()
		{
			JsonArray jsonArray = this._parent as JsonArray;
			if (jsonArray == null)
			{
				ThrowHelper.ThrowInvalidOperationException_NodeParentWrongType("JsonArray");
			}
			return jsonArray.GetElementIndex(this);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002562F File Offset: 0x0002382F
		[NullableContext(2)]
		public static bool DeepEquals(JsonNode node1, JsonNode node2)
		{
			if (node1 == null)
			{
				return node2 == null;
			}
			return node2 != null && node1.DeepEqualsCore(node2);
		}

		// Token: 0x060007BD RID: 1981
		internal abstract bool DeepEqualsCore(JsonNode node);

		// Token: 0x060007BE RID: 1982 RVA: 0x00025648 File Offset: 0x00023848
		[RequiresUnreferencedCode("Creating JsonValue instances with non-primitive types is not compatible with trimming. It can result in non-primitive types being serialized, which may have their members trimmed.")]
		[RequiresDynamicCode("Creating JsonValue instances with non-primitive types requires generating code at runtime.")]
		public void ReplaceWith<[Nullable(2)] T>(T value)
		{
			JsonNode parent = this._parent;
			JsonObject jsonObject = parent as JsonObject;
			JsonNode jsonNode;
			if (jsonObject != null)
			{
				jsonNode = JsonNode.ConvertFromValue<T>(value, null);
				jsonObject.SetItem(this.GetPropertyName(), jsonNode);
				return;
			}
			JsonArray jsonArray = parent as JsonArray;
			if (jsonArray == null)
			{
				return;
			}
			jsonNode = JsonNode.ConvertFromValue<T>(value, null);
			jsonArray.SetItem(this.GetElementIndex(), jsonNode);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000256B0 File Offset: 0x000238B0
		internal void AssignParent(JsonNode parent)
		{
			if (this.Parent != null)
			{
				ThrowHelper.ThrowInvalidOperationException_NodeAlreadyHasParent();
			}
			for (JsonNode jsonNode = parent; jsonNode != null; jsonNode = jsonNode.Parent)
			{
				if (jsonNode == this)
				{
					ThrowHelper.ThrowInvalidOperationException_NodeCycleDetected();
				}
			}
			this.Parent = parent;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000256E8 File Offset: 0x000238E8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal static JsonNode ConvertFromValue<T>(T value, JsonNodeOptions? options = null)
		{
			if (value == null)
			{
				return null;
			}
			JsonNode jsonNode = value as JsonNode;
			if (jsonNode != null)
			{
				return jsonNode;
			}
			if (value is JsonElement)
			{
				JsonElement element = value as JsonElement;
				return JsonNodeConverter.Create(element, options);
			}
			JsonTypeInfo<T> jsonTypeInfo = (JsonTypeInfo<T>)JsonSerializerOptions.Default.GetTypeInfo(typeof(T));
			return JsonValue.CreateFromTypeInfo<T>(value, jsonTypeInfo, options);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00025758 File Offset: 0x00023958
		public static implicit operator JsonNode(bool value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00025774 File Offset: 0x00023974
		[NullableContext(2)]
		public static implicit operator JsonNode(bool? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00025790 File Offset: 0x00023990
		public static implicit operator JsonNode(byte value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000257AC File Offset: 0x000239AC
		[NullableContext(2)]
		public static implicit operator JsonNode(byte? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000257C8 File Offset: 0x000239C8
		public static implicit operator JsonNode(char value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000257E4 File Offset: 0x000239E4
		[NullableContext(2)]
		public static implicit operator JsonNode(char? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00025800 File Offset: 0x00023A00
		public static implicit operator JsonNode(DateTime value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0002581C File Offset: 0x00023A1C
		[NullableContext(2)]
		public static implicit operator JsonNode(DateTime? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00025838 File Offset: 0x00023A38
		public static implicit operator JsonNode(DateTimeOffset value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00025854 File Offset: 0x00023A54
		[NullableContext(2)]
		public static implicit operator JsonNode(DateTimeOffset? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00025870 File Offset: 0x00023A70
		public static implicit operator JsonNode(decimal value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0002588C File Offset: 0x00023A8C
		[NullableContext(2)]
		public static implicit operator JsonNode(decimal? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000258A8 File Offset: 0x00023AA8
		public static implicit operator JsonNode(double value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000258C4 File Offset: 0x00023AC4
		[NullableContext(2)]
		public static implicit operator JsonNode(double? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000258E0 File Offset: 0x00023AE0
		public static implicit operator JsonNode(Guid value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000258FC File Offset: 0x00023AFC
		[NullableContext(2)]
		public static implicit operator JsonNode(Guid? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00025918 File Offset: 0x00023B18
		public static implicit operator JsonNode(short value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00025934 File Offset: 0x00023B34
		[NullableContext(2)]
		public static implicit operator JsonNode(short? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00025950 File Offset: 0x00023B50
		public static implicit operator JsonNode(int value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0002596C File Offset: 0x00023B6C
		[NullableContext(2)]
		public static implicit operator JsonNode(int? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00025988 File Offset: 0x00023B88
		public static implicit operator JsonNode(long value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000259A4 File Offset: 0x00023BA4
		[NullableContext(2)]
		public static implicit operator JsonNode(long? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000259C0 File Offset: 0x00023BC0
		[CLSCompliant(false)]
		public static implicit operator JsonNode(sbyte value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000259DC File Offset: 0x00023BDC
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static implicit operator JsonNode(sbyte? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000259F8 File Offset: 0x00023BF8
		public static implicit operator JsonNode(float value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00025A14 File Offset: 0x00023C14
		[NullableContext(2)]
		public static implicit operator JsonNode(float? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00025A30 File Offset: 0x00023C30
		[NullableContext(2)]
		[return: NotNullIfNotNull("value")]
		public static implicit operator JsonNode(string value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00025A4C File Offset: 0x00023C4C
		[CLSCompliant(false)]
		public static implicit operator JsonNode(ushort value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00025A68 File Offset: 0x00023C68
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static implicit operator JsonNode(ushort? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00025A84 File Offset: 0x00023C84
		[CLSCompliant(false)]
		public static implicit operator JsonNode(uint value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00025AA0 File Offset: 0x00023CA0
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static implicit operator JsonNode(uint? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00025ABC File Offset: 0x00023CBC
		[CLSCompliant(false)]
		public static implicit operator JsonNode(ulong value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00025AD8 File Offset: 0x00023CD8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static implicit operator JsonNode(ulong? value)
		{
			return JsonValue.Create(value, null);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00025AF4 File Offset: 0x00023CF4
		public static explicit operator bool(JsonNode value)
		{
			return value.GetValue<bool>();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00025AFC File Offset: 0x00023CFC
		[NullableContext(2)]
		public static explicit operator bool?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new bool?(value.GetValue<bool>());
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00025B21 File Offset: 0x00023D21
		public static explicit operator byte(JsonNode value)
		{
			return value.GetValue<byte>();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00025B2C File Offset: 0x00023D2C
		[NullableContext(2)]
		public static explicit operator byte?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new byte?(value.GetValue<byte>());
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00025B51 File Offset: 0x00023D51
		public static explicit operator char(JsonNode value)
		{
			return value.GetValue<char>();
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00025B5C File Offset: 0x00023D5C
		[NullableContext(2)]
		public static explicit operator char?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new char?(value.GetValue<char>());
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00025B81 File Offset: 0x00023D81
		public static explicit operator DateTime(JsonNode value)
		{
			return value.GetValue<DateTime>();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00025B8C File Offset: 0x00023D8C
		[NullableContext(2)]
		public static explicit operator DateTime?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new DateTime?(value.GetValue<DateTime>());
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00025BB1 File Offset: 0x00023DB1
		public static explicit operator DateTimeOffset(JsonNode value)
		{
			return value.GetValue<DateTimeOffset>();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00025BBC File Offset: 0x00023DBC
		[NullableContext(2)]
		public static explicit operator DateTimeOffset?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new DateTimeOffset?(value.GetValue<DateTimeOffset>());
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00025BE1 File Offset: 0x00023DE1
		public static explicit operator decimal(JsonNode value)
		{
			return value.GetValue<decimal>();
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00025BEC File Offset: 0x00023DEC
		[NullableContext(2)]
		public static explicit operator decimal?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new decimal?(value.GetValue<decimal>());
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00025C11 File Offset: 0x00023E11
		public static explicit operator double(JsonNode value)
		{
			return value.GetValue<double>();
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00025C1C File Offset: 0x00023E1C
		[NullableContext(2)]
		public static explicit operator double?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new double?(value.GetValue<double>());
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00025C41 File Offset: 0x00023E41
		public static explicit operator Guid(JsonNode value)
		{
			return value.GetValue<Guid>();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00025C4C File Offset: 0x00023E4C
		[NullableContext(2)]
		public static explicit operator Guid?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new Guid?(value.GetValue<Guid>());
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00025C71 File Offset: 0x00023E71
		public static explicit operator short(JsonNode value)
		{
			return value.GetValue<short>();
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00025C7C File Offset: 0x00023E7C
		[NullableContext(2)]
		public static explicit operator short?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new short?(value.GetValue<short>());
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00025CA1 File Offset: 0x00023EA1
		public static explicit operator int(JsonNode value)
		{
			return value.GetValue<int>();
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00025CAC File Offset: 0x00023EAC
		[NullableContext(2)]
		public static explicit operator int?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new int?(value.GetValue<int>());
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00025CD1 File Offset: 0x00023ED1
		public static explicit operator long(JsonNode value)
		{
			return value.GetValue<long>();
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00025CDC File Offset: 0x00023EDC
		[NullableContext(2)]
		public static explicit operator long?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new long?(value.GetValue<long>());
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00025D01 File Offset: 0x00023F01
		[CLSCompliant(false)]
		public static explicit operator sbyte(JsonNode value)
		{
			return value.GetValue<sbyte>();
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00025D0C File Offset: 0x00023F0C
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new sbyte?(value.GetValue<sbyte>());
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00025D31 File Offset: 0x00023F31
		public static explicit operator float(JsonNode value)
		{
			return value.GetValue<float>();
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00025D3C File Offset: 0x00023F3C
		[NullableContext(2)]
		public static explicit operator float?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new float?(value.GetValue<float>());
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00025D61 File Offset: 0x00023F61
		[NullableContext(2)]
		public static explicit operator string(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return value.GetValue<string>();
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00025D6E File Offset: 0x00023F6E
		[CLSCompliant(false)]
		public static explicit operator ushort(JsonNode value)
		{
			return value.GetValue<ushort>();
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00025D78 File Offset: 0x00023F78
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ushort?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new ushort?(value.GetValue<ushort>());
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00025D9D File Offset: 0x00023F9D
		[CLSCompliant(false)]
		public static explicit operator uint(JsonNode value)
		{
			return value.GetValue<uint>();
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00025DA8 File Offset: 0x00023FA8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator uint?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new uint?(value.GetValue<uint>());
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00025DCD File Offset: 0x00023FCD
		[CLSCompliant(false)]
		public static explicit operator ulong(JsonNode value)
		{
			return value.GetValue<ulong>();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00025DD8 File Offset: 0x00023FD8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ulong?(JsonNode value)
		{
			if (value == null)
			{
				return null;
			}
			return new ulong?(value.GetValue<ulong>());
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00025DFD File Offset: 0x00023FFD
		[NullableContext(2)]
		public static JsonNode Parse(ref Utf8JsonReader reader, JsonNodeOptions? nodeOptions = null)
		{
			return JsonNodeConverter.Create(JsonElement.ParseValue(ref reader), nodeOptions);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00025E0B File Offset: 0x0002400B
		[return: Nullable(2)]
		public static JsonNode Parse([StringSyntax("Json")] string json, JsonNodeOptions? nodeOptions = null, JsonDocumentOptions documentOptions = default(JsonDocumentOptions))
		{
			if (json == null)
			{
				ThrowHelper.ThrowArgumentNullException("json");
			}
			return JsonNodeConverter.Create(JsonElement.ParseValue(json, documentOptions), nodeOptions);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00025E27 File Offset: 0x00024027
		[NullableContext(0)]
		[return: Nullable(2)]
		public static JsonNode Parse(ReadOnlySpan<byte> utf8Json, JsonNodeOptions? nodeOptions = null, JsonDocumentOptions documentOptions = default(JsonDocumentOptions))
		{
			return JsonNodeConverter.Create(JsonElement.ParseValue(utf8Json, documentOptions), nodeOptions);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00025E36 File Offset: 0x00024036
		[return: Nullable(2)]
		public static JsonNode Parse(Stream utf8Json, JsonNodeOptions? nodeOptions = null, JsonDocumentOptions documentOptions = default(JsonDocumentOptions))
		{
			if (utf8Json == null)
			{
				ThrowHelper.ThrowArgumentNullException("utf8Json");
			}
			return JsonNodeConverter.Create(JsonElement.ParseValue(utf8Json, documentOptions), nodeOptions);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00025E54 File Offset: 0x00024054
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public static Task<JsonNode> ParseAsync(Stream utf8Json, JsonNodeOptions? nodeOptions = null, JsonDocumentOptions documentOptions = default(JsonDocumentOptions), CancellationToken cancellationToken = default(CancellationToken))
		{
			JsonNode.<ParseAsync>d__108 <ParseAsync>d__;
			<ParseAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JsonNode>.Create();
			<ParseAsync>d__.utf8Json = utf8Json;
			<ParseAsync>d__.nodeOptions = nodeOptions;
			<ParseAsync>d__.documentOptions = documentOptions;
			<ParseAsync>d__.cancellationToken = cancellationToken;
			<ParseAsync>d__.<>1__state = -1;
			<ParseAsync>d__.<>t__builder.Start<JsonNode.<ParseAsync>d__108>(ref <ParseAsync>d__);
			return <ParseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00025EB0 File Offset: 0x000240B0
		public string ToJsonString([Nullable(2)] JsonSerializerOptions options = null)
		{
			JsonWriterOptions options2 = default(JsonWriterOptions);
			int defaultBufferSize = 16384;
			if (options != null)
			{
				options2 = options.GetWriterOptions();
				defaultBufferSize = options.DefaultBufferSize;
			}
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter utf8JsonWriter = Utf8JsonWriterCache.RentWriterAndBuffer(options2, defaultBufferSize, out pooledByteBufferWriter);
			string result;
			try
			{
				this.WriteTo(utf8JsonWriter, options);
				utf8JsonWriter.Flush();
				result = JsonHelpers.Utf8GetString(pooledByteBufferWriter.WrittenMemory.Span);
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(utf8JsonWriter, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00025F28 File Offset: 0x00024128
		public override string ToString()
		{
			if (this is JsonValue)
			{
				JsonValuePrimitive<string> jsonValuePrimitive = this as JsonValuePrimitive<string>;
				if (jsonValuePrimitive != null)
				{
					return jsonValuePrimitive.Value;
				}
				JsonValueOfElement jsonValueOfElement = this as JsonValueOfElement;
				if (jsonValueOfElement != null && jsonValueOfElement.Value.ValueKind == JsonValueKind.String)
				{
					return jsonValueOfElement.Value.GetString();
				}
			}
			PooledByteBufferWriter pooledByteBufferWriter;
			Utf8JsonWriter utf8JsonWriter = Utf8JsonWriterCache.RentWriterAndBuffer(new JsonWriterOptions
			{
				Indented = true
			}, 16384, out pooledByteBufferWriter);
			string result;
			try
			{
				this.WriteTo(utf8JsonWriter, null);
				utf8JsonWriter.Flush();
				result = JsonHelpers.Utf8GetString(pooledByteBufferWriter.WrittenMemory.Span);
			}
			finally
			{
				Utf8JsonWriterCache.ReturnWriterAndBuffer(utf8JsonWriter, pooledByteBufferWriter);
			}
			return result;
		}

		// Token: 0x0600080A RID: 2058
		public abstract void WriteTo(Utf8JsonWriter writer, [Nullable(2)] JsonSerializerOptions options = null);

		// Token: 0x04000235 RID: 565
		private protected static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions();

		// Token: 0x04000236 RID: 566
		private JsonNode _parent;

		// Token: 0x04000237 RID: 567
		private JsonNodeOptions? _options;
	}
}

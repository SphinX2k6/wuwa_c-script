using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Text.Json.Nodes
{
	// Token: 0x02000076 RID: 118
	[DebuggerDisplay("{ToJsonString(),nq}")]
	[DebuggerTypeProxy(typeof(JsonValue<>.DebugView))]
	internal abstract class JsonValue<TValue> : JsonValue
	{
		// Token: 0x06000876 RID: 2166 RVA: 0x00027290 File Offset: 0x00025490
		protected JsonValue(TValue value, JsonNodeOptions? options) : base(options)
		{
			this.Value = value;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000272A0 File Offset: 0x000254A0
		public override T GetValue<T>()
		{
			TValue value = this.Value;
			if (value is T)
			{
				return value as T;
			}
			ThrowHelper.ThrowInvalidOperationException_NodeUnableToConvert(typeof(TValue), typeof(T));
			return default(T);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000272F8 File Offset: 0x000254F8
		public override bool TryGetValue<T>([NotNullWhen(true)] out T value)
		{
			TValue value2 = this.Value;
			if (value2 is T)
			{
				T t = value2 as T;
				value = t;
				return true;
			}
			value = default(T);
			return false;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0002733B File Offset: 0x0002553B
		internal static bool TypeIsSupportedPrimitive
		{
			get
			{
				return JsonValue<TValue>.s_valueKind != null;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00027348 File Offset: 0x00025548
		private protected static JsonValueKind DetermineValueKind(TValue value)
		{
			if (!(value is bool))
			{
				return JsonValue<TValue>.s_valueKind.Value;
			}
			if (!(value as bool))
			{
				return JsonValueKind.False;
			}
			return JsonValueKind.True;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00027384 File Offset: 0x00025584
		private static JsonValueKind? DetermineValueKindForType(Type type)
		{
			if (type.IsEnum)
			{
				return null;
			}
			Type underlyingType = Nullable.GetUnderlyingType(type);
			if (underlyingType != null)
			{
				return JsonValue<TValue>.DetermineValueKindForType(underlyingType);
			}
			if (type == typeof(DateTime) || type == typeof(DateTimeOffset) || type == typeof(TimeSpan) || type == typeof(DateOnly) || type == typeof(TimeOnly) || type == typeof(Guid) || type == typeof(Uri) || type == typeof(Version))
			{
				return new JsonValueKind?(JsonValueKind.String);
			}
			if (type == typeof(Half) || type == typeof(UInt128) || type == typeof(Int128))
			{
				return new JsonValueKind?(JsonValueKind.Number);
			}
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				return new JsonValueKind?(JsonValueKind.Undefined);
			case TypeCode.Char:
				return new JsonValueKind?(JsonValueKind.String);
			case TypeCode.SByte:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Byte:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Int16:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.UInt16:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Int32:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.UInt32:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Int64:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.UInt64:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Single:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Double:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.Decimal:
				return new JsonValueKind?(JsonValueKind.Number);
			case TypeCode.String:
				return new JsonValueKind?(JsonValueKind.String);
			}
			return null;
		}

		// Token: 0x04000249 RID: 585
		internal readonly TValue Value;

		// Token: 0x0400024A RID: 586
		private static readonly JsonValueKind? s_valueKind = JsonValue<TValue>.DetermineValueKindForType(typeof(TValue));

		// Token: 0x02000077 RID: 119
		[ExcludeFromCodeCoverage]
		[DebuggerDisplay("{Json,nq}")]
		private sealed class DebugView
		{
			// Token: 0x0600087D RID: 2173 RVA: 0x00027578 File Offset: 0x00025778
			public DebugView(JsonValue<TValue> node)
			{
				this._node = node;
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x0600087E RID: 2174 RVA: 0x00027587 File Offset: 0x00025787
			public string Json
			{
				get
				{
					return this._node.ToJsonString(null);
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x0600087F RID: 2175 RVA: 0x00027595 File Offset: 0x00025795
			public string Path
			{
				get
				{
					return this._node.GetPath();
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06000880 RID: 2176 RVA: 0x000275A2 File Offset: 0x000257A2
			public TValue Value
			{
				get
				{
					return this._node.Value;
				}
			}

			// Token: 0x0400024B RID: 587
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public JsonValue<TValue> _node;
		}
	}
}

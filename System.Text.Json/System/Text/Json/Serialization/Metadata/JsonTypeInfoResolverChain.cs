using System;
using System.Collections.Generic;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C4 RID: 196
	internal class JsonTypeInfoResolverChain : ConfigurationList<IJsonTypeInfoResolver>, IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x0002CCB0 File Offset: 0x0002AEB0
		public JsonTypeInfoResolverChain() : base(null)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00003363 File Offset: 0x00001563
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002CCB9 File Offset: 0x0002AEB9
		protected override void OnCollectionModifying()
		{
			ThrowHelper.ThrowInvalidOperationException_TypeInfoResolverChainImmutable();
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		public JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			foreach (IJsonTypeInfoResolver jsonTypeInfoResolver in this._list)
			{
				JsonTypeInfo typeInfo = jsonTypeInfoResolver.GetTypeInfo(type, options);
				if (typeInfo != null)
				{
					return typeInfo;
				}
			}
			return null;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002CD20 File Offset: 0x0002AF20
		internal void AddFlattened(IJsonTypeInfoResolver resolver)
		{
			if (resolver != null && !(resolver is EmptyJsonTypeInfoResolver))
			{
				JsonTypeInfoResolverChain jsonTypeInfoResolverChain = resolver as JsonTypeInfoResolverChain;
				if (jsonTypeInfoResolverChain != null)
				{
					this._list.AddRange(jsonTypeInfoResolverChain);
					return;
				}
				this._list.Add(resolver);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		bool IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions options)
		{
			using (List<IJsonTypeInfoResolver>.Enumerator enumerator = this._list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsCompatibleWithOptions(options))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("[");
			foreach (IJsonTypeInfoResolver value in this._list)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(", ");
			}
			if (this._list.Count > 0)
			{
				stringBuilder.Length -= 2;
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}
	}
}

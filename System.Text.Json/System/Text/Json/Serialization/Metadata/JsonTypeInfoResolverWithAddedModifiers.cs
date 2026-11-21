using System;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C5 RID: 197
	internal sealed class JsonTypeInfoResolverWithAddedModifiers : IJsonTypeInfoResolver
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x0002CE50 File Offset: 0x0002B050
		public JsonTypeInfoResolverWithAddedModifiers(IJsonTypeInfoResolver source, Action<JsonTypeInfo>[] modifiers)
		{
			this._source = source;
			this._modifiers = modifiers;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002CE68 File Offset: 0x0002B068
		public JsonTypeInfoResolverWithAddedModifiers WithAddedModifier(Action<JsonTypeInfo> modifier)
		{
			Action<JsonTypeInfo>[] array = new Action<JsonTypeInfo>[this._modifiers.Length + 1];
			this._modifiers.CopyTo(array, 0);
			array[this._modifiers.Length] = modifier;
			return new JsonTypeInfoResolverWithAddedModifiers(this._source, array);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002CEAC File Offset: 0x0002B0AC
		public JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			JsonTypeInfo typeInfo = this._source.GetTypeInfo(type, options);
			if (typeInfo != null)
			{
				Action<JsonTypeInfo>[] modifiers = this._modifiers;
				for (int i = 0; i < modifiers.Length; i++)
				{
					modifiers[i](typeInfo);
				}
			}
			return typeInfo;
		}

		// Token: 0x0400030F RID: 783
		private readonly IJsonTypeInfoResolver _source;

		// Token: 0x04000310 RID: 784
		private readonly Action<JsonTypeInfo>[] _modifiers;
	}
}

using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonTypeInfoResolver
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x0002CBCA File Offset: 0x0002ADCA
		public static IJsonTypeInfoResolver Combine([Nullable(new byte[]
		{
			1,
			2
		})] params IJsonTypeInfoResolver[] resolvers)
		{
			if (resolvers == null)
			{
				ThrowHelper.ThrowArgumentNullException("resolvers");
			}
			return JsonTypeInfoResolver.Combine(resolvers);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
		public unsafe static IJsonTypeInfoResolver Combine([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<IJsonTypeInfoResolver> resolvers)
		{
			JsonTypeInfoResolverChain jsonTypeInfoResolverChain = new JsonTypeInfoResolverChain();
			ReadOnlySpan<IJsonTypeInfoResolver> readOnlySpan = resolvers;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				IJsonTypeInfoResolver resolver = *readOnlySpan[i];
				jsonTypeInfoResolverChain.AddFlattened(resolver);
			}
			if (jsonTypeInfoResolverChain.Count != 1)
			{
				return jsonTypeInfoResolverChain;
			}
			return jsonTypeInfoResolverChain[0];
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002CC34 File Offset: 0x0002AE34
		public static IJsonTypeInfoResolver WithAddedModifier(this IJsonTypeInfoResolver resolver, Action<JsonTypeInfo> modifier)
		{
			if (resolver == null)
			{
				ThrowHelper.ThrowArgumentNullException("resolver");
			}
			if (modifier == null)
			{
				ThrowHelper.ThrowArgumentNullException("modifier");
			}
			JsonTypeInfoResolverWithAddedModifiers jsonTypeInfoResolverWithAddedModifiers = resolver as JsonTypeInfoResolverWithAddedModifiers;
			if (jsonTypeInfoResolverWithAddedModifiers == null)
			{
				return new JsonTypeInfoResolverWithAddedModifiers(resolver, new Action<JsonTypeInfo>[]
				{
					modifier
				});
			}
			return jsonTypeInfoResolverWithAddedModifiers.WithAddedModifier(modifier);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002CC7D File Offset: 0x0002AE7D
		internal static IJsonTypeInfoResolver Empty { get; } = new EmptyJsonTypeInfoResolver();

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002CC84 File Offset: 0x0002AE84
		internal static bool IsCompatibleWithOptions(this IJsonTypeInfoResolver resolver, JsonSerializerOptions options)
		{
			IBuiltInJsonTypeInfoResolver builtInJsonTypeInfoResolver = resolver as IBuiltInJsonTypeInfoResolver;
			return builtInJsonTypeInfoResolver != null && builtInJsonTypeInfoResolver.IsCompatibleWithOptions(options);
		}
	}
}

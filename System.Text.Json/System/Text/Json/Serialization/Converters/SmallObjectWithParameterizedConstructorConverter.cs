using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000134 RID: 308
	internal sealed class SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3> : ObjectWithParameterizedConstructorConverter<T>
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x00036A6C File Offset: 0x00034C6C
		protected override object CreateObject(ref ReadStackFrame frame)
		{
			JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> parameterizedConstructorDelegate = (JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3>)frame.JsonTypeInfo.CreateObjectWithArgs;
			Arguments<TArg0, TArg1, TArg2, TArg3> arguments = (Arguments<TArg0, TArg1, TArg2, TArg3>)frame.CtorArgumentState.Arguments;
			return parameterizedConstructorDelegate(arguments.Arg0, arguments.Arg1, arguments.Arg2, arguments.Arg3);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00036ABC File Offset: 0x00034CBC
		protected override bool ReadAndCacheConstructorArgument([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo)
		{
			Arguments<TArg0, TArg1, TArg2, TArg3> arguments = (Arguments<TArg0, TArg1, TArg2, TArg3>)state.Current.CtorArgumentState.Arguments;
			bool result;
			switch (jsonParameterInfo.Position)
			{
			case 0:
				result = SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3>.TryRead<TArg0>(ref state, ref reader, jsonParameterInfo, out arguments.Arg0);
				break;
			case 1:
				result = SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3>.TryRead<TArg1>(ref state, ref reader, jsonParameterInfo, out arguments.Arg1);
				break;
			case 2:
				result = SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3>.TryRead<TArg2>(ref state, ref reader, jsonParameterInfo, out arguments.Arg2);
				break;
			case 3:
				result = SmallObjectWithParameterizedConstructorConverter<T, TArg0, TArg1, TArg2, TArg3>.TryRead<TArg3>(ref state, ref reader, jsonParameterInfo, out arguments.Arg3);
				break;
			default:
				throw new InvalidOperationException();
			}
			return result;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00036B4C File Offset: 0x00034D4C
		private static bool TryRead<TArg>([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo, out TArg arg)
		{
			JsonParameterInfo<TArg> jsonParameterInfo2 = (JsonParameterInfo<TArg>)jsonParameterInfo;
			TArg effectiveDefaultValue;
			bool flag2;
			bool flag = jsonParameterInfo2.EffectiveConverter.TryRead(ref reader, jsonParameterInfo2.ParameterType, jsonParameterInfo2.Options, ref state, out effectiveDefaultValue, out flag2);
			if (flag && effectiveDefaultValue == null)
			{
				if (jsonParameterInfo2.IgnoreNullTokensOnRead)
				{
					effectiveDefaultValue = jsonParameterInfo2.EffectiveDefaultValue;
				}
				else if (!jsonParameterInfo2.IsNullable && jsonParameterInfo2.Options.RespectNullableAnnotations)
				{
					ThrowHelper.ThrowJsonException_ConstructorParameterDisallowNull(jsonParameterInfo2.Name, state.Current.JsonTypeInfo.Type);
				}
			}
			arg = effectiveDefaultValue;
			return flag;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00036BD0 File Offset: 0x00034DD0
		protected unsafe override void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			Arguments<TArg0, TArg1, TArg2, TArg3> arguments = new Arguments<TArg0, TArg1, TArg2, TArg3>();
			ReadOnlySpan<JsonParameterInfo> parameterCache = jsonTypeInfo.ParameterCache;
			for (int i = 0; i < parameterCache.Length; i++)
			{
				JsonParameterInfo jsonParameterInfo = *parameterCache[i];
				switch (jsonParameterInfo.Position)
				{
				case 0:
					arguments.Arg0 = ((JsonParameterInfo<TArg0>)jsonParameterInfo).EffectiveDefaultValue;
					break;
				case 1:
					arguments.Arg1 = ((JsonParameterInfo<TArg1>)jsonParameterInfo).EffectiveDefaultValue;
					break;
				case 2:
					arguments.Arg2 = ((JsonParameterInfo<TArg2>)jsonParameterInfo).EffectiveDefaultValue;
					break;
				case 3:
					arguments.Arg3 = ((JsonParameterInfo<TArg3>)jsonParameterInfo).EffectiveDefaultValue;
					break;
				}
			}
			state.Current.CtorArgumentState.Arguments = arguments;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00036C8F File Offset: 0x00034E8F
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal override void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			jsonTypeInfo.CreateObjectWithArgs = DefaultJsonTypeInfoResolver.MemberAccessor.CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(base.ConstructorInfo);
		}
	}
}

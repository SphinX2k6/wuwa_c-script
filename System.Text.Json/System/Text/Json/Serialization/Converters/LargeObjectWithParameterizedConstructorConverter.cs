using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000133 RID: 307
	internal class LargeObjectWithParameterizedConstructorConverter<T> : ObjectWithParameterizedConstructorConverter<T>
	{
		// Token: 0x06000E08 RID: 3592 RVA: 0x00036910 File Offset: 0x00034B10
		protected sealed override bool ReadAndCacheConstructorArgument([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo)
		{
			object obj;
			bool flag = jsonParameterInfo.EffectiveConverter.TryReadAsObject(ref reader, jsonParameterInfo.ParameterType, jsonParameterInfo.Options, ref state, out obj);
			if (flag && (obj != null || !jsonParameterInfo.IgnoreNullTokensOnRead))
			{
				if (obj == null && !jsonParameterInfo.IsNullable && jsonParameterInfo.Options.RespectNullableAnnotations)
				{
					ThrowHelper.ThrowJsonException_ConstructorParameterDisallowNull(jsonParameterInfo.Name, state.Current.JsonTypeInfo.Type);
				}
				((object[])state.Current.CtorArgumentState.Arguments)[jsonParameterInfo.Position] = obj;
			}
			return flag;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00036998 File Offset: 0x00034B98
		protected sealed override object CreateObject(ref ReadStackFrame frame)
		{
			object[] array = (object[])frame.CtorArgumentState.Arguments;
			frame.CtorArgumentState.Arguments = null;
			object result = ((Func<object[], T>)frame.JsonTypeInfo.CreateObjectWithArgs)(array);
			ArrayPool<object>.Shared.Return(array, true);
			return result;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000369EC File Offset: 0x00034BEC
		protected unsafe sealed override void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			object[] array = ArrayPool<object>.Shared.Rent(jsonTypeInfo.ParameterCache.Length);
			ReadOnlySpan<JsonParameterInfo> parameterCache = jsonTypeInfo.ParameterCache;
			for (int i = 0; i < parameterCache.Length; i++)
			{
				JsonParameterInfo jsonParameterInfo = *parameterCache[i];
				array[jsonParameterInfo.Position] = jsonParameterInfo.EffectiveDefaultValue;
			}
			state.Current.CtorArgumentState.Arguments = array;
		}
	}
}

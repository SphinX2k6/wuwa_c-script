using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000E3 RID: 227
	internal abstract class MemberAccessor
	{
		// Token: 0x06000C4B RID: 3147
		public abstract Func<object> CreateParameterlessConstructor(Type type, ConstructorInfo constructorInfo);

		// Token: 0x06000C4C RID: 3148
		public abstract Func<object[], T> CreateParameterizedConstructor<T>(ConstructorInfo constructor);

		// Token: 0x06000C4D RID: 3149
		public abstract JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor);

		// Token: 0x06000C4E RID: 3150
		public abstract Action<TCollection, object> CreateAddMethodDelegate<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TCollection>();

		// Token: 0x06000C4F RID: 3151
		public abstract Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>();

		// Token: 0x06000C50 RID: 3152
		public abstract Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>();

		// Token: 0x06000C51 RID: 3153
		public abstract Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo);

		// Token: 0x06000C52 RID: 3154
		public abstract Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo);

		// Token: 0x06000C53 RID: 3155
		public abstract Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo);

		// Token: 0x06000C54 RID: 3156
		public abstract Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo);

		// Token: 0x06000C55 RID: 3157 RVA: 0x000148D8 File Offset: 0x00012AD8
		public virtual void Clear()
		{
		}
	}
}

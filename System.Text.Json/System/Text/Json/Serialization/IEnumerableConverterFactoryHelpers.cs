using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Reflection;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200009E RID: 158
	internal static class IEnumerableConverterFactoryHelpers
	{
		// Token: 0x0600092E RID: 2350 RVA: 0x000285D4 File Offset: 0x000267D4
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		public static MethodInfo GetImmutableEnumerableCreateRangeMethod(this Type type, Type elementType)
		{
			Type immutableEnumerableConstructingType = IEnumerableConverterFactoryHelpers.GetImmutableEnumerableConstructingType(type);
			if (immutableEnumerableConstructingType != null)
			{
				foreach (MethodInfo methodInfo in immutableEnumerableConstructingType.GetMethods())
				{
					if (methodInfo.Name == "CreateRange" && methodInfo.GetParameters().Length == 1 && methodInfo.IsGenericMethod && methodInfo.GetGenericArguments().Length == 1)
					{
						return methodInfo.MakeGenericMethod(new Type[]
						{
							elementType
						});
					}
				}
			}
			ThrowHelper.ThrowNotSupportedException_SerializationNotSupported(type);
			return null;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00028654 File Offset: 0x00026854
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		public static MethodInfo GetImmutableDictionaryCreateRangeMethod(this Type type, Type keyType, Type valueType)
		{
			Type immutableDictionaryConstructingType = IEnumerableConverterFactoryHelpers.GetImmutableDictionaryConstructingType(type);
			if (immutableDictionaryConstructingType != null)
			{
				foreach (MethodInfo methodInfo in immutableDictionaryConstructingType.GetMethods())
				{
					if (methodInfo.Name == "CreateRange" && methodInfo.GetParameters().Length == 1 && methodInfo.IsGenericMethod && methodInfo.GetGenericArguments().Length == 2)
					{
						return methodInfo.MakeGenericMethod(new Type[]
						{
							keyType,
							valueType
						});
					}
				}
			}
			ThrowHelper.ThrowNotSupportedException_SerializationNotSupported(type);
			return null;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000286D8 File Offset: 0x000268D8
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		private static Type GetImmutableEnumerableConstructingType(Type type)
		{
			string immutableEnumerableConstructingTypeName = type.GetImmutableEnumerableConstructingTypeName();
			if (immutableEnumerableConstructingTypeName != null)
			{
				return type.Assembly.GetType(immutableEnumerableConstructingTypeName);
			}
			return null;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00028700 File Offset: 0x00026900
		[RequiresUnreferencedCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		[RequiresDynamicCode("System.Collections.Immutable converters use Reflection to find and create Immutable Collection types, which requires unreferenced code.")]
		private static Type GetImmutableDictionaryConstructingType(Type type)
		{
			string immutableDictionaryConstructingTypeName = type.GetImmutableDictionaryConstructingTypeName();
			if (immutableDictionaryConstructingTypeName != null)
			{
				return type.Assembly.GetType(immutableDictionaryConstructingTypeName);
			}
			return null;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00028725 File Offset: 0x00026925
		public static bool IsNonGenericStackOrQueue(this Type type)
		{
			Type typeIfExists = IEnumerableConverterFactoryHelpers.GetTypeIfExists("System.Collections.Stack, System.Collections.NonGeneric");
			if (typeIfExists != null && typeIfExists.IsAssignableFrom(type))
			{
				return true;
			}
			Type typeIfExists2 = IEnumerableConverterFactoryHelpers.GetTypeIfExists("System.Collections.Queue, System.Collections.NonGeneric");
			return typeIfExists2 != null && typeIfExists2.IsAssignableFrom(type);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0002875E File Offset: 0x0002695E
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2057:TypeGetType", Justification = "This method exists to allow for 'weak references' to the Stack and Queue types. If those types are used in the app, they will be preserved by the app and Type.GetType will return them. If those types are not used in the app, we don't want to preserve them here.")]
		private static Type GetTypeIfExists(string name)
		{
			return Type.GetType(name, false);
		}
	}
}

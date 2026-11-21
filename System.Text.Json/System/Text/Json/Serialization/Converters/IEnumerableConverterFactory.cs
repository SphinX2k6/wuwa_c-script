using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Reflection;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000111 RID: 273
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class IEnumerableConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000D58 RID: 3416 RVA: 0x000281D8 File Offset: 0x000263D8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		public IEnumerableConverterFactory()
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00033C70 File Offset: 0x00031E70
		public override bool CanConvert(Type typeToConvert)
		{
			return typeof(IEnumerable).IsAssignableFrom(typeToConvert);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00033C84 File Offset: 0x00031E84
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			Type type = null;
			Type type2 = null;
			Type typeFromHandle;
			Type type3;
			if (typeToConvert.IsArray)
			{
				if (typeToConvert.GetArrayRank() > 1)
				{
					return UnsupportedTypeConverterFactory.CreateUnsupportedConverterForType(typeToConvert, null);
				}
				typeFromHandle = typeof(ArrayConverter<, >);
				type = typeToConvert.GetElementType();
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(List<>))) != null)
			{
				typeFromHandle = typeof(ListOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(Dictionary<, >))) != null)
			{
				Type[] genericArguments = type3.GetGenericArguments();
				typeFromHandle = typeof(DictionaryOfTKeyTValueConverter<, , >);
				type2 = genericArguments[0];
				type = genericArguments[1];
			}
			else if (typeToConvert.IsImmutableDictionaryType())
			{
				Type[] genericArguments2 = typeToConvert.GetGenericArguments();
				typeFromHandle = typeof(ImmutableDictionaryOfTKeyTValueConverterWithReflection<, , >);
				type2 = genericArguments2[0];
				type = genericArguments2[1];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(IDictionary<, >))) != null)
			{
				Type[] genericArguments3 = type3.GetGenericArguments();
				typeFromHandle = typeof(IDictionaryOfTKeyTValueConverter<, , >);
				type2 = genericArguments3[0];
				type = genericArguments3[1];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(IReadOnlyDictionary<, >))) != null)
			{
				Type[] genericArguments4 = type3.GetGenericArguments();
				typeFromHandle = typeof(IReadOnlyDictionaryOfTKeyTValueConverter<, , >);
				type2 = genericArguments4[0];
				type = genericArguments4[1];
			}
			else if (typeToConvert.IsImmutableEnumerableType())
			{
				typeFromHandle = typeof(ImmutableEnumerableOfTConverterWithReflection<, >);
				type = typeToConvert.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(IList<>))) != null)
			{
				typeFromHandle = typeof(IListOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(ISet<>))) != null)
			{
				typeFromHandle = typeof(ISetOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(ICollection<>))) != null)
			{
				typeFromHandle = typeof(ICollectionOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(Stack<>))) != null)
			{
				typeFromHandle = typeof(StackOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(Queue<>))) != null)
			{
				typeFromHandle = typeof(QueueOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(ConcurrentStack<>))) != null)
			{
				typeFromHandle = typeof(ConcurrentStackOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericBaseClass(typeof(ConcurrentQueue<>))) != null)
			{
				typeFromHandle = typeof(ConcurrentQueueOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if ((type3 = typeToConvert.GetCompatibleGenericInterface(typeof(IEnumerable<>))) != null)
			{
				typeFromHandle = typeof(IEnumerableOfTConverter<, >);
				type = type3.GetGenericArguments()[0];
			}
			else if (typeof(IDictionary).IsAssignableFrom(typeToConvert))
			{
				if (typeToConvert == typeof(IDictionary))
				{
					return IEnumerableConverterFactory.s_converterForIDictionary;
				}
				typeFromHandle = typeof(IDictionaryConverter<>);
			}
			else if (typeof(IList).IsAssignableFrom(typeToConvert))
			{
				if (typeToConvert == typeof(IList))
				{
					return IEnumerableConverterFactory.s_converterForIList;
				}
				typeFromHandle = typeof(IListConverter<>);
			}
			else if (typeToConvert.IsNonGenericStackOrQueue())
			{
				typeFromHandle = typeof(StackOrQueueConverterWithReflection<>);
			}
			else
			{
				if (typeToConvert == typeof(IEnumerable))
				{
					return IEnumerableConverterFactory.s_converterForIEnumerable;
				}
				typeFromHandle = typeof(IEnumerableConverter<>);
			}
			int num = typeFromHandle.GetGenericArguments().Length;
			Type type4;
			if (num == 1)
			{
				type4 = typeFromHandle.MakeGenericType(new Type[]
				{
					typeToConvert
				});
			}
			else if (num == 2)
			{
				JsonTypeInfo.ValidateType(type);
				type4 = typeFromHandle.MakeGenericType(new Type[]
				{
					typeToConvert,
					type
				});
			}
			else
			{
				JsonTypeInfo.ValidateType(type);
				JsonTypeInfo.ValidateType(type2);
				type4 = typeFromHandle.MakeGenericType(new Type[]
				{
					typeToConvert,
					type2,
					type
				});
			}
			return (JsonConverter)Activator.CreateInstance(type4, BindingFlags.Instance | BindingFlags.Public, null, null, null);
		}

		// Token: 0x04000435 RID: 1077
		private static readonly IDictionaryConverter<IDictionary> s_converterForIDictionary = new IDictionaryConverter<IDictionary>();

		// Token: 0x04000436 RID: 1078
		private static readonly IEnumerableConverter<IEnumerable> s_converterForIEnumerable = new IEnumerableConverter<IEnumerable>();

		// Token: 0x04000437 RID: 1079
		private static readonly IListConverter<IList> s_converterForIList = new IListConverter<IList>();
	}
}

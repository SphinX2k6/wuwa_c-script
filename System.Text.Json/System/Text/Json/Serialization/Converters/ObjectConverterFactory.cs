using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Reflection;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000130 RID: 304
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class ObjectConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x00035492 File Offset: 0x00033692
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		public ObjectConverterFactory(bool useDefaultConstructorInUnannotatedStructs = true)
		{
			this._useDefaultConstructorInUnannotatedStructs = useDefaultConstructorInUnannotatedStructs;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00003363 File Offset: 0x00001563
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000354A4 File Offset: 0x000336A4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067:UnrecognizedReflectionPattern", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			bool useDefaultCtorInAnnotatedStructs = this._useDefaultConstructorInUnannotatedStructs && !typeToConvert.IsKeyValuePair();
			ConstructorInfo constructorInfo;
			if (!typeToConvert.TryGetDeserializationConstructor(useDefaultCtorInAnnotatedStructs, out constructorInfo))
			{
				ThrowHelper.ThrowInvalidOperationException_SerializationDuplicateTypeAttribute<JsonConstructorAttribute>(typeToConvert);
			}
			ParameterInfo[] array = (constructorInfo != null) ? constructorInfo.GetParameters() : null;
			Type type;
			if (constructorInfo == null || typeToConvert.IsAbstract || array.Length == 0)
			{
				type = typeof(ObjectDefaultConverter<>).MakeGenericType(new Type[]
				{
					typeToConvert
				});
			}
			else
			{
				int num = array.Length;
				ParameterInfo[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					JsonTypeInfo.ValidateType(array2[i].ParameterType);
				}
				if (num <= 4)
				{
					Type objectType = JsonTypeInfo.ObjectType;
					Type[] array3 = new Type[5];
					array3[0] = typeToConvert;
					for (int j = 0; j < 4; j++)
					{
						if (j < num)
						{
							array3[j + 1] = array[j].ParameterType;
						}
						else
						{
							array3[j + 1] = objectType;
						}
					}
					type = typeof(SmallObjectWithParameterizedConstructorConverter<, , , , >).MakeGenericType(array3);
				}
				else
				{
					type = typeof(LargeObjectWithParameterizedConstructorConverterWithReflection<>).MakeGenericType(new Type[]
					{
						typeToConvert
					});
				}
			}
			JsonConverter jsonConverter = (JsonConverter)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public, null, null, null);
			jsonConverter.ConstructorInfo = constructorInfo;
			return jsonConverter;
		}

		// Token: 0x04000450 RID: 1104
		private readonly bool _useDefaultConstructorInUnannotatedStructs;
	}
}

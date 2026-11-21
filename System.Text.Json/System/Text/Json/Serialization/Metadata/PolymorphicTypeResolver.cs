using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000E4 RID: 228
	internal sealed class PolymorphicTypeResolver
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00030EFC File Offset: 0x0002F0FC
		public PolymorphicTypeResolver(JsonSerializerOptions options, JsonPolymorphismOptions polymorphismOptions, Type baseType, bool converterCanHaveMetadata)
		{
			this.UnknownDerivedTypeHandling = polymorphismOptions.UnknownDerivedTypeHandling;
			this.IgnoreUnrecognizedTypeDiscriminators = polymorphismOptions.IgnoreUnrecognizedTypeDiscriminators;
			this.BaseType = baseType;
			this._options = options;
			if (!PolymorphicTypeResolver.IsSupportedPolymorphicBaseType(this.BaseType))
			{
				ThrowHelper.ThrowInvalidOperationException_TypeDoesNotSupportPolymorphism(this.BaseType);
			}
			bool flag = false;
			foreach (JsonDerivedType jsonDerivedType in polymorphismOptions.DerivedTypes)
			{
				Type type;
				object obj;
				jsonDerivedType.Deconstruct(out type, out obj);
				Type type2 = type;
				object obj2 = obj;
				if (!PolymorphicTypeResolver.IsSupportedDerivedType(this.BaseType, type2) || (type2.IsAbstract && this.UnknownDerivedTypeHandling != JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor))
				{
					ThrowHelper.ThrowInvalidOperationException_DerivedTypeNotSupported(this.BaseType, type2);
				}
				PolymorphicTypeResolver.DerivedJsonTypeInfo value = new PolymorphicTypeResolver.DerivedJsonTypeInfo(type2, obj2);
				if (!this._typeToDiscriminatorId.TryAdd(type2, value))
				{
					ThrowHelper.ThrowInvalidOperationException_DerivedTypeIsAlreadySpecified(this.BaseType, type2);
				}
				if (obj2 != null)
				{
					Dictionary<object, PolymorphicTypeResolver.DerivedJsonTypeInfo> dictionary;
					if ((dictionary = this._discriminatorIdtoType) == null)
					{
						dictionary = (this._discriminatorIdtoType = new Dictionary<object, PolymorphicTypeResolver.DerivedJsonTypeInfo>());
					}
					if (!dictionary.TryAdd(obj2, value))
					{
						ThrowHelper.ThrowInvalidOperationException_TypeDicriminatorIdIsAlreadySpecified(this.BaseType, obj2);
					}
					this.UsesTypeDiscriminators = 1;
				}
				flag = true;
			}
			if (!flag)
			{
				ThrowHelper.ThrowInvalidOperationException_PolymorphicTypeConfigurationDoesNotSpecifyDerivedTypes(this.BaseType);
			}
			if (this.UsesTypeDiscriminators)
			{
				if (!converterCanHaveMetadata)
				{
					ThrowHelper.ThrowNotSupportedException_BaseConverterDoesNotSupportMetadata(this.BaseType);
				}
				string typeDiscriminatorPropertyName = polymorphismOptions.TypeDiscriminatorPropertyName;
				if (!typeDiscriminatorPropertyName.Equals("$type", StringComparison.Ordinal))
				{
					byte[] bytes = Encoding.UTF8.GetBytes(typeDiscriminatorPropertyName);
					if ((JsonSerializer.GetMetadataPropertyName(bytes, null) & ~MetadataPropertyName.Type) != MetadataPropertyName.None)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidCustomTypeDiscriminatorPropertyName();
					}
					this.CustomTypeDiscriminatorPropertyNameUtf8 = bytes;
					this.CustomTypeDiscriminatorPropertyNameJsonEncoded = new JsonEncodedText?(JsonEncodedText.Encode(typeDiscriminatorPropertyName, options.Encoder));
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000310BC File Offset: 0x0002F2BC
		public Type BaseType { get; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000310C4 File Offset: 0x0002F2C4
		public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling { get; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000310CC File Offset: 0x0002F2CC
		public bool UsesTypeDiscriminators { get; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000310D4 File Offset: 0x0002F2D4
		public bool IgnoreUnrecognizedTypeDiscriminators { get; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000310DC File Offset: 0x0002F2DC
		public byte[] CustomTypeDiscriminatorPropertyNameUtf8 { get; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000310E4 File Offset: 0x0002F2E4
		public JsonEncodedText? CustomTypeDiscriminatorPropertyNameJsonEncoded { get; }

		// Token: 0x06000C5E RID: 3166 RVA: 0x000310EC File Offset: 0x0002F2EC
		public bool TryGetDerivedJsonTypeInfo(Type runtimeType, [NotNullWhen(true)] out JsonTypeInfo jsonTypeInfo, out object typeDiscriminator)
		{
			PolymorphicTypeResolver.DerivedJsonTypeInfo derivedJsonTypeInfo;
			if (!this._typeToDiscriminatorId.TryGetValue(runtimeType, out derivedJsonTypeInfo))
			{
				switch (this.UnknownDerivedTypeHandling)
				{
				case JsonUnknownDerivedTypeHandling.FallBackToBaseType:
					this._typeToDiscriminatorId.TryGetValue(this.BaseType, out derivedJsonTypeInfo);
					this._typeToDiscriminatorId[runtimeType] = derivedJsonTypeInfo;
					goto IL_7F;
				case JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor:
					derivedJsonTypeInfo = this.CalculateNearestAncestor(runtimeType);
					this._typeToDiscriminatorId[runtimeType] = derivedJsonTypeInfo;
					goto IL_7F;
				}
				if (runtimeType != this.BaseType)
				{
					ThrowHelper.ThrowNotSupportedException_RuntimeTypeNotSupported(this.BaseType, runtimeType);
				}
			}
			IL_7F:
			if (derivedJsonTypeInfo == null)
			{
				jsonTypeInfo = null;
				typeDiscriminator = null;
				return false;
			}
			jsonTypeInfo = derivedJsonTypeInfo.GetJsonTypeInfo(this._options);
			typeDiscriminator = derivedJsonTypeInfo.TypeDiscriminator;
			return true;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0003119C File Offset: 0x0002F39C
		public bool TryGetDerivedJsonTypeInfo(object typeDiscriminator, [NotNullWhen(true)] out JsonTypeInfo jsonTypeInfo)
		{
			PolymorphicTypeResolver.DerivedJsonTypeInfo derivedJsonTypeInfo;
			if (this._discriminatorIdtoType.TryGetValue(typeDiscriminator, out derivedJsonTypeInfo))
			{
				jsonTypeInfo = derivedJsonTypeInfo.GetJsonTypeInfo(this._options);
				return true;
			}
			if (!this.IgnoreUnrecognizedTypeDiscriminators)
			{
				ThrowHelper.ThrowJsonException_UnrecognizedTypeDiscriminator(typeDiscriminator);
			}
			jsonTypeInfo = null;
			return false;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000311DB File Offset: 0x0002F3DB
		public static bool IsSupportedPolymorphicBaseType(Type type)
		{
			return type != null && (type.IsClass || type.IsInterface) && !type.IsSealed && !type.IsGenericTypeDefinition && !type.IsPointer && type != JsonTypeInfo.ObjectType;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003121B File Offset: 0x0002F41B
		public static bool IsSupportedDerivedType(Type baseType, Type derivedType)
		{
			return baseType.IsAssignableFrom(derivedType) && !derivedType.IsGenericTypeDefinition;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00031234 File Offset: 0x0002F434
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The call to GetInterfaces will cross-reference results with interface types already declared as derived types of the polymorphic base type.")]
		private PolymorphicTypeResolver.DerivedJsonTypeInfo CalculateNearestAncestor(Type type)
		{
			if (type == this.BaseType)
			{
				return null;
			}
			PolymorphicTypeResolver.DerivedJsonTypeInfo derivedJsonTypeInfo = null;
			Type baseType = type.BaseType;
			while (this.BaseType.IsAssignableFrom(baseType) && !this._typeToDiscriminatorId.TryGetValue(baseType, out derivedJsonTypeInfo))
			{
				baseType = baseType.BaseType;
			}
			if (this.BaseType.IsInterface)
			{
				foreach (Type type2 in type.GetInterfaces())
				{
					PolymorphicTypeResolver.DerivedJsonTypeInfo derivedJsonTypeInfo2;
					if (type2 != this.BaseType && this.BaseType.IsAssignableFrom(type2) && this._typeToDiscriminatorId.TryGetValue(type2, out derivedJsonTypeInfo2) && derivedJsonTypeInfo2 != null)
					{
						if (derivedJsonTypeInfo == null)
						{
							derivedJsonTypeInfo = derivedJsonTypeInfo2;
						}
						else
						{
							ThrowHelper.ThrowNotSupportedException_RuntimeTypeDiamondAmbiguity(this.BaseType, type, derivedJsonTypeInfo.DerivedType, derivedJsonTypeInfo2.DerivedType);
						}
					}
				}
			}
			return derivedJsonTypeInfo;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00031300 File Offset: 0x0002F500
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "The call to GetInterfaces will cross-reference results with interface types already declared as derived types of the polymorphic base type.")]
		internal static JsonTypeInfo FindNearestPolymorphicBaseType(JsonTypeInfo typeInfo)
		{
			if (typeInfo.PolymorphismOptions != null)
			{
				return null;
			}
			JsonTypeInfo jsonTypeInfo = null;
			Type baseType = typeInfo.Type.BaseType;
			while (baseType != null)
			{
				JsonTypeInfo jsonTypeInfo2 = PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(baseType, typeInfo.Options);
				if (((jsonTypeInfo2 != null) ? jsonTypeInfo2.PolymorphismOptions : null) != null)
				{
					jsonTypeInfo = jsonTypeInfo2;
					break;
				}
				baseType = baseType.BaseType;
			}
			foreach (Type type in typeInfo.Type.GetInterfaces())
			{
				JsonTypeInfo jsonTypeInfo3 = PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(type, typeInfo.Options);
				if (((jsonTypeInfo3 != null) ? jsonTypeInfo3.PolymorphismOptions : null) != null)
				{
					if (jsonTypeInfo != null)
					{
						if (jsonTypeInfo.Type.IsAssignableFrom(type))
						{
							jsonTypeInfo = jsonTypeInfo3;
						}
						else if (!type.IsAssignableFrom(jsonTypeInfo.Type))
						{
							return null;
						}
					}
					else
					{
						jsonTypeInfo = jsonTypeInfo3;
					}
				}
			}
			return jsonTypeInfo;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000313C8 File Offset: 0x0002F5C8
		[CompilerGenerated]
		internal static JsonTypeInfo <FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(Type type, JsonSerializerOptions options)
		{
			JsonTypeInfo result;
			try
			{
				result = options.GetTypeInfoInternal(type, true, null, false, false);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040003FC RID: 1020
		private readonly ConcurrentDictionary<Type, PolymorphicTypeResolver.DerivedJsonTypeInfo> _typeToDiscriminatorId = new ConcurrentDictionary<Type, PolymorphicTypeResolver.DerivedJsonTypeInfo>();

		// Token: 0x040003FD RID: 1021
		private readonly Dictionary<object, PolymorphicTypeResolver.DerivedJsonTypeInfo> _discriminatorIdtoType;

		// Token: 0x040003FE RID: 1022
		private readonly JsonSerializerOptions _options;

		// Token: 0x020000E5 RID: 229
		private sealed class DerivedJsonTypeInfo
		{
			// Token: 0x06000C65 RID: 3173 RVA: 0x00031404 File Offset: 0x0002F604
			public DerivedJsonTypeInfo(Type type, object typeDiscriminator)
			{
				this.DerivedType = type;
				this.TypeDiscriminator = typeDiscriminator;
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0003141A File Offset: 0x0002F61A
			public Type DerivedType { get; }

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00031422 File Offset: 0x0002F622
			public object TypeDiscriminator { get; }

			// Token: 0x06000C68 RID: 3176 RVA: 0x0003142C File Offset: 0x0002F62C
			public JsonTypeInfo GetJsonTypeInfo(JsonSerializerOptions options)
			{
				JsonTypeInfo result;
				if ((result = this._jsonTypeInfo) == null)
				{
					result = (this._jsonTypeInfo = options.GetTypeInfoInternal(this.DerivedType, true, new bool?(true), false, false));
				}
				return result;
			}

			// Token: 0x04000405 RID: 1029
			private volatile JsonTypeInfo _jsonTypeInfo;
		}
	}
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000124 RID: 292
	[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
	internal sealed class FSharpTypeConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000DB3 RID: 3507 RVA: 0x000281D8 File Offset: 0x000263D8
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpTypeConverterFactory()
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00034B0F File Offset: 0x00032D0F
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		public override bool CanConvert(Type typeToConvert)
		{
			return FSharpCoreReflectionProxy.IsFSharpType(typeToConvert) && FSharpCoreReflectionProxy.Instance.DetectFSharpKind(typeToConvert) != FSharpCoreReflectionProxy.FSharpKind.Unrecognized;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00034B2C File Offset: 0x00032D2C
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:MakeGenericType", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			object[] args = null;
			Type type2;
			switch (FSharpCoreReflectionProxy.Instance.DetectFSharpKind(typeToConvert))
			{
			case FSharpCoreReflectionProxy.FSharpKind.Option:
			{
				Type type = typeToConvert.GetGenericArguments()[0];
				type2 = typeof(FSharpOptionConverter<, >).MakeGenericType(new Type[]
				{
					typeToConvert,
					type
				});
				args = new object[]
				{
					options.GetConverterInternal(type)
				};
				break;
			}
			case FSharpCoreReflectionProxy.FSharpKind.ValueOption:
			{
				Type type = typeToConvert.GetGenericArguments()[0];
				type2 = typeof(FSharpValueOptionConverter<, >).MakeGenericType(new Type[]
				{
					typeToConvert,
					type
				});
				args = new object[]
				{
					options.GetConverterInternal(type)
				};
				break;
			}
			case FSharpCoreReflectionProxy.FSharpKind.List:
			{
				Type type = typeToConvert.GetGenericArguments()[0];
				type2 = typeof(FSharpListConverter<, >).MakeGenericType(new Type[]
				{
					typeToConvert,
					type
				});
				break;
			}
			case FSharpCoreReflectionProxy.FSharpKind.Set:
			{
				Type type = typeToConvert.GetGenericArguments()[0];
				type2 = typeof(FSharpSetConverter<, >).MakeGenericType(new Type[]
				{
					typeToConvert,
					type
				});
				break;
			}
			case FSharpCoreReflectionProxy.FSharpKind.Map:
			{
				Type[] genericArguments = typeToConvert.GetGenericArguments();
				Type type3 = genericArguments[0];
				Type type4 = genericArguments[1];
				type2 = typeof(FSharpMapConverter<, , >).MakeGenericType(new Type[]
				{
					typeToConvert,
					type3,
					type4
				});
				break;
			}
			case FSharpCoreReflectionProxy.FSharpKind.Record:
			{
				ObjectConverterFactory objectConverterFactory;
				if ((objectConverterFactory = this._recordConverterFactory) == null)
				{
					objectConverterFactory = (this._recordConverterFactory = new ObjectConverterFactory(false));
				}
				return objectConverterFactory.CreateConverter(typeToConvert, options);
			}
			case FSharpCoreReflectionProxy.FSharpKind.Union:
				return UnsupportedTypeConverterFactory.CreateUnsupportedConverterForType(typeToConvert, SR.FSharpDiscriminatedUnionsNotSupported);
			default:
				throw new Exception();
			}
			return (JsonConverter)Activator.CreateInstance(type2, args);
		}

		// Token: 0x04000443 RID: 1091
		private ObjectConverterFactory _recordConverterFactory;
	}
}

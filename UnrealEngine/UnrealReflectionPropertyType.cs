using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200009F RID: 159
	public static class UnrealReflectionPropertyType
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x00018C74 File Offset: 0x00016E74
		[NullableContext(1)]
		public static UnrealReflectionPropertyTypeCode GetTypeCode(Type InType)
		{
			switch (Type.GetTypeCode(InType))
			{
			case TypeCode.Empty:
				return UnrealReflectionPropertyTypeCode.Unusable;
			case TypeCode.Object:
			{
				if (InType.IsSubclassOf(typeof(UnrealUObject)))
				{
					return UnrealReflectionPropertyTypeCode.UnrealObject;
				}
				UnrealStructLayoutAttribute unrealStructLayoutAttribute = InType.GetCustomAttribute(typeof(UnrealStructLayoutAttribute)) as UnrealStructLayoutAttribute;
				if (unrealStructLayoutAttribute != null)
				{
					UnrealReflectionPropertyTypeCode unrealTypeCode = unrealStructLayoutAttribute.UnrealTypeCode;
					if (unrealTypeCode <= UnrealReflectionPropertyTypeCode.LazyObject)
					{
						if (unrealTypeCode <= UnrealReflectionPropertyTypeCode.SoftClass)
						{
							if (unrealTypeCode != UnrealReflectionPropertyTypeCode.Name && unrealTypeCode != UnrealReflectionPropertyTypeCode.Text && unrealTypeCode != UnrealReflectionPropertyTypeCode.SoftClass)
							{
								goto IL_131;
							}
						}
						else if (unrealTypeCode != UnrealReflectionPropertyTypeCode.WeakObject && unrealTypeCode != UnrealReflectionPropertyTypeCode.SoftObject && unrealTypeCode != UnrealReflectionPropertyTypeCode.LazyObject)
						{
							goto IL_131;
						}
					}
					else if (unrealTypeCode <= UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
					{
						if (unrealTypeCode != UnrealReflectionPropertyTypeCode.FieldPath && unrealTypeCode != UnrealReflectionPropertyTypeCode.Interface && unrealTypeCode != UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
						{
							goto IL_131;
						}
					}
					else if (unrealTypeCode != UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy && unrealTypeCode != UnrealReflectionPropertyTypeCode.EnumAsByte && unrealTypeCode != (UnrealReflectionPropertyTypeCode)(-2147483648))
					{
						goto IL_131;
					}
					return unrealStructLayoutAttribute.UnrealTypeCode;
					IL_131:
					if (InType.IsSubclassOf(typeof(FScriptDelegate)))
					{
						return UnrealReflectionPropertyTypeCode.Delegate;
					}
					if (InType.IsSubclassOf(typeof(FMulticastScriptDelegate)))
					{
						return UnrealReflectionPropertyTypeCode.MulticastDelegate;
					}
					if (InType.IsSubclassOf(typeof(FSparseDelegate)))
					{
						return UnrealReflectionPropertyTypeCode.MulticastSparseDelegate;
					}
				}
				if (InType.IsInterface && InType.GetInterface("IUnrealInterface") != null)
				{
					return UnrealReflectionPropertyTypeCode.Interface;
				}
				throw new Exception("Unknown Unreal type: " + InType.FullName);
			}
			case TypeCode.DBNull:
				return UnrealReflectionPropertyTypeCode.Unusable;
			case TypeCode.Boolean:
				return UnrealReflectionPropertyTypeCode.Bool;
			case TypeCode.Char:
				return UnrealReflectionPropertyTypeCode.UShort;
			case TypeCode.SByte:
				return UnrealReflectionPropertyTypeCode.Sbyte;
			case TypeCode.Byte:
				return UnrealReflectionPropertyTypeCode.Byte;
			case TypeCode.Int16:
				return UnrealReflectionPropertyTypeCode.Short;
			case TypeCode.UInt16:
				return UnrealReflectionPropertyTypeCode.UShort;
			case TypeCode.Int32:
				return UnrealReflectionPropertyTypeCode.Int;
			case TypeCode.UInt32:
				return UnrealReflectionPropertyTypeCode.UInt;
			case TypeCode.Int64:
				return UnrealReflectionPropertyTypeCode.Long;
			case TypeCode.UInt64:
				return UnrealReflectionPropertyTypeCode.ULong;
			case TypeCode.Single:
				return UnrealReflectionPropertyTypeCode.Float;
			case TypeCode.Double:
				return UnrealReflectionPropertyTypeCode.Double;
			case TypeCode.Decimal:
				return UnrealReflectionPropertyTypeCode.Unusable;
			case TypeCode.DateTime:
				return UnrealReflectionPropertyTypeCode.Unusable;
			case TypeCode.String:
				return UnrealReflectionPropertyTypeCode.String;
			}
			throw new ArgumentOutOfRangeException();
		}
	}
}

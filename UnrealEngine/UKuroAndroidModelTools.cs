using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E73 RID: 7795
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroAndroidModelTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAndroidModelTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DAF2 RID: 121586 RVA: 0x002BD9F2 File Offset: 0x002BBBF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAndroidModelTools._ClassPtr;
		}

		// Token: 0x0601DAF3 RID: 121587 RVA: 0x002BDA00 File Offset: 0x002BBC00
		public UKuroAndroidModelTools() : this(BuiltinUtils.AllocNativeUObject(UKuroAndroidModelTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DAF4 RID: 121588 RVA: 0x002BDA28 File Offset: 0x002BBC28
		[NullableContext(1)]
		public UKuroAndroidModelTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAndroidModelTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DAF5 RID: 121589 RVA: 0x002BDA5B File Offset: 0x002BBC5B
		[NullableContext(1)]
		public static string GetModel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetModel_Internal());
		}

		// Token: 0x0601DAF6 RID: 121590 RVA: 0x002BDA67 File Offset: 0x002BBC67
		[NullableContext(1)]
		public static string GetManufacturer()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetManufacturer_Internal());
		}

		// Token: 0x0601DAF7 RID: 121591 RVA: 0x002BDA73 File Offset: 0x002BBC73
		[NullableContext(1)]
		public static string GetBrand()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetBrand_Internal());
		}

		// Token: 0x0601DAF8 RID: 121592 RVA: 0x002BDA7F File Offset: 0x002BBC7F
		[NullableContext(1)]
		public static string GetAppParallel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetAppParallel_Internal());
		}

		// Token: 0x0601DAF9 RID: 121593 RVA: 0x002BDA8B File Offset: 0x002BBC8B
		[NullableContext(1)]
		public static string GetAndroidVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetAndroidVersion_Internal());
		}

		// Token: 0x0601DAFA RID: 121594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetModel_Internal();

		// Token: 0x0601DAFB RID: 121595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetManufacturer_Internal();

		// Token: 0x0601DAFC RID: 121596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBrand_Internal();

		// Token: 0x0601DAFD RID: 121597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppParallel_Internal();

		// Token: 0x0601DAFE RID: 121598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAndroidVersion_Internal();

		// Token: 0x0601DAFF RID: 121599 RVA: 0x002BDA97 File Offset: 0x002BBC97
		static UKuroAndroidModelTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroAndroidModelTools");
		}

		// Token: 0x0601DB00 RID: 121600 RVA: 0x002BDAA5 File Offset: 0x002BBCA5
		protected UKuroAndroidModelTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010138 RID: 65848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroAndroidModelTools";

		// Token: 0x04010139 RID: 65849
		private static IntPtr _ClassPtr;

		// Token: 0x0401013A RID: 65850
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

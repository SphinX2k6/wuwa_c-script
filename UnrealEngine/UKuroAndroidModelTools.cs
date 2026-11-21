using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A6 RID: 1446
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroAndroidModelTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAndroidModelTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600825C RID: 33372 RVA: 0x000C0CCE File Offset: 0x000BEECE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAndroidModelTools._ClassPtr;
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x000C0CDC File Offset: 0x000BEEDC
		public UKuroAndroidModelTools() : this(BuiltinUtils.AllocNativeUObject(UKuroAndroidModelTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x000C0D04 File Offset: 0x000BEF04
		[NullableContext(1)]
		public UKuroAndroidModelTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAndroidModelTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x000C0D37 File Offset: 0x000BEF37
		[NullableContext(1)]
		public static string GetModel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetModel_Internal());
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x000C0D43 File Offset: 0x000BEF43
		[NullableContext(1)]
		public static string GetManufacturer()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetManufacturer_Internal());
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x000C0D4F File Offset: 0x000BEF4F
		[NullableContext(1)]
		public static string GetBrand()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetBrand_Internal());
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x000C0D5B File Offset: 0x000BEF5B
		[NullableContext(1)]
		public static string GetAppParallel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetAppParallel_Internal());
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x000C0D67 File Offset: 0x000BEF67
		[NullableContext(1)]
		public static string GetAndroidVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAndroidModelTools.__GetAndroidVersion_Internal());
		}

		// Token: 0x06008264 RID: 33380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetModel_Internal();

		// Token: 0x06008265 RID: 33381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetManufacturer_Internal();

		// Token: 0x06008266 RID: 33382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBrand_Internal();

		// Token: 0x06008267 RID: 33383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppParallel_Internal();

		// Token: 0x06008268 RID: 33384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAndroidVersion_Internal();

		// Token: 0x06008269 RID: 33385 RVA: 0x000C0D73 File Offset: 0x000BEF73
		static UKuroAndroidModelTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroAndroidModelTools");
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x000C0D81 File Offset: 0x000BEF81
		protected UKuroAndroidModelTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038CD RID: 14541
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroAndroidModelTools";

		// Token: 0x040038CE RID: 14542
		private static IntPtr _ClassPtr;

		// Token: 0x040038CF RID: 14543
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

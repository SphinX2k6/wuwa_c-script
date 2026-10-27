using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F27 RID: 7975
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroConfigHelper")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UKuroConfigHelper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E400 RID: 123904 RVA: 0x002CF503 File Offset: 0x002CD703
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroConfigHelper._ClassPtr;
		}

		// Token: 0x0601E401 RID: 123905 RVA: 0x002CF510 File Offset: 0x002CD710
		public UKuroConfigHelper() : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E402 RID: 123906 RVA: 0x002CF538 File Offset: 0x002CD738
		[NullableContext(1)]
		public UKuroConfigHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E403 RID: 123907 RVA: 0x002CF56B File Offset: 0x002CD76B
		public void SetEnumMapping(UEnum Enumtype, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> PropertyNames)
		{
			UKuroConfigHelper.__SetEnumMapping_Internal(base.NativePtr, (Enumtype != null) ? Enumtype.NativePtr : IntPtr.Zero, (PropertyNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0601E404 RID: 123908 RVA: 0x002CF598 File Offset: 0x002CD798
		public void RemoveSubConfig(FName KeyName)
		{
			UKuroConfigHelper.__RemoveSubConfig_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0601E405 RID: 123909 RVA: 0x002CF5A6 File Offset: 0x002CD7A6
		public void RefreshConfigs()
		{
			UKuroConfigHelper.__RefreshConfigs_Internal(base.NativePtr);
		}

		// Token: 0x0601E406 RID: 123910 RVA: 0x002CF5B3 File Offset: 0x002CD7B3
		public void InitBase(UObject InObject, UObject InData)
		{
			UKuroConfigHelper.__InitBase_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E407 RID: 123911 RVA: 0x002CF5E0 File Offset: 0x002CD7E0
		public void AddSubConfigByNumber(FName KeyName, int Priority, in TArray<int> PropertyIds, UObject InData)
		{
			UKuroConfigHelper.__AddSubConfigByNumber_Internal(base.NativePtr, KeyName, Priority, (PropertyIds ?? new TArray<int>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E408 RID: 123912 RVA: 0x002CF611 File Offset: 0x002CD811
		public void AddSubConfig(FName KeyName, int Priority, in TArray<FName> PropertyNames, UObject InData)
		{
			UKuroConfigHelper.__AddSubConfig_Internal(base.NativePtr, KeyName, Priority, (PropertyNames ?? new TArray<FName>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E409 RID: 123913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnumMapping_Internal(IntPtr @this, IntPtr Enumtype, IntPtr PropertyNames);

		// Token: 0x0601E40A RID: 123914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSubConfig_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0601E40B RID: 123915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshConfigs_Internal(IntPtr @this);

		// Token: 0x0601E40C RID: 123916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBase_Internal(IntPtr @this, IntPtr InObject, IntPtr InData);

		// Token: 0x0601E40D RID: 123917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfigByNumber_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyIds, IntPtr InData);

		// Token: 0x0601E40E RID: 123918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfig_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyNames, IntPtr InData);

		// Token: 0x0601E40F RID: 123919 RVA: 0x002CF642 File Offset: 0x002CD842
		static UKuroConfigHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroConfigHelper");
		}

		// Token: 0x0601E410 RID: 123920 RVA: 0x002CF650 File Offset: 0x002CD850
		protected UKuroConfigHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401052D RID: 66861
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroConfigHelper";

		// Token: 0x0401052E RID: 66862
		private static IntPtr _ClassPtr;

		// Token: 0x0401052F RID: 66863
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

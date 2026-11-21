using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000364 RID: 868
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDataBag.KuroConfigHelper")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroConfigHelper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600587A RID: 22650 RVA: 0x0007CAF5 File Offset: 0x0007ACF5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroConfigHelper._ClassPtr;
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0007CB04 File Offset: 0x0007AD04
		public UKuroConfigHelper() : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0007CB2C File Offset: 0x0007AD2C
		[NullableContext(1)]
		public UKuroConfigHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x0007CB5F File Offset: 0x0007AD5F
		public void SetRecordLimit(float InMaxDuration, int InMaxCount)
		{
			UKuroConfigHelper.__SetRecordLimit_Internal(base.NativePtr, InMaxDuration, InMaxCount);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0007CB6E File Offset: 0x0007AD6E
		public void SetEnumMapping(UEnum Enumtype, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> PropertyNames)
		{
			UKuroConfigHelper.__SetEnumMapping_Internal(base.NativePtr, (Enumtype != null) ? Enumtype.NativePtr : IntPtr.Zero, (PropertyNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0007CB9B File Offset: 0x0007AD9B
		public void RemoveSubConfig(FName KeyName)
		{
			UKuroConfigHelper.__RemoveSubConfig_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0007CBA9 File Offset: 0x0007ADA9
		public void RefreshConfigs()
		{
			UKuroConfigHelper.__RefreshConfigs_Internal(base.NativePtr);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0007CBB6 File Offset: 0x0007ADB6
		public void InitBase(UObject InObject, UObject InData)
		{
			UKuroConfigHelper.__InitBase_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x0007CBE3 File Offset: 0x0007ADE3
		public void ClearRecords()
		{
			UKuroConfigHelper.__ClearRecords_Internal(base.NativePtr);
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0007CBF0 File Offset: 0x0007ADF0
		public void AddSubConfigByNumber(FName KeyName, int Priority, in TArray<int> PropertyIds, UObject InData)
		{
			UKuroConfigHelper.__AddSubConfigByNumber_Internal(base.NativePtr, KeyName, Priority, (PropertyIds ?? new TArray<int>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0007CC21 File Offset: 0x0007AE21
		public void AddSubConfigByBag(FName KeyName, int Priority, UKuroDataBag InBag, EConfigApplyType ApplyType = EConfigApplyType.Override)
		{
			UKuroConfigHelper.__AddSubConfigByBag_Internal(base.NativePtr, KeyName, Priority, (InBag != null) ? InBag.NativePtr : IntPtr.Zero, ApplyType);
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x0007CC42 File Offset: 0x0007AE42
		public void AddSubConfig(FName KeyName, int Priority, in TArray<FName> PropertyNames, UObject InData, EConfigApplyType ApplyType = EConfigApplyType.Override)
		{
			UKuroConfigHelper.__AddSubConfig_Internal(base.NativePtr, KeyName, Priority, (PropertyNames ?? new TArray<FName>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero, ApplyType);
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x0007CC75 File Offset: 0x0007AE75
		public void AccumulateRecordTime(float DeltaTime)
		{
			UKuroConfigHelper.__AccumulateRecordTime_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06005887 RID: 22663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRecordLimit_Internal(IntPtr @this, float InMaxDuration, int InMaxCount);

		// Token: 0x06005888 RID: 22664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnumMapping_Internal(IntPtr @this, IntPtr Enumtype, IntPtr PropertyNames);

		// Token: 0x06005889 RID: 22665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSubConfig_Internal(IntPtr @this, FName KeyName);

		// Token: 0x0600588A RID: 22666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshConfigs_Internal(IntPtr @this);

		// Token: 0x0600588B RID: 22667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBase_Internal(IntPtr @this, IntPtr InObject, IntPtr InData);

		// Token: 0x0600588C RID: 22668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRecords_Internal(IntPtr @this);

		// Token: 0x0600588D RID: 22669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfigByNumber_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyIds, IntPtr InData);

		// Token: 0x0600588E RID: 22670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfigByBag_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr InBag, EConfigApplyType ApplyType);

		// Token: 0x0600588F RID: 22671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfig_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyNames, IntPtr InData, EConfigApplyType ApplyType);

		// Token: 0x06005890 RID: 22672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AccumulateRecordTime_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06005891 RID: 22673 RVA: 0x0007CC83 File Offset: 0x0007AE83
		static UKuroConfigHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDataBag.KuroConfigHelper");
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x0007CC91 File Offset: 0x0007AE91
		protected UKuroConfigHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002495 RID: 9365
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDataBag.KuroConfigHelper";

		// Token: 0x04002496 RID: 9366
		private static IntPtr _ClassPtr;

		// Token: 0x04002497 RID: 9367
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

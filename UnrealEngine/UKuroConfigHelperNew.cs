using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000365 RID: 869
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDataBag.KuroConfigHelperNew")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UKuroConfigHelperNew : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005893 RID: 22675 RVA: 0x0007CC9A File Offset: 0x0007AE9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroConfigHelperNew._ClassPtr;
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x0007CCA8 File Offset: 0x0007AEA8
		public UKuroConfigHelperNew() : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelperNew.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0007CCD0 File Offset: 0x0007AED0
		public UKuroConfigHelperNew(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroConfigHelperNew.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x0007CD04 File Offset: 0x0007AF04
		// (set) Token: 0x06005897 RID: 22679 RVA: 0x0007CD3D File Offset: 0x0007AF3D
		public TArray<UObject> ReferencedDataObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedDataObjects) == null)
				{
					result = (this._ReferencedDataObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UKuroConfigHelperNew.__PropertyOffset_ReferencedDataObjects, this));
				}
				return result;
			}
			set
			{
				this.ReferencedDataObjects.CopyAssign(value);
			}
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x0007CD4B File Offset: 0x0007AF4B
		public void SetRecordLimit(float InMaxDuration, int InMaxCount)
		{
			UKuroConfigHelperNew.__SetRecordLimit_Internal(base.NativePtr, InMaxDuration, InMaxCount);
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x0007CD5A File Offset: 0x0007AF5A
		[NullableContext(2)]
		public void SetEnumMapping(UEnum Enumtype, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> PropertyNames)
		{
			UKuroConfigHelperNew.__SetEnumMapping_Internal(base.NativePtr, (Enumtype != null) ? Enumtype.NativePtr : IntPtr.Zero, (PropertyNames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x0007CD87 File Offset: 0x0007AF87
		public void RemoveSubConfig(FName KeyName)
		{
			UKuroConfigHelperNew.__RemoveSubConfig_Internal(base.NativePtr, KeyName);
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x0007CD95 File Offset: 0x0007AF95
		public void RefreshConfigs()
		{
			UKuroConfigHelperNew.__RefreshConfigs_Internal(base.NativePtr);
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x0007CDA2 File Offset: 0x0007AFA2
		[NullableContext(2)]
		public void InitBase(UObject InObject, UObject InData)
		{
			UKuroConfigHelperNew.__InitBase_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x0007CDCF File Offset: 0x0007AFCF
		public void ClearRecords()
		{
			UKuroConfigHelperNew.__ClearRecords_Internal(base.NativePtr);
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		[NullableContext(2)]
		public void AddSubConfigByNumber(FName KeyName, int Priority, in TArray<int> PropertyIds, UObject InData)
		{
			UKuroConfigHelperNew.__AddSubConfigByNumber_Internal(base.NativePtr, KeyName, Priority, (PropertyIds ?? new TArray<int>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x0007CE0D File Offset: 0x0007B00D
		[NullableContext(2)]
		public void AddSubConfigByBag(FName KeyName, int Priority, UKuroDataBag InBag, EConfigApplyTypeNew ApplyType = EConfigApplyTypeNew.Override)
		{
			UKuroConfigHelperNew.__AddSubConfigByBag_Internal(base.NativePtr, KeyName, Priority, (InBag != null) ? InBag.NativePtr : IntPtr.Zero, ApplyType);
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0007CE2E File Offset: 0x0007B02E
		[NullableContext(2)]
		public void AddSubConfig(FName KeyName, int Priority, in TArray<FName> PropertyNames, UObject InData, EConfigApplyTypeNew ApplyType = EConfigApplyTypeNew.Override)
		{
			UKuroConfigHelperNew.__AddSubConfig_Internal(base.NativePtr, KeyName, Priority, (PropertyNames ?? new TArray<FName>()).NativePtr, (InData != null) ? InData.NativePtr : IntPtr.Zero, ApplyType);
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x0007CE61 File Offset: 0x0007B061
		public void AccumulateRecordTime(float DeltaTime)
		{
			UKuroConfigHelperNew.__AccumulateRecordTime_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x060058A2 RID: 22690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRecordLimit_Internal(IntPtr @this, float InMaxDuration, int InMaxCount);

		// Token: 0x060058A3 RID: 22691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnumMapping_Internal(IntPtr @this, IntPtr Enumtype, IntPtr PropertyNames);

		// Token: 0x060058A4 RID: 22692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSubConfig_Internal(IntPtr @this, FName KeyName);

		// Token: 0x060058A5 RID: 22693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshConfigs_Internal(IntPtr @this);

		// Token: 0x060058A6 RID: 22694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBase_Internal(IntPtr @this, IntPtr InObject, IntPtr InData);

		// Token: 0x060058A7 RID: 22695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRecords_Internal(IntPtr @this);

		// Token: 0x060058A8 RID: 22696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfigByNumber_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyIds, IntPtr InData);

		// Token: 0x060058A9 RID: 22697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfigByBag_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr InBag, EConfigApplyTypeNew ApplyType);

		// Token: 0x060058AA RID: 22698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSubConfig_Internal(IntPtr @this, FName KeyName, int Priority, IntPtr PropertyNames, IntPtr InData, EConfigApplyTypeNew ApplyType);

		// Token: 0x060058AB RID: 22699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AccumulateRecordTime_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x060058AC RID: 22700 RVA: 0x0007CE6F File Offset: 0x0007B06F
		static UKuroConfigHelperNew()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDataBag.KuroConfigHelperNew");
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x0007CE7D File Offset: 0x0007B07D
		protected UKuroConfigHelperNew(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002498 RID: 9368
		public new const string __ObjectPath = "/Script/KuroDataBag.KuroConfigHelperNew";

		// Token: 0x04002499 RID: 9369
		private static IntPtr _ClassPtr;

		// Token: 0x0400249A RID: 9370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400249B RID: 9371
		internal static int __PropertyOffset_ReferencedDataObjects;

		// Token: 0x0400249C RID: 9372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedDataObjects;
	}
}

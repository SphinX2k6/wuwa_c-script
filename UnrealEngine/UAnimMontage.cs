using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017A RID: 378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimMontage")]
	[UnrealStructLayout(776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 776)]
	public class UAnimMontage : UAnimCompositeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017E8 RID: 6120 RVA: 0x00024966 File Offset: 0x00022B66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimMontage._ClassPtr;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00024974 File Offset: 0x00022B74
		public UAnimMontage() : this(BuiltinUtils.AllocNativeUObject(UAnimMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0002499C File Offset: 0x00022B9C
		public UAnimMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x000249D0 File Offset: 0x00022BD0
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x00024A09 File Offset: 0x00022C09
		public FAlphaBlend BlendIn
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._BlendIn) == null)
				{
					result = (this._BlendIn = new FAlphaBlend(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendIn, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00024A2A File Offset: 0x00022C2A
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00024A3A File Offset: 0x00022C3A
		public unsafe float BlendInTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendInTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendInTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00024A4C File Offset: 0x00022C4C
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00024A85 File Offset: 0x00022C85
		public FAlphaBlend BlendOut
		{
			get
			{
				base.FastCheckIsValid();
				FAlphaBlend result;
				if ((result = this._BlendOut) == null)
				{
					result = (this._BlendOut = new FAlphaBlend(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOut, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAlphaBlend.StaticStruct(), base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOut, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00024AA6 File Offset: 0x00022CA6
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x00024AB6 File Offset: 0x00022CB6
		public unsafe float BlendOutTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00024AC7 File Offset: 0x00022CC7
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00024AD7 File Offset: 0x00022CD7
		public unsafe float BlendOutTriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BlendOutTriggerTime) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00024AE8 File Offset: 0x00022CE8
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x00024AFC File Offset: 0x00022CFC
		public unsafe FName SyncGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncGroup) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00024B11 File Offset: 0x00022D11
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00024B21 File Offset: 0x00022D21
		public unsafe int SyncSlotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncSlotIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SyncSlotIndex) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00024B34 File Offset: 0x00022D34
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x00024B6D File Offset: 0x00022D6D
		public TArray<FCompositeSection> CompositeSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCompositeSection> result;
				if ((result = this._CompositeSections) == null)
				{
					result = (this._CompositeSections = new TArray<FCompositeSection>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_CompositeSections, this));
				}
				return result;
			}
			set
			{
				this.CompositeSections.CopyAssign(value);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00024B7C File Offset: 0x00022D7C
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00024BB5 File Offset: 0x00022DB5
		public TArray<FSlotAnimationTrack> SlotAnimTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSlotAnimationTrack> result;
				if ((result = this._SlotAnimTracks) == null)
				{
					result = (this._SlotAnimTracks = new TArray<FSlotAnimationTrack>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_SlotAnimTracks, this));
				}
				return result;
			}
			set
			{
				this.SlotAnimTracks.CopyAssign(value);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00024BC3 File Offset: 0x00022DC3
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x00024BD3 File Offset: 0x00022DD3
		public unsafe bool bEnableRootMotionTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00024BE4 File Offset: 0x00022DE4
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00024BF4 File Offset: 0x00022DF4
		public unsafe bool bEnableRootMotionRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableRootMotionRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00024C05 File Offset: 0x00022E05
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00024C15 File Offset: 0x00022E15
		public unsafe bool bEnableAutoBlendOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableAutoBlendOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_bEnableAutoBlendOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00024C28 File Offset: 0x00022E28
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00024C61 File Offset: 0x00022E61
		public TArray<int> BranchingPointStateNotifyIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BranchingPointStateNotifyIndices) == null)
				{
					result = (this._BranchingPointStateNotifyIndices = new TArray<int>(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_BranchingPointStateNotifyIndices, this));
				}
				return result;
			}
			set
			{
				this.BranchingPointStateNotifyIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00024C6F File Offset: 0x00022E6F
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00024C83 File Offset: 0x00022E83
		public unsafe FName TimeStretchCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimMontage.__PropertyOffset_TimeStretchCurveName) = value;
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00024C98 File Offset: 0x00022E98
		[SkipLocalsInit]
		public unsafe float GetDefaultBlendOutTime()
		{
			UAnimMontage.__GetDefaultBlendOutTime_FunctionParams* ptr = stackalloc UAnimMontage.__GetDefaultBlendOutTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UAnimMontage.__GetDefaultBlendOutTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnimMontage.__GetDefaultBlendOutTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAnimMontage.__GetDefaultBlendOutTime_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00024CDD File Offset: 0x00022EDD
		static UAnimMontage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimMontage");
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00024CEB File Offset: 0x00022EEB
		protected UAnimMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400077F RID: 1919
		public new const string __ObjectPath = "/Script/Engine.AnimMontage";

		// Token: 0x04000780 RID: 1920
		private static IntPtr _ClassPtr;

		// Token: 0x04000781 RID: 1921
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000782 RID: 1922
		internal static int __PropertyOffset_BlendIn;

		// Token: 0x04000783 RID: 1923
		[Nullable(2)]
		private FAlphaBlend _BlendIn;

		// Token: 0x04000784 RID: 1924
		internal static int __PropertyOffset_BlendInTime_DEPRECATED;

		// Token: 0x04000785 RID: 1925
		internal static int __PropertyOffset_BlendOut;

		// Token: 0x04000786 RID: 1926
		[Nullable(2)]
		private FAlphaBlend _BlendOut;

		// Token: 0x04000787 RID: 1927
		internal static int __PropertyOffset_BlendOutTime_DEPRECATED;

		// Token: 0x04000788 RID: 1928
		internal static int __PropertyOffset_BlendOutTriggerTime;

		// Token: 0x04000789 RID: 1929
		internal static int __PropertyOffset_SyncGroup;

		// Token: 0x0400078A RID: 1930
		internal static int __PropertyOffset_SyncSlotIndex;

		// Token: 0x0400078B RID: 1931
		internal static int __PropertyOffset_CompositeSections;

		// Token: 0x0400078C RID: 1932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCompositeSection> _CompositeSections;

		// Token: 0x0400078D RID: 1933
		internal static int __PropertyOffset_SlotAnimTracks;

		// Token: 0x0400078E RID: 1934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSlotAnimationTrack> _SlotAnimTracks;

		// Token: 0x0400078F RID: 1935
		internal static int __PropertyOffset_bEnableRootMotionTranslation;

		// Token: 0x04000790 RID: 1936
		internal static int __PropertyOffset_bEnableRootMotionRotation;

		// Token: 0x04000791 RID: 1937
		internal static int __PropertyOffset_bEnableAutoBlendOut;

		// Token: 0x04000792 RID: 1938
		internal static int __PropertyOffset_BranchingPointStateNotifyIndices;

		// Token: 0x04000793 RID: 1939
		[Nullable(2)]
		private TArray<int> _BranchingPointStateNotifyIndices;

		// Token: 0x04000794 RID: 1940
		internal static int __PropertyOffset_TimeStretchCurveName;

		// Token: 0x04000795 RID: 1941
		private static IntPtr __GetDefaultBlendOutTime_NativeFunctionPtr;

		// Token: 0x02000967 RID: 2407
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDefaultBlendOutTime_FunctionParams
		{
			// Token: 0x04005893 RID: 22675
			[FieldOffset(0)]
			public float __Result;
		}
	}
}

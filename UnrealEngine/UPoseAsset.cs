using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200101C RID: 4124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PoseAsset")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UPoseAsset : UAnimationAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E1A5 RID: 57765 RVA: 0x0014B976 File Offset: 0x00149B76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPoseAsset._ClassPtr;
		}

		// Token: 0x0600E1A6 RID: 57766 RVA: 0x0014B984 File Offset: 0x00149B84
		public UPoseAsset() : this(BuiltinUtils.AllocNativeUObject(UPoseAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E1A7 RID: 57767 RVA: 0x0014B9AC File Offset: 0x00149BAC
		public UPoseAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPoseAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600E1A8 RID: 57768 RVA: 0x0014B9E0 File Offset: 0x00149BE0
		// (set) Token: 0x0600E1A9 RID: 57769 RVA: 0x0014BA19 File Offset: 0x00149C19
		public FPoseDataContainer PoseContainer
		{
			get
			{
				base.FastCheckIsValid();
				FPoseDataContainer result;
				if ((result = this._PoseContainer) == null)
				{
					result = (this._PoseContainer = new FPoseDataContainer(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_PoseContainer, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseDataContainer.StaticStruct(), base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_PoseContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x0014BA3A File Offset: 0x00149C3A
		// (set) Token: 0x0600E1AB RID: 57771 RVA: 0x0014BA4A File Offset: 0x00149C4A
		public unsafe bool bAdditivePose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_bAdditivePose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_bAdditivePose) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600E1AC RID: 57772 RVA: 0x0014BA5B File Offset: 0x00149C5B
		// (set) Token: 0x0600E1AD RID: 57773 RVA: 0x0014BA6B File Offset: 0x00149C6B
		public unsafe int BasePoseIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_BasePoseIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_BasePoseIndex) = value;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x0014BA7C File Offset: 0x00149C7C
		// (set) Token: 0x0600E1AF RID: 57775 RVA: 0x0014BA90 File Offset: 0x00149C90
		public unsafe FName RetargetSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_RetargetSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPoseAsset.__PropertyOffset_RetargetSource) = value;
			}
		}

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x0014BAA5 File Offset: 0x00149CA5
		static UPoseAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PoseAsset");
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x0014BAB3 File Offset: 0x00149CB3
		protected UPoseAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400791D RID: 31005
		public new const string __ObjectPath = "/Script/Engine.PoseAsset";

		// Token: 0x0400791E RID: 31006
		private static IntPtr _ClassPtr;

		// Token: 0x0400791F RID: 31007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007920 RID: 31008
		internal static int __PropertyOffset_PoseContainer;

		// Token: 0x04007921 RID: 31009
		[Nullable(2)]
		private FPoseDataContainer _PoseContainer;

		// Token: 0x04007922 RID: 31010
		internal static int __PropertyOffset_bAdditivePose;

		// Token: 0x04007923 RID: 31011
		internal static int __PropertyOffset_BasePoseIndex;

		// Token: 0x04007924 RID: 31012
		internal static int __PropertyOffset_RetargetSource;
	}
}

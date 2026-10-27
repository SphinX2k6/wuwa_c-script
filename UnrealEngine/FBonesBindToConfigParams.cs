using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200162B RID: 5675
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BonesBindToConfigParams")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBonesBindToConfigParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014892 RID: 84114 RVA: 0x001E3612 File Offset: 0x001E1812
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBonesBindToConfigParams._ScriptStructPtr != 0) ? FBonesBindToConfigParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BonesBindToConfigParams", ref FBonesBindToConfigParams._ScriptStructPtr);
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x06014893 RID: 84115 RVA: 0x001E3638 File Offset: 0x001E1838
		// (set) Token: 0x06014894 RID: 84116 RVA: 0x001E367B File Offset: 0x001E187B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x06014895 RID: 84117 RVA: 0x001E369C File Offset: 0x001E189C
		// (set) Token: 0x06014896 RID: 84118 RVA: 0x001E36DF File Offset: 0x001E18DF
		public TArray<FBoneBindInfo> BindTos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneBindInfo> result;
				if ((result = this._BindTos) == null)
				{
					result = (this._BindTos = new TArray<FBoneBindInfo>(base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_BindTos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindTos.CopyAssign(value);
			}
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06014897 RID: 84119 RVA: 0x001E36ED File Offset: 0x001E18ED
		// (set) Token: 0x06014898 RID: 84120 RVA: 0x001E36FD File Offset: 0x001E18FD
		public unsafe EBoneBindType BindType
		{
			get
			{
				return (EBoneBindType)(*(base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_BindType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_BindType) = (byte)value;
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x06014899 RID: 84121 RVA: 0x001E3710 File Offset: 0x001E1910
		// (set) Token: 0x0601489A RID: 84122 RVA: 0x001E3753 File Offset: 0x001E1953
		public FBonesBindToRestoreConfig RestoreConfig
		{
			get
			{
				base.FastCheckIsValid();
				FBonesBindToRestoreConfig result;
				if ((result = this._RestoreConfig) == null)
				{
					result = (this._RestoreConfig = new FBonesBindToRestoreConfig(base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_RestoreConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBonesBindToRestoreConfig.StaticStruct(), base.NativePtr + (IntPtr)FBonesBindToConfigParams.__PropertyOffset_RestoreConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601489B RID: 84123 RVA: 0x001E3774 File Offset: 0x001E1974
		public FBonesBindToConfigParams()
		{
		}

		// Token: 0x0601489C RID: 84124 RVA: 0x001E377C File Offset: 0x001E197C
		public FBonesBindToConfigParams(FBoneReference Bone, TArray<FBoneBindInfo> BindTos, EBoneBindType BindType, FBonesBindToRestoreConfig RestoreConfig)
		{
			this.Bone = Bone;
			this.BindTos = BindTos;
			this.BindType = BindType;
			this.RestoreConfig = RestoreConfig;
		}

		// Token: 0x0601489D RID: 84125 RVA: 0x001E37A1 File Offset: 0x001E19A1
		protected override IntPtr GetUStructPtr()
		{
			return FBonesBindToConfigParams.StaticStruct();
		}

		// Token: 0x0601489E RID: 84126 RVA: 0x001E37AD File Offset: 0x001E19AD
		[NullableContext(2)]
		public FBonesBindToConfigParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601489F RID: 84127 RVA: 0x001E37B7 File Offset: 0x001E19B7
		public FBonesBindToConfigParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148A0 RID: 84128 RVA: 0x001E37C2 File Offset: 0x001E19C2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBonesBindToConfigParams(Pointer, false, true);
		}

		// Token: 0x060148A1 RID: 84129 RVA: 0x001E37CC File Offset: 0x001E19CC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBonesBindToConfigParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2AE RID: 45742
		public const string __ObjectPath = "/Script/KuroAnim.BonesBindToConfigParams";

		// Token: 0x0400B2AF RID: 45743
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2B0 RID: 45744
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400B2B1 RID: 45745
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400B2B2 RID: 45746
		internal static int __PropertyOffset_BindTos;

		// Token: 0x0400B2B3 RID: 45747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneBindInfo> _BindTos;

		// Token: 0x0400B2B4 RID: 45748
		internal static int __PropertyOffset_BindType;

		// Token: 0x0400B2B5 RID: 45749
		internal static int __PropertyOffset_RestoreConfig;

		// Token: 0x0400B2B6 RID: 45750
		[Nullable(2)]
		private FBonesBindToRestoreConfig _RestoreConfig;
	}
}

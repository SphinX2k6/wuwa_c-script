using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002ED RID: 749
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ObserveBone")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FAnimNode_ObserveBone : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002AAB RID: 10923 RVA: 0x00040D73 File Offset: 0x0003EF73
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ObserveBone._ScriptStructPtr != 0) ? FAnimNode_ObserveBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ObserveBone", ref FAnimNode_ObserveBone._ScriptStructPtr);
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x00040D98 File Offset: 0x0003EF98
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x00040DDB File Offset: 0x0003EFDB
		[Nullable(1)]
		public FBoneReference BoneToObserve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneToObserve) == null)
				{
					result = (this._BoneToObserve = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_BoneToObserve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_BoneToObserve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x00040DFC File Offset: 0x0003EFFC
		// (set) Token: 0x06002AAF RID: 10927 RVA: 0x00040E10 File Offset: 0x0003F010
		public unsafe TEnumAsByte<EBoneControlSpace> DisplaySpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_DisplaySpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_DisplaySpace) = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x00040E25 File Offset: 0x0003F025
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x00040E35 File Offset: 0x0003F035
		public unsafe bool bRelativeToRefPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_bRelativeToRefPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_bRelativeToRefPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x00040E46 File Offset: 0x0003F046
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x00040E5A File Offset: 0x0003F05A
		public unsafe FVector Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x00040E6F File Offset: 0x0003F06F
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x00040E83 File Offset: 0x0003F083
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x00040E98 File Offset: 0x0003F098
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x00040EAC File Offset: 0x0003F0AC
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ObserveBone.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00040EC1 File Offset: 0x0003F0C1
		public FAnimNode_ObserveBone()
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00040ECC File Offset: 0x0003F0CC
		[NullableContext(1)]
		public FAnimNode_ObserveBone(FBoneReference BoneToObserve, [Nullable(0)] TEnumAsByte<EBoneControlSpace> DisplaySpace, bool bRelativeToRefPose, FVector Translation, FRotator Rotation, FVector Scale, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneToObserve = BoneToObserve;
			this.DisplaySpace = DisplaySpace;
			this.bRelativeToRefPose = bRelativeToRefPose;
			this.Translation = Translation;
			this.Rotation = Rotation;
			this.Scale = Scale;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00040F74 File Offset: 0x0003F174
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ObserveBone.StaticStruct();
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00040F80 File Offset: 0x0003F180
		[NullableContext(2)]
		public FAnimNode_ObserveBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00040F8A File Offset: 0x0003F18A
		public FAnimNode_ObserveBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00040F95 File Offset: 0x0003F195
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ObserveBone(Pointer, false, true);
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00040F9F File Offset: 0x0003F19F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ObserveBone(Pointer, MemoryOwner);
		}

		// Token: 0x0400114D RID: 4429
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ObserveBone";

		// Token: 0x0400114E RID: 4430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400114F RID: 4431
		internal static int __PropertyOffset_BoneToObserve;

		// Token: 0x04001150 RID: 4432
		[Nullable(2)]
		private FBoneReference _BoneToObserve;

		// Token: 0x04001151 RID: 4433
		internal static int __PropertyOffset_DisplaySpace;

		// Token: 0x04001152 RID: 4434
		internal static int __PropertyOffset_bRelativeToRefPose;

		// Token: 0x04001153 RID: 4435
		internal static int __PropertyOffset_Translation;

		// Token: 0x04001154 RID: 4436
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04001155 RID: 4437
		internal static int __PropertyOffset_Scale;
	}
}

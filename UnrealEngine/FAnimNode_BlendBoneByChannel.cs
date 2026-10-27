using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D1 RID: 721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimNode_BlendBoneByChannel : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x0003CB44 File Offset: 0x0003AD44
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendBoneByChannel._ScriptStructPtr != 0) ? FAnimNode_BlendBoneByChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel", ref FAnimNode_BlendBoneByChannel._ScriptStructPtr);
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0003CB68 File Offset: 0x0003AD68
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x0003CBAB File Offset: 0x0003ADAB
		public FPoseLink A
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x0003CBCC File Offset: 0x0003ADCC
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x0003CC0F File Offset: 0x0003AE0F
		public FPoseLink B
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0003CC30 File Offset: 0x0003AE30
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x0003CC73 File Offset: 0x0003AE73
		public TArray<FBlendBoneByChannelEntry> BoneDefinitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlendBoneByChannelEntry> result;
				if ((result = this._BoneDefinitions) == null)
				{
					result = (this._BoneDefinitions = new TArray<FBlendBoneByChannelEntry>(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_BoneDefinitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneDefinitions.CopyAssign(value);
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0003CC81 File Offset: 0x0003AE81
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x0003CC91 File Offset: 0x0003AE91
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0003CCA4 File Offset: 0x0003AEA4
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0003CCE7 File Offset: 0x0003AEE7
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0003CD08 File Offset: 0x0003AF08
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> TransformsSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_TransformsSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendBoneByChannel.__PropertyOffset_TransformsSpace) = value;
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0003CD31 File Offset: 0x0003AF31
		public FAnimNode_BlendBoneByChannel()
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0003CD39 File Offset: 0x0003AF39
		public FAnimNode_BlendBoneByChannel(FPoseLink A, FPoseLink B, TArray<FBlendBoneByChannelEntry> BoneDefinitions, float Alpha, FInputScaleBias AlphaScaleBias, [Nullable(0)] TEnumAsByte<EBoneControlSpace> TransformsSpace)
		{
			this.A = A;
			this.B = B;
			this.BoneDefinitions = BoneDefinitions;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.TransformsSpace = TransformsSpace;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0003CD6E File Offset: 0x0003AF6E
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendBoneByChannel.StaticStruct();
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0003CD7A File Offset: 0x0003AF7A
		[NullableContext(2)]
		public FAnimNode_BlendBoneByChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0003CD84 File Offset: 0x0003AF84
		public FAnimNode_BlendBoneByChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0003CD8F File Offset: 0x0003AF8F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendBoneByChannel(Pointer, false, true);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0003CD99 File Offset: 0x0003AF99
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendBoneByChannel(Pointer, MemoryOwner);
		}

		// Token: 0x0400100B RID: 4107
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel";

		// Token: 0x0400100C RID: 4108
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400100D RID: 4109
		internal static int __PropertyOffset_A;

		// Token: 0x0400100E RID: 4110
		[Nullable(2)]
		private FPoseLink _A;

		// Token: 0x0400100F RID: 4111
		internal static int __PropertyOffset_B;

		// Token: 0x04001010 RID: 4112
		[Nullable(2)]
		private FPoseLink _B;

		// Token: 0x04001011 RID: 4113
		internal static int __PropertyOffset_BoneDefinitions;

		// Token: 0x04001012 RID: 4114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlendBoneByChannelEntry> _BoneDefinitions;

		// Token: 0x04001013 RID: 4115
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04001014 RID: 4116
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x04001015 RID: 4117
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x04001016 RID: 4118
		internal static int __PropertyOffset_TransformsSpace;
	}
}

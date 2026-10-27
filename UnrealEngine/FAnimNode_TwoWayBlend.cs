using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000306 RID: 774
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FAnimNode_TwoWayBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002CC9 RID: 11465 RVA: 0x00044B84 File Offset: 0x00042D84
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TwoWayBlend._ScriptStructPtr != 0) ? FAnimNode_TwoWayBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend", ref FAnimNode_TwoWayBlend._ScriptStructPtr);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x00044BA8 File Offset: 0x00042DA8
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x00044BEB File Offset: 0x00042DEB
		public FPoseLink A
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00044C0C File Offset: 0x00042E0C
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x00044C4F File Offset: 0x00042E4F
		public FPoseLink B
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00044C70 File Offset: 0x00042E70
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x00044C80 File Offset: 0x00042E80
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x00044C91 File Offset: 0x00042E91
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00044CAA File Offset: 0x00042EAA
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bAlphaBoolEnabled) & FAnimNode_TwoWayBlend.__PropertyMask_bAlphaBoolEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bAlphaBoolEnabled) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bAlphaBoolEnabled) & ~FAnimNode_TwoWayBlend.__PropertyMask_bAlphaBoolEnabled) | (value ? FAnimNode_TwoWayBlend.__PropertyMask_bAlphaBoolEnabled : 0));
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x00044CDA File Offset: 0x00042EDA
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00044CF3 File Offset: 0x00042EF3
		public unsafe bool bResetChildOnActivation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bResetChildOnActivation) & FAnimNode_TwoWayBlend.__PropertyMask_bResetChildOnActivation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bResetChildOnActivation) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_bResetChildOnActivation) & ~FAnimNode_TwoWayBlend.__PropertyMask_bResetChildOnActivation) | (value ? FAnimNode_TwoWayBlend.__PropertyMask_bResetChildOnActivation : 0));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x00044D23 File Offset: 0x00042F23
		// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x00044D33 File Offset: 0x00042F33
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x00044D44 File Offset: 0x00042F44
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x00044D87 File Offset: 0x00042F87
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x00044DA8 File Offset: 0x00042FA8
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x00044DEB File Offset: 0x00042FEB
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x00044E0C File Offset: 0x0004300C
		// (set) Token: 0x06002CDB RID: 11483 RVA: 0x00044E20 File Offset: 0x00043020
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x00044E38 File Offset: 0x00043038
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x00044E7B File Offset: 0x0004307B
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoWayBlend.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00044E9C File Offset: 0x0004309C
		public FAnimNode_TwoWayBlend()
		{
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00044EA4 File Offset: 0x000430A4
		public FAnimNode_TwoWayBlend(FPoseLink A, FPoseLink B, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bResetChildOnActivation, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.A = A;
			this.B = B;
			this.AlphaInputType = AlphaInputType;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
			this.bResetChildOnActivation = bResetChildOnActivation;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00044F04 File Offset: 0x00043104
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TwoWayBlend.StaticStruct();
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00044F10 File Offset: 0x00043110
		[NullableContext(2)]
		public FAnimNode_TwoWayBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00044F1A File Offset: 0x0004311A
		public FAnimNode_TwoWayBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00044F25 File Offset: 0x00043125
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TwoWayBlend(Pointer, false, true);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00044F2F File Offset: 0x0004312F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TwoWayBlend(Pointer, MemoryOwner);
		}

		// Token: 0x04001275 RID: 4725
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_TwoWayBlend";

		// Token: 0x04001276 RID: 4726
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001277 RID: 4727
		internal static int __PropertyOffset_A;

		// Token: 0x04001278 RID: 4728
		[Nullable(2)]
		private FPoseLink _A;

		// Token: 0x04001279 RID: 4729
		internal static int __PropertyOffset_B;

		// Token: 0x0400127A RID: 4730
		[Nullable(2)]
		private FPoseLink _B;

		// Token: 0x0400127B RID: 4731
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x0400127C RID: 4732
		internal static int __PropertyOffset_bAlphaBoolEnabled;

		// Token: 0x0400127D RID: 4733
		internal static byte __PropertyMask_bAlphaBoolEnabled;

		// Token: 0x0400127E RID: 4734
		internal static int __PropertyOffset_bResetChildOnActivation;

		// Token: 0x0400127F RID: 4735
		internal static byte __PropertyMask_bResetChildOnActivation;

		// Token: 0x04001280 RID: 4736
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04001281 RID: 4737
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x04001282 RID: 4738
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x04001283 RID: 4739
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x04001284 RID: 4740
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x04001285 RID: 4741
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x04001286 RID: 4742
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x04001287 RID: 4743
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;
	}
}

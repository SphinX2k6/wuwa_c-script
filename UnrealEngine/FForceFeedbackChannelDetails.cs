using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BEC RID: 3052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ForceFeedbackChannelDetails")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FForceFeedbackChannelDetails : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009670 RID: 38512 RVA: 0x000D6920 File Offset: 0x000D4B20
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForceFeedbackChannelDetails._ScriptStructPtr != 0) ? FForceFeedbackChannelDetails._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ForceFeedbackChannelDetails", ref FForceFeedbackChannelDetails._ScriptStructPtr);
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x06009671 RID: 38513 RVA: 0x000D6944 File Offset: 0x000D4B44
		// (set) Token: 0x06009672 RID: 38514 RVA: 0x000D695D File Offset: 0x000D4B5D
		public unsafe bool bAffectsLeftLarge
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftLarge) & FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftLarge) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftLarge) = ((*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftLarge) & ~FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftLarge) | (value ? FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftLarge : 0));
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x000D698D File Offset: 0x000D4B8D
		// (set) Token: 0x06009674 RID: 38516 RVA: 0x000D69A6 File Offset: 0x000D4BA6
		public unsafe bool bAffectsLeftSmall
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftSmall) & FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftSmall) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftSmall) = ((*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsLeftSmall) & ~FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftSmall) | (value ? FForceFeedbackChannelDetails.__PropertyMask_bAffectsLeftSmall : 0));
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x000D69D6 File Offset: 0x000D4BD6
		// (set) Token: 0x06009676 RID: 38518 RVA: 0x000D69EF File Offset: 0x000D4BEF
		public unsafe bool bAffectsRightLarge
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightLarge) & FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightLarge) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightLarge) = ((*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightLarge) & ~FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightLarge) | (value ? FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightLarge : 0));
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x000D6A1F File Offset: 0x000D4C1F
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x000D6A38 File Offset: 0x000D4C38
		public unsafe bool bAffectsRightSmall
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightSmall) & FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightSmall) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightSmall) = ((*(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_bAffectsRightSmall) & ~FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightSmall) | (value ? FForceFeedbackChannelDetails.__PropertyMask_bAffectsRightSmall : 0));
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x000D6A68 File Offset: 0x000D4C68
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x000D6AAB File Offset: 0x000D4CAB
		public FRuntimeFloatCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FForceFeedbackChannelDetails.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x000D6ACC File Offset: 0x000D4CCC
		public FForceFeedbackChannelDetails()
		{
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x000D6AD4 File Offset: 0x000D4CD4
		public FForceFeedbackChannelDetails(bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, FRuntimeFloatCurve Curve)
		{
			this.bAffectsLeftLarge = bAffectsLeftLarge;
			this.bAffectsLeftSmall = bAffectsLeftSmall;
			this.bAffectsRightLarge = bAffectsRightLarge;
			this.bAffectsRightSmall = bAffectsRightSmall;
			this.Curve = Curve;
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x000D6B01 File Offset: 0x000D4D01
		protected override IntPtr GetUStructPtr()
		{
			return FForceFeedbackChannelDetails.StaticStruct();
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x000D6B0D File Offset: 0x000D4D0D
		[NullableContext(2)]
		public FForceFeedbackChannelDetails(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x000D6B17 File Offset: 0x000D4D17
		public FForceFeedbackChannelDetails(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x000D6B22 File Offset: 0x000D4D22
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForceFeedbackChannelDetails(Pointer, false, true);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x000D6B2C File Offset: 0x000D4D2C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForceFeedbackChannelDetails(Pointer, MemoryOwner);
		}

		// Token: 0x04005465 RID: 21605
		public const string __ObjectPath = "/Script/Engine.ForceFeedbackChannelDetails";

		// Token: 0x04005466 RID: 21606
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005467 RID: 21607
		internal static int __PropertyOffset_bAffectsLeftLarge;

		// Token: 0x04005468 RID: 21608
		internal static byte __PropertyMask_bAffectsLeftLarge;

		// Token: 0x04005469 RID: 21609
		internal static int __PropertyOffset_bAffectsLeftSmall;

		// Token: 0x0400546A RID: 21610
		internal static byte __PropertyMask_bAffectsLeftSmall;

		// Token: 0x0400546B RID: 21611
		internal static int __PropertyOffset_bAffectsRightLarge;

		// Token: 0x0400546C RID: 21612
		internal static byte __PropertyMask_bAffectsRightLarge;

		// Token: 0x0400546D RID: 21613
		internal static int __PropertyOffset_bAffectsRightSmall;

		// Token: 0x0400546E RID: 21614
		internal static byte __PropertyMask_bAffectsRightSmall;

		// Token: 0x0400546F RID: 21615
		internal static int __PropertyOffset_Curve;

		// Token: 0x04005470 RID: 21616
		[Nullable(2)]
		private FRuntimeFloatCurve _Curve;
	}
}

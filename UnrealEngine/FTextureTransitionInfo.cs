using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002112 RID: 8466
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.TextureTransitionInfo")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FTextureTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDB1 RID: 130481 RVA: 0x002F6365 File Offset: 0x002F4565
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureTransitionInfo._ScriptStructPtr != 0) ? FTextureTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextureTransitionInfo", ref FTextureTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17007D4C RID: 32076
		// (get) Token: 0x0601FDB2 RID: 130482 RVA: 0x002F638C File Offset: 0x002F458C
		// (set) Token: 0x0601FDB3 RID: 130483 RVA: 0x002F63CF File Offset: 0x002F45CF
		public FTextureTransitionOfState NormalTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._NormalTransition) == null)
				{
					result = (this._NormalTransition = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_NormalTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_NormalTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D4D RID: 32077
		// (get) Token: 0x0601FDB4 RID: 130484 RVA: 0x002F63F0 File Offset: 0x002F45F0
		// (set) Token: 0x0601FDB5 RID: 130485 RVA: 0x002F6433 File Offset: 0x002F4633
		public FTextureTransitionOfState HighlightedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._HighlightedTransition) == null)
				{
					result = (this._HighlightedTransition = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_HighlightedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_HighlightedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D4E RID: 32078
		// (get) Token: 0x0601FDB6 RID: 130486 RVA: 0x002F6454 File Offset: 0x002F4654
		// (set) Token: 0x0601FDB7 RID: 130487 RVA: 0x002F6497 File Offset: 0x002F4697
		public FTextureTransitionOfState PressedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._PressedTransition) == null)
				{
					result = (this._PressedTransition = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_PressedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_PressedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D4F RID: 32079
		// (get) Token: 0x0601FDB8 RID: 130488 RVA: 0x002F64B8 File Offset: 0x002F46B8
		// (set) Token: 0x0601FDB9 RID: 130489 RVA: 0x002F64FB File Offset: 0x002F46FB
		public FTextureTransitionOfState DisabledTransition
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._DisabledTransition) == null)
				{
					result = (this._DisabledTransition = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_DisabledTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FTextureTransitionInfo.__PropertyOffset_DisabledTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FDBA RID: 130490 RVA: 0x002F651C File Offset: 0x002F471C
		public FTextureTransitionInfo()
		{
		}

		// Token: 0x0601FDBB RID: 130491 RVA: 0x002F6524 File Offset: 0x002F4724
		public FTextureTransitionInfo(FTextureTransitionOfState NormalTransition, FTextureTransitionOfState HighlightedTransition, FTextureTransitionOfState PressedTransition, FTextureTransitionOfState DisabledTransition)
		{
			this.NormalTransition = NormalTransition;
			this.HighlightedTransition = HighlightedTransition;
			this.PressedTransition = PressedTransition;
			this.DisabledTransition = DisabledTransition;
		}

		// Token: 0x0601FDBC RID: 130492 RVA: 0x002F6549 File Offset: 0x002F4749
		protected override IntPtr GetUStructPtr()
		{
			return FTextureTransitionInfo.StaticStruct();
		}

		// Token: 0x0601FDBD RID: 130493 RVA: 0x002F6555 File Offset: 0x002F4755
		[NullableContext(2)]
		public FTextureTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDBE RID: 130494 RVA: 0x002F655F File Offset: 0x002F475F
		public FTextureTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDBF RID: 130495 RVA: 0x002F656A File Offset: 0x002F476A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0601FDC0 RID: 130496 RVA: 0x002F6574 File Offset: 0x002F4774
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040112AB RID: 70315
		public const string __ObjectPath = "/Script/LGUI.TextureTransitionInfo";

		// Token: 0x040112AC RID: 70316
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112AD RID: 70317
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x040112AE RID: 70318
		[Nullable(2)]
		private FTextureTransitionOfState _NormalTransition;

		// Token: 0x040112AF RID: 70319
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x040112B0 RID: 70320
		[Nullable(2)]
		private FTextureTransitionOfState _HighlightedTransition;

		// Token: 0x040112B1 RID: 70321
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x040112B2 RID: 70322
		[Nullable(2)]
		private FTextureTransitionOfState _PressedTransition;

		// Token: 0x040112B3 RID: 70323
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x040112B4 RID: 70324
		[Nullable(2)]
		private FTextureTransitionOfState _DisabledTransition;
	}
}

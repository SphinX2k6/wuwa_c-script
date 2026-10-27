using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E5 RID: 8677
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.WidgetTransitionInfo")]
	[UnrealStructLayout(340, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 340)]
	public class FWidgetTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021174 RID: 135540 RVA: 0x0030CAD9 File Offset: 0x0030ACD9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetTransitionInfo._ScriptStructPtr != 0) ? FWidgetTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.WidgetTransitionInfo", ref FWidgetTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x1700812A RID: 33066
		// (get) Token: 0x06021175 RID: 135541 RVA: 0x0030CAFD File Offset: 0x0030ACFD
		// (set) Token: 0x06021176 RID: 135542 RVA: 0x0030CB16 File Offset: 0x0030AD16
		public unsafe bool bCustomNormalTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomNormalTransition) & FWidgetTransitionInfo.__PropertyMask_bCustomNormalTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomNormalTransition) = ((*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomNormalTransition) & ~FWidgetTransitionInfo.__PropertyMask_bCustomNormalTransition) | (value ? FWidgetTransitionInfo.__PropertyMask_bCustomNormalTransition : 0));
			}
		}

		// Token: 0x1700812B RID: 33067
		// (get) Token: 0x06021177 RID: 135543 RVA: 0x0030CB46 File Offset: 0x0030AD46
		// (set) Token: 0x06021178 RID: 135544 RVA: 0x0030CB5F File Offset: 0x0030AD5F
		public unsafe bool bCustomHighlightedTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomHighlightedTransition) & FWidgetTransitionInfo.__PropertyMask_bCustomHighlightedTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomHighlightedTransition) = ((*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomHighlightedTransition) & ~FWidgetTransitionInfo.__PropertyMask_bCustomHighlightedTransition) | (value ? FWidgetTransitionInfo.__PropertyMask_bCustomHighlightedTransition : 0));
			}
		}

		// Token: 0x1700812C RID: 33068
		// (get) Token: 0x06021179 RID: 135545 RVA: 0x0030CB8F File Offset: 0x0030AD8F
		// (set) Token: 0x0602117A RID: 135546 RVA: 0x0030CBA8 File Offset: 0x0030ADA8
		public unsafe bool bCustomPressedTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomPressedTransition) & FWidgetTransitionInfo.__PropertyMask_bCustomPressedTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomPressedTransition) = ((*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomPressedTransition) & ~FWidgetTransitionInfo.__PropertyMask_bCustomPressedTransition) | (value ? FWidgetTransitionInfo.__PropertyMask_bCustomPressedTransition : 0));
			}
		}

		// Token: 0x1700812D RID: 33069
		// (get) Token: 0x0602117B RID: 135547 RVA: 0x0030CBD8 File Offset: 0x0030ADD8
		// (set) Token: 0x0602117C RID: 135548 RVA: 0x0030CBF1 File Offset: 0x0030ADF1
		public unsafe bool bCustomDisabledTransition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomDisabledTransition) & FWidgetTransitionInfo.__PropertyMask_bCustomDisabledTransition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomDisabledTransition) = ((*(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_bCustomDisabledTransition) & ~FWidgetTransitionInfo.__PropertyMask_bCustomDisabledTransition) | (value ? FWidgetTransitionInfo.__PropertyMask_bCustomDisabledTransition : 0));
			}
		}

		// Token: 0x1700812E RID: 33070
		// (get) Token: 0x0602117D RID: 135549 RVA: 0x0030CC24 File Offset: 0x0030AE24
		// (set) Token: 0x0602117E RID: 135550 RVA: 0x0030CC67 File Offset: 0x0030AE67
		public FUIWidget NormalTransition
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._NormalTransition) == null)
				{
					result = (this._NormalTransition = new FUIWidget(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_NormalTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_NormalTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700812F RID: 33071
		// (get) Token: 0x0602117F RID: 135551 RVA: 0x0030CC88 File Offset: 0x0030AE88
		// (set) Token: 0x06021180 RID: 135552 RVA: 0x0030CCCB File Offset: 0x0030AECB
		public FUIWidget HighlightedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._HighlightedTransition) == null)
				{
					result = (this._HighlightedTransition = new FUIWidget(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_HighlightedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_HighlightedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008130 RID: 33072
		// (get) Token: 0x06021181 RID: 135553 RVA: 0x0030CCEC File Offset: 0x0030AEEC
		// (set) Token: 0x06021182 RID: 135554 RVA: 0x0030CD2F File Offset: 0x0030AF2F
		public FUIWidget PressedTransition
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._PressedTransition) == null)
				{
					result = (this._PressedTransition = new FUIWidget(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_PressedTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_PressedTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008131 RID: 33073
		// (get) Token: 0x06021183 RID: 135555 RVA: 0x0030CD50 File Offset: 0x0030AF50
		// (set) Token: 0x06021184 RID: 135556 RVA: 0x0030CD93 File Offset: 0x0030AF93
		public FUIWidget DisabledTransition
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._DisabledTransition) == null)
				{
					result = (this._DisabledTransition = new FUIWidget(base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_DisabledTransition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)FWidgetTransitionInfo.__PropertyOffset_DisabledTransition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021185 RID: 135557 RVA: 0x0030CDB4 File Offset: 0x0030AFB4
		public FWidgetTransitionInfo()
		{
		}

		// Token: 0x06021186 RID: 135558 RVA: 0x0030CDBC File Offset: 0x0030AFBC
		public FWidgetTransitionInfo(bool bCustomNormalTransition, bool bCustomHighlightedTransition, bool bCustomPressedTransition, bool bCustomDisabledTransition, FUIWidget NormalTransition, FUIWidget HighlightedTransition, FUIWidget PressedTransition, FUIWidget DisabledTransition)
		{
			this.bCustomNormalTransition = bCustomNormalTransition;
			this.bCustomHighlightedTransition = bCustomHighlightedTransition;
			this.bCustomPressedTransition = bCustomPressedTransition;
			this.bCustomDisabledTransition = bCustomDisabledTransition;
			this.NormalTransition = NormalTransition;
			this.HighlightedTransition = HighlightedTransition;
			this.PressedTransition = PressedTransition;
			this.DisabledTransition = DisabledTransition;
		}

		// Token: 0x06021187 RID: 135559 RVA: 0x0030CE0C File Offset: 0x0030B00C
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetTransitionInfo.StaticStruct();
		}

		// Token: 0x06021188 RID: 135560 RVA: 0x0030CE18 File Offset: 0x0030B018
		[NullableContext(2)]
		public FWidgetTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021189 RID: 135561 RVA: 0x0030CE22 File Offset: 0x0030B022
		public FWidgetTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602118A RID: 135562 RVA: 0x0030CE2D File Offset: 0x0030B02D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0602118B RID: 135563 RVA: 0x0030CE37 File Offset: 0x0030B037
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011A68 RID: 72296
		public const string __ObjectPath = "/Script/LGUI.WidgetTransitionInfo";

		// Token: 0x04011A69 RID: 72297
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A6A RID: 72298
		internal static int __PropertyOffset_bCustomNormalTransition;

		// Token: 0x04011A6B RID: 72299
		internal static byte __PropertyMask_bCustomNormalTransition;

		// Token: 0x04011A6C RID: 72300
		internal static int __PropertyOffset_bCustomHighlightedTransition;

		// Token: 0x04011A6D RID: 72301
		internal static byte __PropertyMask_bCustomHighlightedTransition;

		// Token: 0x04011A6E RID: 72302
		internal static int __PropertyOffset_bCustomPressedTransition;

		// Token: 0x04011A6F RID: 72303
		internal static byte __PropertyMask_bCustomPressedTransition;

		// Token: 0x04011A70 RID: 72304
		internal static int __PropertyOffset_bCustomDisabledTransition;

		// Token: 0x04011A71 RID: 72305
		internal static byte __PropertyMask_bCustomDisabledTransition;

		// Token: 0x04011A72 RID: 72306
		internal static int __PropertyOffset_NormalTransition;

		// Token: 0x04011A73 RID: 72307
		[Nullable(2)]
		private FUIWidget _NormalTransition;

		// Token: 0x04011A74 RID: 72308
		internal static int __PropertyOffset_HighlightedTransition;

		// Token: 0x04011A75 RID: 72309
		[Nullable(2)]
		private FUIWidget _HighlightedTransition;

		// Token: 0x04011A76 RID: 72310
		internal static int __PropertyOffset_PressedTransition;

		// Token: 0x04011A77 RID: 72311
		[Nullable(2)]
		private FUIWidget _PressedTransition;

		// Token: 0x04011A78 RID: 72312
		internal static int __PropertyOffset_DisabledTransition;

		// Token: 0x04011A79 RID: 72313
		[Nullable(2)]
		private FUIWidget _DisabledTransition;
	}
}

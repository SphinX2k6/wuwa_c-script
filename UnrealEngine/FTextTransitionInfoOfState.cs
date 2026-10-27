using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002111 RID: 8465
	[UnrealObjectPath("/Script/LGUI.TextTransitionInfoOfState")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTextTransitionInfoOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD95 RID: 130453 RVA: 0x002F6121 File Offset: 0x002F4321
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextTransitionInfoOfState._ScriptStructPtr != 0) ? FTextTransitionInfoOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextTransitionInfoOfState", ref FTextTransitionInfoOfState._ScriptStructPtr);
		}

		// Token: 0x17007D42 RID: 32066
		// (get) Token: 0x0601FD96 RID: 130454 RVA: 0x002F6145 File Offset: 0x002F4345
		// (set) Token: 0x0601FD97 RID: 130455 RVA: 0x002F6159 File Offset: 0x002F4359
		public unsafe FColor FontColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_FontColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_FontColor) = value;
			}
		}

		// Token: 0x17007D43 RID: 32067
		// (get) Token: 0x0601FD98 RID: 130456 RVA: 0x002F616E File Offset: 0x002F436E
		// (set) Token: 0x0601FD99 RID: 130457 RVA: 0x002F6182 File Offset: 0x002F4382
		public unsafe FColor OutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_OutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_OutlineColor) = value;
			}
		}

		// Token: 0x17007D44 RID: 32068
		// (get) Token: 0x0601FD9A RID: 130458 RVA: 0x002F6197 File Offset: 0x002F4397
		// (set) Token: 0x0601FD9B RID: 130459 RVA: 0x002F61A7 File Offset: 0x002F43A7
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17007D45 RID: 32069
		// (get) Token: 0x0601FD9C RID: 130460 RVA: 0x002F61B8 File Offset: 0x002F43B8
		// (set) Token: 0x0601FD9D RID: 130461 RVA: 0x002F61C8 File Offset: 0x002F43C8
		public unsafe UITextFontStyle fontStyle
		{
			get
			{
				return (UITextFontStyle)(*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_fontStyle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_fontStyle) = (byte)value;
			}
		}

		// Token: 0x17007D46 RID: 32070
		// (get) Token: 0x0601FD9E RID: 130462 RVA: 0x002F61D9 File Offset: 0x002F43D9
		// (set) Token: 0x0601FD9F RID: 130463 RVA: 0x002F61F2 File Offset: 0x002F43F2
		public unsafe bool bGradualChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bGradualChange) & FTextTransitionInfoOfState.__PropertyMask_bGradualChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bGradualChange) = ((*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bGradualChange) & ~FTextTransitionInfoOfState.__PropertyMask_bGradualChange) | (value ? FTextTransitionInfoOfState.__PropertyMask_bGradualChange : 0));
			}
		}

		// Token: 0x17007D47 RID: 32071
		// (get) Token: 0x0601FDA0 RID: 130464 RVA: 0x002F6222 File Offset: 0x002F4422
		// (set) Token: 0x0601FDA1 RID: 130465 RVA: 0x002F6232 File Offset: 0x002F4432
		public unsafe float GradualDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_GradualDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_GradualDuration) = value;
			}
		}

		// Token: 0x17007D48 RID: 32072
		// (get) Token: 0x0601FDA2 RID: 130466 RVA: 0x002F6243 File Offset: 0x002F4443
		// (set) Token: 0x0601FDA3 RID: 130467 RVA: 0x002F6253 File Offset: 0x002F4453
		public unsafe bool bSetFontColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D49 RID: 32073
		// (get) Token: 0x0601FDA4 RID: 130468 RVA: 0x002F6264 File Offset: 0x002F4464
		// (set) Token: 0x0601FDA5 RID: 130469 RVA: 0x002F6274 File Offset: 0x002F4474
		public unsafe bool bSetOutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetOutlineColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetOutlineColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D4A RID: 32074
		// (get) Token: 0x0601FDA6 RID: 130470 RVA: 0x002F6285 File Offset: 0x002F4485
		// (set) Token: 0x0601FDA7 RID: 130471 RVA: 0x002F6295 File Offset: 0x002F4495
		public unsafe bool bSetFontSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D4B RID: 32075
		// (get) Token: 0x0601FDA8 RID: 130472 RVA: 0x002F62A6 File Offset: 0x002F44A6
		// (set) Token: 0x0601FDA9 RID: 130473 RVA: 0x002F62B6 File Offset: 0x002F44B6
		public unsafe bool bSetFontStyle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontStyle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextTransitionInfoOfState.__PropertyOffset_bSetFontStyle) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FDAA RID: 130474 RVA: 0x002F62C7 File Offset: 0x002F44C7
		public FTextTransitionInfoOfState()
		{
		}

		// Token: 0x0601FDAB RID: 130475 RVA: 0x002F62D0 File Offset: 0x002F44D0
		[NullableContext(1)]
		public FTextTransitionInfoOfState(string PredefineColor, FColor FontColor, FColor OutlineColor, float Size, UITextFontStyle fontStyle, bool bGradualChange, float GradualDuration, bool bSetFontColor, bool bSetOutlineColor, bool bSetFontSize, bool bSetFontStyle)
		{
			this.FontColor = FontColor;
			this.OutlineColor = OutlineColor;
			this.Size = Size;
			this.fontStyle = fontStyle;
			this.bGradualChange = bGradualChange;
			this.GradualDuration = GradualDuration;
			this.bSetFontColor = bSetFontColor;
			this.bSetOutlineColor = bSetOutlineColor;
			this.bSetFontSize = bSetFontSize;
			this.bSetFontStyle = bSetFontStyle;
		}

		// Token: 0x0601FDAC RID: 130476 RVA: 0x002F6331 File Offset: 0x002F4531
		protected override IntPtr GetUStructPtr()
		{
			return FTextTransitionInfoOfState.StaticStruct();
		}

		// Token: 0x0601FDAD RID: 130477 RVA: 0x002F633D File Offset: 0x002F453D
		[NullableContext(2)]
		public FTextTransitionInfoOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDAE RID: 130478 RVA: 0x002F6347 File Offset: 0x002F4547
		public FTextTransitionInfoOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDAF RID: 130479 RVA: 0x002F6352 File Offset: 0x002F4552
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextTransitionInfoOfState(Pointer, false, true);
		}

		// Token: 0x0601FDB0 RID: 130480 RVA: 0x002F635C File Offset: 0x002F455C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextTransitionInfoOfState(Pointer, MemoryOwner);
		}

		// Token: 0x0401129E RID: 70302
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.TextTransitionInfoOfState";

		// Token: 0x0401129F RID: 70303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112A0 RID: 70304
		internal static int __PropertyOffset_FontColor;

		// Token: 0x040112A1 RID: 70305
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x040112A2 RID: 70306
		internal static int __PropertyOffset_Size;

		// Token: 0x040112A3 RID: 70307
		internal static int __PropertyOffset_fontStyle;

		// Token: 0x040112A4 RID: 70308
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x040112A5 RID: 70309
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x040112A6 RID: 70310
		internal static int __PropertyOffset_GradualDuration;

		// Token: 0x040112A7 RID: 70311
		internal static int __PropertyOffset_bSetFontColor;

		// Token: 0x040112A8 RID: 70312
		internal static int __PropertyOffset_bSetOutlineColor;

		// Token: 0x040112A9 RID: 70313
		internal static int __PropertyOffset_bSetFontSize;

		// Token: 0x040112AA RID: 70314
		internal static int __PropertyOffset_bSetFontStyle;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E1 RID: 1761
	[UnrealObjectPath("/Script/LGUI.TextTransitionInfoOfState")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTextTransitionInfoOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600958C RID: 38284 RVA: 0x000E1DA4 File Offset: 0x000DFFA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextTransitionInfoOfState._ScriptStructPtr != 0) ? FTextTransitionInfoOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextTransitionInfoOfState", ref FTextTransitionInfoOfState._ScriptStructPtr);
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x000E1DC8 File Offset: 0x000DFFC8
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x000E1DDC File Offset: 0x000DFFDC
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

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x000E1DF1 File Offset: 0x000DFFF1
		// (set) Token: 0x06009590 RID: 38288 RVA: 0x000E1E05 File Offset: 0x000E0005
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

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x000E1E1A File Offset: 0x000E001A
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x000E1E2A File Offset: 0x000E002A
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

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x000E1E3B File Offset: 0x000E003B
		// (set) Token: 0x06009594 RID: 38292 RVA: 0x000E1E54 File Offset: 0x000E0054
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

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x000E1E84 File Offset: 0x000E0084
		// (set) Token: 0x06009596 RID: 38294 RVA: 0x000E1E94 File Offset: 0x000E0094
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

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06009597 RID: 38295 RVA: 0x000E1EA5 File Offset: 0x000E00A5
		// (set) Token: 0x06009598 RID: 38296 RVA: 0x000E1EB5 File Offset: 0x000E00B5
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

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x000E1EC6 File Offset: 0x000E00C6
		// (set) Token: 0x0600959A RID: 38298 RVA: 0x000E1ED6 File Offset: 0x000E00D6
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

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x0600959B RID: 38299 RVA: 0x000E1EE7 File Offset: 0x000E00E7
		// (set) Token: 0x0600959C RID: 38300 RVA: 0x000E1EF7 File Offset: 0x000E00F7
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

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x0600959D RID: 38301 RVA: 0x000E1F08 File Offset: 0x000E0108
		// (set) Token: 0x0600959E RID: 38302 RVA: 0x000E1F18 File Offset: 0x000E0118
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

		// Token: 0x0600959F RID: 38303 RVA: 0x000E1F29 File Offset: 0x000E0129
		public FTextTransitionInfoOfState()
		{
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x000E1F31 File Offset: 0x000E0131
		protected override IntPtr GetUStructPtr()
		{
			return FTextTransitionInfoOfState.StaticStruct();
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x000E1F3D File Offset: 0x000E013D
		[NullableContext(2)]
		public FTextTransitionInfoOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x000E1F47 File Offset: 0x000E0147
		public FTextTransitionInfoOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x000E1F52 File Offset: 0x000E0152
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextTransitionInfoOfState(Pointer, false, true);
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x000E1F5C File Offset: 0x000E015C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextTransitionInfoOfState(Pointer, MemoryOwner);
		}

		// Token: 0x04004113 RID: 16659
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.TextTransitionInfoOfState";

		// Token: 0x04004114 RID: 16660
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004115 RID: 16661
		internal static int __PropertyOffset_FontColor;

		// Token: 0x04004116 RID: 16662
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x04004117 RID: 16663
		internal static int __PropertyOffset_Size;

		// Token: 0x04004118 RID: 16664
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x04004119 RID: 16665
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x0400411A RID: 16666
		internal static int __PropertyOffset_GradualDuration;

		// Token: 0x0400411B RID: 16667
		internal static int __PropertyOffset_bSetFontColor;

		// Token: 0x0400411C RID: 16668
		internal static int __PropertyOffset_bSetOutlineColor;

		// Token: 0x0400411D RID: 16669
		internal static int __PropertyOffset_bSetFontSize;

		// Token: 0x0400411E RID: 16670
		internal static int __PropertyOffset_bSetFontStyle;
	}
}

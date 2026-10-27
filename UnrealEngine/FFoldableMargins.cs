using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002012 RID: 8210
	[UnrealObjectPath("/Script/LGUI.FoldableMargins")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFoldableMargins : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF24 RID: 126756 RVA: 0x002E05F0 File Offset: 0x002DE7F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoldableMargins._ScriptStructPtr != 0) ? FFoldableMargins._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.FoldableMargins", ref FFoldableMargins._ScriptStructPtr);
		}

		// Token: 0x17007B39 RID: 31545
		// (get) Token: 0x0601EF25 RID: 126757 RVA: 0x002E0614 File Offset: 0x002DE814
		// (set) Token: 0x0601EF26 RID: 126758 RVA: 0x002E0628 File Offset: 0x002DE828
		public unsafe FMargin SquareMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoldableMargins.__PropertyOffset_SquareMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoldableMargins.__PropertyOffset_SquareMargin) = value;
			}
		}

		// Token: 0x17007B3A RID: 31546
		// (get) Token: 0x0601EF27 RID: 126759 RVA: 0x002E063D File Offset: 0x002DE83D
		// (set) Token: 0x0601EF28 RID: 126760 RVA: 0x002E0651 File Offset: 0x002DE851
		public unsafe FMargin NarrowMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoldableMargins.__PropertyOffset_NarrowMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoldableMargins.__PropertyOffset_NarrowMargin) = value;
			}
		}

		// Token: 0x0601EF29 RID: 126761 RVA: 0x002E0666 File Offset: 0x002DE866
		public FFoldableMargins()
		{
		}

		// Token: 0x0601EF2A RID: 126762 RVA: 0x002E066E File Offset: 0x002DE86E
		public FFoldableMargins(FMargin SquareMargin, FMargin NarrowMargin)
		{
			this.SquareMargin = SquareMargin;
			this.NarrowMargin = NarrowMargin;
		}

		// Token: 0x0601EF2B RID: 126763 RVA: 0x002E0684 File Offset: 0x002DE884
		protected override IntPtr GetUStructPtr()
		{
			return FFoldableMargins.StaticStruct();
		}

		// Token: 0x0601EF2C RID: 126764 RVA: 0x002E0690 File Offset: 0x002DE890
		[NullableContext(2)]
		public FFoldableMargins(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF2D RID: 126765 RVA: 0x002E069A File Offset: 0x002DE89A
		public FFoldableMargins(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF2E RID: 126766 RVA: 0x002E06A5 File Offset: 0x002DE8A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoldableMargins(Pointer, false, true);
		}

		// Token: 0x0601EF2F RID: 126767 RVA: 0x002E06AF File Offset: 0x002DE8AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoldableMargins(Pointer, MemoryOwner);
		}

		// Token: 0x04010D38 RID: 68920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.FoldableMargins";

		// Token: 0x04010D39 RID: 68921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D3A RID: 68922
		internal static int __PropertyOffset_SquareMargin;

		// Token: 0x04010D3B RID: 68923
		internal static int __PropertyOffset_NarrowMargin;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002664 RID: 9828
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessCopy")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPropertyAccessCopy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024849 RID: 149577 RVA: 0x00361124 File Offset: 0x0035F324
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessCopy._ScriptStructPtr != 0) ? FPropertyAccessCopy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessCopy", ref FPropertyAccessCopy._ScriptStructPtr);
		}

		// Token: 0x17008CBF RID: 36031
		// (get) Token: 0x0602484A RID: 149578 RVA: 0x00361148 File Offset: 0x0035F348
		// (set) Token: 0x0602484B RID: 149579 RVA: 0x00361158 File Offset: 0x0035F358
		public unsafe int AccessIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_AccessIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_AccessIndex) = value;
			}
		}

		// Token: 0x17008CC0 RID: 36032
		// (get) Token: 0x0602484C RID: 149580 RVA: 0x00361169 File Offset: 0x0035F369
		// (set) Token: 0x0602484D RID: 149581 RVA: 0x00361179 File Offset: 0x0035F379
		public unsafe int DestAccessStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_DestAccessStartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_DestAccessStartIndex) = value;
			}
		}

		// Token: 0x17008CC1 RID: 36033
		// (get) Token: 0x0602484E RID: 149582 RVA: 0x0036118A File Offset: 0x0035F38A
		// (set) Token: 0x0602484F RID: 149583 RVA: 0x0036119A File Offset: 0x0035F39A
		public unsafe int DestAccessEndIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_DestAccessEndIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_DestAccessEndIndex) = value;
			}
		}

		// Token: 0x17008CC2 RID: 36034
		// (get) Token: 0x06024850 RID: 149584 RVA: 0x003611AB File Offset: 0x0035F3AB
		// (set) Token: 0x06024851 RID: 149585 RVA: 0x003611BB File Offset: 0x0035F3BB
		public unsafe EPropertyAccessCopyType Type
		{
			get
			{
				return (EPropertyAccessCopyType)(*(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessCopy.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06024852 RID: 149586 RVA: 0x003611CC File Offset: 0x0035F3CC
		public FPropertyAccessCopy()
		{
		}

		// Token: 0x06024853 RID: 149587 RVA: 0x003611D4 File Offset: 0x0035F3D4
		public FPropertyAccessCopy(int AccessIndex, int DestAccessStartIndex, int DestAccessEndIndex, EPropertyAccessCopyType Type)
		{
			this.AccessIndex = AccessIndex;
			this.DestAccessStartIndex = DestAccessStartIndex;
			this.DestAccessEndIndex = DestAccessEndIndex;
			this.Type = Type;
		}

		// Token: 0x06024854 RID: 149588 RVA: 0x003611F9 File Offset: 0x0035F3F9
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessCopy.StaticStruct();
		}

		// Token: 0x06024855 RID: 149589 RVA: 0x00361205 File Offset: 0x0035F405
		[NullableContext(2)]
		public FPropertyAccessCopy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024856 RID: 149590 RVA: 0x0036120F File Offset: 0x0035F40F
		public FPropertyAccessCopy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024857 RID: 149591 RVA: 0x0036121A File Offset: 0x0035F41A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessCopy(Pointer, false, true);
		}

		// Token: 0x06024858 RID: 149592 RVA: 0x00361224 File Offset: 0x0035F424
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessCopy(Pointer, MemoryOwner);
		}

		// Token: 0x040139F6 RID: 80374
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessCopy";

		// Token: 0x040139F7 RID: 80375
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040139F8 RID: 80376
		internal static int __PropertyOffset_AccessIndex;

		// Token: 0x040139F9 RID: 80377
		internal static int __PropertyOffset_DestAccessStartIndex;

		// Token: 0x040139FA RID: 80378
		internal static int __PropertyOffset_DestAccessEndIndex;

		// Token: 0x040139FB RID: 80379
		internal static int __PropertyOffset_Type;
	}
}

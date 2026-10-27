using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001187 RID: 4487
	[UnrealObjectPath("/Script/Engine.StatColorMapEntry")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FStatColorMapEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107DB RID: 67547 RVA: 0x001837DB File Offset: 0x001819DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStatColorMapEntry._ScriptStructPtr != 0) ? FStatColorMapEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StatColorMapEntry", ref FStatColorMapEntry._ScriptStructPtr);
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x060107DC RID: 67548 RVA: 0x001837FF File Offset: 0x001819FF
		// (set) Token: 0x060107DD RID: 67549 RVA: 0x0018380F File Offset: 0x00181A0F
		public unsafe float In
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStatColorMapEntry.__PropertyOffset_In);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStatColorMapEntry.__PropertyOffset_In) = value;
			}
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x060107DE RID: 67550 RVA: 0x00183820 File Offset: 0x00181A20
		// (set) Token: 0x060107DF RID: 67551 RVA: 0x00183834 File Offset: 0x00181A34
		public unsafe FColor Out
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStatColorMapEntry.__PropertyOffset_Out);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStatColorMapEntry.__PropertyOffset_Out) = value;
			}
		}

		// Token: 0x060107E0 RID: 67552 RVA: 0x00183849 File Offset: 0x00181A49
		public FStatColorMapEntry()
		{
		}

		// Token: 0x060107E1 RID: 67553 RVA: 0x00183851 File Offset: 0x00181A51
		public FStatColorMapEntry(float In, FColor Out)
		{
			this.In = In;
			this.Out = Out;
		}

		// Token: 0x060107E2 RID: 67554 RVA: 0x00183867 File Offset: 0x00181A67
		protected override IntPtr GetUStructPtr()
		{
			return FStatColorMapEntry.StaticStruct();
		}

		// Token: 0x060107E3 RID: 67555 RVA: 0x00183873 File Offset: 0x00181A73
		[NullableContext(2)]
		public FStatColorMapEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060107E4 RID: 67556 RVA: 0x0018387D File Offset: 0x00181A7D
		public FStatColorMapEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060107E5 RID: 67557 RVA: 0x00183888 File Offset: 0x00181A88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStatColorMapEntry(Pointer, false, true);
		}

		// Token: 0x060107E6 RID: 67558 RVA: 0x00183892 File Offset: 0x00181A92
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStatColorMapEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04008D25 RID: 36133
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StatColorMapEntry";

		// Token: 0x04008D26 RID: 36134
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D27 RID: 36135
		internal static int __PropertyOffset_In;

		// Token: 0x04008D28 RID: 36136
		internal static int __PropertyOffset_Out;
	}
}

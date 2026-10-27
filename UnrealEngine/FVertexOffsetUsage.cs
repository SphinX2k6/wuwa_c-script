using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200122A RID: 4650
	[UnrealObjectPath("/Script/Engine.VertexOffsetUsage")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FVertexOffsetUsage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060111BB RID: 70075 RVA: 0x00191A43 File Offset: 0x0018FC43
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVertexOffsetUsage._ScriptStructPtr != 0) ? FVertexOffsetUsage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VertexOffsetUsage", ref FVertexOffsetUsage._ScriptStructPtr);
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x060111BC RID: 70076 RVA: 0x00191A67 File Offset: 0x0018FC67
		// (set) Token: 0x060111BD RID: 70077 RVA: 0x00191A77 File Offset: 0x0018FC77
		public unsafe int Usage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVertexOffsetUsage.__PropertyOffset_Usage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVertexOffsetUsage.__PropertyOffset_Usage) = value;
			}
		}

		// Token: 0x060111BE RID: 70078 RVA: 0x00191A88 File Offset: 0x0018FC88
		public FVertexOffsetUsage()
		{
		}

		// Token: 0x060111BF RID: 70079 RVA: 0x00191A90 File Offset: 0x0018FC90
		public FVertexOffsetUsage(int Usage)
		{
			this.Usage = Usage;
		}

		// Token: 0x060111C0 RID: 70080 RVA: 0x00191A9F File Offset: 0x0018FC9F
		protected override IntPtr GetUStructPtr()
		{
			return FVertexOffsetUsage.StaticStruct();
		}

		// Token: 0x060111C1 RID: 70081 RVA: 0x00191AAB File Offset: 0x0018FCAB
		[NullableContext(2)]
		public FVertexOffsetUsage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111C2 RID: 70082 RVA: 0x00191AB5 File Offset: 0x0018FCB5
		public FVertexOffsetUsage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111C3 RID: 70083 RVA: 0x00191AC0 File Offset: 0x0018FCC0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVertexOffsetUsage(Pointer, false, true);
		}

		// Token: 0x060111C4 RID: 70084 RVA: 0x00191ACA File Offset: 0x0018FCCA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVertexOffsetUsage(Pointer, MemoryOwner);
		}

		// Token: 0x04009286 RID: 37510
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VertexOffsetUsage";

		// Token: 0x04009287 RID: 37511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009288 RID: 37512
		internal static int __PropertyOffset_Usage;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022B8 RID: 8888
	[UnrealObjectPath("/Script/MeshBlend.GridCell")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGridCell : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C4A RID: 138314 RVA: 0x0031ECBC File Offset: 0x0031CEBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGridCell._ScriptStructPtr != 0) ? FGridCell._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.GridCell", ref FGridCell._ScriptStructPtr);
		}

		// Token: 0x06021C4B RID: 138315 RVA: 0x0031ECE0 File Offset: 0x0031CEE0
		public FGridCell()
		{
		}

		// Token: 0x06021C4C RID: 138316 RVA: 0x0031ECE8 File Offset: 0x0031CEE8
		protected override IntPtr GetUStructPtr()
		{
			return FGridCell.StaticStruct();
		}

		// Token: 0x06021C4D RID: 138317 RVA: 0x0031ECF4 File Offset: 0x0031CEF4
		[NullableContext(2)]
		public FGridCell(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C4E RID: 138318 RVA: 0x0031ECFE File Offset: 0x0031CEFE
		public FGridCell(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C4F RID: 138319 RVA: 0x0031ED09 File Offset: 0x0031CF09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGridCell(Pointer, false, true);
		}

		// Token: 0x06021C50 RID: 138320 RVA: 0x0031ED13 File Offset: 0x0031CF13
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGridCell(Pointer, MemoryOwner);
		}

		// Token: 0x04012052 RID: 73810
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.GridCell";

		// Token: 0x04012053 RID: 73811
		private static IntPtr _ScriptStructPtr;
	}
}

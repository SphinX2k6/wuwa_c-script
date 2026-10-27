using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200265E RID: 9822
	[UnrealObjectPath("/Script/ProceduralMeshComponent.ProcMeshTangent")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FProcMeshTangent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602481C RID: 149532 RVA: 0x00360D69 File Offset: 0x0035EF69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProcMeshTangent._ScriptStructPtr != 0) ? FProcMeshTangent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ProceduralMeshComponent.ProcMeshTangent", ref FProcMeshTangent._ScriptStructPtr);
		}

		// Token: 0x17008CB1 RID: 36017
		// (get) Token: 0x0602481D RID: 149533 RVA: 0x00360D8D File Offset: 0x0035EF8D
		// (set) Token: 0x0602481E RID: 149534 RVA: 0x00360DA1 File Offset: 0x0035EFA1
		public unsafe FVector TangentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshTangent.__PropertyOffset_TangentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshTangent.__PropertyOffset_TangentX) = value;
			}
		}

		// Token: 0x17008CB2 RID: 36018
		// (get) Token: 0x0602481F RID: 149535 RVA: 0x00360DB6 File Offset: 0x0035EFB6
		// (set) Token: 0x06024820 RID: 149536 RVA: 0x00360DC6 File Offset: 0x0035EFC6
		public unsafe bool bFlipTangentY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshTangent.__PropertyOffset_bFlipTangentY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshTangent.__PropertyOffset_bFlipTangentY) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024821 RID: 149537 RVA: 0x00360DD7 File Offset: 0x0035EFD7
		public FProcMeshTangent()
		{
		}

		// Token: 0x06024822 RID: 149538 RVA: 0x00360DDF File Offset: 0x0035EFDF
		public FProcMeshTangent(FVector TangentX, bool bFlipTangentY)
		{
			this.TangentX = TangentX;
			this.bFlipTangentY = bFlipTangentY;
		}

		// Token: 0x06024823 RID: 149539 RVA: 0x00360DF5 File Offset: 0x0035EFF5
		protected override IntPtr GetUStructPtr()
		{
			return FProcMeshTangent.StaticStruct();
		}

		// Token: 0x06024824 RID: 149540 RVA: 0x00360E01 File Offset: 0x0035F001
		[NullableContext(2)]
		public FProcMeshTangent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024825 RID: 149541 RVA: 0x00360E0B File Offset: 0x0035F00B
		public FProcMeshTangent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024826 RID: 149542 RVA: 0x00360E16 File Offset: 0x0035F016
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProcMeshTangent(Pointer, false, true);
		}

		// Token: 0x06024827 RID: 149543 RVA: 0x00360E20 File Offset: 0x0035F020
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProcMeshTangent(Pointer, MemoryOwner);
		}

		// Token: 0x040139C2 RID: 80322
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ProceduralMeshComponent.ProcMeshTangent";

		// Token: 0x040139C3 RID: 80323
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040139C4 RID: 80324
		internal static int __PropertyOffset_TangentX;

		// Token: 0x040139C5 RID: 80325
		internal static int __PropertyOffset_bFlipTangentY;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C1 RID: 8897
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendPCGHelper")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMeshBlendPCGHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CB8 RID: 138424 RVA: 0x0031F53D File Offset: 0x0031D73D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendPCGHelper._ScriptStructPtr != 0) ? FMeshBlendPCGHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendPCGHelper", ref FMeshBlendPCGHelper._ScriptStructPtr);
		}

		// Token: 0x06021CB9 RID: 138425 RVA: 0x0031F561 File Offset: 0x0031D761
		public FMeshBlendPCGHelper()
		{
		}

		// Token: 0x06021CBA RID: 138426 RVA: 0x0031F569 File Offset: 0x0031D769
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendPCGHelper.StaticStruct();
		}

		// Token: 0x06021CBB RID: 138427 RVA: 0x0031F575 File Offset: 0x0031D775
		[NullableContext(2)]
		public FMeshBlendPCGHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CBC RID: 138428 RVA: 0x0031F57F File Offset: 0x0031D77F
		public FMeshBlendPCGHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CBD RID: 138429 RVA: 0x0031F58A File Offset: 0x0031D78A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendPCGHelper(Pointer, false, true);
		}

		// Token: 0x06021CBE RID: 138430 RVA: 0x0031F594 File Offset: 0x0031D794
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendPCGHelper(Pointer, MemoryOwner);
		}

		// Token: 0x0401207F RID: 73855
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendPCGHelper";

		// Token: 0x04012080 RID: 73856
		private static IntPtr _ScriptStructPtr;
	}
}

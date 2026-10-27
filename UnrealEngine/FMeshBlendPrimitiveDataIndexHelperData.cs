using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022C4 RID: 8900
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelperData")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMeshBlendPrimitiveDataIndexHelperData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021CD5 RID: 138453 RVA: 0x0031F77B File Offset: 0x0031D97B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendPrimitiveDataIndexHelperData._ScriptStructPtr != 0) ? FMeshBlendPrimitiveDataIndexHelperData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelperData", ref FMeshBlendPrimitiveDataIndexHelperData._ScriptStructPtr);
		}

		// Token: 0x17008312 RID: 33554
		// (get) Token: 0x06021CD6 RID: 138454 RVA: 0x0031F79F File Offset: 0x0031D99F
		// (set) Token: 0x06021CD7 RID: 138455 RVA: 0x0031F7AF File Offset: 0x0031D9AF
		public unsafe int PrimitiveDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendPrimitiveDataIndexHelperData.__PropertyOffset_PrimitiveDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendPrimitiveDataIndexHelperData.__PropertyOffset_PrimitiveDataIndex) = value;
			}
		}

		// Token: 0x06021CD8 RID: 138456 RVA: 0x0031F7C0 File Offset: 0x0031D9C0
		public FMeshBlendPrimitiveDataIndexHelperData()
		{
		}

		// Token: 0x06021CD9 RID: 138457 RVA: 0x0031F7C8 File Offset: 0x0031D9C8
		public FMeshBlendPrimitiveDataIndexHelperData(int PrimitiveDataIndex, bool bIsOnlyStaticBlends)
		{
			this.PrimitiveDataIndex = PrimitiveDataIndex;
		}

		// Token: 0x06021CDA RID: 138458 RVA: 0x0031F7D7 File Offset: 0x0031D9D7
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendPrimitiveDataIndexHelperData.StaticStruct();
		}

		// Token: 0x06021CDB RID: 138459 RVA: 0x0031F7E3 File Offset: 0x0031D9E3
		[NullableContext(2)]
		public FMeshBlendPrimitiveDataIndexHelperData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021CDC RID: 138460 RVA: 0x0031F7ED File Offset: 0x0031D9ED
		public FMeshBlendPrimitiveDataIndexHelperData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CDD RID: 138461 RVA: 0x0031F7F8 File Offset: 0x0031D9F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendPrimitiveDataIndexHelperData(Pointer, false, true);
		}

		// Token: 0x06021CDE RID: 138462 RVA: 0x0031F802 File Offset: 0x0031DA02
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendPrimitiveDataIndexHelperData(Pointer, MemoryOwner);
		}

		// Token: 0x0401208B RID: 73867
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendPrimitiveDataIndexHelperData";

		// Token: 0x0401208C RID: 73868
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401208D RID: 73869
		internal static int __PropertyOffset_PrimitiveDataIndex;
	}
}

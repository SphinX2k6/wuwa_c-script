using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F66 RID: 8038
	[UnrealObjectPath("/Script/Landscape.GizmoSelectData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FGizmoSelectData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E7AD RID: 124845 RVA: 0x002D4E17 File Offset: 0x002D3017
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGizmoSelectData._ScriptStructPtr != 0) ? FGizmoSelectData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.GizmoSelectData", ref FGizmoSelectData._ScriptStructPtr);
		}

		// Token: 0x0601E7AE RID: 124846 RVA: 0x002D4E3B File Offset: 0x002D303B
		public FGizmoSelectData()
		{
		}

		// Token: 0x0601E7AF RID: 124847 RVA: 0x002D4E43 File Offset: 0x002D3043
		public FGizmoSelectData(float Ratio, float HeightData)
		{
		}

		// Token: 0x0601E7B0 RID: 124848 RVA: 0x002D4E4B File Offset: 0x002D304B
		protected override IntPtr GetUStructPtr()
		{
			return FGizmoSelectData.StaticStruct();
		}

		// Token: 0x0601E7B1 RID: 124849 RVA: 0x002D4E57 File Offset: 0x002D3057
		[NullableContext(2)]
		public FGizmoSelectData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7B2 RID: 124850 RVA: 0x002D4E61 File Offset: 0x002D3061
		public FGizmoSelectData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7B3 RID: 124851 RVA: 0x002D4E6C File Offset: 0x002D306C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGizmoSelectData(Pointer, false, true);
		}

		// Token: 0x0601E7B4 RID: 124852 RVA: 0x002D4E76 File Offset: 0x002D3076
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGizmoSelectData(Pointer, MemoryOwner);
		}

		// Token: 0x04010791 RID: 67473
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.GizmoSelectData";

		// Token: 0x04010792 RID: 67474
		private static IntPtr _ScriptStructPtr;
	}
}

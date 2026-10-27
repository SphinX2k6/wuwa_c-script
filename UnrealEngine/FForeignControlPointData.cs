using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F63 RID: 8035
	[UnrealObjectPath("/Script/Landscape.ForeignControlPointData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FForeignControlPointData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E795 RID: 124821 RVA: 0x002D4CDF File Offset: 0x002D2EDF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForeignControlPointData._ScriptStructPtr != 0) ? FForeignControlPointData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.ForeignControlPointData", ref FForeignControlPointData._ScriptStructPtr);
		}

		// Token: 0x0601E796 RID: 124822 RVA: 0x002D4D03 File Offset: 0x002D2F03
		public FForeignControlPointData()
		{
		}

		// Token: 0x0601E797 RID: 124823 RVA: 0x002D4D0B File Offset: 0x002D2F0B
		[NullableContext(1)]
		public FForeignControlPointData(FGuid ModificationKey, UControlPointMeshComponent MeshComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<ULandscapeSplineControlPoint> Identifier)
		{
		}

		// Token: 0x0601E798 RID: 124824 RVA: 0x002D4D13 File Offset: 0x002D2F13
		protected override IntPtr GetUStructPtr()
		{
			return FForeignControlPointData.StaticStruct();
		}

		// Token: 0x0601E799 RID: 124825 RVA: 0x002D4D1F File Offset: 0x002D2F1F
		[NullableContext(2)]
		public FForeignControlPointData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E79A RID: 124826 RVA: 0x002D4D29 File Offset: 0x002D2F29
		public FForeignControlPointData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E79B RID: 124827 RVA: 0x002D4D34 File Offset: 0x002D2F34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForeignControlPointData(Pointer, false, true);
		}

		// Token: 0x0601E79C RID: 124828 RVA: 0x002D4D3E File Offset: 0x002D2F3E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForeignControlPointData(Pointer, MemoryOwner);
		}

		// Token: 0x0401078B RID: 67467
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.ForeignControlPointData";

		// Token: 0x0401078C RID: 67468
		private static IntPtr _ScriptStructPtr;
	}
}

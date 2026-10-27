using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F64 RID: 8036
	[UnrealObjectPath("/Script/Landscape.ForeignSplineSegmentData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FForeignSplineSegmentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E79D RID: 124829 RVA: 0x002D4D47 File Offset: 0x002D2F47
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForeignSplineSegmentData._ScriptStructPtr != 0) ? FForeignSplineSegmentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.ForeignSplineSegmentData", ref FForeignSplineSegmentData._ScriptStructPtr);
		}

		// Token: 0x0601E79E RID: 124830 RVA: 0x002D4D6B File Offset: 0x002D2F6B
		public FForeignSplineSegmentData()
		{
		}

		// Token: 0x0601E79F RID: 124831 RVA: 0x002D4D73 File Offset: 0x002D2F73
		[NullableContext(1)]
		public FForeignSplineSegmentData(FGuid ModificationKey, TArray<USplineMeshComponent> MeshComponents, [Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<ULandscapeSplineSegment> Identifier)
		{
		}

		// Token: 0x0601E7A0 RID: 124832 RVA: 0x002D4D7B File Offset: 0x002D2F7B
		protected override IntPtr GetUStructPtr()
		{
			return FForeignSplineSegmentData.StaticStruct();
		}

		// Token: 0x0601E7A1 RID: 124833 RVA: 0x002D4D87 File Offset: 0x002D2F87
		[NullableContext(2)]
		public FForeignSplineSegmentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7A2 RID: 124834 RVA: 0x002D4D91 File Offset: 0x002D2F91
		public FForeignSplineSegmentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7A3 RID: 124835 RVA: 0x002D4D9C File Offset: 0x002D2F9C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForeignSplineSegmentData(Pointer, false, true);
		}

		// Token: 0x0601E7A4 RID: 124836 RVA: 0x002D4DA6 File Offset: 0x002D2FA6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForeignSplineSegmentData(Pointer, MemoryOwner);
		}

		// Token: 0x0401078D RID: 67469
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.ForeignSplineSegmentData";

		// Token: 0x0401078E RID: 67470
		private static IntPtr _ScriptStructPtr;
	}
}

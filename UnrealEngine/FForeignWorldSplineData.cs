using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F65 RID: 8037
	[UnrealObjectPath("/Script/Landscape.ForeignWorldSplineData")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FForeignWorldSplineData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E7A5 RID: 124837 RVA: 0x002D4DAF File Offset: 0x002D2FAF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForeignWorldSplineData._ScriptStructPtr != 0) ? FForeignWorldSplineData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.ForeignWorldSplineData", ref FForeignWorldSplineData._ScriptStructPtr);
		}

		// Token: 0x0601E7A6 RID: 124838 RVA: 0x002D4DD3 File Offset: 0x002D2FD3
		public FForeignWorldSplineData()
		{
		}

		// Token: 0x0601E7A7 RID: 124839 RVA: 0x002D4DDB File Offset: 0x002D2FDB
		[NullableContext(1)]
		public FForeignWorldSplineData([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TLazyObjectPtr<ULandscapeSplineControlPoint>, FForeignControlPointData> ForeignControlPointDataMap_DEPRECATED, TArray<FForeignControlPointData> ForeignControlPointData, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TLazyObjectPtr<ULandscapeSplineSegment>, FForeignSplineSegmentData> ForeignSplineSegmentDataMap_DEPRECATED, TArray<FForeignSplineSegmentData> ForeignSplineSegmentData)
		{
		}

		// Token: 0x0601E7A8 RID: 124840 RVA: 0x002D4DE3 File Offset: 0x002D2FE3
		protected override IntPtr GetUStructPtr()
		{
			return FForeignWorldSplineData.StaticStruct();
		}

		// Token: 0x0601E7A9 RID: 124841 RVA: 0x002D4DEF File Offset: 0x002D2FEF
		[NullableContext(2)]
		public FForeignWorldSplineData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7AA RID: 124842 RVA: 0x002D4DF9 File Offset: 0x002D2FF9
		public FForeignWorldSplineData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7AB RID: 124843 RVA: 0x002D4E04 File Offset: 0x002D3004
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForeignWorldSplineData(Pointer, false, true);
		}

		// Token: 0x0601E7AC RID: 124844 RVA: 0x002D4E0E File Offset: 0x002D300E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForeignWorldSplineData(Pointer, MemoryOwner);
		}

		// Token: 0x0401078F RID: 67471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.ForeignWorldSplineData";

		// Token: 0x04010790 RID: 67472
		private static IntPtr _ScriptStructPtr;
	}
}

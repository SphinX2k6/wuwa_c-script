using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001430 RID: 5168
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionRepData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGeometryCollectionRepData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012E8C RID: 77452 RVA: 0x001BCB78 File Offset: 0x001BAD78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCollectionRepData._ScriptStructPtr != 0) ? FGeometryCollectionRepData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeometryCollectionRepData", ref FGeometryCollectionRepData._ScriptStructPtr);
		}

		// Token: 0x06012E8D RID: 77453 RVA: 0x001BCB9C File Offset: 0x001BAD9C
		public FGeometryCollectionRepData()
		{
		}

		// Token: 0x06012E8E RID: 77454 RVA: 0x001BCBA4 File Offset: 0x001BADA4
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCollectionRepData.StaticStruct();
		}

		// Token: 0x06012E8F RID: 77455 RVA: 0x001BCBB0 File Offset: 0x001BADB0
		[NullableContext(2)]
		public FGeometryCollectionRepData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012E90 RID: 77456 RVA: 0x001BCBBA File Offset: 0x001BADBA
		public FGeometryCollectionRepData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012E91 RID: 77457 RVA: 0x001BCBC5 File Offset: 0x001BADC5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCollectionRepData(Pointer, false, true);
		}

		// Token: 0x06012E92 RID: 77458 RVA: 0x001BCBCF File Offset: 0x001BADCF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCollectionRepData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A1AA RID: 41386
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionRepData";

		// Token: 0x0400A1AB RID: 41387
		private static IntPtr _ScriptStructPtr;
	}
}

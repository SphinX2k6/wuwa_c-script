using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001413 RID: 5139
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheMeshData")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FGeometryCacheMeshData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C2A RID: 76842 RVA: 0x001B9B39 File Offset: 0x001B7D39
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCacheMeshData._ScriptStructPtr != 0) ? FGeometryCacheMeshData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCache.GeometryCacheMeshData", ref FGeometryCacheMeshData._ScriptStructPtr);
		}

		// Token: 0x06012C2B RID: 76843 RVA: 0x001B9B5D File Offset: 0x001B7D5D
		public FGeometryCacheMeshData()
		{
		}

		// Token: 0x06012C2C RID: 76844 RVA: 0x001B9B65 File Offset: 0x001B7D65
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCacheMeshData.StaticStruct();
		}

		// Token: 0x06012C2D RID: 76845 RVA: 0x001B9B71 File Offset: 0x001B7D71
		[NullableContext(2)]
		public FGeometryCacheMeshData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012C2E RID: 76846 RVA: 0x001B9B7B File Offset: 0x001B7D7B
		public FGeometryCacheMeshData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012C2F RID: 76847 RVA: 0x001B9B86 File Offset: 0x001B7D86
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCacheMeshData(Pointer, false, true);
		}

		// Token: 0x06012C30 RID: 76848 RVA: 0x001B9B90 File Offset: 0x001B7D90
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCacheMeshData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A068 RID: 41064
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCache.GeometryCacheMeshData";

		// Token: 0x0400A069 RID: 41065
		private static IntPtr _ScriptStructPtr;
	}
}

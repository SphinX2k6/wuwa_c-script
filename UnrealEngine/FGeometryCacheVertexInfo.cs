using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001419 RID: 5145
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheVertexInfo")]
	[UnrealStructLayout(9, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class FGeometryCacheVertexInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C60 RID: 76896 RVA: 0x001B9F97 File Offset: 0x001B8197
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCacheVertexInfo._ScriptStructPtr != 0) ? FGeometryCacheVertexInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCache.GeometryCacheVertexInfo", ref FGeometryCacheVertexInfo._ScriptStructPtr);
		}

		// Token: 0x06012C61 RID: 76897 RVA: 0x001B9FBB File Offset: 0x001B81BB
		public FGeometryCacheVertexInfo()
		{
		}

		// Token: 0x06012C62 RID: 76898 RVA: 0x001B9FC3 File Offset: 0x001B81C3
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCacheVertexInfo.StaticStruct();
		}

		// Token: 0x06012C63 RID: 76899 RVA: 0x001B9FCF File Offset: 0x001B81CF
		[NullableContext(2)]
		public FGeometryCacheVertexInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012C64 RID: 76900 RVA: 0x001B9FD9 File Offset: 0x001B81D9
		public FGeometryCacheVertexInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012C65 RID: 76901 RVA: 0x001B9FE4 File Offset: 0x001B81E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCacheVertexInfo(Pointer, false, true);
		}

		// Token: 0x06012C66 RID: 76902 RVA: 0x001B9FEE File Offset: 0x001B81EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCacheVertexInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A081 RID: 41089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCache.GeometryCacheVertexInfo";

		// Token: 0x0400A082 RID: 41090
		private static IntPtr _ScriptStructPtr;
	}
}

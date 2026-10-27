using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200141A RID: 5146
	[UnrealObjectPath("/Script/GeometryCache.TrackRenderData")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FTrackRenderData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C67 RID: 76903 RVA: 0x001B9FF7 File Offset: 0x001B81F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrackRenderData._ScriptStructPtr != 0) ? FTrackRenderData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCache.TrackRenderData", ref FTrackRenderData._ScriptStructPtr);
		}

		// Token: 0x06012C68 RID: 76904 RVA: 0x001BA01B File Offset: 0x001B821B
		public FTrackRenderData()
		{
		}

		// Token: 0x06012C69 RID: 76905 RVA: 0x001BA023 File Offset: 0x001B8223
		protected override IntPtr GetUStructPtr()
		{
			return FTrackRenderData.StaticStruct();
		}

		// Token: 0x06012C6A RID: 76906 RVA: 0x001BA02F File Offset: 0x001B822F
		[NullableContext(2)]
		public FTrackRenderData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012C6B RID: 76907 RVA: 0x001BA039 File Offset: 0x001B8239
		public FTrackRenderData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012C6C RID: 76908 RVA: 0x001BA044 File Offset: 0x001B8244
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrackRenderData(Pointer, false, true);
		}

		// Token: 0x06012C6D RID: 76909 RVA: 0x001BA04E File Offset: 0x001B824E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrackRenderData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A083 RID: 41091
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCache.TrackRenderData";

		// Token: 0x0400A084 RID: 41092
		private static IntPtr _ScriptStructPtr;
	}
}

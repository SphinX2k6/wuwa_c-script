using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001507 RID: 5383
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniVolumeInfo")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FHoudiniVolumeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601394C RID: 80204 RVA: 0x001CC3AC File Offset: 0x001CA5AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniVolumeInfo._ScriptStructPtr != 0) ? FHoudiniVolumeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniVolumeInfo", ref FHoudiniVolumeInfo._ScriptStructPtr);
		}

		// Token: 0x0601394D RID: 80205 RVA: 0x001CC3D0 File Offset: 0x001CA5D0
		public FHoudiniVolumeInfo()
		{
		}

		// Token: 0x0601394E RID: 80206 RVA: 0x001CC3D8 File Offset: 0x001CA5D8
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniVolumeInfo.StaticStruct();
		}

		// Token: 0x0601394F RID: 80207 RVA: 0x001CC3E4 File Offset: 0x001CA5E4
		[NullableContext(2)]
		public FHoudiniVolumeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013950 RID: 80208 RVA: 0x001CC3EE File Offset: 0x001CA5EE
		public FHoudiniVolumeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013951 RID: 80209 RVA: 0x001CC3F9 File Offset: 0x001CA5F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniVolumeInfo(Pointer, false, true);
		}

		// Token: 0x06013952 RID: 80210 RVA: 0x001CC403 File Offset: 0x001CA603
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniVolumeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A93E RID: 43326
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniVolumeInfo";

		// Token: 0x0400A93F RID: 43327
		private static IntPtr _ScriptStructPtr;
	}
}

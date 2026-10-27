using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000248 RID: 584
	[UnrealObjectPath("/Script/AkAudio.AkSurfaceEdgeVerts")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAkSurfaceEdgeVerts : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600228E RID: 8846 RVA: 0x00033393 File Offset: 0x00031593
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSurfaceEdgeVerts._ScriptStructPtr != 0) ? FAkSurfaceEdgeVerts._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSurfaceEdgeVerts", ref FAkSurfaceEdgeVerts._ScriptStructPtr);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000333B7 File Offset: 0x000315B7
		public FAkSurfaceEdgeVerts()
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000333BF File Offset: 0x000315BF
		protected override IntPtr GetUStructPtr()
		{
			return FAkSurfaceEdgeVerts.StaticStruct();
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000333CB File Offset: 0x000315CB
		[NullableContext(2)]
		public FAkSurfaceEdgeVerts(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000333D5 File Offset: 0x000315D5
		public FAkSurfaceEdgeVerts(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000333E0 File Offset: 0x000315E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSurfaceEdgeVerts(Pointer, false, true);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000333EA File Offset: 0x000315EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSurfaceEdgeVerts(Pointer, MemoryOwner);
		}

		// Token: 0x04000BEC RID: 3052
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSurfaceEdgeVerts";

		// Token: 0x04000BED RID: 3053
		private static IntPtr _ScriptStructPtr;
	}
}

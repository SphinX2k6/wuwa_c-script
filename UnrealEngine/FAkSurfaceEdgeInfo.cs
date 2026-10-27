using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000247 RID: 583
	[UnrealObjectPath("/Script/AkAudio.AkSurfaceEdgeInfo")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAkSurfaceEdgeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002287 RID: 8839 RVA: 0x00033333 File Offset: 0x00031533
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSurfaceEdgeInfo._ScriptStructPtr != 0) ? FAkSurfaceEdgeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSurfaceEdgeInfo", ref FAkSurfaceEdgeInfo._ScriptStructPtr);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00033357 File Offset: 0x00031557
		public FAkSurfaceEdgeInfo()
		{
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x0003335F File Offset: 0x0003155F
		protected override IntPtr GetUStructPtr()
		{
			return FAkSurfaceEdgeInfo.StaticStruct();
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0003336B File Offset: 0x0003156B
		[NullableContext(2)]
		public FAkSurfaceEdgeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00033375 File Offset: 0x00031575
		public FAkSurfaceEdgeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00033380 File Offset: 0x00031580
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSurfaceEdgeInfo(Pointer, false, true);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0003338A File Offset: 0x0003158A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSurfaceEdgeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000BEA RID: 3050
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSurfaceEdgeInfo";

		// Token: 0x04000BEB RID: 3051
		private static IntPtr _ScriptStructPtr;
	}
}

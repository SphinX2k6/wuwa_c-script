using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AB4 RID: 6836
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdManagerRayResult")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FKuroBirdManagerRayResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060195F0 RID: 103920 RVA: 0x00257D12 File Offset: 0x00255F12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBirdManagerRayResult._ScriptStructPtr != 0) ? FKuroBirdManagerRayResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdManagerRayResult", ref FKuroBirdManagerRayResult._ScriptStructPtr);
		}

		// Token: 0x060195F1 RID: 103921 RVA: 0x00257D36 File Offset: 0x00255F36
		public FKuroBirdManagerRayResult()
		{
		}

		// Token: 0x060195F2 RID: 103922 RVA: 0x00257D3E File Offset: 0x00255F3E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBirdManagerRayResult.StaticStruct();
		}

		// Token: 0x060195F3 RID: 103923 RVA: 0x00257D4A File Offset: 0x00255F4A
		[NullableContext(2)]
		public FKuroBirdManagerRayResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060195F4 RID: 103924 RVA: 0x00257D54 File Offset: 0x00255F54
		public FKuroBirdManagerRayResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060195F5 RID: 103925 RVA: 0x00257D5F File Offset: 0x00255F5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBirdManagerRayResult(Pointer, false, true);
		}

		// Token: 0x060195F6 RID: 103926 RVA: 0x00257D69 File Offset: 0x00255F69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBirdManagerRayResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400DD37 RID: 56631
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdManagerRayResult";

		// Token: 0x0400DD38 RID: 56632
		private static IntPtr _ScriptStructPtr;
	}
}

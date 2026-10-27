using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D11 RID: 3345
	[UnrealObjectPath("/Script/Engine.KuroStaticMeshStreamingLog")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroStaticMeshStreamingLog : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B2F2 RID: 45810 RVA: 0x000FEE50 File Offset: 0x000FD050
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStaticMeshStreamingLog._ScriptStructPtr != 0) ? FKuroStaticMeshStreamingLog._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroStaticMeshStreamingLog", ref FKuroStaticMeshStreamingLog._ScriptStructPtr);
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x000FEE74 File Offset: 0x000FD074
		public FKuroStaticMeshStreamingLog()
		{
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x000FEE7C File Offset: 0x000FD07C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStaticMeshStreamingLog.StaticStruct();
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x000FEE88 File Offset: 0x000FD088
		[NullableContext(2)]
		public FKuroStaticMeshStreamingLog(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x000FEE92 File Offset: 0x000FD092
		public FKuroStaticMeshStreamingLog(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x000FEE9D File Offset: 0x000FD09D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStaticMeshStreamingLog(Pointer, false, true);
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x000FEEA7 File Offset: 0x000FD0A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStaticMeshStreamingLog(Pointer, MemoryOwner);
		}

		// Token: 0x04005DF5 RID: 24053
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroStaticMeshStreamingLog";

		// Token: 0x04005DF6 RID: 24054
		private static IntPtr _ScriptStructPtr;
	}
}

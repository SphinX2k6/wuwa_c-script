using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D10 RID: 3344
	[UnrealObjectPath("/Script/Engine.KuroStaticMeshStreamingActorInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroStaticMeshStreamingActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B2EB RID: 45803 RVA: 0x000FEDF0 File Offset: 0x000FCFF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStaticMeshStreamingActorInfo._ScriptStructPtr != 0) ? FKuroStaticMeshStreamingActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroStaticMeshStreamingActorInfo", ref FKuroStaticMeshStreamingActorInfo._ScriptStructPtr);
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x000FEE14 File Offset: 0x000FD014
		public FKuroStaticMeshStreamingActorInfo()
		{
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x000FEE1C File Offset: 0x000FD01C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStaticMeshStreamingActorInfo.StaticStruct();
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x000FEE28 File Offset: 0x000FD028
		[NullableContext(2)]
		public FKuroStaticMeshStreamingActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x000FEE32 File Offset: 0x000FD032
		public FKuroStaticMeshStreamingActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x000FEE3D File Offset: 0x000FD03D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStaticMeshStreamingActorInfo(Pointer, false, true);
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x000FEE47 File Offset: 0x000FD047
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStaticMeshStreamingActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005DF3 RID: 24051
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroStaticMeshStreamingActorInfo";

		// Token: 0x04005DF4 RID: 24052
		private static IntPtr _ScriptStructPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A2D RID: 6701
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudInstanceQueryResult")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroPointCloudInstanceQueryResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018CCC RID: 101580 RVA: 0x0024A5B9 File Offset: 0x002487B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudInstanceQueryResult._ScriptStructPtr != 0) ? FKuroPointCloudInstanceQueryResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudInstanceQueryResult", ref FKuroPointCloudInstanceQueryResult._ScriptStructPtr);
		}

		// Token: 0x06018CCD RID: 101581 RVA: 0x0024A5DD File Offset: 0x002487DD
		public FKuroPointCloudInstanceQueryResult()
		{
		}

		// Token: 0x06018CCE RID: 101582 RVA: 0x0024A5E5 File Offset: 0x002487E5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudInstanceQueryResult.StaticStruct();
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x0024A5F1 File Offset: 0x002487F1
		[NullableContext(2)]
		public FKuroPointCloudInstanceQueryResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x0024A5FB File Offset: 0x002487FB
		public FKuroPointCloudInstanceQueryResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x0024A606 File Offset: 0x00248806
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudInstanceQueryResult(Pointer, false, true);
		}

		// Token: 0x06018CD2 RID: 101586 RVA: 0x0024A610 File Offset: 0x00248810
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudInstanceQueryResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400D683 RID: 54915
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudInstanceQueryResult";

		// Token: 0x0400D684 RID: 54916
		private static IntPtr _ScriptStructPtr;
	}
}

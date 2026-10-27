using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED1 RID: 3793
	[UnrealObjectPath("/Script/Engine.NavAvoidanceData")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNavAvoidanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CD4F RID: 52559 RVA: 0x0012B14D File Offset: 0x0012934D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavAvoidanceData._ScriptStructPtr != 0) ? FNavAvoidanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavAvoidanceData", ref FNavAvoidanceData._ScriptStructPtr);
		}

		// Token: 0x0600CD50 RID: 52560 RVA: 0x0012B171 File Offset: 0x00129371
		public FNavAvoidanceData()
		{
		}

		// Token: 0x0600CD51 RID: 52561 RVA: 0x0012B179 File Offset: 0x00129379
		protected override IntPtr GetUStructPtr()
		{
			return FNavAvoidanceData.StaticStruct();
		}

		// Token: 0x0600CD52 RID: 52562 RVA: 0x0012B185 File Offset: 0x00129385
		[NullableContext(2)]
		public FNavAvoidanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CD53 RID: 52563 RVA: 0x0012B18F File Offset: 0x0012938F
		public FNavAvoidanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD54 RID: 52564 RVA: 0x0012B19A File Offset: 0x0012939A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavAvoidanceData(Pointer, false, true);
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x0012B1A4 File Offset: 0x001293A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavAvoidanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04006E84 RID: 28292
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavAvoidanceData";

		// Token: 0x04006E85 RID: 28293
		private static IntPtr _ScriptStructPtr;
	}
}

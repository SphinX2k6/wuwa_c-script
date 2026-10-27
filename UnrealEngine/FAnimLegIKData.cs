using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002CB RID: 715
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimLegIKData")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FAnimLegIKData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600279F RID: 10143 RVA: 0x0003B615 File Offset: 0x00039815
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimLegIKData._ScriptStructPtr != 0) ? FAnimLegIKData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimLegIKData", ref FAnimLegIKData._ScriptStructPtr);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x0003B639 File Offset: 0x00039839
		public FAnimLegIKData()
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x0003B641 File Offset: 0x00039841
		protected override IntPtr GetUStructPtr()
		{
			return FAnimLegIKData.StaticStruct();
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0003B64D File Offset: 0x0003984D
		[NullableContext(2)]
		public FAnimLegIKData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0003B657 File Offset: 0x00039857
		public FAnimLegIKData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x0003B662 File Offset: 0x00039862
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimLegIKData(Pointer, false, true);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x0003B66C File Offset: 0x0003986C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimLegIKData(Pointer, MemoryOwner);
		}

		// Token: 0x04000FA0 RID: 4000
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AnimLegIKData";

		// Token: 0x04000FA1 RID: 4001
		private static IntPtr _ScriptStructPtr;
	}
}

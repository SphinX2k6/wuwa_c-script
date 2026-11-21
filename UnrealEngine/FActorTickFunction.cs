using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000173 RID: 371
	[UnrealObjectPath("/Script/Engine.ActorTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActorTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060016AD RID: 5805 RVA: 0x000236BA File Offset: 0x000218BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorTickFunction._ScriptStructPtr != 0) ? FActorTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorTickFunction", ref FActorTickFunction._ScriptStructPtr);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000236DE File Offset: 0x000218DE
		public FActorTickFunction()
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000236E6 File Offset: 0x000218E6
		protected override IntPtr GetUStructPtr()
		{
			return FActorTickFunction.StaticStruct();
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000236F2 File Offset: 0x000218F2
		[NullableContext(2)]
		public FActorTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x000236FC File Offset: 0x000218FC
		public FActorTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00023707 File Offset: 0x00021907
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorTickFunction(Pointer, false, true);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00023711 File Offset: 0x00021911
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04000737 RID: 1847
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorTickFunction";

		// Token: 0x04000738 RID: 1848
		private static IntPtr _ScriptStructPtr;
	}
}

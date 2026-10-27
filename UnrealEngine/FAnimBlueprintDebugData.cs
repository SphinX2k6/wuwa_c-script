using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007EC RID: 2028
	[UnrealObjectPath("/Script/Engine.AnimBlueprintDebugData")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 672)]
	public class FAnimBlueprintDebugData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C33 RID: 27699 RVA: 0x0009B990 File Offset: 0x00099B90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimBlueprintDebugData._ScriptStructPtr != 0) ? FAnimBlueprintDebugData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimBlueprintDebugData", ref FAnimBlueprintDebugData._ScriptStructPtr);
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x0009B9B4 File Offset: 0x00099BB4
		public FAnimBlueprintDebugData()
		{
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x0009B9BC File Offset: 0x00099BBC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimBlueprintDebugData.StaticStruct();
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x0009B9C8 File Offset: 0x00099BC8
		[NullableContext(2)]
		public FAnimBlueprintDebugData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0009B9D2 File Offset: 0x00099BD2
		public FAnimBlueprintDebugData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x0009B9DD File Offset: 0x00099BDD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimBlueprintDebugData(Pointer, false, true);
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x0009B9E7 File Offset: 0x00099BE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimBlueprintDebugData(Pointer, MemoryOwner);
		}

		// Token: 0x04003411 RID: 13329
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimBlueprintDebugData";

		// Token: 0x04003412 RID: 13330
		private static IntPtr _ScriptStructPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200083F RID: 2111
	[UnrealObjectPath("/Script/Engine.AnimSingleNodeInstanceProxy")]
	[UnrealStructLayout(2768, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2768)]
	public class FAnimSingleNodeInstanceProxy : FAnimInstanceProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060071CA RID: 29130 RVA: 0x000A3020 File Offset: 0x000A1220
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSingleNodeInstanceProxy._ScriptStructPtr != 0) ? FAnimSingleNodeInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSingleNodeInstanceProxy", ref FAnimSingleNodeInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x000A3044 File Offset: 0x000A1244
		public FAnimSingleNodeInstanceProxy()
		{
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x000A304C File Offset: 0x000A124C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSingleNodeInstanceProxy.StaticStruct();
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x000A3058 File Offset: 0x000A1258
		[NullableContext(2)]
		public FAnimSingleNodeInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x000A3062 File Offset: 0x000A1262
		public FAnimSingleNodeInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x000A306D File Offset: 0x000A126D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSingleNodeInstanceProxy(Pointer, false, true);
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x000A3077 File Offset: 0x000A1277
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSingleNodeInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x040036A9 RID: 13993
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimSingleNodeInstanceProxy";

		// Token: 0x040036AA RID: 13994
		private static IntPtr _ScriptStructPtr;
	}
}

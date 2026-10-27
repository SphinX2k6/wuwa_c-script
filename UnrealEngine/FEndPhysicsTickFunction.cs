using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000AEA RID: 2794
	[UnrealObjectPath("/Script/Engine.EndPhysicsTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FEndPhysicsTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600904A RID: 36938 RVA: 0x000CE83C File Offset: 0x000CCA3C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEndPhysicsTickFunction._ScriptStructPtr != 0) ? FEndPhysicsTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EndPhysicsTickFunction", ref FEndPhysicsTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x000CE860 File Offset: 0x000CCA60
		public FEndPhysicsTickFunction()
		{
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x000CE868 File Offset: 0x000CCA68
		public FEndPhysicsTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x000CE8A5 File Offset: 0x000CCAA5
		protected override IntPtr GetUStructPtr()
		{
			return FEndPhysicsTickFunction.StaticStruct();
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x000CE8B1 File Offset: 0x000CCAB1
		[NullableContext(2)]
		public FEndPhysicsTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x000CE8BB File Offset: 0x000CCABB
		public FEndPhysicsTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x000CE8C6 File Offset: 0x000CCAC6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEndPhysicsTickFunction(Pointer, false, true);
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x000CE8D0 File Offset: 0x000CCAD0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEndPhysicsTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04004B52 RID: 19282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EndPhysicsTickFunction";

		// Token: 0x04004B53 RID: 19283
		private static IntPtr _ScriptStructPtr;
	}
}

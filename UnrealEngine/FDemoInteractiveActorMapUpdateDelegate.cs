using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B9 RID: 1465
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FDemoInteractiveActorMapUpdateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600835B RID: 33627 RVA: 0x000C2692 File Offset: 0x000C0892
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDemoInteractiveActorMapUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x000C269E File Offset: 0x000C089E
		private static IntPtr StaticFunctionPtr()
		{
			if (FDemoInteractiveActorMapUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDemoInteractiveActorMapUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.DemoInteractiveActorMapUpdateDelegate__DelegateSignature");
			}
			return FDemoInteractiveActorMapUpdateDelegate._FunctionPtr;
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x000C26C1 File Offset: 0x000C08C1
		public FDemoInteractiveActorMapUpdateDelegate()
		{
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x000C26C9 File Offset: 0x000C08C9
		[NullableContext(2)]
		public FDemoInteractiveActorMapUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x000C26D3 File Offset: 0x000C08D3
		public FDemoInteractiveActorMapUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x000C26DE File Offset: 0x000C08DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x000C2710 File Offset: 0x000C0910
		[NullableContext(1)]
		public void Add(Action<FName> Callback)
		{
			if (FDemoInteractiveActorMapUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDemoInteractiveActorMapUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDemoInteractiveActorMapUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDemoInteractiveActorMapUpdateDelegate.OnScriptCallback));
				}
				FDemoInteractiveActorMapUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FDemoInteractiveActorMapUpdateDelegate.RegisterId);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x000C274A File Offset: 0x000C094A
		[NullableContext(1)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x000C2754 File Offset: 0x000C0954
		[SkipLocalsInit]
		public unsafe void Broadcast(FName ActorKey)
		{
			FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams* ptr = stackalloc FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDemoInteractiveActorMapUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x000C2790 File Offset: 0x000C0990
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x0400391F RID: 14623
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003920 RID: 14624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.DemoInteractiveActorMapUpdateDelegate__DelegateSignature";

		// Token: 0x04003921 RID: 14625
		private static int RegisterId;

		// Token: 0x02000D3D RID: 3389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FDemoInteractiveActorMapUpdateDelegate_DelegateParams
		{
			// Token: 0x04005FDA RID: 24538
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x02000D3E RID: 3390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FDB RID: 24539
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

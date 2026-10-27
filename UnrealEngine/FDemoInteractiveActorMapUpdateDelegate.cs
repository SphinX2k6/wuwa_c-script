using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E94 RID: 7828
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FDemoInteractiveActorMapUpdateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC5A RID: 121946 RVA: 0x002BFEC6 File Offset: 0x002BE0C6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDemoInteractiveActorMapUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC5B RID: 121947 RVA: 0x002BFED2 File Offset: 0x002BE0D2
		private static IntPtr StaticFunctionPtr()
		{
			if (FDemoInteractiveActorMapUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDemoInteractiveActorMapUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.DemoInteractiveActorMapUpdateDelegate__DelegateSignature");
			}
			return FDemoInteractiveActorMapUpdateDelegate._FunctionPtr;
		}

		// Token: 0x0601DC5C RID: 121948 RVA: 0x002BFEF5 File Offset: 0x002BE0F5
		public FDemoInteractiveActorMapUpdateDelegate()
		{
		}

		// Token: 0x0601DC5D RID: 121949 RVA: 0x002BFEFD File Offset: 0x002BE0FD
		[NullableContext(2)]
		public FDemoInteractiveActorMapUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC5E RID: 121950 RVA: 0x002BFF07 File Offset: 0x002BE107
		public FDemoInteractiveActorMapUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC5F RID: 121951 RVA: 0x002BFF12 File Offset: 0x002BE112
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC60 RID: 121952 RVA: 0x002BFF44 File Offset: 0x002BE144
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601DC61 RID: 121953 RVA: 0x002BFF7E File Offset: 0x002BE17E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC62 RID: 121954 RVA: 0x002BFF88 File Offset: 0x002BE188
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName ActorKey)
		{
			FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams* ptr = stackalloc FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDemoInteractiveActorMapUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601DC63 RID: 121955 RVA: 0x002BFFC4 File Offset: 0x002BE1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FDemoInteractiveActorMapUpdateDelegate.__FDemoInteractiveActorMapUpdateDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x040101DE RID: 66014
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101DF RID: 66015
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.DemoInteractiveActorMapUpdateDelegate__DelegateSignature";

		// Token: 0x040101E0 RID: 66016
		private static int RegisterId;

		// Token: 0x020032E3 RID: 13027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FDemoInteractiveActorMapUpdateDelegate_DelegateParams
		{
			// Token: 0x04017193 RID: 94611
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x020032E4 RID: 13028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017194 RID: 94612
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

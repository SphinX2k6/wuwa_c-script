using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013CB RID: 5067
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAsyncGameplayMessageDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128E7 RID: 76007 RVA: 0x001B4E39 File Offset: 0x001B3039
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAsyncGameplayMessageDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128E8 RID: 76008 RVA: 0x001B4E45 File Offset: 0x001B3045
		private static IntPtr StaticFunctionPtr()
		{
			if (FAsyncGameplayMessageDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAsyncGameplayMessageDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayMessageRuntime.AsyncGameplayMessageDelegate__DelegateSignature");
			}
			return FAsyncGameplayMessageDelegate._FunctionPtr;
		}

		// Token: 0x060128E9 RID: 76009 RVA: 0x001B4E68 File Offset: 0x001B3068
		public FAsyncGameplayMessageDelegate()
		{
		}

		// Token: 0x060128EA RID: 76010 RVA: 0x001B4E70 File Offset: 0x001B3070
		[NullableContext(2)]
		public FAsyncGameplayMessageDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128EB RID: 76011 RVA: 0x001B4E7A File Offset: 0x001B307A
		public FAsyncGameplayMessageDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128EC RID: 76012 RVA: 0x001B4E85 File Offset: 0x001B3085
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag>) ?? ((Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag>)Delegate.CreateDelegate(typeof(Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128ED RID: 76013 RVA: 0x001B4EB7 File Offset: 0x001B30B7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag> Callback)
		{
			if (FAsyncGameplayMessageDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAsyncGameplayMessageDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAsyncGameplayMessageDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAsyncGameplayMessageDelegate.OnScriptCallback));
				}
				FAsyncGameplayMessageDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAsyncGameplayMessageDelegate.RegisterId);
		}

		// Token: 0x060128EE RID: 76014 RVA: 0x001B4EF1 File Offset: 0x001B30F1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128EF RID: 76015 RVA: 0x001B4EFC File Offset: 0x001B30FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UAsyncAction_ListenForGameplayMessage ProxyObject, FGameplayTag ActualChannel)
		{
			FAsyncGameplayMessageDelegate.__FAsyncGameplayMessageDelegate_DelegateParams* ptr = stackalloc FAsyncGameplayMessageDelegate.__FAsyncGameplayMessageDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FAsyncGameplayMessageDelegate.__FAsyncGameplayMessageDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAsyncGameplayMessageDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ProxyObject = ((ProxyObject != null) ? ProxyObject.NativePtr : IntPtr.Zero);
			ptr->ActualChannel = ActualChannel;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060128F0 RID: 76016 RVA: 0x001B4F50 File Offset: 0x001B3150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag> action = target as Action<UAsyncAction_ListenForGameplayMessage, FGameplayTag>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UAsyncAction_ListenForGameplayMessage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncAction_ListenForGameplayMessage>(((FAsyncGameplayMessageDelegate.__FAsyncGameplayMessageDelegate_DelegateParams*)__Parameters)->ProxyObject);
			action(orCreateUObjectByNativePointer, ((FAsyncGameplayMessageDelegate.__FAsyncGameplayMessageDelegate_DelegateParams*)__Parameters)->ActualChannel);
		}

		// Token: 0x04009EB1 RID: 40625
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009EB2 RID: 40626
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayMessageRuntime.AsyncGameplayMessageDelegate__DelegateSignature";

		// Token: 0x04009EB3 RID: 40627
		private static int RegisterId;

		// Token: 0x02002E6C RID: 11884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FAsyncGameplayMessageDelegate_DelegateParams
		{
			// Token: 0x0401692E RID: 92462
			[FieldOffset(0)]
			public IntPtr ProxyObject;

			// Token: 0x0401692F RID: 92463
			[FieldOffset(8)]
			public FGameplayTag ActualChannel;
		}

		// Token: 0x02002E6D RID: 11885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016930 RID: 92464
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

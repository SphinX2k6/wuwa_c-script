using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200196C RID: 6508
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayEffectExecuted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601830E RID: 99086 RVA: 0x0023A779 File Offset: 0x00238979
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayEffectExecuted.StaticFunctionPtr();
		}

		// Token: 0x0601830F RID: 99087 RVA: 0x0023A785 File Offset: 0x00238985
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayEffectExecuted._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayEffectExecuted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayEffectExecuted__DelegateSignature");
			}
			return FOnGameplayEffectExecuted._FunctionPtr;
		}

		// Token: 0x06018310 RID: 99088 RVA: 0x0023A7A8 File Offset: 0x002389A8
		public FOnGameplayEffectExecuted()
		{
		}

		// Token: 0x06018311 RID: 99089 RVA: 0x0023A7B0 File Offset: 0x002389B0
		[NullableContext(2)]
		public FOnGameplayEffectExecuted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018312 RID: 99090 RVA: 0x0023A7BA File Offset: 0x002389BA
		public FOnGameplayEffectExecuted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018313 RID: 99091 RVA: 0x0023A7C5 File Offset: 0x002389C5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018314 RID: 99092 RVA: 0x0023A7F7 File Offset: 0x002389F7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnGameplayEffectExecuted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameplayEffectExecuted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameplayEffectExecuted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameplayEffectExecuted.OnScriptCallback));
				}
				FOnGameplayEffectExecuted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameplayEffectExecuted.RegisterId);
		}

		// Token: 0x06018315 RID: 99093 RVA: 0x0023A831 File Offset: 0x00238A31
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018316 RID: 99094 RVA: 0x0023A83C File Offset: 0x00238A3C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string DebugInfo)
		{
			FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams* ptr = stackalloc FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayEffectExecuted.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DebugInfo), DebugInfo);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnGameplayEffectExecuted._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018317 RID: 99095 RVA: 0x0023A890 File Offset: 0x00238A90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams*)__Parameters)->DebugInfo));
			action(obj);
		}

		// Token: 0x0400D1BA RID: 53690
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1BB RID: 53691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayEffectExecuted__DelegateSignature";

		// Token: 0x0400D1BC RID: 53692
		private static int RegisterId;

		// Token: 0x0200305A RID: 12378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnGameplayEffectExecuted_DelegateParams
		{
			// Token: 0x04016D22 RID: 93474
			[FieldOffset(0)]
			public FString DebugInfo;
		}

		// Token: 0x0200305B RID: 12379
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D23 RID: 93475
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

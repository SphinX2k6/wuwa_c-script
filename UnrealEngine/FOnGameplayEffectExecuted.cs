using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000435 RID: 1077
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameplayEffectExecuted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068A7 RID: 26791 RVA: 0x00098A90 File Offset: 0x00096C90
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameplayEffectExecuted.StaticFunctionPtr();
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00098A9C File Offset: 0x00096C9C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameplayEffectExecuted._FunctionPtr == IntPtr.Zero)
			{
				FOnGameplayEffectExecuted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnGameplayEffectExecuted__DelegateSignature");
			}
			return FOnGameplayEffectExecuted._FunctionPtr;
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00098ABF File Offset: 0x00096CBF
		public FOnGameplayEffectExecuted()
		{
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00098AC7 File Offset: 0x00096CC7
		[NullableContext(2)]
		public FOnGameplayEffectExecuted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00098AD1 File Offset: 0x00096CD1
		public FOnGameplayEffectExecuted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00098ADC File Offset: 0x00096CDC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00098B0E File Offset: 0x00096D0E
		[NullableContext(1)]
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

		// Token: 0x060068AE RID: 26798 RVA: 0x00098B48 File Offset: 0x00096D48
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00098B54 File Offset: 0x00096D54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string DebugInfo)
		{
			FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams* ptr = stackalloc FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGameplayEffectExecuted.__FOnGameplayEffectExecuted_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameplayEffectExecuted.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->DebugInfo), DebugInfo);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnGameplayEffectExecuted._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00098BA8 File Offset: 0x00096DA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002C9E RID: 11422
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002C9F RID: 11423
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnGameplayEffectExecuted__DelegateSignature";

		// Token: 0x04002CA0 RID: 11424
		private static int RegisterId;

		// Token: 0x02000B52 RID: 2898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnGameplayEffectExecuted_DelegateParams
		{
			// Token: 0x04005C65 RID: 23653
			[FieldOffset(0)]
			public FString DebugInfo;
		}

		// Token: 0x02000B53 RID: 2899
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C66 RID: 23654
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

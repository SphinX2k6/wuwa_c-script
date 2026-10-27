using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001321 RID: 4897
	public sealed class FActiveGameplayEffectQueryCustomMatch_Dynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060120A5 RID: 73893 RVA: 0x001A7C94 File Offset: 0x001A5E94
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActiveGameplayEffectQueryCustomMatch_Dynamic.StaticFunctionPtr();
		}

		// Token: 0x060120A6 RID: 73894 RVA: 0x001A7CA0 File Offset: 0x001A5EA0
		private static IntPtr StaticFunctionPtr()
		{
			if (FActiveGameplayEffectQueryCustomMatch_Dynamic._FunctionPtr == IntPtr.Zero)
			{
				FActiveGameplayEffectQueryCustomMatch_Dynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.ActiveGameplayEffectQueryCustomMatch_Dynamic__DelegateSignature");
			}
			return FActiveGameplayEffectQueryCustomMatch_Dynamic._FunctionPtr;
		}

		// Token: 0x060120A7 RID: 73895 RVA: 0x001A7CC3 File Offset: 0x001A5EC3
		public FActiveGameplayEffectQueryCustomMatch_Dynamic()
		{
		}

		// Token: 0x060120A8 RID: 73896 RVA: 0x001A7CCB File Offset: 0x001A5ECB
		[NullableContext(2)]
		public FActiveGameplayEffectQueryCustomMatch_Dynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060120A9 RID: 73897 RVA: 0x001A7CD5 File Offset: 0x001A5ED5
		public FActiveGameplayEffectQueryCustomMatch_Dynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060120AA RID: 73898 RVA: 0x001A7CE0 File Offset: 0x001A5EE0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate) ?? ((FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate)Delegate.CreateDelegate(typeof(FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060120AB RID: 73899 RVA: 0x001A7D12 File Offset: 0x001A5F12
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate Callback)
		{
			if (FActiveGameplayEffectQueryCustomMatch_Dynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActiveGameplayEffectQueryCustomMatch_Dynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActiveGameplayEffectQueryCustomMatch_Dynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActiveGameplayEffectQueryCustomMatch_Dynamic.OnScriptCallback));
				}
				FActiveGameplayEffectQueryCustomMatch_Dynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FActiveGameplayEffectQueryCustomMatch_Dynamic.RegisterId);
		}

		// Token: 0x060120AC RID: 73900 RVA: 0x001A7D4C File Offset: 0x001A5F4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FActiveGameplayEffect Effect, ref bool bMatches)
		{
			FActiveGameplayEffectQueryCustomMatch_Dynamic.__FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams* ptr = stackalloc FActiveGameplayEffectQueryCustomMatch_Dynamic.__FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams[(UIntPtr)919] + 15L / (long)sizeof(FActiveGameplayEffectQueryCustomMatch_Dynamic.__FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActiveGameplayEffectQueryCustomMatch_Dynamic.StaticFunctionPtr(), (void*)ptr, 1);
			if (Effect != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffect.StaticStruct(), &ptr->Effect, Effect.NativePtr, 1, false);
			}
			ptr->bMatches = bMatches;
			base.ExecuteInternal((void*)ptr);
			bMatches = ptr->bMatches;
			UnrealReflectionUtils.DestroyStruct(FActiveGameplayEffectQueryCustomMatch_Dynamic._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060120AD RID: 73901 RVA: 0x001A7DC8 File Offset: 0x001A5FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate factiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate = target as FActiveGameplayEffectQueryCustomMatch_Dynamic.FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate;
			if (factiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffect effect = new FActiveGameplayEffect(&((FActiveGameplayEffectQueryCustomMatch_Dynamic.__FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams*)__Parameters)->Effect, true, true);
			factiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate(effect, ref ((FActiveGameplayEffectQueryCustomMatch_Dynamic.__FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams*)__Parameters)->bMatches);
		}

		// Token: 0x04009A2C RID: 39468
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009A2D RID: 39469
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffectQueryCustomMatch_Dynamic__DelegateSignature";

		// Token: 0x04009A2E RID: 39470
		private static int RegisterId;

		// Token: 0x02002E21 RID: 11809
		// (Invoke) Token: 0x06028566 RID: 165222
		public delegate void FActiveGameplayEffectQueryCustomMatch_Dynamic_ScriptDelegate(FActiveGameplayEffect Effect, ref bool bMatches);

		// Token: 0x02002E22 RID: 11810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 904)]
		protected ref struct __FActiveGameplayEffectQueryCustomMatch_Dynamic_DelegateParams
		{
			// Token: 0x040168B6 RID: 92342
			[FieldOffset(0)]
			public byte Effect;

			// Token: 0x040168B7 RID: 92343
			[FieldOffset(896)]
			public bool bMatches;
		}

		// Token: 0x02002E23 RID: 11811
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168B8 RID: 92344
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

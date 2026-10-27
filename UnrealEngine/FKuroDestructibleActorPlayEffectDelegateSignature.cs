using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE1 RID: 6881
	public sealed class FKuroDestructibleActorPlayEffectDelegateSignature : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06019A4D RID: 105037 RVA: 0x0025E596 File Offset: 0x0025C796
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDestructibleActorPlayEffectDelegateSignature.StaticFunctionPtr();
		}

		// Token: 0x06019A4E RID: 105038 RVA: 0x0025E5A2 File Offset: 0x0025C7A2
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorPlayEffectDelegateSignature__DelegateSignature");
			}
			return FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr;
		}

		// Token: 0x06019A4F RID: 105039 RVA: 0x0025E5C5 File Offset: 0x0025C7C5
		public FKuroDestructibleActorPlayEffectDelegateSignature()
		{
		}

		// Token: 0x06019A50 RID: 105040 RVA: 0x0025E5CD File Offset: 0x0025C7CD
		[NullableContext(2)]
		public FKuroDestructibleActorPlayEffectDelegateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019A51 RID: 105041 RVA: 0x0025E5D7 File Offset: 0x0025C7D7
		public FKuroDestructibleActorPlayEffectDelegateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019A52 RID: 105042 RVA: 0x0025E5E2 File Offset: 0x0025C7E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKuroDestructibleEffect>) ?? ((Action<FKuroDestructibleEffect>)Delegate.CreateDelegate(typeof(Action<FKuroDestructibleEffect>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06019A53 RID: 105043 RVA: 0x0025E614 File Offset: 0x0025C814
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FKuroDestructibleEffect> Callback)
		{
			if (FKuroDestructibleActorPlayEffectDelegateSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroDestructibleActorPlayEffectDelegateSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroDestructibleActorPlayEffectDelegateSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroDestructibleActorPlayEffectDelegateSignature.OnScriptCallback));
				}
				FKuroDestructibleActorPlayEffectDelegateSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroDestructibleActorPlayEffectDelegateSignature.RegisterId);
		}

		// Token: 0x06019A54 RID: 105044 RVA: 0x0025E650 File Offset: 0x0025C850
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FKuroDestructibleEffect EffectData)
		{
			FKuroDestructibleActorPlayEffectDelegateSignature.__FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams* ptr = stackalloc FKuroDestructibleActorPlayEffectDelegateSignature.__FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FKuroDestructibleActorPlayEffectDelegateSignature.__FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroDestructibleActorPlayEffectDelegateSignature.StaticFunctionPtr(), (void*)ptr, 1);
			if (EffectData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroDestructibleEffect.StaticStruct(), &ptr->EffectData, EffectData.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06019A55 RID: 105045 RVA: 0x0025E6A8 File Offset: 0x0025C8A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKuroDestructibleEffect> action = target as Action<FKuroDestructibleEffect>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKuroDestructibleEffect obj = new FKuroDestructibleEffect(&((FKuroDestructibleActorPlayEffectDelegateSignature.__FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams*)__Parameters)->EffectData, true, true);
			action(obj);
		}

		// Token: 0x0400DF38 RID: 57144
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400DF39 RID: 57145
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorPlayEffectDelegateSignature__DelegateSignature";

		// Token: 0x0400DF3A RID: 57146
		private static int RegisterId;

		// Token: 0x02003139 RID: 12601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams
		{
			// Token: 0x04016F49 RID: 94025
			[FieldOffset(0)]
			public byte EffectData;
		}

		// Token: 0x0200313A RID: 12602
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F4A RID: 94026
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

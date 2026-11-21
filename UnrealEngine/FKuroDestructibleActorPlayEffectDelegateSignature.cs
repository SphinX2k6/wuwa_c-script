using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BF RID: 1215
	public sealed class FKuroDestructibleActorPlayEffectDelegateSignature : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x000A56B6 File Offset: 0x000A38B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDestructibleActorPlayEffectDelegateSignature.StaticFunctionPtr();
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x000A56C2 File Offset: 0x000A38C2
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorPlayEffectDelegateSignature__DelegateSignature");
			}
			return FKuroDestructibleActorPlayEffectDelegateSignature._FunctionPtr;
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x000A56E5 File Offset: 0x000A38E5
		public FKuroDestructibleActorPlayEffectDelegateSignature()
		{
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x000A56ED File Offset: 0x000A38ED
		[NullableContext(2)]
		public FKuroDestructibleActorPlayEffectDelegateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x000A56F7 File Offset: 0x000A38F7
		public FKuroDestructibleActorPlayEffectDelegateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x000A5702 File Offset: 0x000A3902
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKuroDestructibleEffect>) ?? ((Action<FKuroDestructibleEffect>)Delegate.CreateDelegate(typeof(Action<FKuroDestructibleEffect>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x000A5734 File Offset: 0x000A3934
		[NullableContext(1)]
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

		// Token: 0x06006FF4 RID: 28660 RVA: 0x000A5770 File Offset: 0x000A3970
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06006FF5 RID: 28661 RVA: 0x000A57C8 File Offset: 0x000A39C8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003052 RID: 12370
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003053 RID: 12371
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorPlayEffectDelegateSignature__DelegateSignature";

		// Token: 0x04003054 RID: 12372
		private static int RegisterId;

		// Token: 0x02000C07 RID: 3079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		private ref struct __FKuroDestructibleActorPlayEffectDelegateSignature_DelegateParams
		{
			// Token: 0x04005E3C RID: 24124
			[FieldOffset(0)]
			public byte EffectData;
		}

		// Token: 0x02000C08 RID: 3080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E3D RID: 24125
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001972 RID: 6514
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageRemainCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601834A RID: 99146 RVA: 0x0023B072 File Offset: 0x00239272
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageRemainCallback.StaticFunctionPtr();
		}

		// Token: 0x0601834B RID: 99147 RVA: 0x0023B07E File Offset: 0x0023927E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageRemainCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageRemainCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnMontageRemainCallback__DelegateSignature");
			}
			return FOnMontageRemainCallback._FunctionPtr;
		}

		// Token: 0x0601834C RID: 99148 RVA: 0x0023B0A1 File Offset: 0x002392A1
		public FOnMontageRemainCallback()
		{
		}

		// Token: 0x0601834D RID: 99149 RVA: 0x0023B0A9 File Offset: 0x002392A9
		[NullableContext(2)]
		public FOnMontageRemainCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601834E RID: 99150 RVA: 0x0023B0B3 File Offset: 0x002392B3
		public FOnMontageRemainCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601834F RID: 99151 RVA: 0x0023B0BE File Offset: 0x002392BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018350 RID: 99152 RVA: 0x0023B0F0 File Offset: 0x002392F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnMontageRemainCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageRemainCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageRemainCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageRemainCallback.OnScriptCallback));
				}
				FOnMontageRemainCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageRemainCallback.RegisterId);
		}

		// Token: 0x06018351 RID: 99153 RVA: 0x0023B12A File Offset: 0x0023932A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x0023B134 File Offset: 0x00239334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float RemainTime)
		{
			FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams* ptr = stackalloc FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageRemainCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RemainTime = RemainTime;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x0023B170 File Offset: 0x00239370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams*)__Parameters)->RemainTime);
		}

		// Token: 0x0400D1CC RID: 53708
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1CD RID: 53709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnMontageRemainCallback__DelegateSignature";

		// Token: 0x0400D1CE RID: 53710
		private static int RegisterId;

		// Token: 0x02003066 RID: 12390
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnMontageRemainCallback_DelegateParams
		{
			// Token: 0x04016D34 RID: 93492
			[FieldOffset(0)]
			public float RemainTime;
		}

		// Token: 0x02003067 RID: 12391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D35 RID: 93493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

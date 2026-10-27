using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F28 RID: 3880
	public sealed class FOnQuartzMetronomeEventBP : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D170 RID: 53616 RVA: 0x00132990 File Offset: 0x00130B90
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQuartzMetronomeEventBP.StaticFunctionPtr();
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x0013299C File Offset: 0x00130B9C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQuartzMetronomeEventBP._FunctionPtr == IntPtr.Zero)
			{
				FOnQuartzMetronomeEventBP._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature");
			}
			return FOnQuartzMetronomeEventBP._FunctionPtr;
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x001329BF File Offset: 0x00130BBF
		public FOnQuartzMetronomeEventBP()
		{
		}

		// Token: 0x0600D173 RID: 53619 RVA: 0x001329C7 File Offset: 0x00130BC7
		[NullableContext(2)]
		public FOnQuartzMetronomeEventBP(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x001329D1 File Offset: 0x00130BD1
		public FOnQuartzMetronomeEventBP(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x001329DC File Offset: 0x00130BDC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName, EQuartzCommandQuantization, int, int, float>) ?? ((Action<FName, EQuartzCommandQuantization, int, int, float>)Delegate.CreateDelegate(typeof(Action<FName, EQuartzCommandQuantization, int, int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x00132A0E File Offset: 0x00130C0E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FName, EQuartzCommandQuantization, int, int, float> Callback)
		{
			if (FOnQuartzMetronomeEventBP.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQuartzMetronomeEventBP.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQuartzMetronomeEventBP.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQuartzMetronomeEventBP.OnScriptCallback));
				}
				FOnQuartzMetronomeEventBP.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnQuartzMetronomeEventBP.RegisterId);
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x00132A48 File Offset: 0x00130C48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FName ClockName, EQuartzCommandQuantization QuantizationType, int NumBars, int Beat, float BeatFraction)
		{
			FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams* ptr = stackalloc FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams[(UIntPtr)43] + 15L / (long)sizeof(FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQuartzMetronomeEventBP.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ClockName = ClockName;
			ptr->QuantizationType = QuantizationType;
			ptr->NumBars = NumBars;
			ptr->Beat = Beat;
			ptr->BeatFraction = BeatFraction;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D178 RID: 53624 RVA: 0x00132AA4 File Offset: 0x00130CA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, EQuartzCommandQuantization, int, int, float> action = target as Action<FName, EQuartzCommandQuantization, int, int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams*)__Parameters)->ClockName, ((FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams*)__Parameters)->QuantizationType, ((FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams*)__Parameters)->NumBars, ((FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams*)__Parameters)->Beat, ((FOnQuartzMetronomeEventBP.__FOnQuartzMetronomeEventBP_DelegateParams*)__Parameters)->BeatFraction);
		}

		// Token: 0x04007084 RID: 28804
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007085 RID: 28805
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnQuartzMetronomeEventBP__DelegateSignature";

		// Token: 0x04007086 RID: 28806
		private static int RegisterId;

		// Token: 0x02002D9A RID: 11674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __FOnQuartzMetronomeEventBP_DelegateParams
		{
			// Token: 0x040167BD RID: 92093
			[FieldOffset(0)]
			public FName ClockName;

			// Token: 0x040167BE RID: 92094
			[FieldOffset(12)]
			public EQuartzCommandQuantization QuantizationType;

			// Token: 0x040167BF RID: 92095
			[FieldOffset(16)]
			public int NumBars;

			// Token: 0x040167C0 RID: 92096
			[FieldOffset(20)]
			public int Beat;

			// Token: 0x040167C1 RID: 92097
			[FieldOffset(24)]
			public float BeatFraction;
		}

		// Token: 0x02002D9B RID: 11675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167C2 RID: 92098
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

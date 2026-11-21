using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000498 RID: 1176
	public sealed class FGetCurrentTemperatureDataDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006DD2 RID: 28114 RVA: 0x000A0DEA File Offset: 0x0009EFEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetCurrentTemperatureDataDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x000A0DF6 File Offset: 0x0009EFF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetCurrentTemperatureDataDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGetCurrentTemperatureDataDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPerformance.GetCurrentTemperatureDataDelegate__DelegateSignature");
			}
			return FGetCurrentTemperatureDataDelegate._FunctionPtr;
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x000A0E19 File Offset: 0x0009F019
		public FGetCurrentTemperatureDataDelegate()
		{
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x000A0E21 File Offset: 0x0009F021
		[NullableContext(2)]
		public FGetCurrentTemperatureDataDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x000A0E2B File Offset: 0x0009F02B
		public FGetCurrentTemperatureDataDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x000A0E36 File Offset: 0x0009F036
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, float, float>) ?? ((Action<bool, float, float>)Delegate.CreateDelegate(typeof(Action<bool, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x000A0E68 File Offset: 0x0009F068
		[NullableContext(1)]
		public void Bind(Action<bool, float, float> Callback)
		{
			if (FGetCurrentTemperatureDataDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetCurrentTemperatureDataDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetCurrentTemperatureDataDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetCurrentTemperatureDataDelegate.OnScriptCallback));
				}
				FGetCurrentTemperatureDataDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetCurrentTemperatureDataDelegate.RegisterId);
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x000A0EA4 File Offset: 0x0009F0A4
		[SkipLocalsInit]
		public unsafe void Execute(bool bResult, float CurrentTemperature, float TempBudget)
		{
			FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams* ptr = stackalloc FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetCurrentTemperatureDataDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bResult = bResult;
			ptr->CurrentTemperature = CurrentTemperature;
			ptr->TempBudget = TempBudget;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x000A0EF0 File Offset: 0x0009F0F0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, float, float> action = target as Action<bool, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->bResult, ((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->CurrentTemperature, ((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->TempBudget);
		}

		// Token: 0x04002EE8 RID: 12008
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EE9 RID: 12009
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPerformance.GetCurrentTemperatureDataDelegate__DelegateSignature";

		// Token: 0x04002EEA RID: 12010
		private static int RegisterId;

		// Token: 0x02000BAA RID: 2986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FGetCurrentTemperatureDataDelegate_DelegateParams
		{
			// Token: 0x04005D32 RID: 23858
			[FieldOffset(0)]
			public bool bResult;

			// Token: 0x04005D33 RID: 23859
			[FieldOffset(4)]
			public float CurrentTemperature;

			// Token: 0x04005D34 RID: 23860
			[FieldOffset(8)]
			public float TempBudget;
		}

		// Token: 0x02000BAB RID: 2987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D35 RID: 23861
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

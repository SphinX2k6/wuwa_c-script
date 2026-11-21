using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200084D RID: 2125
	public sealed class FOnTimeCalibrated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B92D RID: 47405 RVA: 0x00128710 File Offset: 0x00126910
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimeCalibrated.StaticFunctionPtr();
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x0012871C File Offset: 0x0012691C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimeCalibrated._FunctionPtr == IntPtr.Zero)
			{
				FOnTimeCalibrated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/TASdkPlugin.OnTimeCalibrated__DelegateSignature");
			}
			return FOnTimeCalibrated._FunctionPtr;
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x0012873F File Offset: 0x0012693F
		public FOnTimeCalibrated()
		{
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x00128747 File Offset: 0x00126947
		[NullableContext(2)]
		public FOnTimeCalibrated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x00128751 File Offset: 0x00126951
		public FOnTimeCalibrated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x0012875C File Offset: 0x0012695C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x0012878E File Offset: 0x0012698E
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FOnTimeCalibrated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTimeCalibrated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTimeCalibrated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTimeCalibrated.OnScriptCallback));
				}
				FOnTimeCalibrated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTimeCalibrated.RegisterId);
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x001287C8 File Offset: 0x001269C8
		[SkipLocalsInit]
		public unsafe void Execute(int Index)
		{
			FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams* ptr = stackalloc FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTimeCalibrated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x00128808 File Offset: 0x00126A08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x04005428 RID: 21544
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005429 RID: 21545
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TASdkPlugin.OnTimeCalibrated__DelegateSignature";

		// Token: 0x0400542A RID: 21546
		private static int RegisterId;

		// Token: 0x020013DB RID: 5083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnTimeCalibrated_DelegateParams
		{
			// Token: 0x04006847 RID: 26695
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x020013DC RID: 5084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006848 RID: 26696
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

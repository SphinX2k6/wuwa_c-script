using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028F9 RID: 10489
	public sealed class FOnTimeCalibrated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026E74 RID: 159348 RVA: 0x003B58C8 File Offset: 0x003B3AC8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimeCalibrated.StaticFunctionPtr();
		}

		// Token: 0x06026E75 RID: 159349 RVA: 0x003B58D4 File Offset: 0x003B3AD4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimeCalibrated._FunctionPtr == IntPtr.Zero)
			{
				FOnTimeCalibrated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/TASdkPlugin.OnTimeCalibrated__DelegateSignature");
			}
			return FOnTimeCalibrated._FunctionPtr;
		}

		// Token: 0x06026E76 RID: 159350 RVA: 0x003B58F7 File Offset: 0x003B3AF7
		public FOnTimeCalibrated()
		{
		}

		// Token: 0x06026E77 RID: 159351 RVA: 0x003B58FF File Offset: 0x003B3AFF
		[NullableContext(2)]
		public FOnTimeCalibrated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E78 RID: 159352 RVA: 0x003B5909 File Offset: 0x003B3B09
		public FOnTimeCalibrated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E79 RID: 159353 RVA: 0x003B5914 File Offset: 0x003B3B14
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026E7A RID: 159354 RVA: 0x003B5946 File Offset: 0x003B3B46
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06026E7B RID: 159355 RVA: 0x003B5980 File Offset: 0x003B3B80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Index)
		{
			FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams* ptr = stackalloc FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTimeCalibrated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06026E7C RID: 159356 RVA: 0x003B59C0 File Offset: 0x003B3BC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTimeCalibrated.__FOnTimeCalibrated_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x040155C3 RID: 87491
		internal static IntPtr _FunctionPtr;

		// Token: 0x040155C4 RID: 87492
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TASdkPlugin.OnTimeCalibrated__DelegateSignature";

		// Token: 0x040155C5 RID: 87493
		private static int RegisterId;

		// Token: 0x02003B58 RID: 15192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnTimeCalibrated_DelegateParams
		{
			// Token: 0x04017D02 RID: 97538
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02003B59 RID: 15193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D03 RID: 97539
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

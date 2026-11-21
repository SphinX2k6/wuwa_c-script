using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D4 RID: 724
	public sealed class FKAOnTimeCalibrated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004E46 RID: 20038 RVA: 0x0006D720 File Offset: 0x0006B920
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKAOnTimeCalibrated.StaticFunctionPtr();
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x0006D72C File Offset: 0x0006B92C
		private static IntPtr StaticFunctionPtr()
		{
			if (FKAOnTimeCalibrated._FunctionPtr == IntPtr.Zero)
			{
				FKAOnTimeCalibrated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KRDataAnalyticsPlugin.KAOnTimeCalibrated__DelegateSignature");
			}
			return FKAOnTimeCalibrated._FunctionPtr;
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x0006D74F File Offset: 0x0006B94F
		public FKAOnTimeCalibrated()
		{
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x0006D757 File Offset: 0x0006B957
		[NullableContext(2)]
		public FKAOnTimeCalibrated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x0006D761 File Offset: 0x0006B961
		public FKAOnTimeCalibrated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x0006D76C File Offset: 0x0006B96C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x0006D79E File Offset: 0x0006B99E
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FKAOnTimeCalibrated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKAOnTimeCalibrated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKAOnTimeCalibrated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKAOnTimeCalibrated.OnScriptCallback));
				}
				FKAOnTimeCalibrated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKAOnTimeCalibrated.RegisterId);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x0006D7D8 File Offset: 0x0006B9D8
		[SkipLocalsInit]
		public unsafe void Execute(int Index)
		{
			FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams* ptr = stackalloc FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKAOnTimeCalibrated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x0006D818 File Offset: 0x0006BA18
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x04001F69 RID: 8041
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F6A RID: 8042
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KAOnTimeCalibrated__DelegateSignature";

		// Token: 0x04001F6B RID: 8043
		private static int RegisterId;

		// Token: 0x02000A02 RID: 2562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKAOnTimeCalibrated_DelegateParams
		{
			// Token: 0x040059A9 RID: 22953
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02000A03 RID: 2563
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059AA RID: 22954
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

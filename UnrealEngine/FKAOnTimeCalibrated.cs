using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E0 RID: 5600
	public sealed class FKAOnTimeCalibrated : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601431C RID: 82716 RVA: 0x001DA940 File Offset: 0x001D8B40
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKAOnTimeCalibrated.StaticFunctionPtr();
		}

		// Token: 0x0601431D RID: 82717 RVA: 0x001DA94C File Offset: 0x001D8B4C
		private static IntPtr StaticFunctionPtr()
		{
			if (FKAOnTimeCalibrated._FunctionPtr == IntPtr.Zero)
			{
				FKAOnTimeCalibrated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KRDataAnalyticsPlugin.KAOnTimeCalibrated__DelegateSignature");
			}
			return FKAOnTimeCalibrated._FunctionPtr;
		}

		// Token: 0x0601431E RID: 82718 RVA: 0x001DA96F File Offset: 0x001D8B6F
		public FKAOnTimeCalibrated()
		{
		}

		// Token: 0x0601431F RID: 82719 RVA: 0x001DA977 File Offset: 0x001D8B77
		[NullableContext(2)]
		public FKAOnTimeCalibrated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014320 RID: 82720 RVA: 0x001DA981 File Offset: 0x001D8B81
		public FKAOnTimeCalibrated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014321 RID: 82721 RVA: 0x001DA98C File Offset: 0x001D8B8C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014322 RID: 82722 RVA: 0x001DA9BE File Offset: 0x001D8BBE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06014323 RID: 82723 RVA: 0x001DA9F8 File Offset: 0x001D8BF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Index)
		{
			FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams* ptr = stackalloc FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKAOnTimeCalibrated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06014324 RID: 82724 RVA: 0x001DAA38 File Offset: 0x001D8C38
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
			action(((FKAOnTimeCalibrated.__FKAOnTimeCalibrated_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x0400AFBF RID: 44991
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400AFC0 RID: 44992
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KAOnTimeCalibrated__DelegateSignature";

		// Token: 0x0400AFC1 RID: 44993
		private static int RegisterId;

		// Token: 0x02002EC9 RID: 11977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKAOnTimeCalibrated_DelegateParams
		{
			// Token: 0x040169CE RID: 92622
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02002ECA RID: 11978
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169CF RID: 92623
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

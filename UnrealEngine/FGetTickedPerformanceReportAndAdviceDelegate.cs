using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A1C RID: 6684
	public sealed class FGetTickedPerformanceReportAndAdviceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018BA9 RID: 101289 RVA: 0x00247F16 File Offset: 0x00246116
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetTickedPerformanceReportAndAdviceDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018BAA RID: 101290 RVA: 0x00247F22 File Offset: 0x00246122
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPerformance.GetTickedPerformanceReportAndAdviceDelegate__DelegateSignature");
			}
			return FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr;
		}

		// Token: 0x06018BAB RID: 101291 RVA: 0x00247F45 File Offset: 0x00246145
		public FGetTickedPerformanceReportAndAdviceDelegate()
		{
		}

		// Token: 0x06018BAC RID: 101292 RVA: 0x00247F4D File Offset: 0x0024614D
		[NullableContext(2)]
		public FGetTickedPerformanceReportAndAdviceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018BAD RID: 101293 RVA: 0x00247F57 File Offset: 0x00246157
		public FGetTickedPerformanceReportAndAdviceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018BAE RID: 101294 RVA: 0x00247F62 File Offset: 0x00246162
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKuroPerformanceReport>) ?? ((Action<FKuroPerformanceReport>)Delegate.CreateDelegate(typeof(Action<FKuroPerformanceReport>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018BAF RID: 101295 RVA: 0x00247F94 File Offset: 0x00246194
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FKuroPerformanceReport> Callback)
		{
			if (FGetTickedPerformanceReportAndAdviceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetTickedPerformanceReportAndAdviceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetTickedPerformanceReportAndAdviceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetTickedPerformanceReportAndAdviceDelegate.OnScriptCallback));
				}
				FGetTickedPerformanceReportAndAdviceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetTickedPerformanceReportAndAdviceDelegate.RegisterId);
		}

		// Token: 0x06018BB0 RID: 101296 RVA: 0x00247FD0 File Offset: 0x002461D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FKuroPerformanceReport PerformanceReport)
		{
			FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams* ptr = stackalloc FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams[(UIntPtr)67] + 15L / (long)sizeof(FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetTickedPerformanceReportAndAdviceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PerformanceReport = PerformanceReport;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018BB1 RID: 101297 RVA: 0x00248010 File Offset: 0x00246210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKuroPerformanceReport> action = target as Action<FKuroPerformanceReport>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams*)__Parameters)->PerformanceReport);
		}

		// Token: 0x0400D5C9 RID: 54729
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D5CA RID: 54730
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPerformance.GetTickedPerformanceReportAndAdviceDelegate__DelegateSignature";

		// Token: 0x0400D5CB RID: 54731
		private static int RegisterId;

		// Token: 0x020030CF RID: 12495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams
		{
			// Token: 0x04016E30 RID: 93744
			[FieldOffset(0)]
			public FKuroPerformanceReport PerformanceReport;
		}

		// Token: 0x020030D0 RID: 12496
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E31 RID: 93745
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

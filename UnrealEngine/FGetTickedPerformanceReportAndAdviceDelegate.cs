using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000499 RID: 1177
	public sealed class FGetTickedPerformanceReportAndAdviceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006DDB RID: 28123 RVA: 0x000A0F46 File Offset: 0x0009F146
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetTickedPerformanceReportAndAdviceDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x000A0F52 File Offset: 0x0009F152
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPerformance.GetTickedPerformanceReportAndAdviceDelegate__DelegateSignature");
			}
			return FGetTickedPerformanceReportAndAdviceDelegate._FunctionPtr;
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x000A0F75 File Offset: 0x0009F175
		public FGetTickedPerformanceReportAndAdviceDelegate()
		{
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x000A0F7D File Offset: 0x0009F17D
		[NullableContext(2)]
		public FGetTickedPerformanceReportAndAdviceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x000A0F87 File Offset: 0x0009F187
		public FGetTickedPerformanceReportAndAdviceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x000A0F92 File Offset: 0x0009F192
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKuroPerformanceReport>) ?? ((Action<FKuroPerformanceReport>)Delegate.CreateDelegate(typeof(Action<FKuroPerformanceReport>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x000A0FC4 File Offset: 0x0009F1C4
		[NullableContext(1)]
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

		// Token: 0x06006DE2 RID: 28130 RVA: 0x000A1000 File Offset: 0x0009F200
		[SkipLocalsInit]
		public unsafe void Execute(FKuroPerformanceReport PerformanceReport)
		{
			FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams* ptr = stackalloc FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams[(UIntPtr)67] + 15L / (long)sizeof(FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetTickedPerformanceReportAndAdviceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PerformanceReport = PerformanceReport;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x000A1040 File Offset: 0x0009F240
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKuroPerformanceReport> action = target as Action<FKuroPerformanceReport>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FGetTickedPerformanceReportAndAdviceDelegate.__FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams*)__Parameters)->PerformanceReport);
		}

		// Token: 0x04002EEB RID: 12011
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EEC RID: 12012
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPerformance.GetTickedPerformanceReportAndAdviceDelegate__DelegateSignature";

		// Token: 0x04002EED RID: 12013
		private static int RegisterId;

		// Token: 0x02000BAC RID: 2988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		private ref struct __FGetTickedPerformanceReportAndAdviceDelegate_DelegateParams
		{
			// Token: 0x04005D36 RID: 23862
			[FieldOffset(0)]
			public FKuroPerformanceReport PerformanceReport;
		}

		// Token: 0x02000BAD RID: 2989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D37 RID: 23863
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

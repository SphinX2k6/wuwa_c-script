using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002282 RID: 8834
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnWorkloadAdviceChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021952 RID: 137554 RVA: 0x0031AFF8 File Offset: 0x003191F8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWorkloadAdviceChanged.StaticFunctionPtr();
		}

		// Token: 0x06021953 RID: 137555 RVA: 0x0031B004 File Offset: 0x00319204
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWorkloadAdviceChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnWorkloadAdviceChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.OnWorkloadAdviceChanged__DelegateSignature");
			}
			return FOnWorkloadAdviceChanged._FunctionPtr;
		}

		// Token: 0x06021954 RID: 137556 RVA: 0x0031B027 File Offset: 0x00319227
		public FOnWorkloadAdviceChanged()
		{
		}

		// Token: 0x06021955 RID: 137557 RVA: 0x0031B02F File Offset: 0x0031922F
		[NullableContext(2)]
		public FOnWorkloadAdviceChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021956 RID: 137558 RVA: 0x0031B039 File Offset: 0x00319239
		public FOnWorkloadAdviceChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021957 RID: 137559 RVA: 0x0031B044 File Offset: 0x00319244
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EMagtWorkloadAdvice, FMagtPerfReport>) ?? ((Action<EMagtWorkloadAdvice, FMagtPerfReport>)Delegate.CreateDelegate(typeof(Action<EMagtWorkloadAdvice, FMagtPerfReport>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021958 RID: 137560 RVA: 0x0031B076 File Offset: 0x00319276
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EMagtWorkloadAdvice, FMagtPerfReport> Callback)
		{
			if (FOnWorkloadAdviceChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWorkloadAdviceChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWorkloadAdviceChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWorkloadAdviceChanged.OnScriptCallback));
				}
				FOnWorkloadAdviceChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnWorkloadAdviceChanged.RegisterId);
		}

		// Token: 0x06021959 RID: 137561 RVA: 0x0031B0B0 File Offset: 0x003192B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EMagtWorkloadAdvice, FMagtPerfReport> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602195A RID: 137562 RVA: 0x0031B0BC File Offset: 0x003192BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EMagtWorkloadAdvice NewAdvice, in FMagtPerfReport PerfReport)
		{
			FOnWorkloadAdviceChanged.__FOnWorkloadAdviceChanged_DelegateParams* ptr = stackalloc FOnWorkloadAdviceChanged.__FOnWorkloadAdviceChanged_DelegateParams[(UIntPtr)59] + 15L / (long)sizeof(FOnWorkloadAdviceChanged.__FOnWorkloadAdviceChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnWorkloadAdviceChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewAdvice = NewAdvice;
			if (PerfReport != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMagtPerfReport.StaticStruct(), &ptr->PerfReport, PerfReport.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602195B RID: 137563 RVA: 0x0031B11C File Offset: 0x0031931C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EMagtWorkloadAdvice, FMagtPerfReport> action = target as Action<EMagtWorkloadAdvice, FMagtPerfReport>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FMagtPerfReport arg = new FMagtPerfReport(&((FOnWorkloadAdviceChanged.__FOnWorkloadAdviceChanged_DelegateParams*)__Parameters)->PerfReport, true, true);
			action(((FOnWorkloadAdviceChanged.__FOnWorkloadAdviceChanged_DelegateParams*)__Parameters)->NewAdvice, arg);
		}

		// Token: 0x04011EED RID: 73453
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011EEE RID: 73454
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.OnWorkloadAdviceChanged__DelegateSignature";

		// Token: 0x04011EEF RID: 73455
		private static int RegisterId;

		// Token: 0x0200360C RID: 13836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __FOnWorkloadAdviceChanged_DelegateParams
		{
			// Token: 0x04017698 RID: 95896
			[FieldOffset(0)]
			public EMagtWorkloadAdvice NewAdvice;

			// Token: 0x04017699 RID: 95897
			[FieldOffset(4)]
			public byte PerfReport;
		}

		// Token: 0x0200360D RID: 13837
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401769A RID: 95898
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

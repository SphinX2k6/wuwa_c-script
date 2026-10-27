using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F32 RID: 3890
	public sealed class FOnTimelineVector : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1CD RID: 53709 RVA: 0x00133776 File Offset: 0x00131976
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimelineVector.StaticFunctionPtr();
		}

		// Token: 0x0600D1CE RID: 53710 RVA: 0x00133782 File Offset: 0x00131982
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimelineVector._FunctionPtr == IntPtr.Zero)
			{
				FOnTimelineVector._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnTimelineVector__DelegateSignature");
			}
			return FOnTimelineVector._FunctionPtr;
		}

		// Token: 0x0600D1CF RID: 53711 RVA: 0x001337A5 File Offset: 0x001319A5
		public FOnTimelineVector()
		{
		}

		// Token: 0x0600D1D0 RID: 53712 RVA: 0x001337AD File Offset: 0x001319AD
		[NullableContext(2)]
		public FOnTimelineVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x001337B7 File Offset: 0x001319B7
		public FOnTimelineVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x001337C2 File Offset: 0x001319C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x001337F4 File Offset: 0x001319F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector> Callback)
		{
			if (FOnTimelineVector.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTimelineVector.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTimelineVector.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTimelineVector.OnScriptCallback));
				}
				FOnTimelineVector.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTimelineVector.RegisterId);
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x00133830 File Offset: 0x00131A30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FVector Output)
		{
			FOnTimelineVector.__FOnTimelineVector_DelegateParams* ptr = stackalloc FOnTimelineVector.__FOnTimelineVector_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnTimelineVector.__FOnTimelineVector_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTimelineVector.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Output = Output;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D1D5 RID: 53717 RVA: 0x00133870 File Offset: 0x00131A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTimelineVector.__FOnTimelineVector_DelegateParams*)__Parameters)->Output);
		}

		// Token: 0x040070A1 RID: 28833
		internal static IntPtr _FunctionPtr;

		// Token: 0x040070A2 RID: 28834
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnTimelineVector__DelegateSignature";

		// Token: 0x040070A3 RID: 28835
		private static int RegisterId;

		// Token: 0x02002DB0 RID: 11696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnTimelineVector_DelegateParams
		{
			// Token: 0x040167D5 RID: 92117
			[FieldOffset(0)]
			public FVector Output;
		}

		// Token: 0x02002DB1 RID: 11697
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D6 RID: 92118
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

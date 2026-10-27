using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F31 RID: 3889
	public sealed class FOnTimelineLinearColor : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D1C4 RID: 53700 RVA: 0x00133632 File Offset: 0x00131832
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTimelineLinearColor.StaticFunctionPtr();
		}

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x0013363E File Offset: 0x0013183E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTimelineLinearColor._FunctionPtr == IntPtr.Zero)
			{
				FOnTimelineLinearColor._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnTimelineLinearColor__DelegateSignature");
			}
			return FOnTimelineLinearColor._FunctionPtr;
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x00133661 File Offset: 0x00131861
		public FOnTimelineLinearColor()
		{
		}

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x00133669 File Offset: 0x00131869
		[NullableContext(2)]
		public FOnTimelineLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x00133673 File Offset: 0x00131873
		public FOnTimelineLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x0013367E File Offset: 0x0013187E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FLinearColor>) ?? ((Action<FLinearColor>)Delegate.CreateDelegate(typeof(Action<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x001336B0 File Offset: 0x001318B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FLinearColor> Callback)
		{
			if (FOnTimelineLinearColor.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTimelineLinearColor.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTimelineLinearColor.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTimelineLinearColor.OnScriptCallback));
				}
				FOnTimelineLinearColor.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnTimelineLinearColor.RegisterId);
		}

		// Token: 0x0600D1CB RID: 53707 RVA: 0x001336EC File Offset: 0x001318EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FLinearColor Output)
		{
			FOnTimelineLinearColor.__FOnTimelineLinearColor_DelegateParams* ptr = stackalloc FOnTimelineLinearColor.__FOnTimelineLinearColor_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnTimelineLinearColor.__FOnTimelineLinearColor_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTimelineLinearColor.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Output = Output;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D1CC RID: 53708 RVA: 0x0013372C File Offset: 0x0013192C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLinearColor> action = target as Action<FLinearColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTimelineLinearColor.__FOnTimelineLinearColor_DelegateParams*)__Parameters)->Output);
		}

		// Token: 0x0400709E RID: 28830
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400709F RID: 28831
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnTimelineLinearColor__DelegateSignature";

		// Token: 0x040070A0 RID: 28832
		private static int RegisterId;

		// Token: 0x02002DAE RID: 11694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnTimelineLinearColor_DelegateParams
		{
			// Token: 0x040167D3 RID: 92115
			[FieldOffset(0)]
			public FLinearColor Output;
		}

		// Token: 0x02002DAF RID: 11695
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167D4 RID: 92116
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

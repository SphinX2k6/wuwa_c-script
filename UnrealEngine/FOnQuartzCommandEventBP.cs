using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F27 RID: 3879
	public sealed class FOnQuartzCommandEventBP : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D167 RID: 53607 RVA: 0x00132844 File Offset: 0x00130A44
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQuartzCommandEventBP.StaticFunctionPtr();
		}

		// Token: 0x0600D168 RID: 53608 RVA: 0x00132850 File Offset: 0x00130A50
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQuartzCommandEventBP._FunctionPtr == IntPtr.Zero)
			{
				FOnQuartzCommandEventBP._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnQuartzCommandEventBP__DelegateSignature");
			}
			return FOnQuartzCommandEventBP._FunctionPtr;
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x00132873 File Offset: 0x00130A73
		public FOnQuartzCommandEventBP()
		{
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x0013287B File Offset: 0x00130A7B
		[NullableContext(2)]
		public FOnQuartzCommandEventBP(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x00132885 File Offset: 0x00130A85
		public FOnQuartzCommandEventBP(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x00132890 File Offset: 0x00130A90
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EQuartzCommandDelegateSubType, FName>) ?? ((Action<EQuartzCommandDelegateSubType, FName>)Delegate.CreateDelegate(typeof(Action<EQuartzCommandDelegateSubType, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x001328C2 File Offset: 0x00130AC2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<EQuartzCommandDelegateSubType, FName> Callback)
		{
			if (FOnQuartzCommandEventBP.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQuartzCommandEventBP.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQuartzCommandEventBP.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQuartzCommandEventBP.OnScriptCallback));
				}
				FOnQuartzCommandEventBP.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnQuartzCommandEventBP.RegisterId);
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x001328FC File Offset: 0x00130AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EQuartzCommandDelegateSubType EventType, FName Name)
		{
			FOnQuartzCommandEventBP.__FOnQuartzCommandEventBP_DelegateParams* ptr = stackalloc FOnQuartzCommandEventBP.__FOnQuartzCommandEventBP_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnQuartzCommandEventBP.__FOnQuartzCommandEventBP_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQuartzCommandEventBP.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventType = EventType;
			ptr->Name = Name;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x00132940 File Offset: 0x00130B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EQuartzCommandDelegateSubType, FName> action = target as Action<EQuartzCommandDelegateSubType, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnQuartzCommandEventBP.__FOnQuartzCommandEventBP_DelegateParams*)__Parameters)->EventType, ((FOnQuartzCommandEventBP.__FOnQuartzCommandEventBP_DelegateParams*)__Parameters)->Name);
		}

		// Token: 0x04007081 RID: 28801
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007082 RID: 28802
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnQuartzCommandEventBP__DelegateSignature";

		// Token: 0x04007083 RID: 28803
		private static int RegisterId;

		// Token: 0x02002D98 RID: 11672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnQuartzCommandEventBP_DelegateParams
		{
			// Token: 0x040167BA RID: 92090
			[FieldOffset(0)]
			public EQuartzCommandDelegateSubType EventType;

			// Token: 0x040167BB RID: 92091
			[FieldOffset(4)]
			public FName Name;
		}

		// Token: 0x02002D99 RID: 11673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167BC RID: 92092
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

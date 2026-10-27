using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F06 RID: 7942
	public sealed class FProcessCustomCommandDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E24B RID: 123467 RVA: 0x002CCFB8 File Offset: 0x002CB1B8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FProcessCustomCommandDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601E24C RID: 123468 RVA: 0x002CCFC4 File Offset: 0x002CB1C4
		private static IntPtr StaticFunctionPtr()
		{
			if (FProcessCustomCommandDelegate._FunctionPtr == IntPtr.Zero)
			{
				FProcessCustomCommandDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.ProcessCustomCommandDelegate__DelegateSignature");
			}
			return FProcessCustomCommandDelegate._FunctionPtr;
		}

		// Token: 0x0601E24D RID: 123469 RVA: 0x002CCFE7 File Offset: 0x002CB1E7
		public FProcessCustomCommandDelegate()
		{
		}

		// Token: 0x0601E24E RID: 123470 RVA: 0x002CCFEF File Offset: 0x002CB1EF
		[NullableContext(2)]
		public FProcessCustomCommandDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E24F RID: 123471 RVA: 0x002CCFF9 File Offset: 0x002CB1F9
		public FProcessCustomCommandDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E250 RID: 123472 RVA: 0x002CD004 File Offset: 0x002CB204
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E251 RID: 123473 RVA: 0x002CD036 File Offset: 0x002CB236
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FProcessCustomCommandDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FProcessCustomCommandDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FProcessCustomCommandDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FProcessCustomCommandDelegate.OnScriptCallback));
				}
				FProcessCustomCommandDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FProcessCustomCommandDelegate.RegisterId);
		}

		// Token: 0x0601E252 RID: 123474 RVA: 0x002CD070 File Offset: 0x002CB270
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Command)
		{
			FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams* ptr = stackalloc FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FProcessCustomCommandDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Command), Command);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FProcessCustomCommandDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E253 RID: 123475 RVA: 0x002CD0C4 File Offset: 0x002CB2C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams*)__Parameters)->Command));
			action(obj);
		}

		// Token: 0x04010473 RID: 66675
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010474 RID: 66676
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.ProcessCustomCommandDelegate__DelegateSignature";

		// Token: 0x04010475 RID: 66677
		private static int RegisterId;

		// Token: 0x020033F5 RID: 13301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FProcessCustomCommandDelegate_DelegateParams
		{
			// Token: 0x040173AF RID: 95151
			[FieldOffset(0)]
			public FString Command;
		}

		// Token: 0x020033F6 RID: 13302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173B0 RID: 95152
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

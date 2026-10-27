using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019BC RID: 6588
	public sealed class FLogDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018808 RID: 100360 RVA: 0x002419EE File Offset: 0x0023FBEE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLogDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018809 RID: 100361 RVA: 0x002419FA File Offset: 0x0023FBFA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLogDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLogDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroLogAnalyzer.LogDelegate__DelegateSignature");
			}
			return FLogDelegate._FunctionPtr;
		}

		// Token: 0x0601880A RID: 100362 RVA: 0x00241A1D File Offset: 0x0023FC1D
		public FLogDelegate()
		{
		}

		// Token: 0x0601880B RID: 100363 RVA: 0x00241A25 File Offset: 0x0023FC25
		[NullableContext(2)]
		public FLogDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601880C RID: 100364 RVA: 0x00241A2F File Offset: 0x0023FC2F
		public FLogDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601880D RID: 100365 RVA: 0x00241A3A File Offset: 0x0023FC3A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName, int, string, string>) ?? ((Action<FName, int, string, string>)Delegate.CreateDelegate(typeof(Action<FName, int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601880E RID: 100366 RVA: 0x00241A6C File Offset: 0x0023FC6C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FName, int, string, string> Callback)
		{
			if (FLogDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLogDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLogDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLogDelegate.OnScriptCallback));
				}
				FLogDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLogDelegate.RegisterId);
		}

		// Token: 0x0601880F RID: 100367 RVA: 0x00241AA8 File Offset: 0x0023FCA8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FName Category, int Verbosity, string Format, string Message)
		{
			FLogDelegate.__FLogDelegate_DelegateParams* ptr = stackalloc FLogDelegate.__FLogDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FLogDelegate.__FLogDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLogDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Category = Category;
			ptr->Verbosity = Verbosity;
			FString.CopyFrom((void*)(&ptr->Format), Format);
			FString.CopyFrom((void*)(&ptr->Message), Message);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLogDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018810 RID: 100368 RVA: 0x00241B20 File Offset: 0x0023FD20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, int, string, string> action = target as Action<FName, int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Format));
			string arg2 = FString.ToString((void*)(&((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Message));
			action(((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Category, ((FLogDelegate.__FLogDelegate_DelegateParams*)__Parameters)->Verbosity, arg, arg2);
		}

		// Token: 0x0400D3BF RID: 54207
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D3C0 RID: 54208
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroLogAnalyzer.LogDelegate__DelegateSignature";

		// Token: 0x0400D3C1 RID: 54209
		private static int RegisterId;

		// Token: 0x02003088 RID: 12424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FLogDelegate_DelegateParams
		{
			// Token: 0x04016D6C RID: 93548
			[FieldOffset(0)]
			public FName Category;

			// Token: 0x04016D6D RID: 93549
			[FieldOffset(12)]
			public int Verbosity;

			// Token: 0x04016D6E RID: 93550
			[FieldOffset(16)]
			public FString Format;

			// Token: 0x04016D6F RID: 93551
			[FieldOffset(32)]
			public FString Message;
		}

		// Token: 0x02003089 RID: 12425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D70 RID: 93552
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002766 RID: 10086
	public sealed class FSharpherealConsoleCommandWithWorldAndArgsDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025B76 RID: 154486 RVA: 0x00392A33 File Offset: 0x00390C33
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithWorldAndArgsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06025B77 RID: 154487 RVA: 0x00392A3F File Offset: 0x00390C3F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithWorldAndArgsDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr;
		}

		// Token: 0x06025B78 RID: 154488 RVA: 0x00392A62 File Offset: 0x00390C62
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate()
		{
		}

		// Token: 0x06025B79 RID: 154489 RVA: 0x00392A6A File Offset: 0x00390C6A
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B7A RID: 154490 RVA: 0x00392A74 File Offset: 0x00390C74
		public FSharpherealConsoleCommandWithWorldAndArgsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B7B RID: 154491 RVA: 0x00392A7F File Offset: 0x00390C7F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate) ?? ((FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025B7C RID: 154492 RVA: 0x00392AB1 File Offset: 0x00390CB1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate Callback)
		{
			if (FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithWorldAndArgsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithWorldAndArgsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithWorldAndArgsDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithWorldAndArgsDelegate.RegisterId);
		}

		// Token: 0x06025B7D RID: 154493 RVA: 0x00392AEC File Offset: 0x00390CEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args, UWorld World)
		{
			FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithWorldAndArgsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Args;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Args);
			}
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = Args;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Args);
			}
			UnrealReflectionUtils.DestroyStruct(FSharpherealConsoleCommandWithWorldAndArgsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025B7E RID: 154494 RVA: 0x00392B74 File Offset: 0x00390D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate = target as FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate;
			if (fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->Args, true, true);
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->World);
			fsharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate(tarray, orCreateUObjectByNativePointer);
			if (tarray != null)
			{
				tarray.CopyTo(&((FSharpherealConsoleCommandWithWorldAndArgsDelegate.__FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams*)__Parameters)->Args, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04014884 RID: 84100
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014885 RID: 84101
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithWorldAndArgsDelegate__DelegateSignature";

		// Token: 0x04014886 RID: 84102
		private static int RegisterId;

		// Token: 0x02003A5D RID: 14941
		// (Invoke) Token: 0x060285D2 RID: 165330
		public delegate void FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args, UWorld World);

		// Token: 0x02003A5E RID: 14942
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSharpherealConsoleCommandWithWorldAndArgsDelegate_DelegateParams
		{
			// Token: 0x04017BB6 RID: 97206
			[FieldOffset(0)]
			public byte Args;

			// Token: 0x04017BB7 RID: 97207
			[FieldOffset(16)]
			public IntPtr World;
		}

		// Token: 0x02003A5F RID: 14943
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BB8 RID: 97208
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

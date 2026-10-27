using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002765 RID: 10085
	public sealed class FSharpherealConsoleCommandWithArgsDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025B6D RID: 154477 RVA: 0x0039289A File Offset: 0x00390A9A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithArgsDelegate.StaticFunctionPtr();
		}

		// Token: 0x06025B6E RID: 154478 RVA: 0x003928A6 File Offset: 0x00390AA6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithArgsDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr;
		}

		// Token: 0x06025B6F RID: 154479 RVA: 0x003928C9 File Offset: 0x00390AC9
		public FSharpherealConsoleCommandWithArgsDelegate()
		{
		}

		// Token: 0x06025B70 RID: 154480 RVA: 0x003928D1 File Offset: 0x00390AD1
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithArgsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B71 RID: 154481 RVA: 0x003928DB File Offset: 0x00390ADB
		public FSharpherealConsoleCommandWithArgsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B72 RID: 154482 RVA: 0x003928E6 File Offset: 0x00390AE6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate) ?? ((FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025B73 RID: 154483 RVA: 0x00392918 File Offset: 0x00390B18
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate Callback)
		{
			if (FSharpherealConsoleCommandWithArgsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithArgsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithArgsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithArgsDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithArgsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithArgsDelegate.RegisterId);
		}

		// Token: 0x06025B74 RID: 154484 RVA: 0x00392954 File Offset: 0x00390B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args)
		{
			FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithArgsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = Args;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Args);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<string> tarray2 = Args;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Args);
			}
			UnrealReflectionUtils.DestroyStruct(FSharpherealConsoleCommandWithArgsDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025B75 RID: 154485 RVA: 0x003929C4 File Offset: 0x00390BC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate = target as FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate;
			if (fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams*)__Parameters)->Args, true, true);
			fsharpherealConsoleCommandWithArgsDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FSharpherealConsoleCommandWithArgsDelegate.__FSharpherealConsoleCommandWithArgsDelegate_DelegateParams*)__Parameters)->Args, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04014881 RID: 84097
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014882 RID: 84098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithArgsDelegate__DelegateSignature";

		// Token: 0x04014883 RID: 84099
		private static int RegisterId;

		// Token: 0x02003A5A RID: 14938
		// (Invoke) Token: 0x060285CE RID: 165326
		public delegate void FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> Args);

		// Token: 0x02003A5B RID: 14939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSharpherealConsoleCommandWithArgsDelegate_DelegateParams
		{
			// Token: 0x04017BB4 RID: 97204
			[FieldOffset(0)]
			public byte Args;
		}

		// Token: 0x02003A5C RID: 14940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BB5 RID: 97205
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002767 RID: 10087
	public sealed class FSharpherealConsoleCommandWithWorldDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025B7F RID: 154495 RVA: 0x00392BF1 File Offset: 0x00390DF1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandWithWorldDelegate.StaticFunctionPtr();
		}

		// Token: 0x06025B80 RID: 154496 RVA: 0x00392BFD File Offset: 0x00390DFD
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandWithWorldDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandWithWorldDelegate._FunctionPtr;
		}

		// Token: 0x06025B81 RID: 154497 RVA: 0x00392C20 File Offset: 0x00390E20
		public FSharpherealConsoleCommandWithWorldDelegate()
		{
		}

		// Token: 0x06025B82 RID: 154498 RVA: 0x00392C28 File Offset: 0x00390E28
		[NullableContext(2)]
		public FSharpherealConsoleCommandWithWorldDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B83 RID: 154499 RVA: 0x00392C32 File Offset: 0x00390E32
		public FSharpherealConsoleCommandWithWorldDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B84 RID: 154500 RVA: 0x00392C3D File Offset: 0x00390E3D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UWorld>) ?? ((Action<UWorld>)Delegate.CreateDelegate(typeof(Action<UWorld>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025B85 RID: 154501 RVA: 0x00392C6F File Offset: 0x00390E6F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UWorld> Callback)
		{
			if (FSharpherealConsoleCommandWithWorldDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandWithWorldDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandWithWorldDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandWithWorldDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandWithWorldDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandWithWorldDelegate.RegisterId);
		}

		// Token: 0x06025B86 RID: 154502 RVA: 0x00392CAC File Offset: 0x00390EAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UWorld World)
		{
			FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams* ptr = stackalloc FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealConsoleCommandWithWorldDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06025B87 RID: 154503 RVA: 0x00392CF8 File Offset: 0x00390EF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UWorld> action = target as Action<UWorld>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UWorld orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(((FSharpherealConsoleCommandWithWorldDelegate.__FSharpherealConsoleCommandWithWorldDelegate_DelegateParams*)__Parameters)->World);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04014887 RID: 84103
		internal static IntPtr _FunctionPtr;

		// Token: 0x04014888 RID: 84104
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandWithWorldDelegate__DelegateSignature";

		// Token: 0x04014889 RID: 84105
		private static int RegisterId;

		// Token: 0x02003A60 RID: 14944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSharpherealConsoleCommandWithWorldDelegate_DelegateParams
		{
			// Token: 0x04017BB9 RID: 97209
			[FieldOffset(0)]
			public IntPtr World;
		}

		// Token: 0x02003A61 RID: 14945
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BBA RID: 97210
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

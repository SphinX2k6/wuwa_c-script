using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FD0 RID: 8144
	public sealed class FCheckTextInputDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EE51 RID: 126545 RVA: 0x002DE9BC File Offset: 0x002DCBBC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCheckTextInputDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601EE52 RID: 126546 RVA: 0x002DE9C8 File Offset: 0x002DCBC8
		private static IntPtr StaticFunctionPtr()
		{
			if (FCheckTextInputDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCheckTextInputDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.CheckTextInputDelegate__DelegateSignature");
			}
			return FCheckTextInputDelegate._FunctionPtr;
		}

		// Token: 0x0601EE53 RID: 126547 RVA: 0x002DE9EB File Offset: 0x002DCBEB
		public FCheckTextInputDelegate()
		{
		}

		// Token: 0x0601EE54 RID: 126548 RVA: 0x002DE9F3 File Offset: 0x002DCBF3
		[NullableContext(2)]
		public FCheckTextInputDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE55 RID: 126549 RVA: 0x002DE9FD File Offset: 0x002DCBFD
		public FCheckTextInputDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE56 RID: 126550 RVA: 0x002DEA08 File Offset: 0x002DCC08
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EE57 RID: 126551 RVA: 0x002DEA3A File Offset: 0x002DCC3A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FCheckTextInputDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCheckTextInputDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCheckTextInputDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCheckTextInputDelegate.OnScriptCallback));
				}
				FCheckTextInputDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCheckTextInputDelegate.RegisterId);
		}

		// Token: 0x0601EE58 RID: 126552 RVA: 0x002DEA74 File Offset: 0x002DCC74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(string InString)
		{
			FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams* ptr = stackalloc FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCheckTextInputDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FCheckTextInputDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601EE59 RID: 126553 RVA: 0x002DEAD0 File Offset: 0x002DCCD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams*)__Parameters)->InString));
			bool _Result = func(arg);
			((FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04010B04 RID: 68356
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010B05 RID: 68357
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.CheckTextInputDelegate__DelegateSignature";

		// Token: 0x04010B06 RID: 68358
		private static int RegisterId;

		// Token: 0x02003425 RID: 13349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FCheckTextInputDelegate_DelegateParams
		{
			// Token: 0x04017400 RID: 95232
			[FieldOffset(0)]
			public FString InString;

			// Token: 0x04017401 RID: 95233
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003426 RID: 13350
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017402 RID: 95234
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

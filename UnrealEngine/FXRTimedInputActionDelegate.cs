using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001475 RID: 5237
	public sealed class FXRTimedInputActionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060131B5 RID: 78261 RVA: 0x001C1A3C File Offset: 0x001BFC3C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FXRTimedInputActionDelegate.StaticFunctionPtr();
		}

		// Token: 0x060131B6 RID: 78262 RVA: 0x001C1A48 File Offset: 0x001BFC48
		private static IntPtr StaticFunctionPtr()
		{
			if (FXRTimedInputActionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FXRTimedInputActionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/HeadMountedDisplay.XRTimedInputActionDelegate__DelegateSignature");
			}
			return FXRTimedInputActionDelegate._FunctionPtr;
		}

		// Token: 0x060131B7 RID: 78263 RVA: 0x001C1A6B File Offset: 0x001BFC6B
		public FXRTimedInputActionDelegate()
		{
		}

		// Token: 0x060131B8 RID: 78264 RVA: 0x001C1A73 File Offset: 0x001BFC73
		[NullableContext(2)]
		public FXRTimedInputActionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060131B9 RID: 78265 RVA: 0x001C1A7D File Offset: 0x001BFC7D
		public FXRTimedInputActionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060131BA RID: 78266 RVA: 0x001C1A88 File Offset: 0x001BFC88
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float, FTimespan>) ?? ((Action<float, FTimespan>)Delegate.CreateDelegate(typeof(Action<float, FTimespan>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060131BB RID: 78267 RVA: 0x001C1ABA File Offset: 0x001BFCBA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float, FTimespan> Callback)
		{
			if (FXRTimedInputActionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FXRTimedInputActionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FXRTimedInputActionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FXRTimedInputActionDelegate.OnScriptCallback));
				}
				FXRTimedInputActionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FXRTimedInputActionDelegate.RegisterId);
		}

		// Token: 0x060131BC RID: 78268 RVA: 0x001C1AF4 File Offset: 0x001BFCF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float Value, FTimespan Time)
		{
			FXRTimedInputActionDelegate.__FXRTimedInputActionDelegate_DelegateParams* ptr = stackalloc FXRTimedInputActionDelegate.__FXRTimedInputActionDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FXRTimedInputActionDelegate.__FXRTimedInputActionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FXRTimedInputActionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Value = Value;
			if (Time != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), &ptr->Time, Time.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x001C1B54 File Offset: 0x001BFD54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, FTimespan> action = target as Action<float, FTimespan>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FTimespan arg = new FTimespan(&((FXRTimedInputActionDelegate.__FXRTimedInputActionDelegate_DelegateParams*)__Parameters)->Time, true, true);
			action(((FXRTimedInputActionDelegate.__FXRTimedInputActionDelegate_DelegateParams*)__Parameters)->Value, arg);
		}

		// Token: 0x0400A3DC RID: 41948
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400A3DD RID: 41949
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRTimedInputActionDelegate__DelegateSignature";

		// Token: 0x0400A3DE RID: 41950
		private static int RegisterId;

		// Token: 0x02002EB0 RID: 11952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FXRTimedInputActionDelegate_DelegateParams
		{
			// Token: 0x040169AB RID: 92587
			[FieldOffset(0)]
			public float Value;

			// Token: 0x040169AC RID: 92588
			[FieldOffset(8)]
			public byte Time;
		}

		// Token: 0x02002EB1 RID: 11953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169AD RID: 92589
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

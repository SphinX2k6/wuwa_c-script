using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BB RID: 8379
	public sealed class FLGUIScrollbarDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F90C RID: 129292 RVA: 0x002EEB86 File Offset: 0x002ECD86
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollbarDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F90D RID: 129293 RVA: 0x002EEB92 File Offset: 0x002ECD92
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollbarDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollbarDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollbarDelegate__DelegateSignature");
			}
			return FLGUIScrollbarDelegate._FunctionPtr;
		}

		// Token: 0x0601F90E RID: 129294 RVA: 0x002EEBB5 File Offset: 0x002ECDB5
		public FLGUIScrollbarDelegate()
		{
		}

		// Token: 0x0601F90F RID: 129295 RVA: 0x002EEBBD File Offset: 0x002ECDBD
		[NullableContext(2)]
		public FLGUIScrollbarDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F910 RID: 129296 RVA: 0x002EEBC7 File Offset: 0x002ECDC7
		public FLGUIScrollbarDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F911 RID: 129297 RVA: 0x002EEBD2 File Offset: 0x002ECDD2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIScrollbarComponent, bool>) ?? ((Action<UUIScrollbarComponent, bool>)Delegate.CreateDelegate(typeof(Action<UUIScrollbarComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F912 RID: 129298 RVA: 0x002EEC04 File Offset: 0x002ECE04
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIScrollbarComponent, bool> Callback)
		{
			if (FLGUIScrollbarDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollbarDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollbarDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollbarDelegate.OnScriptCallback));
				}
				FLGUIScrollbarDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollbarDelegate.RegisterId);
		}

		// Token: 0x0601F913 RID: 129299 RVA: 0x002EEC40 File Offset: 0x002ECE40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUIScrollbarComponent ScrollbarComponent, bool ativeOrInactive)
		{
			FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams* ptr = stackalloc FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollbarDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScrollbarComponent = ((ScrollbarComponent != null) ? ScrollbarComponent.NativePtr : IntPtr.Zero);
			ptr->ativeOrInactive = ativeOrInactive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F914 RID: 129300 RVA: 0x002EEC94 File Offset: 0x002ECE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIScrollbarComponent, bool> action = target as Action<UUIScrollbarComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIScrollbarComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIScrollbarComponent>(((FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams*)__Parameters)->ScrollbarComponent);
			action(orCreateUObjectByNativePointer, ((FLGUIScrollbarDelegate.__FLGUIScrollbarDelegate_DelegateParams*)__Parameters)->ativeOrInactive);
		}

		// Token: 0x040110A4 RID: 69796
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110A5 RID: 69797
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollbarDelegate__DelegateSignature";

		// Token: 0x040110A6 RID: 69798
		private static int RegisterId;

		// Token: 0x020034AE RID: 13486
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIScrollbarDelegate_DelegateParams
		{
			// Token: 0x040174B5 RID: 95413
			[FieldOffset(0)]
			public IntPtr ScrollbarComponent;

			// Token: 0x040174B6 RID: 95414
			[FieldOffset(8)]
			public bool ativeOrInactive;
		}

		// Token: 0x020034AF RID: 13487
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174B7 RID: 95415
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

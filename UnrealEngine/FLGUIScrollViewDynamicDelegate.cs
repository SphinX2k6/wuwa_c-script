using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BE RID: 8382
	public sealed class FLGUIScrollViewDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F927 RID: 129319 RVA: 0x002EEF85 File Offset: 0x002ED185
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollViewDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F928 RID: 129320 RVA: 0x002EEF91 File Offset: 0x002ED191
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollViewDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollViewDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollViewDynamicDelegate__DelegateSignature");
			}
			return FLGUIScrollViewDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F929 RID: 129321 RVA: 0x002EEFB4 File Offset: 0x002ED1B4
		public FLGUIScrollViewDynamicDelegate()
		{
		}

		// Token: 0x0601F92A RID: 129322 RVA: 0x002EEFBC File Offset: 0x002ED1BC
		[NullableContext(2)]
		public FLGUIScrollViewDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F92B RID: 129323 RVA: 0x002EEFC6 File Offset: 0x002ED1C6
		public FLGUIScrollViewDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F92C RID: 129324 RVA: 0x002EEFD1 File Offset: 0x002ED1D1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F92D RID: 129325 RVA: 0x002EF003 File Offset: 0x002ED203
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector2D> Callback)
		{
			if (FLGUIScrollViewDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollViewDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollViewDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollViewDynamicDelegate.OnScriptCallback));
				}
				FLGUIScrollViewDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollViewDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F92E RID: 129326 RVA: 0x002EF040 File Offset: 0x002ED240
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FVector2D InVector2)
		{
			FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollViewDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InVector2 = InVector2;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x002EF080 File Offset: 0x002ED280
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams*)__Parameters)->InVector2);
		}

		// Token: 0x040110AD RID: 69805
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110AE RID: 69806
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollViewDynamicDelegate__DelegateSignature";

		// Token: 0x040110AF RID: 69807
		private static int RegisterId;

		// Token: 0x020034B4 RID: 13492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIScrollViewDynamicDelegate_DelegateParams
		{
			// Token: 0x040174BC RID: 95420
			[FieldOffset(0)]
			public FVector2D InVector2;
		}

		// Token: 0x020034B5 RID: 13493
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174BD RID: 95421
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

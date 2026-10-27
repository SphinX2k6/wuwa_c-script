using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BC RID: 8380
	public sealed class FLGUIScrollbarDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F915 RID: 129301 RVA: 0x002EECEB File Offset: 0x002ECEEB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollbarDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F916 RID: 129302 RVA: 0x002EECF7 File Offset: 0x002ECEF7
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollbarDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollbarDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollbarDynamicDelegate__DelegateSignature");
			}
			return FLGUIScrollbarDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F917 RID: 129303 RVA: 0x002EED1A File Offset: 0x002ECF1A
		public FLGUIScrollbarDynamicDelegate()
		{
		}

		// Token: 0x0601F918 RID: 129304 RVA: 0x002EED22 File Offset: 0x002ECF22
		[NullableContext(2)]
		public FLGUIScrollbarDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F919 RID: 129305 RVA: 0x002EED2C File Offset: 0x002ECF2C
		public FLGUIScrollbarDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F91A RID: 129306 RVA: 0x002EED37 File Offset: 0x002ECF37
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F91B RID: 129307 RVA: 0x002EED69 File Offset: 0x002ECF69
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIScrollbarDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollbarDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollbarDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollbarDynamicDelegate.OnScriptCallback));
				}
				FLGUIScrollbarDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollbarDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F91C RID: 129308 RVA: 0x002EEDA4 File Offset: 0x002ECFA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float InFloat)
		{
			FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollbarDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InFloat = InFloat;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F91D RID: 129309 RVA: 0x002EEDE4 File Offset: 0x002ECFE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams*)__Parameters)->InFloat);
		}

		// Token: 0x040110A7 RID: 69799
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110A8 RID: 69800
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollbarDynamicDelegate__DelegateSignature";

		// Token: 0x040110A9 RID: 69801
		private static int RegisterId;

		// Token: 0x020034B0 RID: 13488
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIScrollbarDynamicDelegate_DelegateParams
		{
			// Token: 0x040174B8 RID: 95416
			[FieldOffset(0)]
			public float InFloat;
		}

		// Token: 0x020034B1 RID: 13489
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174B9 RID: 95417
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

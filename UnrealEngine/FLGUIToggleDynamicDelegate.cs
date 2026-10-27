using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D9 RID: 8409
	public sealed class FLGUIToggleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FABC RID: 129724 RVA: 0x002F19F7 File Offset: 0x002EFBF7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIToggleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FABD RID: 129725 RVA: 0x002F1A03 File Offset: 0x002EFC03
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIToggleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIToggleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIToggleDynamicDelegate__DelegateSignature");
			}
			return FLGUIToggleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601FABE RID: 129726 RVA: 0x002F1A26 File Offset: 0x002EFC26
		public FLGUIToggleDynamicDelegate()
		{
		}

		// Token: 0x0601FABF RID: 129727 RVA: 0x002F1A2E File Offset: 0x002EFC2E
		[NullableContext(2)]
		public FLGUIToggleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x002F1A38 File Offset: 0x002EFC38
		public FLGUIToggleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FAC1 RID: 129729 RVA: 0x002F1A43 File Offset: 0x002EFC43
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FAC2 RID: 129730 RVA: 0x002F1A75 File Offset: 0x002EFC75
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIToggleDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIToggleDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIToggleDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIToggleDynamicDelegate.OnScriptCallback));
				}
				FLGUIToggleDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIToggleDynamicDelegate.RegisterId);
		}

		// Token: 0x0601FAC3 RID: 129731 RVA: 0x002F1AB0 File Offset: 0x002EFCB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool InBool)
		{
			FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIToggleDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InBool = InBool;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FAC4 RID: 129732 RVA: 0x002F1AF0 File Offset: 0x002EFCF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams*)__Parameters)->InBool);
		}

		// Token: 0x0401116B RID: 69995
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401116C RID: 69996
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIToggleDynamicDelegate__DelegateSignature";

		// Token: 0x0401116D RID: 69997
		private static int RegisterId;

		// Token: 0x020034CC RID: 13516
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIToggleDynamicDelegate_DelegateParams
		{
			// Token: 0x040174D7 RID: 95447
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x020034CD RID: 13517
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174D8 RID: 95448
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

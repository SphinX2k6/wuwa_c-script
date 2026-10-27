using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002027 RID: 8231
	public sealed class FLGUIBehaviourLateUpdateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F040 RID: 127040 RVA: 0x002E1B8C File Offset: 0x002DFD8C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIBehaviourLateUpdateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F041 RID: 127041 RVA: 0x002E1B98 File Offset: 0x002DFD98
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIBehaviourLateUpdateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIBehaviourLateUpdateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIBehaviourLateUpdateDelegate__DelegateSignature");
			}
			return FLGUIBehaviourLateUpdateDelegate._FunctionPtr;
		}

		// Token: 0x0601F042 RID: 127042 RVA: 0x002E1BBB File Offset: 0x002DFDBB
		public FLGUIBehaviourLateUpdateDelegate()
		{
		}

		// Token: 0x0601F043 RID: 127043 RVA: 0x002E1BC3 File Offset: 0x002DFDC3
		[NullableContext(2)]
		public FLGUIBehaviourLateUpdateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F044 RID: 127044 RVA: 0x002E1BCD File Offset: 0x002DFDCD
		public FLGUIBehaviourLateUpdateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F045 RID: 127045 RVA: 0x002E1BD8 File Offset: 0x002DFDD8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F046 RID: 127046 RVA: 0x002E1C0A File Offset: 0x002DFE0A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIBehaviourLateUpdateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIBehaviourLateUpdateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIBehaviourLateUpdateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIBehaviourLateUpdateDelegate.OnScriptCallback));
				}
				FLGUIBehaviourLateUpdateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIBehaviourLateUpdateDelegate.RegisterId);
		}

		// Token: 0x0601F047 RID: 127047 RVA: 0x002E1C44 File Offset: 0x002DFE44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float DeltaTime)
		{
			FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams* ptr = stackalloc FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIBehaviourLateUpdateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F048 RID: 127048 RVA: 0x002E1C84 File Offset: 0x002DFE84
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
			action(((FLGUIBehaviourLateUpdateDelegate.__FLGUIBehaviourLateUpdateDelegate_DelegateParams*)__Parameters)->DeltaTime);
		}

		// Token: 0x04010DA2 RID: 69026
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010DA3 RID: 69027
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIBehaviourLateUpdateDelegate__DelegateSignature";

		// Token: 0x04010DA4 RID: 69028
		private static int RegisterId;

		// Token: 0x02003433 RID: 13363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIBehaviourLateUpdateDelegate_DelegateParams
		{
			// Token: 0x04017412 RID: 95250
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003434 RID: 13364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017413 RID: 95251
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

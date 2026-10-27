using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002038 RID: 8248
	public sealed class FLGUIDraggableDynamicDelegateTwoParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F32A RID: 127786 RVA: 0x002E51E9 File Offset: 0x002E33E9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableDynamicDelegateTwoParams.StaticFunctionPtr();
		}

		// Token: 0x0601F32B RID: 127787 RVA: 0x002E51F5 File Offset: 0x002E33F5
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableDynamicDelegateTwoParams__DelegateSignature");
			}
			return FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr;
		}

		// Token: 0x0601F32C RID: 127788 RVA: 0x002E5218 File Offset: 0x002E3418
		public FLGUIDraggableDynamicDelegateTwoParams()
		{
		}

		// Token: 0x0601F32D RID: 127789 RVA: 0x002E5220 File Offset: 0x002E3420
		[NullableContext(2)]
		public FLGUIDraggableDynamicDelegateTwoParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F32E RID: 127790 RVA: 0x002E522A File Offset: 0x002E342A
		public FLGUIDraggableDynamicDelegateTwoParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F32F RID: 127791 RVA: 0x002E5235 File Offset: 0x002E3435
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, bool>) ?? ((Action<bool, bool>)Delegate.CreateDelegate(typeof(Action<bool, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F330 RID: 127792 RVA: 0x002E5267 File Offset: 0x002E3467
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool, bool> Callback)
		{
			if (FLGUIDraggableDynamicDelegateTwoParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableDynamicDelegateTwoParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableDynamicDelegateTwoParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableDynamicDelegateTwoParams.OnScriptCallback));
				}
				FLGUIDraggableDynamicDelegateTwoParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableDynamicDelegateTwoParams.RegisterId);
		}

		// Token: 0x0601F331 RID: 127793 RVA: 0x002E52A4 File Offset: 0x002E34A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool PositionChanged, bool SizeChanged)
		{
			FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams* ptr = stackalloc FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams[(UIntPtr)17] + 15L / (long)sizeof(FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableDynamicDelegateTwoParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PositionChanged = PositionChanged;
			ptr->SizeChanged = SizeChanged;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F332 RID: 127794 RVA: 0x002E52E8 File Offset: 0x002E34E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, bool> action = target as Action<bool, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams*)__Parameters)->PositionChanged, ((FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams*)__Parameters)->SizeChanged);
		}

		// Token: 0x04010E29 RID: 69161
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E2A RID: 69162
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableDynamicDelegateTwoParams__DelegateSignature";

		// Token: 0x04010E2B RID: 69163
		private static int RegisterId;

		// Token: 0x02003442 RID: 13378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __FLGUIDraggableDynamicDelegateTwoParams_DelegateParams
		{
			// Token: 0x04017424 RID: 95268
			[FieldOffset(0)]
			public bool PositionChanged;

			// Token: 0x04017425 RID: 95269
			[FieldOffset(1)]
			public bool SizeChanged;
		}

		// Token: 0x02003443 RID: 13379
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017426 RID: 95270
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

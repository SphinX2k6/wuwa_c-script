using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002050 RID: 8272
	public sealed class FLGUIDrawableEvent_Int64_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F40B RID: 128011 RVA: 0x002E67EC File Offset: 0x002E49EC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Int64_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F40C RID: 128012 RVA: 0x002E67F8 File Offset: 0x002E49F8
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Int64_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Int64_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F40D RID: 128013 RVA: 0x002E681B File Offset: 0x002E4A1B
		public FLGUIDrawableEvent_Int64_DynamicDelegate()
		{
		}

		// Token: 0x0601F40E RID: 128014 RVA: 0x002E6823 File Offset: 0x002E4A23
		[NullableContext(2)]
		public FLGUIDrawableEvent_Int64_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F40F RID: 128015 RVA: 0x002E682D File Offset: 0x002E4A2D
		public FLGUIDrawableEvent_Int64_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F410 RID: 128016 RVA: 0x002E6838 File Offset: 0x002E4A38
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F411 RID: 128017 RVA: 0x002E686A File Offset: 0x002E4A6A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<long> Callback)
		{
			if (FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Int64_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Int64_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Int64_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Int64_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F412 RID: 128018 RVA: 0x002E68A4 File Offset: 0x002E4AA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(long value)
		{
			FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Int64_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F413 RID: 128019 RVA: 0x002E68E4 File Offset: 0x002E4AE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long> action = target as Action<long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Int64_DynamicDelegate.__FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E8E RID: 69262
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E8F RID: 69263
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Int64_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E90 RID: 69264
		private static int RegisterId;

		// Token: 0x02003456 RID: 13398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_Int64_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017439 RID: 95289
			[FieldOffset(0)]
			public long value;
		}

		// Token: 0x02003457 RID: 13399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401743A RID: 95290
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068C RID: 1676
	public sealed class FLGUIDrawableEvent_Vector3_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090DA RID: 37082 RVA: 0x000D9CFA File Offset: 0x000D7EFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector3_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x000D9D06 File Offset: 0x000D7F06
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector3_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x000D9D29 File Offset: 0x000D7F29
		public FLGUIDrawableEvent_Vector3_DynamicDelegate()
		{
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x000D9D31 File Offset: 0x000D7F31
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector3_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x000D9D3B File Offset: 0x000D7F3B
		public FLGUIDrawableEvent_Vector3_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x000D9D46 File Offset: 0x000D7F46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x000D9D78 File Offset: 0x000D7F78
		[NullableContext(1)]
		public void Bind(Action<FVector> Callback)
		{
			if (FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Vector3_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Vector3_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Vector3_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x000D9DB4 File Offset: 0x000D7FB4
		[SkipLocalsInit]
		public unsafe void Execute(FVector value)
		{
			FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector3_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x000D9DF4 File Offset: 0x000D7FF4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F3D RID: 16189
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F3E RID: 16190
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector3_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F3F RID: 16191
		private static int RegisterId;

		// Token: 0x02000EAB RID: 3755
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400625A RID: 25178
			[FieldOffset(0)]
			public FVector value;
		}

		// Token: 0x02000EAC RID: 3756
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400625B RID: 25179
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

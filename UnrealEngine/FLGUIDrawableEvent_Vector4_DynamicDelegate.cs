using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068D RID: 1677
	public sealed class FLGUIDrawableEvent_Vector4_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090E3 RID: 37091 RVA: 0x000D9E3E File Offset: 0x000D803E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector4_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x000D9E4A File Offset: 0x000D804A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector4_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x000D9E6D File Offset: 0x000D806D
		public FLGUIDrawableEvent_Vector4_DynamicDelegate()
		{
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x000D9E75 File Offset: 0x000D8075
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector4_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x000D9E7F File Offset: 0x000D807F
		public FLGUIDrawableEvent_Vector4_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x000D9E8A File Offset: 0x000D808A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector4>) ?? ((Action<FVector4>)Delegate.CreateDelegate(typeof(Action<FVector4>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x000D9EBC File Offset: 0x000D80BC
		[NullableContext(1)]
		public void Bind(Action<FVector4> Callback)
		{
			if (FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Vector4_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Vector4_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Vector4_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x000D9EF8 File Offset: 0x000D80F8
		[SkipLocalsInit]
		public unsafe void Execute(FVector4 value)
		{
			FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector4_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090EB RID: 37099 RVA: 0x000D9F38 File Offset: 0x000D8138
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector4> action = target as Action<FVector4>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F40 RID: 16192
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F41 RID: 16193
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector4_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F42 RID: 16194
		private static int RegisterId;

		// Token: 0x02000EAD RID: 3757
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400625C RID: 25180
			[FieldOffset(0)]
			public FVector4 value;
		}

		// Token: 0x02000EAE RID: 3758
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400625D RID: 25181
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

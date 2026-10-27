using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C16 RID: 7190
	public sealed class FOnCharacterShadowConfigChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBCA RID: 113610 RVA: 0x0028D05E File Offset: 0x0028B25E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCharacterShadowConfigChanged.StaticFunctionPtr();
		}

		// Token: 0x0601BBCB RID: 113611 RVA: 0x0028D06A File Offset: 0x0028B26A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCharacterShadowConfigChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnCharacterShadowConfigChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnCharacterShadowConfigChanged__DelegateSignature");
			}
			return FOnCharacterShadowConfigChanged._FunctionPtr;
		}

		// Token: 0x0601BBCC RID: 113612 RVA: 0x0028D08D File Offset: 0x0028B28D
		public FOnCharacterShadowConfigChanged()
		{
		}

		// Token: 0x0601BBCD RID: 113613 RVA: 0x0028D095 File Offset: 0x0028B295
		[NullableContext(2)]
		public FOnCharacterShadowConfigChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBCE RID: 113614 RVA: 0x0028D09F File Offset: 0x0028B29F
		public FOnCharacterShadowConfigChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBCF RID: 113615 RVA: 0x0028D0AA File Offset: 0x0028B2AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBD0 RID: 113616 RVA: 0x0028D0DC File Offset: 0x0028B2DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FName> Callback)
		{
			if (FOnCharacterShadowConfigChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCharacterShadowConfigChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCharacterShadowConfigChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCharacterShadowConfigChanged.OnScriptCallback));
				}
				FOnCharacterShadowConfigChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnCharacterShadowConfigChanged.RegisterId);
		}

		// Token: 0x0601BBD1 RID: 113617 RVA: 0x0028D118 File Offset: 0x0028B318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FName CVarName)
		{
			FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams* ptr = stackalloc FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCharacterShadowConfigChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CVarName = CVarName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601BBD2 RID: 113618 RVA: 0x0028D158 File Offset: 0x0028B358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams*)__Parameters)->CVarName);
		}

		// Token: 0x0400EE93 RID: 61075
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EE94 RID: 61076
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnCharacterShadowConfigChanged__DelegateSignature";

		// Token: 0x0400EE95 RID: 61077
		private static int RegisterId;

		// Token: 0x02003199 RID: 12697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnCharacterShadowConfigChanged_DelegateParams
		{
			// Token: 0x04016FD7 RID: 94167
			[FieldOffset(0)]
			public FName CVarName;
		}

		// Token: 0x0200319A RID: 12698
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FD8 RID: 94168
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

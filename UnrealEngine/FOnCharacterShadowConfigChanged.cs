using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F0 RID: 1264
	public sealed class FOnCharacterShadowConfigChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600771A RID: 30490 RVA: 0x000AE03A File Offset: 0x000AC23A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCharacterShadowConfigChanged.StaticFunctionPtr();
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x000AE046 File Offset: 0x000AC246
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCharacterShadowConfigChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnCharacterShadowConfigChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnCharacterShadowConfigChanged__DelegateSignature");
			}
			return FOnCharacterShadowConfigChanged._FunctionPtr;
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x000AE069 File Offset: 0x000AC269
		public FOnCharacterShadowConfigChanged()
		{
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x000AE071 File Offset: 0x000AC271
		[NullableContext(2)]
		public FOnCharacterShadowConfigChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x000AE07B File Offset: 0x000AC27B
		public FOnCharacterShadowConfigChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x000AE086 File Offset: 0x000AC286
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000AE0B8 File Offset: 0x000AC2B8
		[NullableContext(1)]
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

		// Token: 0x06007721 RID: 30497 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		[SkipLocalsInit]
		public unsafe void Execute(FName CVarName)
		{
			FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams* ptr = stackalloc FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCharacterShadowConfigChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CVarName = CVarName;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x000AE134 File Offset: 0x000AC334
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnCharacterShadowConfigChanged.__FOnCharacterShadowConfigChanged_DelegateParams*)__Parameters)->CVarName);
		}

		// Token: 0x04003238 RID: 12856
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003239 RID: 12857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnCharacterShadowConfigChanged__DelegateSignature";

		// Token: 0x0400323A RID: 12858
		private static int RegisterId;

		// Token: 0x02000C2F RID: 3119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FOnCharacterShadowConfigChanged_DelegateParams
		{
			// Token: 0x04005E7C RID: 24188
			[FieldOffset(0)]
			public FName CVarName;
		}

		// Token: 0x02000C30 RID: 3120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E7D RID: 24189
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

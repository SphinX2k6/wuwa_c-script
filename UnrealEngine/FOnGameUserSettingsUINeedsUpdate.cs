using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000253 RID: 595
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameUserSettingsUINeedsUpdate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032F5 RID: 13045 RVA: 0x00048E5D File Offset: 0x0004705D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameUserSettingsUINeedsUpdate.StaticFunctionPtr();
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00048E69 File Offset: 0x00047069
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameUserSettingsUINeedsUpdate._FunctionPtr == IntPtr.Zero)
			{
				FOnGameUserSettingsUINeedsUpdate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature");
			}
			return FOnGameUserSettingsUINeedsUpdate._FunctionPtr;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00048E8C File Offset: 0x0004708C
		public FOnGameUserSettingsUINeedsUpdate()
		{
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00048E94 File Offset: 0x00047094
		[NullableContext(2)]
		public FOnGameUserSettingsUINeedsUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00048E9E File Offset: 0x0004709E
		public FOnGameUserSettingsUINeedsUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00048EA9 File Offset: 0x000470A9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00048EDB File Offset: 0x000470DB
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnGameUserSettingsUINeedsUpdate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameUserSettingsUINeedsUpdate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameUserSettingsUINeedsUpdate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameUserSettingsUINeedsUpdate.OnScriptCallback));
				}
				FOnGameUserSettingsUINeedsUpdate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameUserSettingsUINeedsUpdate.RegisterId);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x00048F15 File Offset: 0x00047115
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00048F1E File Offset: 0x0004711E
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00048F28 File Offset: 0x00047128
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040011C5 RID: 4549
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011C6 RID: 4550
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature";

		// Token: 0x040011C7 RID: 4551
		private static int RegisterId;

		// Token: 0x020009D2 RID: 2514
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400595F RID: 22879
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

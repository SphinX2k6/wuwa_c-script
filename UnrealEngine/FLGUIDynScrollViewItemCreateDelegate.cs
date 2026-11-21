using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068F RID: 1679
	public sealed class FLGUIDynScrollViewItemCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090F5 RID: 37109 RVA: 0x000DA0E7 File Offset: 0x000D82E7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x000DA0F3 File Offset: 0x000D82F3
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemCreateDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemCreateDelegate._FunctionPtr;
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x000DA116 File Offset: 0x000D8316
		public FLGUIDynScrollViewItemCreateDelegate()
		{
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x000DA11E File Offset: 0x000D831E
		[NullableContext(2)]
		public FLGUIDynScrollViewItemCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x000DA128 File Offset: 0x000D8328
		public FLGUIDynScrollViewItemCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x000DA133 File Offset: 0x000D8333
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x000DA165 File Offset: 0x000D8365
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIDynScrollViewItemCreateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDynScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDynScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDynScrollViewItemCreateDelegate.OnScriptCallback));
				}
				FLGUIDynScrollViewItemCreateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDynScrollViewItemCreateDelegate.RegisterId);
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x000DA1A0 File Offset: 0x000D83A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int DisplayIndex, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DisplayIndex = DisplayIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x000DA1F4 File Offset: 0x000D83F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->DisplayIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003F46 RID: 16198
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F47 RID: 16199
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemCreateDelegate__DelegateSignature";

		// Token: 0x04003F48 RID: 16200
		private static int RegisterId;

		// Token: 0x02000EB1 RID: 3761
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDynScrollViewItemCreateDelegate_DelegateParams
		{
			// Token: 0x04006261 RID: 25185
			[FieldOffset(0)]
			public int DisplayIndex;

			// Token: 0x04006262 RID: 25186
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000EB2 RID: 3762
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006263 RID: 25187
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206A RID: 8298
	public sealed class FLGUIDynScrollViewItemCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4E7 RID: 128231 RVA: 0x002E7DE3 File Offset: 0x002E5FE3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDynScrollViewItemCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4E8 RID: 128232 RVA: 0x002E7DEF File Offset: 0x002E5FEF
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDynScrollViewItemCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDynScrollViewItemCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDynScrollViewItemCreateDelegate__DelegateSignature");
			}
			return FLGUIDynScrollViewItemCreateDelegate._FunctionPtr;
		}

		// Token: 0x0601F4E9 RID: 128233 RVA: 0x002E7E12 File Offset: 0x002E6012
		public FLGUIDynScrollViewItemCreateDelegate()
		{
		}

		// Token: 0x0601F4EA RID: 128234 RVA: 0x002E7E1A File Offset: 0x002E601A
		[NullableContext(2)]
		public FLGUIDynScrollViewItemCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4EB RID: 128235 RVA: 0x002E7E24 File Offset: 0x002E6024
		public FLGUIDynScrollViewItemCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4EC RID: 128236 RVA: 0x002E7E2F File Offset: 0x002E602F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4ED RID: 128237 RVA: 0x002E7E61 File Offset: 0x002E6061
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F4EE RID: 128238 RVA: 0x002E7E9C File Offset: 0x002E609C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int DisplayIndex, AUIBaseActor Actor)
		{
			FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams* ptr = stackalloc FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDynScrollViewItemCreateDelegate.__FLGUIDynScrollViewItemCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDynScrollViewItemCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DisplayIndex = DisplayIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4EF RID: 128239 RVA: 0x002E7EF0 File Offset: 0x002E60F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010ECE RID: 69326
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010ECF RID: 69327
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDynScrollViewItemCreateDelegate__DelegateSignature";

		// Token: 0x04010ED0 RID: 69328
		private static int RegisterId;

		// Token: 0x0200346E RID: 13422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDynScrollViewItemCreateDelegate_DelegateParams
		{
			// Token: 0x04017452 RID: 95314
			[FieldOffset(0)]
			public int DisplayIndex;

			// Token: 0x04017453 RID: 95315
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x0200346F RID: 13423
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017454 RID: 95316
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

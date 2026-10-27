using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200094E RID: 2382
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060086F2 RID: 34546 RVA: 0x000C064E File Offset: 0x000BE84E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x000C065A File Offset: 0x000BE85A
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature");
			}
			return FComponentBeginCursorOverSignature._FunctionPtr;
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x000C067D File Offset: 0x000BE87D
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnBeginCursorOver;
			}
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x000C0684 File Offset: 0x000BE884
		[NullableContext(2)]
		public FComponentBeginCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x000C068E File Offset: 0x000BE88E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent>) ?? ((Action<UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x000C06C0 File Offset: 0x000BE8C0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			if (FComponentBeginCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginCursorOverSignature.OnScriptCallback));
				}
				FComponentBeginCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginCursorOverSignature.RegisterId);
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x000C0710 File Offset: 0x000BE910
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x000C0730 File Offset: 0x000BE930
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent)
		{
			FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams* ptr = stackalloc FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x000C078C File Offset: 0x000BE98C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent> action = target as Action<UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginCursorOverSignature.__FComponentBeginCursorOverSignature_DelegateParams*)__Parameters)->TouchedComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400403D RID: 16445
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400403E RID: 16446
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginCursorOverSignature__DelegateSignature";

		// Token: 0x0400403F RID: 16447
		private static int RegisterId;

		// Token: 0x02002CBF RID: 11455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FComponentBeginCursorOverSignature_DelegateParams
		{
			// Token: 0x04016650 RID: 91728
			[FieldOffset(0)]
			public IntPtr TouchedComponent;
		}

		// Token: 0x02002CC0 RID: 11456
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016651 RID: 91729
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

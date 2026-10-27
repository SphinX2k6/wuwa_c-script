using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000965 RID: 2405
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentWakeSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060087D8 RID: 34776 RVA: 0x000C2892 File Offset: 0x000C0A92
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentWakeSignature.StaticFunctionPtr();
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x000C289E File Offset: 0x000C0A9E
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentWakeSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentWakeSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentWakeSignature__DelegateSignature");
			}
			return FComponentWakeSignature._FunctionPtr;
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060087DA RID: 34778 RVA: 0x000C28C1 File Offset: 0x000C0AC1
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentWake;
			}
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x000C28C8 File Offset: 0x000C0AC8
		[NullableContext(2)]
		public FComponentWakeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x000C28D2 File Offset: 0x000C0AD2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FName>) ?? ((Action<UPrimitiveComponent, FName>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x000C2904 File Offset: 0x000C0B04
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			if (FComponentWakeSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentWakeSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentWakeSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentWakeSignature.OnScriptCallback));
				}
				FComponentWakeSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentWakeSignature.RegisterId);
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x000C2954 File Offset: 0x000C0B54
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x000C2974 File Offset: 0x000C0B74
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent WakingComponent, FName BoneName)
		{
			FComponentWakeSignature.__FComponentWakeSignature_DelegateParams* ptr = stackalloc FComponentWakeSignature.__FComponentWakeSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentWakeSignature.__FComponentWakeSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentWakeSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->WakingComponent = ((WakingComponent != null) ? WakingComponent.NativePtr : IntPtr.Zero);
			ptr->BoneName = BoneName;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x000C29D8 File Offset: 0x000C0BD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FName> action = target as Action<UPrimitiveComponent, FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentWakeSignature.__FComponentWakeSignature_DelegateParams*)__Parameters)->WakingComponent);
			action(orCreateUObjectByNativePointer, ((FComponentWakeSignature.__FComponentWakeSignature_DelegateParams*)__Parameters)->BoneName);
		}

		// Token: 0x04004091 RID: 16529
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004092 RID: 16530
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentWakeSignature__DelegateSignature";

		// Token: 0x04004093 RID: 16531
		private static int RegisterId;

		// Token: 0x02002CDD RID: 11485
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FComponentWakeSignature_DelegateParams
		{
			// Token: 0x0401668A RID: 91786
			[FieldOffset(0)]
			public IntPtr WakingComponent;

			// Token: 0x0401668B RID: 91787
			[FieldOffset(8)]
			public FName BoneName;
		}

		// Token: 0x02002CDE RID: 11486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401668C RID: 91788
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

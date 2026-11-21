using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B9 RID: 441
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentWakeSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002060 RID: 8288 RVA: 0x0002FAEF File Offset: 0x0002DCEF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentWakeSignature.StaticFunctionPtr();
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0002FAFB File Offset: 0x0002DCFB
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentWakeSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentWakeSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentWakeSignature__DelegateSignature");
			}
			return FComponentWakeSignature._FunctionPtr;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0002FB1E File Offset: 0x0002DD1E
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentWake;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0002FB25 File Offset: 0x0002DD25
		[NullableContext(2)]
		public FComponentWakeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0002FB2F File Offset: 0x0002DD2F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FName>) ?? ((Action<UPrimitiveComponent, FName>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0002FB64 File Offset: 0x0002DD64
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

		// Token: 0x06002066 RID: 8294 RVA: 0x0002FBB4 File Offset: 0x0002DDB4
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UPrimitiveComponent, FName> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0002FBD4 File Offset: 0x0002DDD4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent WakingComponent, FName BoneName)
		{
			FComponentWakeSignature.__FComponentWakeSignature_DelegateParams* ptr = stackalloc FComponentWakeSignature.__FComponentWakeSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentWakeSignature.__FComponentWakeSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentWakeSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->WakingComponent = ((WakingComponent != null) ? WakingComponent.NativePtr : IntPtr.Zero);
			ptr->BoneName = BoneName;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0002FC38 File Offset: 0x0002DE38
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000AC4 RID: 2756
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AC5 RID: 2757
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentWakeSignature__DelegateSignature";

		// Token: 0x04000AC6 RID: 2758
		private static int RegisterId;

		// Token: 0x02000999 RID: 2457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FComponentWakeSignature_DelegateParams
		{
			// Token: 0x040058FF RID: 22783
			[FieldOffset(0)]
			public IntPtr WakingComponent;

			// Token: 0x04005900 RID: 22784
			[FieldOffset(8)]
			public FName BoneName;
		}

		// Token: 0x0200099A RID: 2458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005901 RID: 22785
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

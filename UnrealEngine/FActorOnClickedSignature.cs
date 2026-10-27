using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C6 RID: 1990
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnClickedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A42 RID: 27202 RVA: 0x00098E47 File Offset: 0x00097047
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnClickedSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00098E53 File Offset: 0x00097053
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnClickedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnClickedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnClickedSignature__DelegateSignature");
			}
			return FActorOnClickedSignature._FunctionPtr;
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x00098E76 File Offset: 0x00097076
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnClicked;
			}
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x00098E7D File Offset: 0x0009707D
		[NullableContext(2)]
		public FActorOnClickedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00098E87 File Offset: 0x00097087
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FKey>) ?? ((Action<AActor, FKey>)Delegate.CreateDelegate(typeof(Action<AActor, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00098EBC File Offset: 0x000970BC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			if (FActorOnClickedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnClickedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnClickedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnClickedSignature.OnScriptCallback));
				}
				FActorOnClickedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnClickedSignature.RegisterId);
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x00098F0C File Offset: 0x0009710C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00098F2C File Offset: 0x0009712C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor TouchedActor, FKey ButtonPressed)
		{
			FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams* ptr = stackalloc FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnClickedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			if (ButtonPressed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonPressed, ButtonPressed.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActorOnClickedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00098FBC File Offset: 0x000971BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FKey> action = target as Action<AActor, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams*)__Parameters)->TouchedActor);
			FKey arg = new FKey(&((FActorOnClickedSignature.__FActorOnClickedSignature_DelegateParams*)__Parameters)->ButtonPressed, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04003330 RID: 13104
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003331 RID: 13105
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnClickedSignature__DelegateSignature";

		// Token: 0x04003332 RID: 13106
		private static int RegisterId;

		// Token: 0x02002C79 RID: 11385
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FActorOnClickedSignature_DelegateParams
		{
			// Token: 0x040165AE RID: 91566
			[FieldOffset(0)]
			public IntPtr TouchedActor;

			// Token: 0x040165AF RID: 91567
			[FieldOffset(8)]
			public byte ButtonPressed;
		}

		// Token: 0x02002C7A RID: 11386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165B0 RID: 91568
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000406 RID: 1030
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInstanceARActorSpawnedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003764 RID: 14180 RVA: 0x00054244 File Offset: 0x00052444
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInstanceARActorSpawnedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00054250 File Offset: 0x00052450
		private static IntPtr StaticFunctionPtr()
		{
			if (UARLifeCycleComponent.__InstanceARActorSpawnedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UARLifeCycleComponent.__InstanceARActorSpawnedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.ARLifeCycleComponent:InstanceARActorSpawnedDelegate__DelegateSignature");
			}
			return UARLifeCycleComponent.__InstanceARActorSpawnedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00054273 File Offset: 0x00052473
		public FInstanceARActorSpawnedDelegate()
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x0005427B File Offset: 0x0005247B
		[NullableContext(2)]
		public FInstanceARActorSpawnedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00054285 File Offset: 0x00052485
		public FInstanceARActorSpawnedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00054290 File Offset: 0x00052490
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate) ?? ((FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x000542C2 File Offset: 0x000524C2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate Callback)
		{
			if (FInstanceARActorSpawnedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInstanceARActorSpawnedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInstanceARActorSpawnedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInstanceARActorSpawnedDelegate.OnScriptCallback));
				}
				FInstanceARActorSpawnedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInstanceARActorSpawnedDelegate.RegisterId);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x000542FC File Offset: 0x000524FC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00054308 File Offset: 0x00052508
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UClassStackOnlyPtr ComponentClass, FGuid NativeID, AARActor SpawnedActor)
		{
			FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams* ptr = stackalloc FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInstanceARActorSpawnedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ComponentClass = ComponentClass;
			ptr->NativeID = NativeID;
			ptr->SpawnedActor = ((SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00054364 File Offset: 0x00052564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate finstanceARActorSpawnedDelegate_ScriptDelegate = target as FInstanceARActorSpawnedDelegate.FInstanceARActorSpawnedDelegate_ScriptDelegate;
			if (finstanceARActorSpawnedDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AARActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AARActor>(((FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams*)__Parameters)->SpawnedActor);
			finstanceARActorSpawnedDelegate_ScriptDelegate(((FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams*)__Parameters)->ComponentClass, ((FInstanceARActorSpawnedDelegate.__FInstanceARActorSpawnedDelegate_DelegateParams*)__Parameters)->NativeID, orCreateUObjectByNativePointer);
		}

		// Token: 0x04001932 RID: 6450
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARLifeCycleComponent:InstanceARActorSpawnedDelegate__DelegateSignature";

		// Token: 0x04001933 RID: 6451
		private static int RegisterId;

		// Token: 0x02002C22 RID: 11298
		// (Invoke) Token: 0x0602852E RID: 165166
		public delegate void FInstanceARActorSpawnedDelegate_ScriptDelegate(UClassStackOnlyPtr ComponentClass, FGuid NativeID, AARActor SpawnedActor);

		// Token: 0x02002C23 RID: 11299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FInstanceARActorSpawnedDelegate_DelegateParams
		{
			// Token: 0x0401652A RID: 91434
			[FieldOffset(0)]
			public UClassStackOnlyPtr ComponentClass;

			// Token: 0x0401652B RID: 91435
			[FieldOffset(8)]
			public FGuid NativeID;

			// Token: 0x0401652C RID: 91436
			[FieldOffset(24)]
			public IntPtr SpawnedActor;
		}

		// Token: 0x02002C24 RID: 11300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401652D RID: 91437
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

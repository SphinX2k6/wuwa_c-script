using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC4 RID: 8132
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSequenceObjectSpawned : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EDBC RID: 126396 RVA: 0x002DDC69 File Offset: 0x002DBE69
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSequenceObjectSpawned.StaticFunctionPtr();
		}

		// Token: 0x0601EDBD RID: 126397 RVA: 0x002DDC75 File Offset: 0x002DBE75
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSequenceObjectSpawned._FunctionPtr == IntPtr.Zero)
			{
				FOnSequenceObjectSpawned._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LevelSequence.OnSequenceObjectSpawned__DelegateSignature");
			}
			return FOnSequenceObjectSpawned._FunctionPtr;
		}

		// Token: 0x0601EDBE RID: 126398 RVA: 0x002DDC98 File Offset: 0x002DBE98
		public FOnSequenceObjectSpawned()
		{
		}

		// Token: 0x0601EDBF RID: 126399 RVA: 0x002DDCA0 File Offset: 0x002DBEA0
		[NullableContext(2)]
		public FOnSequenceObjectSpawned(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDC0 RID: 126400 RVA: 0x002DDCAA File Offset: 0x002DBEAA
		public FOnSequenceObjectSpawned(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDC1 RID: 126401 RVA: 0x002DDCB5 File Offset: 0x002DBEB5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ULevelSequence, FGuid, UObject>) ?? ((Action<ULevelSequence, FGuid, UObject>)Delegate.CreateDelegate(typeof(Action<ULevelSequence, FGuid, UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EDC2 RID: 126402 RVA: 0x002DDCE7 File Offset: 0x002DBEE7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<ULevelSequence, FGuid, UObject> Callback)
		{
			if (FOnSequenceObjectSpawned.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSequenceObjectSpawned.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSequenceObjectSpawned.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSequenceObjectSpawned.OnScriptCallback));
				}
				FOnSequenceObjectSpawned.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSequenceObjectSpawned.RegisterId);
		}

		// Token: 0x0601EDC3 RID: 126403 RVA: 0x002DDD21 File Offset: 0x002DBF21
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<ULevelSequence, FGuid, UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601EDC4 RID: 126404 RVA: 0x002DDD2C File Offset: 0x002DBF2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ULevelSequence LevelSequence, FGuid Guid, UObject Object)
		{
			FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams* ptr = stackalloc FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSequenceObjectSpawned.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LevelSequence = ((LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero);
			ptr->Guid = Guid;
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601EDC5 RID: 126405 RVA: 0x002DDD94 File Offset: 0x002DBF94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULevelSequence, FGuid, UObject> action = target as Action<ULevelSequence, FGuid, UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(((FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams*)__Parameters)->LevelSequence);
			UObject orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams*)__Parameters)->Object);
			action(orCreateUObjectByNativePointer, ((FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams*)__Parameters)->Guid, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04010AC5 RID: 68293
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010AC6 RID: 68294
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.OnSequenceObjectSpawned__DelegateSignature";

		// Token: 0x04010AC7 RID: 68295
		private static int RegisterId;

		// Token: 0x02003421 RID: 13345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnSequenceObjectSpawned_DelegateParams
		{
			// Token: 0x040173FA RID: 95226
			[FieldOffset(0)]
			public IntPtr LevelSequence;

			// Token: 0x040173FB RID: 95227
			[FieldOffset(8)]
			public FGuid Guid;

			// Token: 0x040173FC RID: 95228
			[FieldOffset(24)]
			public IntPtr Object;
		}

		// Token: 0x02003422 RID: 13346
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173FD RID: 95229
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

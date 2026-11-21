using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000645 RID: 1605
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSequenceObjectSpawned : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008D3E RID: 36158 RVA: 0x000D4765 File Offset: 0x000D2965
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSequenceObjectSpawned.StaticFunctionPtr();
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x000D4771 File Offset: 0x000D2971
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSequenceObjectSpawned._FunctionPtr == IntPtr.Zero)
			{
				FOnSequenceObjectSpawned._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LevelSequence.OnSequenceObjectSpawned__DelegateSignature");
			}
			return FOnSequenceObjectSpawned._FunctionPtr;
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x000D4794 File Offset: 0x000D2994
		public FOnSequenceObjectSpawned()
		{
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x000D479C File Offset: 0x000D299C
		[NullableContext(2)]
		public FOnSequenceObjectSpawned(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x000D47A6 File Offset: 0x000D29A6
		public FOnSequenceObjectSpawned(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x000D47B1 File Offset: 0x000D29B1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ULevelSequence, FGuid, UObject>) ?? ((Action<ULevelSequence, FGuid, UObject>)Delegate.CreateDelegate(typeof(Action<ULevelSequence, FGuid, UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x000D47E3 File Offset: 0x000D29E3
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

		// Token: 0x06008D45 RID: 36165 RVA: 0x000D481D File Offset: 0x000D2A1D
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<ULevelSequence, FGuid, UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x000D4828 File Offset: 0x000D2A28
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ULevelSequence LevelSequence, FGuid Guid, UObject Object)
		{
			FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams* ptr = stackalloc FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnSequenceObjectSpawned.__FOnSequenceObjectSpawned_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSequenceObjectSpawned.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LevelSequence = ((LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero);
			ptr->Guid = Guid;
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x000D4890 File Offset: 0x000D2A90
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003D7A RID: 15738
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003D7B RID: 15739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.OnSequenceObjectSpawned__DelegateSignature";

		// Token: 0x04003D7C RID: 15740
		private static int RegisterId;

		// Token: 0x02000E64 RID: 3684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnSequenceObjectSpawned_DelegateParams
		{
			// Token: 0x04006209 RID: 25097
			[FieldOffset(0)]
			public IntPtr LevelSequence;

			// Token: 0x0400620A RID: 25098
			[FieldOffset(8)]
			public FGuid Guid;

			// Token: 0x0400620B RID: 25099
			[FieldOffset(24)]
			public IntPtr Object;
		}

		// Token: 0x02000E65 RID: 3685
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400620C RID: 25100
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

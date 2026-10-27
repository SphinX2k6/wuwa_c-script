using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034B RID: 843
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FActorFractureSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002ECC RID: 11980 RVA: 0x0004798F File Offset: 0x00045B8F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorFractureSignature.StaticFunctionPtr();
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x0004799B File Offset: 0x00045B9B
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorFractureSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorFractureSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/ApexDestruction.ActorFractureSignature__DelegateSignature");
			}
			return FActorFractureSignature._FunctionPtr;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000479BE File Offset: 0x00045BBE
		public FActorFractureSignature()
		{
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000479C6 File Offset: 0x00045BC6
		[NullableContext(2)]
		public FActorFractureSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000479D0 File Offset: 0x00045BD0
		public FActorFractureSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000479DB File Offset: 0x00045BDB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector, FVector>) ?? ((Action<FVector, FVector>)Delegate.CreateDelegate(typeof(Action<FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00047A0D File Offset: 0x00045C0D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FVector, FVector> Callback)
		{
			if (FActorFractureSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorFractureSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorFractureSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorFractureSignature.OnScriptCallback));
				}
				FActorFractureSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FActorFractureSignature.RegisterId);
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00047A47 File Offset: 0x00045C47
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00047A50 File Offset: 0x00045C50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FVector HitPoint, in FVector HitDirection)
		{
			FActorFractureSignature.__FActorFractureSignature_DelegateParams* ptr = stackalloc FActorFractureSignature.__FActorFractureSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FActorFractureSignature.__FActorFractureSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorFractureSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->HitPoint = HitPoint;
			ptr->HitDirection = HitDirection;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00047AA0 File Offset: 0x00045CA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector, FVector> action = target as Action<FVector, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FActorFractureSignature.__FActorFractureSignature_DelegateParams*)__Parameters)->HitPoint, ((FActorFractureSignature.__FActorFractureSignature_DelegateParams*)__Parameters)->HitDirection);
		}

		// Token: 0x0400142A RID: 5162
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400142B RID: 5163
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.ActorFractureSignature__DelegateSignature";

		// Token: 0x0400142C RID: 5164
		private static int RegisterId;

		// Token: 0x02002BD0 RID: 11216
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FActorFractureSignature_DelegateParams
		{
			// Token: 0x0401648B RID: 91275
			[FieldOffset(0)]
			public FVector HitPoint;

			// Token: 0x0401648C RID: 91276
			[FieldOffset(12)]
			public FVector HitDirection;
		}

		// Token: 0x02002BD1 RID: 11217
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401648D RID: 91277
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

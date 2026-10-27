using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034C RID: 844
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FComponentFractureSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002ED6 RID: 11990 RVA: 0x00047AF0 File Offset: 0x00045CF0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentFractureSignature.StaticFunctionPtr();
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00047AFC File Offset: 0x00045CFC
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentFractureSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentFractureSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature");
			}
			return FComponentFractureSignature._FunctionPtr;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00047B1F File Offset: 0x00045D1F
		public FComponentFractureSignature()
		{
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00047B27 File Offset: 0x00045D27
		[NullableContext(2)]
		public FComponentFractureSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00047B31 File Offset: 0x00045D31
		public FComponentFractureSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00047B3C File Offset: 0x00045D3C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector, FVector>) ?? ((Action<FVector, FVector>)Delegate.CreateDelegate(typeof(Action<FVector, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00047B6E File Offset: 0x00045D6E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FVector, FVector> Callback)
		{
			if (FComponentFractureSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentFractureSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentFractureSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentFractureSignature.OnScriptCallback));
				}
				FComponentFractureSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FComponentFractureSignature.RegisterId);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00047BA8 File Offset: 0x00045DA8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FVector, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00047BB4 File Offset: 0x00045DB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FVector HitPoint, in FVector HitDirection)
		{
			FComponentFractureSignature.__FComponentFractureSignature_DelegateParams* ptr = stackalloc FComponentFractureSignature.__FComponentFractureSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FComponentFractureSignature.__FComponentFractureSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentFractureSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->HitPoint = HitPoint;
			ptr->HitDirection = HitDirection;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00047C04 File Offset: 0x00045E04
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
			action(((FComponentFractureSignature.__FComponentFractureSignature_DelegateParams*)__Parameters)->HitPoint, ((FComponentFractureSignature.__FComponentFractureSignature_DelegateParams*)__Parameters)->HitDirection);
		}

		// Token: 0x0400142D RID: 5165
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400142E RID: 5166
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.ComponentFractureSignature__DelegateSignature";

		// Token: 0x0400142F RID: 5167
		private static int RegisterId;

		// Token: 0x02002BD2 RID: 11218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FComponentFractureSignature_DelegateParams
		{
			// Token: 0x0401648E RID: 91278
			[FieldOffset(0)]
			public FVector HitPoint;

			// Token: 0x0401648F RID: 91279
			[FieldOffset(12)]
			public FVector HitDirection;
		}

		// Token: 0x02002BD3 RID: 11219
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016490 RID: 91280
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

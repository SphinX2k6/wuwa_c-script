using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001834 RID: 6196
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroFastCollisionOverlapSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016D66 RID: 93542 RVA: 0x00215746 File Offset: 0x00213946
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroFastCollisionOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06016D67 RID: 93543 RVA: 0x00215752 File Offset: 0x00213952
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroFastCollisionOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroFastCollisionOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFastCollision.KuroFastCollisionOverlapSignature__DelegateSignature");
			}
			return FKuroFastCollisionOverlapSignature._FunctionPtr;
		}

		// Token: 0x06016D68 RID: 93544 RVA: 0x00215775 File Offset: 0x00213975
		public FKuroFastCollisionOverlapSignature()
		{
		}

		// Token: 0x06016D69 RID: 93545 RVA: 0x0021577D File Offset: 0x0021397D
		[NullableContext(2)]
		public FKuroFastCollisionOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D6A RID: 93546 RVA: 0x00215787 File Offset: 0x00213987
		public FKuroFastCollisionOverlapSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D6B RID: 93547 RVA: 0x00215792 File Offset: 0x00213992
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate) ?? ((FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate)Delegate.CreateDelegate(typeof(FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016D6C RID: 93548 RVA: 0x002157C4 File Offset: 0x002139C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate Callback)
		{
			if (FKuroFastCollisionOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroFastCollisionOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroFastCollisionOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroFastCollisionOverlapSignature.OnScriptCallback));
				}
				FKuroFastCollisionOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroFastCollisionOverlapSignature.RegisterId);
		}

		// Token: 0x06016D6D RID: 93549 RVA: 0x002157FE File Offset: 0x002139FE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016D6E RID: 93550 RVA: 0x00215808 File Offset: 0x00213A08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UKuroFastCollisionShapeComponent OverlappedComponent, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> OtherObjects)
		{
			FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams* ptr = stackalloc FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroFastCollisionOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			TArray<UObject> tarray = OtherObjects;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OtherObjects);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<UObject> tarray2 = OtherObjects;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OtherObjects);
			}
			UnrealReflectionUtils.DestroyStruct(FKuroFastCollisionOverlapSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016D6F RID: 93551 RVA: 0x0021588C File Offset: 0x00213A8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate fkuroFastCollisionOverlapSignature_ScriptDelegate = target as FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate;
			if (fkuroFastCollisionOverlapSignature_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UKuroFastCollisionShapeComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroFastCollisionShapeComponent>(((FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams*)__Parameters)->OverlappedComponent);
			TArray<UObject> tarray = new TArray<UObject>(&((FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams*)__Parameters)->OtherObjects, true, true);
			fkuroFastCollisionOverlapSignature_ScriptDelegate(orCreateUObjectByNativePointer, tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FKuroFastCollisionOverlapSignature.__FKuroFastCollisionOverlapSignature_DelegateParams*)__Parameters)->OtherObjects, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400C6A6 RID: 50854
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C6A7 RID: 50855
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionOverlapSignature__DelegateSignature";

		// Token: 0x0400C6A8 RID: 50856
		private static int RegisterId;

		// Token: 0x02002F66 RID: 12134
		// (Invoke) Token: 0x0602857E RID: 165246
		public delegate void FKuroFastCollisionOverlapSignature_ScriptDelegate(UKuroFastCollisionShapeComponent OverlappedComponent, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> OtherObjects);

		// Token: 0x02002F67 RID: 12135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroFastCollisionOverlapSignature_DelegateParams
		{
			// Token: 0x04016B1D RID: 92957
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04016B1E RID: 92958
			[FieldOffset(8)]
			public byte OtherObjects;
		}

		// Token: 0x02002F68 RID: 12136
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B1F RID: 92959
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

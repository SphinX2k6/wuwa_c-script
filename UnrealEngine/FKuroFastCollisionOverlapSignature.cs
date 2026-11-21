using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000380 RID: 896
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroFastCollisionOverlapSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005A14 RID: 23060 RVA: 0x0007F4F6 File Offset: 0x0007D6F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroFastCollisionOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x0007F502 File Offset: 0x0007D702
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroFastCollisionOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroFastCollisionOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFastCollision.KuroFastCollisionOverlapSignature__DelegateSignature");
			}
			return FKuroFastCollisionOverlapSignature._FunctionPtr;
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0007F525 File Offset: 0x0007D725
		public FKuroFastCollisionOverlapSignature()
		{
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0007F52D File Offset: 0x0007D72D
		[NullableContext(2)]
		public FKuroFastCollisionOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x0007F537 File Offset: 0x0007D737
		public FKuroFastCollisionOverlapSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x0007F542 File Offset: 0x0007D742
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate) ?? ((FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate)Delegate.CreateDelegate(typeof(FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x0007F574 File Offset: 0x0007D774
		[NullableContext(1)]
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

		// Token: 0x06005A1B RID: 23067 RVA: 0x0007F5AE File Offset: 0x0007D7AE
		[NullableContext(1)]
		public void Remove(FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x0007F5B8 File Offset: 0x0007D7B8
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06005A1D RID: 23069 RVA: 0x0007F63C File Offset: 0x0007D83C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002569 RID: 9577
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400256A RID: 9578
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionOverlapSignature__DelegateSignature";

		// Token: 0x0400256B RID: 9579
		private static int RegisterId;

		// Token: 0x02000A8F RID: 2703
		// (Invoke) Token: 0x0600BEEF RID: 48879
		public delegate void FKuroFastCollisionOverlapSignature_ScriptDelegate(UKuroFastCollisionShapeComponent OverlappedComponent, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> OtherObjects);

		// Token: 0x02000A90 RID: 2704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroFastCollisionOverlapSignature_DelegateParams
		{
			// Token: 0x04005ADF RID: 23263
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04005AE0 RID: 23264
			[FieldOffset(8)]
			public byte OtherObjects;
		}

		// Token: 0x02000A91 RID: 2705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AE1 RID: 23265
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200183E RID: 6206
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroFauxPhysicsAxisRotateConstraintHit : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016E10 RID: 93712 RVA: 0x0021658E File Offset: 0x0021478E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroFauxPhysicsAxisRotateConstraintHit.StaticFunctionPtr();
		}

		// Token: 0x06016E11 RID: 93713 RVA: 0x0021659A File Offset: 0x0021479A
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr == IntPtr.Zero)
			{
				FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateConstraintHit__DelegateSignature");
			}
			return FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr;
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x002165BD File Offset: 0x002147BD
		public FKuroFauxPhysicsAxisRotateConstraintHit()
		{
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x002165C5 File Offset: 0x002147C5
		[NullableContext(2)]
		public FKuroFauxPhysicsAxisRotateConstraintHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x002165CF File Offset: 0x002147CF
		public FKuroFauxPhysicsAxisRotateConstraintHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x002165DA File Offset: 0x002147DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x0021660C File Offset: 0x0021480C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FKuroFauxPhysicsAxisRotateConstraintHit.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroFauxPhysicsAxisRotateConstraintHit.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroFauxPhysicsAxisRotateConstraintHit.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroFauxPhysicsAxisRotateConstraintHit.OnScriptCallback));
				}
				FKuroFauxPhysicsAxisRotateConstraintHit.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroFauxPhysicsAxisRotateConstraintHit.RegisterId);
		}

		// Token: 0x06016E17 RID: 93719 RVA: 0x00216646 File Offset: 0x00214846
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x00216650 File Offset: 0x00214850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Strength)
		{
			FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams* ptr = stackalloc FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroFauxPhysicsAxisRotateConstraintHit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Strength = Strength;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x0021668C File Offset: 0x0021488C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams*)__Parameters)->Strength);
		}

		// Token: 0x0400C6FD RID: 50941
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C6FE RID: 50942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateConstraintHit__DelegateSignature";

		// Token: 0x0400C6FF RID: 50943
		private static int RegisterId;

		// Token: 0x02002F69 RID: 12137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams
		{
			// Token: 0x04016B20 RID: 92960
			[FieldOffset(0)]
			public float Strength;
		}

		// Token: 0x02002F6A RID: 12138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B21 RID: 92961
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

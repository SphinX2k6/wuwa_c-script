using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200184B RID: 6219
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroPhysicsConeRotateConstraintHit : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016EC6 RID: 93894 RVA: 0x0021723D File Offset: 0x0021543D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroPhysicsConeRotateConstraintHit.StaticFunctionPtr();
		}

		// Token: 0x06016EC7 RID: 93895 RVA: 0x00217249 File Offset: 0x00215449
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroPhysicsConeRotateConstraintHit._FunctionPtr == IntPtr.Zero)
			{
				FKuroPhysicsConeRotateConstraintHit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.KuroPhysicsConeRotateConstraintHit__DelegateSignature");
			}
			return FKuroPhysicsConeRotateConstraintHit._FunctionPtr;
		}

		// Token: 0x06016EC8 RID: 93896 RVA: 0x0021726C File Offset: 0x0021546C
		public FKuroPhysicsConeRotateConstraintHit()
		{
		}

		// Token: 0x06016EC9 RID: 93897 RVA: 0x00217274 File Offset: 0x00215474
		[NullableContext(2)]
		public FKuroPhysicsConeRotateConstraintHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016ECA RID: 93898 RVA: 0x0021727E File Offset: 0x0021547E
		public FKuroPhysicsConeRotateConstraintHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016ECB RID: 93899 RVA: 0x00217289 File Offset: 0x00215489
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x002172BB File Offset: 0x002154BB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FKuroPhysicsConeRotateConstraintHit.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroPhysicsConeRotateConstraintHit.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroPhysicsConeRotateConstraintHit.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroPhysicsConeRotateConstraintHit.OnScriptCallback));
				}
				FKuroPhysicsConeRotateConstraintHit.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroPhysicsConeRotateConstraintHit.RegisterId);
		}

		// Token: 0x06016ECD RID: 93901 RVA: 0x002172F5 File Offset: 0x002154F5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016ECE RID: 93902 RVA: 0x00217300 File Offset: 0x00215500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Strength)
		{
			FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams* ptr = stackalloc FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroPhysicsConeRotateConstraintHit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Strength = Strength;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06016ECF RID: 93903 RVA: 0x0021733C File Offset: 0x0021553C
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
			action(((FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams*)__Parameters)->Strength);
		}

		// Token: 0x0400C74B RID: 51019
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C74C RID: 51020
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroPhysicsConeRotateConstraintHit__DelegateSignature";

		// Token: 0x0400C74D RID: 51021
		private static int RegisterId;

		// Token: 0x02002F6C RID: 12140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroPhysicsConeRotateConstraintHit_DelegateParams
		{
			// Token: 0x04016B27 RID: 92967
			[FieldOffset(0)]
			public float Strength;
		}

		// Token: 0x02002F6D RID: 12141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B28 RID: 92968
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

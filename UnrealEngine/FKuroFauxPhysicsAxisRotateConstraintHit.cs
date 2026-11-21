using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000385 RID: 901
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroFauxPhysicsAxisRotateConstraintHit : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005A77 RID: 23159 RVA: 0x0007FE04 File Offset: 0x0007E004
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroFauxPhysicsAxisRotateConstraintHit.StaticFunctionPtr();
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x0007FE10 File Offset: 0x0007E010
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr == IntPtr.Zero)
			{
				FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateConstraintHit__DelegateSignature");
			}
			return FKuroFauxPhysicsAxisRotateConstraintHit._FunctionPtr;
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x0007FE33 File Offset: 0x0007E033
		public FKuroFauxPhysicsAxisRotateConstraintHit()
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x0007FE3B File Offset: 0x0007E03B
		[NullableContext(2)]
		public FKuroFauxPhysicsAxisRotateConstraintHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x0007FE45 File Offset: 0x0007E045
		public FKuroFauxPhysicsAxisRotateConstraintHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x0007FE50 File Offset: 0x0007E050
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x0007FE82 File Offset: 0x0007E082
		[NullableContext(1)]
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

		// Token: 0x06005A7E RID: 23166 RVA: 0x0007FEBC File Offset: 0x0007E0BC
		[NullableContext(1)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
		[SkipLocalsInit]
		public unsafe void Broadcast(float Strength)
		{
			FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams* ptr = stackalloc FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroFauxPhysicsAxisRotateConstraintHit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Strength = Strength;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x0007FF04 File Offset: 0x0007E104
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroFauxPhysicsAxisRotateConstraintHit.__FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams*)__Parameters)->Strength);
		}

		// Token: 0x0400259D RID: 9629
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400259E RID: 9630
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateConstraintHit__DelegateSignature";

		// Token: 0x0400259F RID: 9631
		private static int RegisterId;

		// Token: 0x02000A92 RID: 2706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroFauxPhysicsAxisRotateConstraintHit_DelegateParams
		{
			// Token: 0x04005AE2 RID: 23266
			[FieldOffset(0)]
			public float Strength;
		}

		// Token: 0x02000A93 RID: 2707
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AE3 RID: 23267
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

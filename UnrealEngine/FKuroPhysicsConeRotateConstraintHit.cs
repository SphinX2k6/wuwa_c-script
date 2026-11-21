using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038B RID: 907
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroPhysicsConeRotateConstraintHit : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005AEC RID: 23276 RVA: 0x0008063B File Offset: 0x0007E83B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroPhysicsConeRotateConstraintHit.StaticFunctionPtr();
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00080647 File Offset: 0x0007E847
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroPhysicsConeRotateConstraintHit._FunctionPtr == IntPtr.Zero)
			{
				FKuroPhysicsConeRotateConstraintHit._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.KuroPhysicsConeRotateConstraintHit__DelegateSignature");
			}
			return FKuroPhysicsConeRotateConstraintHit._FunctionPtr;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x0008066A File Offset: 0x0007E86A
		public FKuroPhysicsConeRotateConstraintHit()
		{
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00080672 File Offset: 0x0007E872
		[NullableContext(2)]
		public FKuroPhysicsConeRotateConstraintHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x0008067C File Offset: 0x0007E87C
		public FKuroPhysicsConeRotateConstraintHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00080687 File Offset: 0x0007E887
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x000806B9 File Offset: 0x0007E8B9
		[NullableContext(1)]
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

		// Token: 0x06005AF3 RID: 23283 RVA: 0x000806F3 File Offset: 0x0007E8F3
		[NullableContext(1)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x000806FC File Offset: 0x0007E8FC
		[SkipLocalsInit]
		public unsafe void Broadcast(float Strength)
		{
			FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams* ptr = stackalloc FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroPhysicsConeRotateConstraintHit.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Strength = Strength;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x00080738 File Offset: 0x0007E938
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroPhysicsConeRotateConstraintHit.__FKuroPhysicsConeRotateConstraintHit_DelegateParams*)__Parameters)->Strength);
		}

		// Token: 0x040025CB RID: 9675
		internal static IntPtr _FunctionPtr;

		// Token: 0x040025CC RID: 9676
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroPhysicsConeRotateConstraintHit__DelegateSignature";

		// Token: 0x040025CD RID: 9677
		private static int RegisterId;

		// Token: 0x02000A95 RID: 2709
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroPhysicsConeRotateConstraintHit_DelegateParams
		{
			// Token: 0x04005AE9 RID: 23273
			[FieldOffset(0)]
			public float Strength;
		}

		// Token: 0x02000A96 RID: 2710
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AEA RID: 23274
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}

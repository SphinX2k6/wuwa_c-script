using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018B0 RID: 6320
	[UnrealObjectPath("/Script/KuroGameplay.EffectSystemActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AEffectSystemActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601762F RID: 95791 RVA: 0x002230A7 File Offset: 0x002212A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AEffectSystemActor._ClassPtr;
		}

		// Token: 0x06017630 RID: 95792 RVA: 0x002230B4 File Offset: 0x002212B4
		public AEffectSystemActor() : this(BuiltinUtils.AllocNativeUObject(AEffectSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017631 RID: 95793 RVA: 0x002230DC File Offset: 0x002212DC
		[NullableContext(1)]
		public AEffectSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AEffectSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017632 RID: 95794 RVA: 0x00223110 File Offset: 0x00221310
		public unsafe void StopEffect(in FName Reason, bool Immediately = false, bool DestroyActor = false)
		{
			fixed (FName* ptr = &Reason)
			{
				void* ptr2 = (void*)ptr;
				AEffectSystemActor.__StopEffect_Internal(base.NativePtr, Reason, Immediately, DestroyActor);
			}
		}

		// Token: 0x06017633 RID: 95795 RVA: 0x00223133 File Offset: 0x00221333
		public void SetOwnerEntityId(int EntityId)
		{
			AEffectSystemActor.__SetOwnerEntityId_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06017634 RID: 95796 RVA: 0x00223141 File Offset: 0x00221341
		public float GetTimeScale()
		{
			return AEffectSystemActor.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x06017635 RID: 95797 RVA: 0x0022314E File Offset: 0x0022134E
		public int GetOwnerEntityId()
		{
			return AEffectSystemActor.__GetOwnerEntityId_Internal(base.NativePtr);
		}

		// Token: 0x06017636 RID: 95798 RVA: 0x0022315B File Offset: 0x0022135B
		public int GetHandle()
		{
			return AEffectSystemActor.__GetHandle_Internal(base.NativePtr);
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x00223168 File Offset: 0x00221368
		public int GetEffectType()
		{
			return AEffectSystemActor.__GetEffectType_Internal(base.NativePtr);
		}

		// Token: 0x06017638 RID: 95800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopEffect_Internal(IntPtr @this, in FName Reason, bool Immediately, bool DestroyActor);

		// Token: 0x06017639 RID: 95801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerEntityId_Internal(IntPtr @this, int EntityId);

		// Token: 0x0601763A RID: 95802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x0601763B RID: 95803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOwnerEntityId_Internal(IntPtr @this);

		// Token: 0x0601763C RID: 95804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHandle_Internal(IntPtr @this);

		// Token: 0x0601763D RID: 95805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectType_Internal(IntPtr @this);

		// Token: 0x0601763E RID: 95806 RVA: 0x00223175 File Offset: 0x00221375
		static AEffectSystemActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectSystemActor");
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x00223183 File Offset: 0x00221383
		protected AEffectSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CB76 RID: 52086
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectSystemActor";

		// Token: 0x0400CB77 RID: 52087
		private static IntPtr _ClassPtr;

		// Token: 0x0400CB78 RID: 52088
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

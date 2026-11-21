using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D2 RID: 978
	[UnrealObjectPath("/Script/KuroGameplay.EffectSystemActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AEffectSystemActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060060C2 RID: 24770 RVA: 0x0008A287 File Offset: 0x00088487
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AEffectSystemActor._ClassPtr;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x0008A294 File Offset: 0x00088494
		public AEffectSystemActor() : this(BuiltinUtils.AllocNativeUObject(AEffectSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x0008A2BC File Offset: 0x000884BC
		[NullableContext(1)]
		public AEffectSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AEffectSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x0008A2F0 File Offset: 0x000884F0
		public unsafe void StopEffect(in FName Reason, bool Immediately = false, bool DestroyActor = false)
		{
			fixed (FName* ptr = &Reason)
			{
				void* ptr2 = (void*)ptr;
				AEffectSystemActor.__StopEffect_Internal(base.NativePtr, Reason, Immediately, DestroyActor);
			}
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x0008A313 File Offset: 0x00088513
		public void SetOwnerEntityId(int EntityId)
		{
			AEffectSystemActor.__SetOwnerEntityId_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x0008A321 File Offset: 0x00088521
		public float GetTimeScale()
		{
			return AEffectSystemActor.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x0008A32E File Offset: 0x0008852E
		public int GetOwnerEntityId()
		{
			return AEffectSystemActor.__GetOwnerEntityId_Internal(base.NativePtr);
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x0008A33B File Offset: 0x0008853B
		public int GetHandle()
		{
			return AEffectSystemActor.__GetHandle_Internal(base.NativePtr);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x0008A348 File Offset: 0x00088548
		public int GetEffectType()
		{
			return AEffectSystemActor.__GetEffectType_Internal(base.NativePtr);
		}

		// Token: 0x060060CB RID: 24779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopEffect_Internal(IntPtr @this, in FName Reason, bool Immediately, bool DestroyActor);

		// Token: 0x060060CC RID: 24780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerEntityId_Internal(IntPtr @this, int EntityId);

		// Token: 0x060060CD RID: 24781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x060060CE RID: 24782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOwnerEntityId_Internal(IntPtr @this);

		// Token: 0x060060CF RID: 24783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHandle_Internal(IntPtr @this);

		// Token: 0x060060D0 RID: 24784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectType_Internal(IntPtr @this);

		// Token: 0x060060D1 RID: 24785 RVA: 0x0008A355 File Offset: 0x00088555
		static AEffectSystemActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectSystemActor");
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x0008A363 File Offset: 0x00088563
		protected AEffectSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002935 RID: 10549
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectSystemActor";

		// Token: 0x04002936 RID: 10550
		private static IntPtr _ClassPtr;

		// Token: 0x04002937 RID: 10551
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

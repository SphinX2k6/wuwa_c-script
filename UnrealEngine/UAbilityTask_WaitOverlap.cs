using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001318 RID: 4888
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitOverlap")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UAbilityTask_WaitOverlap : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012021 RID: 73761 RVA: 0x001A7097 File Offset: 0x001A5297
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitOverlap._ClassPtr;
		}

		// Token: 0x06012022 RID: 73762 RVA: 0x001A70A4 File Offset: 0x001A52A4
		public UAbilityTask_WaitOverlap() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitOverlap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012023 RID: 73763 RVA: 0x001A70CC File Offset: 0x001A52CC
		public UAbilityTask_WaitOverlap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitOverlap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x06012024 RID: 73764 RVA: 0x001A7100 File Offset: 0x001A5300
		// (set) Token: 0x06012025 RID: 73765 RVA: 0x001A7139 File Offset: 0x001A5339
		public FWaitOverlapDelegate OnOverlap
		{
			get
			{
				base.FastCheckIsValid();
				FWaitOverlapDelegate result;
				if ((result = this._OnOverlap) == null)
				{
					result = (this._OnOverlap = new FWaitOverlapDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitOverlap.__PropertyOffset_OnOverlap, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitOverlap.__PropertyOffset_OnOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012026 RID: 73766 RVA: 0x001A715A File Offset: 0x001A535A
		[NullableContext(2)]
		public static UAbilityTask_WaitOverlap WaitForOverlap(UGameplayAbility OwningAbility)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitOverlap>(UAbilityTask_WaitOverlap.__WaitForOverlap_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06012027 RID: 73767 RVA: 0x001A7178 File Offset: 0x001A5378
		[NullableContext(2)]
		public void OnHitCallback(UPrimitiveComponent HitComp, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			UAbilityTask_WaitOverlap.__OnHitCallback_Internal(base.NativePtr, (HitComp != null) ? HitComp.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06012028 RID: 73768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForOverlap_Internal(IntPtr OwningAbility);

		// Token: 0x06012029 RID: 73769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHitCallback_Internal(IntPtr @this, IntPtr HitComp, IntPtr OtherActor, IntPtr OtherComp, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x0601202A RID: 73770 RVA: 0x001A71D3 File Offset: 0x001A53D3
		static UAbilityTask_WaitOverlap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitOverlap");
		}

		// Token: 0x0601202B RID: 73771 RVA: 0x001A71E1 File Offset: 0x001A53E1
		protected UAbilityTask_WaitOverlap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099F6 RID: 39414
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitOverlap";

		// Token: 0x040099F7 RID: 39415
		private static IntPtr _ClassPtr;

		// Token: 0x040099F8 RID: 39416
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099F9 RID: 39417
		internal static int __PropertyOffset_OnOverlap;

		// Token: 0x040099FA RID: 39418
		[Nullable(2)]
		private FWaitOverlapDelegate _OnOverlap;
	}
}

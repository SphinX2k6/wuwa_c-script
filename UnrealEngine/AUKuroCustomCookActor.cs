using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C33 RID: 7219
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor")]
	[UnrealStructLayout(1424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AUKuroCustomCookActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BF93 RID: 114579 RVA: 0x0029297E File Offset: 0x00290B7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUKuroCustomCookActor._ClassPtr;
		}

		// Token: 0x0601BF94 RID: 114580 RVA: 0x0029298C File Offset: 0x00290B8C
		public AUKuroCustomCookActor() : this(BuiltinUtils.AllocNativeUObject(AUKuroCustomCookActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BF95 RID: 114581 RVA: 0x002929B4 File Offset: 0x00290BB4
		[NullableContext(1)]
		public AUKuroCustomCookActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUKuroCustomCookActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601BF96 RID: 114582 RVA: 0x002929E7 File Offset: 0x00290BE7
		public virtual void BeforeSave()
		{
			AUKuroCustomCookActor.__BeforeSave_Internal(base.NativePtr);
		}

		// Token: 0x0601BF97 RID: 114583 RVA: 0x002929F4 File Offset: 0x00290BF4
		public virtual void BeforeCookForPC()
		{
			AUKuroCustomCookActor.__BeforeCookForPC_Internal(base.NativePtr);
		}

		// Token: 0x0601BF98 RID: 114584 RVA: 0x00292A01 File Offset: 0x00290C01
		protected virtual void BeforeCookForPC_Implementation()
		{
			AUKuroCustomCookActor.__BeforeCookForPC_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601BF99 RID: 114585 RVA: 0x00292A0E File Offset: 0x00290C0E
		public virtual void BeforeCookForMobile()
		{
			AUKuroCustomCookActor.__BeforeCookForMobile_Internal(base.NativePtr);
		}

		// Token: 0x0601BF9A RID: 114586 RVA: 0x00292A1B File Offset: 0x00290C1B
		protected virtual void BeforeCookForMobile_Implementation()
		{
			AUKuroCustomCookActor.__BeforeCookForMobile_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601BF9B RID: 114587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeSave_Internal(IntPtr @this);

		// Token: 0x0601BF9C RID: 114588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForPC_Internal(IntPtr @this);

		// Token: 0x0601BF9D RID: 114589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForPC_Implementation_Internal(IntPtr @this);

		// Token: 0x0601BF9E RID: 114590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForMobile_Internal(IntPtr @this);

		// Token: 0x0601BF9F RID: 114591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForMobile_Implementation_Internal(IntPtr @this);

		// Token: 0x0601BFA0 RID: 114592 RVA: 0x00292A28 File Offset: 0x00290C28
		static AUKuroCustomCookActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor");
		}

		// Token: 0x0601BFA1 RID: 114593 RVA: 0x00292A36 File Offset: 0x00290C36
		protected AUKuroCustomCookActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F05D RID: 61533
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor";

		// Token: 0x0400F05E RID: 61534
		private static IntPtr _ClassPtr;

		// Token: 0x0400F05F RID: 61535
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F6 RID: 1270
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor")]
	[UnrealStructLayout(1424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AUKuroCustomCookActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600775A RID: 30554 RVA: 0x000AE7AC File Offset: 0x000AC9AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUKuroCustomCookActor._ClassPtr;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x000AE7B8 File Offset: 0x000AC9B8
		public AUKuroCustomCookActor() : this(BuiltinUtils.AllocNativeUObject(AUKuroCustomCookActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x000AE7E0 File Offset: 0x000AC9E0
		[NullableContext(1)]
		public AUKuroCustomCookActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUKuroCustomCookActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x000AE813 File Offset: 0x000ACA13
		public virtual void BeforeSave()
		{
			AUKuroCustomCookActor.__BeforeSave_Internal(base.NativePtr);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x000AE820 File Offset: 0x000ACA20
		public virtual void BeforeCookForPC()
		{
			AUKuroCustomCookActor.__BeforeCookForPC_Internal(base.NativePtr);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x000AE82D File Offset: 0x000ACA2D
		protected virtual void BeforeCookForPC_Implementation()
		{
			AUKuroCustomCookActor.__BeforeCookForPC_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x000AE83A File Offset: 0x000ACA3A
		public virtual void BeforeCookForMobile()
		{
			AUKuroCustomCookActor.__BeforeCookForMobile_Internal(base.NativePtr);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x000AE847 File Offset: 0x000ACA47
		protected virtual void BeforeCookForMobile_Implementation()
		{
			AUKuroCustomCookActor.__BeforeCookForMobile_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06007762 RID: 30562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeSave_Internal(IntPtr @this);

		// Token: 0x06007763 RID: 30563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForPC_Internal(IntPtr @this);

		// Token: 0x06007764 RID: 30564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForPC_Implementation_Internal(IntPtr @this);

		// Token: 0x06007765 RID: 30565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForMobile_Internal(IntPtr @this);

		// Token: 0x06007766 RID: 30566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeCookForMobile_Implementation_Internal(IntPtr @this);

		// Token: 0x06007767 RID: 30567 RVA: 0x000AE854 File Offset: 0x000ACA54
		static AUKuroCustomCookActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor");
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x000AE862 File Offset: 0x000ACA62
		protected AUKuroCustomCookActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400324E RID: 12878
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.UKuroCustomCookActor";

		// Token: 0x0400324F RID: 12879
		private static IntPtr _ClassPtr;

		// Token: 0x04003250 RID: 12880
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

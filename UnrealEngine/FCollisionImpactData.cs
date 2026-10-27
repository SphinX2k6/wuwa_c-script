using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000943 RID: 2371
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CollisionImpactData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCollisionImpactData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008605 RID: 34309 RVA: 0x000BEFDF File Offset: 0x000BD1DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionImpactData._ScriptStructPtr != 0) ? FCollisionImpactData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionImpactData", ref FCollisionImpactData._ScriptStructPtr);
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06008606 RID: 34310 RVA: 0x000BF004 File Offset: 0x000BD204
		// (set) Token: 0x06008607 RID: 34311 RVA: 0x000BF047 File Offset: 0x000BD247
		public TArray<FRigidBodyContactInfo> ContactInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigidBodyContactInfo> result;
				if ((result = this._ContactInfos) == null)
				{
					result = (this._ContactInfos = new TArray<FRigidBodyContactInfo>(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_ContactInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ContactInfos.CopyAssign(value);
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06008608 RID: 34312 RVA: 0x000BF055 File Offset: 0x000BD255
		// (set) Token: 0x06008609 RID: 34313 RVA: 0x000BF069 File Offset: 0x000BD269
		public unsafe FVector TotalNormalImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_TotalNormalImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_TotalNormalImpulse) = value;
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600860A RID: 34314 RVA: 0x000BF07E File Offset: 0x000BD27E
		// (set) Token: 0x0600860B RID: 34315 RVA: 0x000BF092 File Offset: 0x000BD292
		public unsafe FVector TotalFrictionImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_TotalFrictionImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_TotalFrictionImpulse) = value;
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600860C RID: 34316 RVA: 0x000BF0A7 File Offset: 0x000BD2A7
		// (set) Token: 0x0600860D RID: 34317 RVA: 0x000BF0B7 File Offset: 0x000BD2B7
		public unsafe bool bIsVelocityDeltaUnderThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_bIsVelocityDeltaUnderThreshold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionImpactData.__PropertyOffset_bIsVelocityDeltaUnderThreshold) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x000BF0C8 File Offset: 0x000BD2C8
		public FCollisionImpactData()
		{
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x000BF0D0 File Offset: 0x000BD2D0
		public FCollisionImpactData(TArray<FRigidBodyContactInfo> ContactInfos, FVector TotalNormalImpulse, FVector TotalFrictionImpulse, bool bIsVelocityDeltaUnderThreshold)
		{
			this.ContactInfos = ContactInfos;
			this.TotalNormalImpulse = TotalNormalImpulse;
			this.TotalFrictionImpulse = TotalFrictionImpulse;
			this.bIsVelocityDeltaUnderThreshold = bIsVelocityDeltaUnderThreshold;
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x000BF0F5 File Offset: 0x000BD2F5
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionImpactData.StaticStruct();
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x000BF101 File Offset: 0x000BD301
		[NullableContext(2)]
		public FCollisionImpactData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x000BF10B File Offset: 0x000BD30B
		public FCollisionImpactData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x000BF116 File Offset: 0x000BD316
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionImpactData(Pointer, false, true);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x000BF120 File Offset: 0x000BD320
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionImpactData(Pointer, MemoryOwner);
		}

		// Token: 0x04003FBF RID: 16319
		public const string __ObjectPath = "/Script/Engine.CollisionImpactData";

		// Token: 0x04003FC0 RID: 16320
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FC1 RID: 16321
		internal static int __PropertyOffset_ContactInfos;

		// Token: 0x04003FC2 RID: 16322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigidBodyContactInfo> _ContactInfos;

		// Token: 0x04003FC3 RID: 16323
		internal static int __PropertyOffset_TotalNormalImpulse;

		// Token: 0x04003FC4 RID: 16324
		internal static int __PropertyOffset_TotalFrictionImpulse;

		// Token: 0x04003FC5 RID: 16325
		internal static int __PropertyOffset_bIsVelocityDeltaUnderThreshold;
	}
}

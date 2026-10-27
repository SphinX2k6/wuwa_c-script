using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015D6 RID: 5590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiPhysicsLimitsDataAsset")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKawaiiPhysicsLimitsDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601426D RID: 82541 RVA: 0x001D9914 File Offset: 0x001D7B14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKawaiiPhysicsLimitsDataAsset._ClassPtr;
		}

		// Token: 0x0601426E RID: 82542 RVA: 0x001D9920 File Offset: 0x001D7B20
		public UKawaiiPhysicsLimitsDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKawaiiPhysicsLimitsDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601426F RID: 82543 RVA: 0x001D9948 File Offset: 0x001D7B48
		public UKawaiiPhysicsLimitsDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKawaiiPhysicsLimitsDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x06014270 RID: 82544 RVA: 0x001D997C File Offset: 0x001D7B7C
		// (set) Token: 0x06014271 RID: 82545 RVA: 0x001D99B5 File Offset: 0x001D7BB5
		public TArray<FSphericalLimit> SphericalLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSphericalLimit> result;
				if ((result = this._SphericalLimits) == null)
				{
					result = (this._SphericalLimits = new TArray<FSphericalLimit>(base.NativePtr + (IntPtr)UKawaiiPhysicsLimitsDataAsset.__PropertyOffset_SphericalLimits, this));
				}
				return result;
			}
			set
			{
				this.SphericalLimits.CopyAssign(value);
			}
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x06014272 RID: 82546 RVA: 0x001D99C4 File Offset: 0x001D7BC4
		// (set) Token: 0x06014273 RID: 82547 RVA: 0x001D99FD File Offset: 0x001D7BFD
		public TArray<FCapsuleLimit> CapsuleLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCapsuleLimit> result;
				if ((result = this._CapsuleLimits) == null)
				{
					result = (this._CapsuleLimits = new TArray<FCapsuleLimit>(base.NativePtr + (IntPtr)UKawaiiPhysicsLimitsDataAsset.__PropertyOffset_CapsuleLimits, this));
				}
				return result;
			}
			set
			{
				this.CapsuleLimits.CopyAssign(value);
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x06014274 RID: 82548 RVA: 0x001D9A0C File Offset: 0x001D7C0C
		// (set) Token: 0x06014275 RID: 82549 RVA: 0x001D9A45 File Offset: 0x001D7C45
		public TArray<FPlanarLimit> PlanarLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlanarLimit> result;
				if ((result = this._PlanarLimits) == null)
				{
					result = (this._PlanarLimits = new TArray<FPlanarLimit>(base.NativePtr + (IntPtr)UKawaiiPhysicsLimitsDataAsset.__PropertyOffset_PlanarLimits, this));
				}
				return result;
			}
			set
			{
				this.PlanarLimits.CopyAssign(value);
			}
		}

		// Token: 0x06014276 RID: 82550 RVA: 0x001D9A53 File Offset: 0x001D7C53
		static UKawaiiPhysicsLimitsDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KawaiiPhysics.KawaiiPhysicsLimitsDataAsset");
		}

		// Token: 0x06014277 RID: 82551 RVA: 0x001D9A61 File Offset: 0x001D7C61
		protected UKawaiiPhysicsLimitsDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AF5D RID: 44893
		public new const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiPhysicsLimitsDataAsset";

		// Token: 0x0400AF5E RID: 44894
		private static IntPtr _ClassPtr;

		// Token: 0x0400AF5F RID: 44895
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AF60 RID: 44896
		internal static int __PropertyOffset_SphericalLimits;

		// Token: 0x0400AF61 RID: 44897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSphericalLimit> _SphericalLimits;

		// Token: 0x0400AF62 RID: 44898
		internal static int __PropertyOffset_CapsuleLimits;

		// Token: 0x0400AF63 RID: 44899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCapsuleLimit> _CapsuleLimits;

		// Token: 0x0400AF64 RID: 44900
		internal static int __PropertyOffset_PlanarLimits;

		// Token: 0x0400AF65 RID: 44901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPlanarLimit> _PlanarLimits;
	}
}

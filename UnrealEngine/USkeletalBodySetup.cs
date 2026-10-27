using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F1 RID: 4337
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalBodySetup")]
	[UnrealStructLayout(872, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 872)]
	public class USkeletalBodySetup : UBodySetup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F8CB RID: 63691 RVA: 0x0016FF58 File Offset: 0x0016E158
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalBodySetup._ClassPtr;
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x0016FF64 File Offset: 0x0016E164
		public USkeletalBodySetup() : this(BuiltinUtils.AllocNativeUObject(USkeletalBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x0016FF8C File Offset: 0x0016E18C
		public USkeletalBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0600F8CE RID: 63694 RVA: 0x0016FFBF File Offset: 0x0016E1BF
		// (set) Token: 0x0600F8CF RID: 63695 RVA: 0x0016FFCF File Offset: 0x0016E1CF
		public unsafe bool bSkipScaleFromAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalBodySetup.__PropertyOffset_bSkipScaleFromAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalBodySetup.__PropertyOffset_bSkipScaleFromAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x0016FFE0 File Offset: 0x0016E1E0
		// (set) Token: 0x0600F8D1 RID: 63697 RVA: 0x00170019 File Offset: 0x0016E219
		public TArray<FPhysicalAnimationProfile> PhysicalAnimationData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhysicalAnimationProfile> result;
				if ((result = this._PhysicalAnimationData) == null)
				{
					result = (this._PhysicalAnimationData = new TArray<FPhysicalAnimationProfile>(base.NativePtr + (IntPtr)USkeletalBodySetup.__PropertyOffset_PhysicalAnimationData, this));
				}
				return result;
			}
			set
			{
				this.PhysicalAnimationData.CopyAssign(value);
			}
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00170027 File Offset: 0x0016E227
		static USkeletalBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalBodySetup");
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x00170035 File Offset: 0x0016E235
		protected USkeletalBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008667 RID: 34407
		public new const string __ObjectPath = "/Script/Engine.SkeletalBodySetup";

		// Token: 0x04008668 RID: 34408
		private static IntPtr _ClassPtr;

		// Token: 0x04008669 RID: 34409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400866A RID: 34410
		internal static int __PropertyOffset_bSkipScaleFromAnimation;

		// Token: 0x0400866B RID: 34411
		internal static int __PropertyOffset_PhysicalAnimationData;

		// Token: 0x0400866C RID: 34412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhysicalAnimationProfile> _PhysicalAnimationData;
	}
}

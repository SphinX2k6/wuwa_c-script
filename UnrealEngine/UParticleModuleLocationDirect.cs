using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F77 RID: 3959
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationDirect")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UParticleModuleLocationDirect : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D57D RID: 54653 RVA: 0x00139FD5 File Offset: 0x001381D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationDirect._ClassPtr;
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x00139FE4 File Offset: 0x001381E4
		public UParticleModuleLocationDirect() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationDirect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x0013A00C File Offset: 0x0013820C
		public UParticleModuleLocationDirect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationDirect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600D580 RID: 54656 RVA: 0x0013A040 File Offset: 0x00138240
		// (set) Token: 0x0600D581 RID: 54657 RVA: 0x0013A079 File Offset: 0x00138279
		public FRawDistributionVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600D582 RID: 54658 RVA: 0x0013A09C File Offset: 0x0013829C
		// (set) Token: 0x0600D583 RID: 54659 RVA: 0x0013A0D5 File Offset: 0x001382D5
		public FRawDistributionVector LocationOffset
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._LocationOffset) == null)
				{
					result = (this._LocationOffset = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_LocationOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_LocationOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600D584 RID: 54660 RVA: 0x0013A0F8 File Offset: 0x001382F8
		// (set) Token: 0x0600D585 RID: 54661 RVA: 0x0013A131 File Offset: 0x00138331
		public FRawDistributionVector ScaleFactor
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._ScaleFactor) == null)
				{
					result = (this._ScaleFactor = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_ScaleFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_ScaleFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x0013A154 File Offset: 0x00138354
		// (set) Token: 0x0600D587 RID: 54663 RVA: 0x0013A18D File Offset: 0x0013838D
		public FRawDistributionVector Direction
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Direction) == null)
				{
					result = (this._Direction = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_Direction, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationDirect.__PropertyOffset_Direction, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x0013A1AE File Offset: 0x001383AE
		static UParticleModuleLocationDirect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationDirect");
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x0013A1BC File Offset: 0x001383BC
		protected UParticleModuleLocationDirect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400731C RID: 29468
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationDirect";

		// Token: 0x0400731D RID: 29469
		private static IntPtr _ClassPtr;

		// Token: 0x0400731E RID: 29470
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400731F RID: 29471
		internal static int __PropertyOffset_Location;

		// Token: 0x04007320 RID: 29472
		[Nullable(2)]
		private FRawDistributionVector _Location;

		// Token: 0x04007321 RID: 29473
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x04007322 RID: 29474
		[Nullable(2)]
		private FRawDistributionVector _LocationOffset;

		// Token: 0x04007323 RID: 29475
		internal static int __PropertyOffset_ScaleFactor;

		// Token: 0x04007324 RID: 29476
		[Nullable(2)]
		private FRawDistributionVector _ScaleFactor;

		// Token: 0x04007325 RID: 29477
		internal static int __PropertyOffset_Direction;

		// Token: 0x04007326 RID: 29478
		[Nullable(2)]
		private FRawDistributionVector _Direction;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAB RID: 4011
	[UnrealObjectPath("/Script/Engine.ParticleModuleTrailSource")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UParticleModuleTrailSource : UParticleModuleTrailBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7B7 RID: 55223 RVA: 0x0013E135 File Offset: 0x0013C335
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTrailSource._ClassPtr;
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x0013E144 File Offset: 0x0013C344
		public UParticleModuleTrailSource() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTrailSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x0013E16C File Offset: 0x0013C36C
		[NullableContext(1)]
		public UParticleModuleTrailSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTrailSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600D7BA RID: 55226 RVA: 0x0013E19F File Offset: 0x0013C39F
		// (set) Token: 0x0600D7BB RID: 55227 RVA: 0x0013E1B3 File Offset: 0x0013C3B3
		public unsafe TEnumAsByte<ETrail2SourceMethod> SourceMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceMethod) = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600D7BC RID: 55228 RVA: 0x0013E1C8 File Offset: 0x0013C3C8
		// (set) Token: 0x0600D7BD RID: 55229 RVA: 0x0013E1DC File Offset: 0x0013C3DC
		public unsafe FName SourceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceName) = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x0013E1F4 File Offset: 0x0013C3F4
		// (set) Token: 0x0600D7BF RID: 55231 RVA: 0x0013E22D File Offset: 0x0013C42D
		[Nullable(1)]
		public FRawDistributionFloat SourceStrength
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SourceStrength) == null)
				{
					result = (this._SourceStrength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceStrength, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600D7C0 RID: 55232 RVA: 0x0013E24E File Offset: 0x0013C44E
		// (set) Token: 0x0600D7C1 RID: 55233 RVA: 0x0013E267 File Offset: 0x0013C467
		public unsafe bool bLockSourceStength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bLockSourceStength) & UParticleModuleTrailSource.__PropertyMask_bLockSourceStength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bLockSourceStength) = ((*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bLockSourceStength) & ~UParticleModuleTrailSource.__PropertyMask_bLockSourceStength) | (value ? UParticleModuleTrailSource.__PropertyMask_bLockSourceStength : 0));
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600D7C2 RID: 55234 RVA: 0x0013E297 File Offset: 0x0013C497
		// (set) Token: 0x0600D7C3 RID: 55235 RVA: 0x0013E2A7 File Offset: 0x0013C4A7
		public unsafe int SourceOffsetCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceOffsetCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceOffsetCount) = value;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x0013E2B8 File Offset: 0x0013C4B8
		// (set) Token: 0x0600D7C5 RID: 55237 RVA: 0x0013E2F1 File Offset: 0x0013C4F1
		[Nullable(1)]
		public TArray<FVector> SourceOffsetDefaults
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SourceOffsetDefaults) == null)
				{
					result = (this._SourceOffsetDefaults = new TArray<FVector>(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SourceOffsetDefaults, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SourceOffsetDefaults.CopyAssign(value);
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x0013E2FF File Offset: 0x0013C4FF
		// (set) Token: 0x0600D7C7 RID: 55239 RVA: 0x0013E313 File Offset: 0x0013C513
		public unsafe TEnumAsByte<EParticleSourceSelectionMethod> SelectionMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SelectionMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_SelectionMethod) = value;
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600D7C8 RID: 55240 RVA: 0x0013E328 File Offset: 0x0013C528
		// (set) Token: 0x0600D7C9 RID: 55241 RVA: 0x0013E341 File Offset: 0x0013C541
		public unsafe bool bInheritRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bInheritRotation) & UParticleModuleTrailSource.__PropertyMask_bInheritRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bInheritRotation) = ((*(base.NativePtr + (IntPtr)UParticleModuleTrailSource.__PropertyOffset_bInheritRotation) & ~UParticleModuleTrailSource.__PropertyMask_bInheritRotation) | (value ? UParticleModuleTrailSource.__PropertyMask_bInheritRotation : 0));
			}
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x0013E371 File Offset: 0x0013C571
		static UParticleModuleTrailSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTrailSource");
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x0013E37F File Offset: 0x0013C57F
		protected UParticleModuleTrailSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074C1 RID: 29889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTrailSource";

		// Token: 0x040074C2 RID: 29890
		private static IntPtr _ClassPtr;

		// Token: 0x040074C3 RID: 29891
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040074C4 RID: 29892
		internal static int __PropertyOffset_SourceMethod;

		// Token: 0x040074C5 RID: 29893
		internal static int __PropertyOffset_SourceName;

		// Token: 0x040074C6 RID: 29894
		internal static int __PropertyOffset_SourceStrength;

		// Token: 0x040074C7 RID: 29895
		[Nullable(2)]
		private FRawDistributionFloat _SourceStrength;

		// Token: 0x040074C8 RID: 29896
		internal static int __PropertyOffset_bLockSourceStength;

		// Token: 0x040074C9 RID: 29897
		internal static byte __PropertyMask_bLockSourceStength;

		// Token: 0x040074CA RID: 29898
		internal static int __PropertyOffset_SourceOffsetCount;

		// Token: 0x040074CB RID: 29899
		internal static int __PropertyOffset_SourceOffsetDefaults;

		// Token: 0x040074CC RID: 29900
		[Nullable(2)]
		private TArray<FVector> _SourceOffsetDefaults;

		// Token: 0x040074CD RID: 29901
		internal static int __PropertyOffset_SelectionMethod;

		// Token: 0x040074CE RID: 29902
		internal static int __PropertyOffset_bInheritRotation;

		// Token: 0x040074CF RID: 29903
		internal static byte __PropertyMask_bInheritRotation;
	}
}

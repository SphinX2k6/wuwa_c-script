using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200168C RID: 5772
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroAudioMaterialSettings")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroAudioMaterialSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F2E RID: 85806 RVA: 0x001ECB50 File Offset: 0x001EAD50
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioMaterialSettings._ClassPtr;
		}

		// Token: 0x06014F2F RID: 85807 RVA: 0x001ECB5C File Offset: 0x001EAD5C
		public UKuroAudioMaterialSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F30 RID: 85808 RVA: 0x001ECB84 File Offset: 0x001EAD84
		public UKuroAudioMaterialSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x06014F31 RID: 85809 RVA: 0x001ECBB8 File Offset: 0x001EADB8
		// (set) Token: 0x06014F32 RID: 85810 RVA: 0x001ECBF1 File Offset: 0x001EADF1
		public TArray<FKuroMatName2PhysMaterial> MatName2PhysMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMatName2PhysMaterial> result;
				if ((result = this._MatName2PhysMaterial) == null)
				{
					result = (this._MatName2PhysMaterial = new TArray<FKuroMatName2PhysMaterial>(base.NativePtr + (IntPtr)UKuroAudioMaterialSettings.__PropertyOffset_MatName2PhysMaterial, this));
				}
				return result;
			}
			set
			{
				this.MatName2PhysMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x06014F33 RID: 85811 RVA: 0x001ECC00 File Offset: 0x001EAE00
		// (set) Token: 0x06014F34 RID: 85812 RVA: 0x001ECC39 File Offset: 0x001EAE39
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EPhysicalSurface>, FName> FootstepAudioTextureMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EPhysicalSurface>, FName> result;
				if ((result = this._FootstepAudioTextureMap) == null)
				{
					result = (this._FootstepAudioTextureMap = new TMap<TEnumAsByte<EPhysicalSurface>, FName>(base.NativePtr + (IntPtr)UKuroAudioMaterialSettings.__PropertyOffset_FootstepAudioTextureMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FootstepAudioTextureMap.CopyAssign(value);
			}
		}

		// Token: 0x06014F35 RID: 85813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetFootstepTextureName(EPhysicalSurface SurfaceType);

		// Token: 0x06014F36 RID: 85814 RVA: 0x001ECC47 File Offset: 0x001EAE47
		static UKuroAudioMaterialSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudioMaterial.KuroAudioMaterialSettings");
		}

		// Token: 0x06014F37 RID: 85815 RVA: 0x001ECC55 File Offset: 0x001EAE55
		protected UKuroAudioMaterialSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B693 RID: 46739
		public new const string __ObjectPath = "/Script/KuroAudioMaterial.KuroAudioMaterialSettings";

		// Token: 0x0400B694 RID: 46740
		private static IntPtr _ClassPtr;

		// Token: 0x0400B695 RID: 46741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B696 RID: 46742
		internal static int __PropertyOffset_MatName2PhysMaterial;

		// Token: 0x0400B697 RID: 46743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMatName2PhysMaterial> _MatName2PhysMaterial;

		// Token: 0x0400B698 RID: 46744
		internal static int __PropertyOffset_FootstepAudioTextureMap;

		// Token: 0x0400B699 RID: 46745
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EPhysicalSurface>, FName> _FootstepAudioTextureMap;
	}
}

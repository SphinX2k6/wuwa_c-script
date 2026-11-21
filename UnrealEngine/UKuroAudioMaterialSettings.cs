using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000309 RID: 777
	[UnrealObjectPath("/Script/KuroAudioMaterial.KuroAudioMaterialSettings")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroAudioMaterialSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005325 RID: 21285 RVA: 0x00074430 File Offset: 0x00072630
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioMaterialSettings._ClassPtr;
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x0007443C File Offset: 0x0007263C
		public UKuroAudioMaterialSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00074464 File Offset: 0x00072664
		[NullableContext(1)]
		public UKuroAudioMaterialSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioMaterialSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x00074498 File Offset: 0x00072698
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x000744D1 File Offset: 0x000726D1
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

		// Token: 0x0600532A RID: 21290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName GetFootstepTextureName(EPhysicalSurface SurfaceType);

		// Token: 0x0600532B RID: 21291 RVA: 0x000744DF File Offset: 0x000726DF
		static UKuroAudioMaterialSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudioMaterial.KuroAudioMaterialSettings");
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x000744ED File Offset: 0x000726ED
		protected UKuroAudioMaterialSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021F4 RID: 8692
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudioMaterial.KuroAudioMaterialSettings";

		// Token: 0x040021F5 RID: 8693
		private static IntPtr _ClassPtr;

		// Token: 0x040021F6 RID: 8694
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040021F7 RID: 8695
		internal static int __PropertyOffset_FootstepAudioTextureMap;

		// Token: 0x040021F8 RID: 8696
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EPhysicalSurface>, FName> _FootstepAudioTextureMap;
	}
}

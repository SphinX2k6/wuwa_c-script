using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B7 RID: 1207
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroChangeMaterialsTextures : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F35 RID: 28469 RVA: 0x000A4946 File Offset: 0x000A2B46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroChangeMaterialsTextures._ClassPtr;
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x000A4954 File Offset: 0x000A2B54
		public UKuroChangeMaterialsTextures() : this(BuiltinUtils.AllocNativeUObject(UKuroChangeMaterialsTextures.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x000A497C File Offset: 0x000A2B7C
		public UKuroChangeMaterialsTextures(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroChangeMaterialsTextures.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x000A49AF File Offset: 0x000A2BAF
		// (set) Token: 0x06006F39 RID: 28473 RVA: 0x000A49C3 File Offset: 0x000A2BC3
		public unsafe string SkeletalMeshName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_SkeletalMeshName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_SkeletalMeshName)), value);
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x000A49EC File Offset: 0x000A2BEC
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06006F3C RID: 28476 RVA: 0x000A4A04 File Offset: 0x000A2C04
		// (set) Token: 0x06006F3D RID: 28477 RVA: 0x000A4A3D File Offset: 0x000A2C3D
		public TArray<TSoftObjectPtr<UTexture2D>> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UTexture2D>> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TArray<TSoftObjectPtr<UTexture2D>>(base.NativePtr + (IntPtr)UKuroChangeMaterialsTextures.__PropertyOffset_Textures, this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x000A4A4B File Offset: 0x000A2C4B
		static UKuroChangeMaterialsTextures()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures");
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x000A4A59 File Offset: 0x000A2C59
		protected UKuroChangeMaterialsTextures(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400301A RID: 12314
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroChangeMaterialsTextures";

		// Token: 0x0400301B RID: 12315
		private static IntPtr _ClassPtr;

		// Token: 0x0400301C RID: 12316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400301D RID: 12317
		internal static int __PropertyOffset_SkeletalMeshName;

		// Token: 0x0400301E RID: 12318
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400301F RID: 12319
		internal static int __PropertyOffset_Textures;

		// Token: 0x04003020 RID: 12320
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UTexture2D>> _Textures;
	}
}

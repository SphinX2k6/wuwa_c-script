using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200088C RID: 2188
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitAnimTextureDA")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UBakedBoneSplitAnimTextureDA : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060077AB RID: 30635 RVA: 0x000AB5EA File Offset: 0x000A97EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitAnimTextureDA._ClassPtr;
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x000AB5F8 File Offset: 0x000A97F8
		public UBakedBoneSplitAnimTextureDA() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitAnimTextureDA.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x000AB620 File Offset: 0x000A9820
		public UBakedBoneSplitAnimTextureDA(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitAnimTextureDA.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x000AB654 File Offset: 0x000A9854
		// (set) Token: 0x060077AF RID: 30639 RVA: 0x000AB68D File Offset: 0x000A988D
		public TArray<UBakedBoneTexture2D> BakedBoneAnimTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBakedBoneTexture2D> result;
				if ((result = this._BakedBoneAnimTextures) == null)
				{
					result = (this._BakedBoneAnimTextures = new TArray<UBakedBoneTexture2D>(base.NativePtr + (IntPtr)UBakedBoneSplitAnimTextureDA.__PropertyOffset_BakedBoneAnimTextures, this));
				}
				return result;
			}
			set
			{
				this.BakedBoneAnimTextures.CopyAssign(value);
			}
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x000AB69B File Offset: 0x000A989B
		static UBakedBoneSplitAnimTextureDA()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitAnimTextureDA");
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x000AB6A9 File Offset: 0x000A98A9
		protected UBakedBoneSplitAnimTextureDA(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003974 RID: 14708
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitAnimTextureDA";

		// Token: 0x04003975 RID: 14709
		private static IntPtr _ClassPtr;

		// Token: 0x04003976 RID: 14710
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003977 RID: 14711
		internal static int __PropertyOffset_BakedBoneAnimTextures;

		// Token: 0x04003978 RID: 14712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBakedBoneTexture2D> _BakedBoneAnimTextures;
	}
}

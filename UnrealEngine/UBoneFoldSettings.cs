using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008D6 RID: 2262
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneFoldSettings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UBoneFoldSettings : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007C6C RID: 31852 RVA: 0x000B278B File Offset: 0x000B098B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoneFoldSettings._ClassPtr;
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x000B2798 File Offset: 0x000B0998
		public UBoneFoldSettings() : this(BuiltinUtils.AllocNativeUObject(UBoneFoldSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x000B27C0 File Offset: 0x000B09C0
		public UBoneFoldSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoneFoldSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x000B27F4 File Offset: 0x000B09F4
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x000B282D File Offset: 0x000B0A2D
		public TArray<FBoneFoldLayer> BoneFoldLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneFoldLayer> result;
				if ((result = this._BoneFoldLayers) == null)
				{
					result = (this._BoneFoldLayers = new TArray<FBoneFoldLayer>(base.NativePtr + (IntPtr)UBoneFoldSettings.__PropertyOffset_BoneFoldLayers, this));
				}
				return result;
			}
			set
			{
				this.BoneFoldLayers.CopyAssign(value);
			}
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x000B283B File Offset: 0x000B0A3B
		static UBoneFoldSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoneFoldSettings");
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x000B2849 File Offset: 0x000B0A49
		protected UBoneFoldSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BA4 RID: 15268
		public new const string __ObjectPath = "/Script/Engine.BoneFoldSettings";

		// Token: 0x04003BA5 RID: 15269
		private static IntPtr _ClassPtr;

		// Token: 0x04003BA6 RID: 15270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BA7 RID: 15271
		internal static int __PropertyOffset_BoneFoldLayers;

		// Token: 0x04003BA8 RID: 15272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneFoldLayer> _BoneFoldLayers;
	}
}

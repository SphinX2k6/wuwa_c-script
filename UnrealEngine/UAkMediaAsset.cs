using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000220 RID: 544
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMediaAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAkMediaAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x0002F9ED File Offset: 0x0002DBED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMediaAsset._ClassPtr;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0002F9FC File Offset: 0x0002DBFC
		public UAkMediaAsset() : this(BuiltinUtils.AllocNativeUObject(UAkMediaAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0002FA24 File Offset: 0x0002DC24
		public UAkMediaAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMediaAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0002FA58 File Offset: 0x0002DC58
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x0002FA91 File Offset: 0x0002DC91
		public TMap<string, UAkMediaAssetData> MediaAssetDataPerPlatform
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UAkMediaAssetData> result;
				if ((result = this._MediaAssetDataPerPlatform) == null)
				{
					result = (this._MediaAssetDataPerPlatform = new TMap<string, UAkMediaAssetData>(base.NativePtr + (IntPtr)UAkMediaAsset.__PropertyOffset_MediaAssetDataPerPlatform, this));
				}
				return result;
			}
			set
			{
				this.MediaAssetDataPerPlatform.CopyAssign(value);
			}
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0002FA9F File Offset: 0x0002DC9F
		static UAkMediaAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMediaAsset");
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0002FAAD File Offset: 0x0002DCAD
		protected UAkMediaAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000ABF RID: 2751
		public new const string __ObjectPath = "/Script/AkAudio.AkMediaAsset";

		// Token: 0x04000AC0 RID: 2752
		private static IntPtr _ClassPtr;

		// Token: 0x04000AC1 RID: 2753
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AC2 RID: 2754
		internal static int __PropertyOffset_MediaAssetDataPerPlatform;

		// Token: 0x04000AC3 RID: 2755
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UAkMediaAssetData> _MediaAssetDataPerPlatform;
	}
}

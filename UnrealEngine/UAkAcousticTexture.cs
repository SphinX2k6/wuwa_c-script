using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E4 RID: 484
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAcousticTexture")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAkAcousticTexture : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x0002A90C File Offset: 0x00028B0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAcousticTexture._ClassPtr;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0002A918 File Offset: 0x00028B18
		public UAkAcousticTexture() : this(BuiltinUtils.AllocNativeUObject(UAkAcousticTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0002A940 File Offset: 0x00028B40
		public UAkAcousticTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAcousticTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0002A974 File Offset: 0x00028B74
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x0002A9AD File Offset: 0x00028BAD
		public FWwiseAcousticTextureCookedData AcousticTextureCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseAcousticTextureCookedData result;
				if ((result = this._AcousticTextureCookedData) == null)
				{
					result = (this._AcousticTextureCookedData = new FWwiseAcousticTextureCookedData(base.NativePtr + (IntPtr)UAkAcousticTexture.__PropertyOffset_AcousticTextureCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseAcousticTextureCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkAcousticTexture.__PropertyOffset_AcousticTextureCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0002A9CE File Offset: 0x00028BCE
		static UAkAcousticTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAcousticTexture");
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0002A9DC File Offset: 0x00028BDC
		protected UAkAcousticTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400094E RID: 2382
		public new const string __ObjectPath = "/Script/AkAudio.AkAcousticTexture";

		// Token: 0x0400094F RID: 2383
		private static IntPtr _ClassPtr;

		// Token: 0x04000950 RID: 2384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000951 RID: 2385
		internal static int __PropertyOffset_AcousticTextureCookedData;

		// Token: 0x04000952 RID: 2386
		[Nullable(2)]
		private FWwiseAcousticTextureCookedData _AcousticTextureCookedData;
	}
}

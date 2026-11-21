using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000412 RID: 1042
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.MediaActorAsset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMediaActorAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006563 RID: 25955 RVA: 0x00090FF1 File Offset: 0x0008F1F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaActorAsset._ClassPtr;
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x00091000 File Offset: 0x0008F200
		public UMediaActorAsset() : this(BuiltinUtils.AllocNativeUObject(UMediaActorAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x00091028 File Offset: 0x0008F228
		public UMediaActorAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaActorAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06006566 RID: 25958 RVA: 0x0009105C File Offset: 0x0008F25C
		// (set) Token: 0x06006567 RID: 25959 RVA: 0x00091095 File Offset: 0x0008F295
		public TArray<UMediaPlayer> MediaPlayerArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMediaPlayer> result;
				if ((result = this._MediaPlayerArray) == null)
				{
					result = (this._MediaPlayerArray = new TArray<UMediaPlayer>(base.NativePtr + (IntPtr)UMediaActorAsset.__PropertyOffset_MediaPlayerArray, this));
				}
				return result;
			}
			set
			{
				this.MediaPlayerArray.CopyAssign(value);
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06006568 RID: 25960 RVA: 0x000910A4 File Offset: 0x0008F2A4
		// (set) Token: 0x06006569 RID: 25961 RVA: 0x000910DD File Offset: 0x0008F2DD
		public TArray<UMediaTexture> MediaTextureArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMediaTexture> result;
				if ((result = this._MediaTextureArray) == null)
				{
					result = (this._MediaTextureArray = new TArray<UMediaTexture>(base.NativePtr + (IntPtr)UMediaActorAsset.__PropertyOffset_MediaTextureArray, this));
				}
				return result;
			}
			set
			{
				this.MediaTextureArray.CopyAssign(value);
			}
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x000910EB File Offset: 0x0008F2EB
		static UMediaActorAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.MediaActorAsset");
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x000910F9 File Offset: 0x0008F2F9
		protected UMediaActorAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002AA2 RID: 10914
		public new const string __ObjectPath = "/Script/KuroGameplay.MediaActorAsset";

		// Token: 0x04002AA3 RID: 10915
		private static IntPtr _ClassPtr;

		// Token: 0x04002AA4 RID: 10916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002AA5 RID: 10917
		internal static int __PropertyOffset_MediaPlayerArray;

		// Token: 0x04002AA6 RID: 10918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMediaPlayer> _MediaPlayerArray;

		// Token: 0x04002AA7 RID: 10919
		internal static int __PropertyOffset_MediaTextureArray;

		// Token: 0x04002AA8 RID: 10920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMediaTexture> _MediaTextureArray;
	}
}

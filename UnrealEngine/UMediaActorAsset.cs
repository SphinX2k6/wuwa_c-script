using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001924 RID: 6436
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.MediaActorAsset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMediaActorAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017DED RID: 97773 RVA: 0x0022F9F1 File Offset: 0x0022DBF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaActorAsset._ClassPtr;
		}

		// Token: 0x06017DEE RID: 97774 RVA: 0x0022FA00 File Offset: 0x0022DC00
		public UMediaActorAsset() : this(BuiltinUtils.AllocNativeUObject(UMediaActorAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017DEF RID: 97775 RVA: 0x0022FA28 File Offset: 0x0022DC28
		public UMediaActorAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaActorAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x06017DF0 RID: 97776 RVA: 0x0022FA5C File Offset: 0x0022DC5C
		// (set) Token: 0x06017DF1 RID: 97777 RVA: 0x0022FA95 File Offset: 0x0022DC95
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

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x06017DF2 RID: 97778 RVA: 0x0022FAA4 File Offset: 0x0022DCA4
		// (set) Token: 0x06017DF3 RID: 97779 RVA: 0x0022FADD File Offset: 0x0022DCDD
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

		// Token: 0x06017DF4 RID: 97780 RVA: 0x0022FAEB File Offset: 0x0022DCEB
		static UMediaActorAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.MediaActorAsset");
		}

		// Token: 0x06017DF5 RID: 97781 RVA: 0x0022FAF9 File Offset: 0x0022DCF9
		protected UMediaActorAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEDD RID: 52957
		public new const string __ObjectPath = "/Script/KuroGameplay.MediaActorAsset";

		// Token: 0x0400CEDE RID: 52958
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEDF RID: 52959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEE0 RID: 52960
		internal static int __PropertyOffset_MediaPlayerArray;

		// Token: 0x0400CEE1 RID: 52961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMediaPlayer> _MediaPlayerArray;

		// Token: 0x0400CEE2 RID: 52962
		internal static int __PropertyOffset_MediaTextureArray;

		// Token: 0x0400CEE3 RID: 52963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMediaTexture> _MediaTextureArray;
	}
}

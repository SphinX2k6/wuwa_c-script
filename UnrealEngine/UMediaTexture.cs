using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000752 RID: 1874
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaTexture")]
	[UnrealStructLayout(4336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4336)]
	public class UMediaTexture : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3C2 RID: 41922 RVA: 0x000F1C05 File Offset: 0x000EFE05
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaTexture._ClassPtr;
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x000F1C14 File Offset: 0x000EFE14
		public UMediaTexture() : this(BuiltinUtils.AllocNativeUObject(UMediaTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x000F1C3C File Offset: 0x000EFE3C
		[NullableContext(1)]
		public UMediaTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x000F1C6F File Offset: 0x000EFE6F
		// (set) Token: 0x0600A3C6 RID: 41926 RVA: 0x000F1C7F File Offset: 0x000EFE7F
		public unsafe bool AutoClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AutoClear) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AutoClear) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x000F1C90 File Offset: 0x000EFE90
		// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x000F1CA4 File Offset: 0x000EFEA4
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x000F1CB9 File Offset: 0x000EFEB9
		// (set) Token: 0x0600A3CA RID: 41930 RVA: 0x000F1CC9 File Offset: 0x000EFEC9
		public unsafe bool EnableGenMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_EnableGenMips) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_EnableGenMips) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x000F1CDA File Offset: 0x000EFEDA
		// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x000F1CEA File Offset: 0x000EFEEA
		public unsafe byte NumMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NumMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NumMips) = value;
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x000F1CFB File Offset: 0x000EFEFB
		// (set) Token: 0x0600A3CE RID: 41934 RVA: 0x000F1D0B File Offset: 0x000EFF0B
		public unsafe bool NewStyleOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NewStyleOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NewStyleOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x000F1D1C File Offset: 0x000EFF1C
		// (set) Token: 0x0600A3D0 RID: 41936 RVA: 0x000F1D2C File Offset: 0x000EFF2C
		public unsafe float CurrentAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentAspectRatio) = value;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600A3D1 RID: 41937 RVA: 0x000F1D3D File Offset: 0x000EFF3D
		// (set) Token: 0x0600A3D2 RID: 41938 RVA: 0x000F1D51 File Offset: 0x000EFF51
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaTexture.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaTexture.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x000F1D66 File Offset: 0x000EFF66
		public void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
		{
			UMediaTexture.__SetMediaPlayer_Internal(base.NativePtr, (NewMediaPlayer != null) ? NewMediaPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x000F1D83 File Offset: 0x000EFF83
		public int GetWidth()
		{
			return UMediaTexture.__GetWidth_Internal(base.NativePtr);
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x000F1D90 File Offset: 0x000EFF90
		public UMediaPlayer GetMediaPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(UMediaTexture.__GetMediaPlayer_Internal(base.NativePtr));
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x000F1DA2 File Offset: 0x000EFFA2
		public int GetHeight()
		{
			return UMediaTexture.__GetHeight_Internal(base.NativePtr);
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x000F1DAF File Offset: 0x000EFFAF
		public float GetAspectRatio()
		{
			return UMediaTexture.__GetAspectRatio_Internal(base.NativePtr);
		}

		// Token: 0x0600A3D8 RID: 41944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaPlayer_Internal(IntPtr @this, IntPtr NewMediaPlayer);

		// Token: 0x0600A3D9 RID: 41945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWidth_Internal(IntPtr @this);

		// Token: 0x0600A3DA RID: 41946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaPlayer_Internal(IntPtr @this);

		// Token: 0x0600A3DB RID: 41947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHeight_Internal(IntPtr @this);

		// Token: 0x0600A3DC RID: 41948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAspectRatio_Internal(IntPtr @this);

		// Token: 0x0600A3DD RID: 41949 RVA: 0x000F1DBC File Offset: 0x000EFFBC
		static UMediaTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaTexture");
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x000F1DCA File Offset: 0x000EFFCA
		protected UMediaTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045DE RID: 17886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaTexture";

		// Token: 0x040045DF RID: 17887
		private static IntPtr _ClassPtr;

		// Token: 0x040045E0 RID: 17888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040045E1 RID: 17889
		internal static int __PropertyOffset_AutoClear;

		// Token: 0x040045E2 RID: 17890
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x040045E3 RID: 17891
		internal static int __PropertyOffset_EnableGenMips;

		// Token: 0x040045E4 RID: 17892
		internal static int __PropertyOffset_NumMips;

		// Token: 0x040045E5 RID: 17893
		internal static int __PropertyOffset_NewStyleOutput;

		// Token: 0x040045E6 RID: 17894
		internal static int __PropertyOffset_CurrentAspectRatio;

		// Token: 0x040045E7 RID: 17895
		internal static int __PropertyOffset_MediaPlayer;
	}
}

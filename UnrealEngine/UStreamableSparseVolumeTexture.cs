using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A7 RID: 4519
	[UnrealObjectPath("/Script/Engine.StreamableSparseVolumeTexture")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UStreamableSparseVolumeTexture : USparseVolumeTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A89 RID: 68233 RVA: 0x00187849 File Offset: 0x00185A49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamableSparseVolumeTexture._ClassPtr;
		}

		// Token: 0x06010A8A RID: 68234 RVA: 0x00187858 File Offset: 0x00185A58
		public UStreamableSparseVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(UStreamableSparseVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A8B RID: 68235 RVA: 0x00187880 File Offset: 0x00185A80
		[NullableContext(1)]
		public UStreamableSparseVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamableSparseVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x06010A8C RID: 68236 RVA: 0x001878B3 File Offset: 0x00185AB3
		// (set) Token: 0x06010A8D RID: 68237 RVA: 0x001878C7 File Offset: 0x00185AC7
		public unsafe FIntVector VolumeResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_VolumeResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_VolumeResolution) = value;
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x06010A8E RID: 68238 RVA: 0x001878DC File Offset: 0x00185ADC
		// (set) Token: 0x06010A8F RID: 68239 RVA: 0x001878EC File Offset: 0x00185AEC
		public unsafe int NumMipLevels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_NumMipLevels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_NumMipLevels) = value;
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x06010A90 RID: 68240 RVA: 0x001878FD File Offset: 0x00185AFD
		// (set) Token: 0x06010A91 RID: 68241 RVA: 0x0018790D File Offset: 0x00185B0D
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x06010A92 RID: 68242 RVA: 0x0018791E File Offset: 0x00185B1E
		// (set) Token: 0x06010A93 RID: 68243 RVA: 0x00187932 File Offset: 0x00185B32
		public unsafe TEnumAsByte<EPixelFormat> FormatA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FormatA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FormatA) = value;
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x06010A94 RID: 68244 RVA: 0x00187947 File Offset: 0x00185B47
		// (set) Token: 0x06010A95 RID: 68245 RVA: 0x0018795B File Offset: 0x00185B5B
		public unsafe TEnumAsByte<EPixelFormat> FormatB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FormatB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FormatB) = value;
			}
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x06010A96 RID: 68246 RVA: 0x00187970 File Offset: 0x00185B70
		// (set) Token: 0x06010A97 RID: 68247 RVA: 0x00187984 File Offset: 0x00185B84
		public unsafe FVector4 FallbackValueA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FallbackValueA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FallbackValueA) = value;
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x06010A98 RID: 68248 RVA: 0x00187999 File Offset: 0x00185B99
		// (set) Token: 0x06010A99 RID: 68249 RVA: 0x001879AD File Offset: 0x00185BAD
		public unsafe FVector4 FallbackValueB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FallbackValueB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_FallbackValueB) = value;
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x06010A9A RID: 68250 RVA: 0x001879C2 File Offset: 0x00185BC2
		// (set) Token: 0x06010A9B RID: 68251 RVA: 0x001879D6 File Offset: 0x00185BD6
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x06010A9C RID: 68252 RVA: 0x001879EB File Offset: 0x00185BEB
		// (set) Token: 0x06010A9D RID: 68253 RVA: 0x001879FF File Offset: 0x00185BFF
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x06010A9E RID: 68254 RVA: 0x00187A14 File Offset: 0x00185C14
		// (set) Token: 0x06010A9F RID: 68255 RVA: 0x00187A28 File Offset: 0x00185C28
		public unsafe TEnumAsByte<TextureAddress> AddressZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_AddressZ) = value;
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x06010AA0 RID: 68256 RVA: 0x00187A3D File Offset: 0x00185C3D
		// (set) Token: 0x06010AA1 RID: 68257 RVA: 0x00187A4D File Offset: 0x00185C4D
		public unsafe bool bLocalDDCOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_bLocalDDCOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_bLocalDDCOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x06010AA2 RID: 68258 RVA: 0x00187A60 File Offset: 0x00185C60
		// (set) Token: 0x06010AA3 RID: 68259 RVA: 0x00187A99 File Offset: 0x00185C99
		[Nullable(1)]
		public TArray<USparseVolumeTextureFrame> Frames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USparseVolumeTextureFrame> result;
				if ((result = this._Frames) == null)
				{
					result = (this._Frames = new TArray<USparseVolumeTextureFrame>(base.NativePtr + (IntPtr)UStreamableSparseVolumeTexture.__PropertyOffset_Frames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Frames.CopyAssign(value);
			}
		}

		// Token: 0x06010AA4 RID: 68260 RVA: 0x00187AA7 File Offset: 0x00185CA7
		static UStreamableSparseVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StreamableSparseVolumeTexture");
		}

		// Token: 0x06010AA5 RID: 68261 RVA: 0x00187AB5 File Offset: 0x00185CB5
		protected UStreamableSparseVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E91 RID: 36497
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StreamableSparseVolumeTexture";

		// Token: 0x04008E92 RID: 36498
		private static IntPtr _ClassPtr;

		// Token: 0x04008E93 RID: 36499
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008E94 RID: 36500
		internal static int __PropertyOffset_VolumeResolution;

		// Token: 0x04008E95 RID: 36501
		internal static int __PropertyOffset_NumMipLevels;

		// Token: 0x04008E96 RID: 36502
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x04008E97 RID: 36503
		internal static int __PropertyOffset_FormatA;

		// Token: 0x04008E98 RID: 36504
		internal static int __PropertyOffset_FormatB;

		// Token: 0x04008E99 RID: 36505
		internal static int __PropertyOffset_FallbackValueA;

		// Token: 0x04008E9A RID: 36506
		internal static int __PropertyOffset_FallbackValueB;

		// Token: 0x04008E9B RID: 36507
		internal static int __PropertyOffset_AddressX;

		// Token: 0x04008E9C RID: 36508
		internal static int __PropertyOffset_AddressY;

		// Token: 0x04008E9D RID: 36509
		internal static int __PropertyOffset_AddressZ;

		// Token: 0x04008E9E RID: 36510
		internal static int __PropertyOffset_bLocalDDCOnly;

		// Token: 0x04008E9F RID: 36511
		internal static int __PropertyOffset_Frames;

		// Token: 0x04008EA0 RID: 36512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USparseVolumeTextureFrame> _Frames;
	}
}

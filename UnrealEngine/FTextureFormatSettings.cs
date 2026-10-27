using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011D5 RID: 4565
	[UnrealObjectPath("/Script/Engine.TextureFormatSettings")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FTextureFormatSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010D0C RID: 68876 RVA: 0x0018B20A File Offset: 0x0018940A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureFormatSettings._ScriptStructPtr != 0) ? FTextureFormatSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureFormatSettings", ref FTextureFormatSettings._ScriptStructPtr);
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x06010D0D RID: 68877 RVA: 0x0018B22E File Offset: 0x0018942E
		// (set) Token: 0x06010D0E RID: 68878 RVA: 0x0018B242 File Offset: 0x00189442
		public unsafe TEnumAsByte<TextureCompressionSettings> CompressionSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionSettings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionSettings) = value;
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x06010D0F RID: 68879 RVA: 0x0018B257 File Offset: 0x00189457
		// (set) Token: 0x06010D10 RID: 68880 RVA: 0x0018B270 File Offset: 0x00189470
		public unsafe bool CompressionNoAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNoAlpha) & FTextureFormatSettings.__PropertyMask_CompressionNoAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNoAlpha) = ((*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNoAlpha) & ~FTextureFormatSettings.__PropertyMask_CompressionNoAlpha) | (value ? FTextureFormatSettings.__PropertyMask_CompressionNoAlpha : 0));
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06010D11 RID: 68881 RVA: 0x0018B2A0 File Offset: 0x001894A0
		// (set) Token: 0x06010D12 RID: 68882 RVA: 0x0018B2B9 File Offset: 0x001894B9
		public unsafe bool CompressionNone
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNone) & FTextureFormatSettings.__PropertyMask_CompressionNone) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNone) = ((*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionNone) & ~FTextureFormatSettings.__PropertyMask_CompressionNone) | (value ? FTextureFormatSettings.__PropertyMask_CompressionNone : 0));
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x06010D13 RID: 68883 RVA: 0x0018B2E9 File Offset: 0x001894E9
		// (set) Token: 0x06010D14 RID: 68884 RVA: 0x0018B302 File Offset: 0x00189502
		public unsafe bool CompressionYCoCg
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionYCoCg) & FTextureFormatSettings.__PropertyMask_CompressionYCoCg) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionYCoCg) = ((*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_CompressionYCoCg) & ~FTextureFormatSettings.__PropertyMask_CompressionYCoCg) | (value ? FTextureFormatSettings.__PropertyMask_CompressionYCoCg : 0));
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x06010D15 RID: 68885 RVA: 0x0018B332 File Offset: 0x00189532
		// (set) Token: 0x06010D16 RID: 68886 RVA: 0x0018B34B File Offset: 0x0018954B
		public unsafe bool SRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_SRGB) & FTextureFormatSettings.__PropertyMask_SRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_SRGB) = ((*(base.NativePtr + (IntPtr)FTextureFormatSettings.__PropertyOffset_SRGB) & ~FTextureFormatSettings.__PropertyMask_SRGB) | (value ? FTextureFormatSettings.__PropertyMask_SRGB : 0));
			}
		}

		// Token: 0x06010D17 RID: 68887 RVA: 0x0018B37B File Offset: 0x0018957B
		public FTextureFormatSettings()
		{
		}

		// Token: 0x06010D18 RID: 68888 RVA: 0x0018B383 File Offset: 0x00189583
		public FTextureFormatSettings(TEnumAsByte<TextureCompressionSettings> CompressionSettings, bool CompressionNoAlpha, bool CompressionNone, bool CompressionYCoCg, bool SRGB)
		{
			this.CompressionSettings = CompressionSettings;
			this.CompressionNoAlpha = CompressionNoAlpha;
			this.CompressionNone = CompressionNone;
			this.CompressionYCoCg = CompressionYCoCg;
			this.SRGB = SRGB;
		}

		// Token: 0x06010D19 RID: 68889 RVA: 0x0018B3B0 File Offset: 0x001895B0
		protected override IntPtr GetUStructPtr()
		{
			return FTextureFormatSettings.StaticStruct();
		}

		// Token: 0x06010D1A RID: 68890 RVA: 0x0018B3BC File Offset: 0x001895BC
		[NullableContext(2)]
		public FTextureFormatSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010D1B RID: 68891 RVA: 0x0018B3C6 File Offset: 0x001895C6
		public FTextureFormatSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010D1C RID: 68892 RVA: 0x0018B3D1 File Offset: 0x001895D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureFormatSettings(Pointer, false, true);
		}

		// Token: 0x06010D1D RID: 68893 RVA: 0x0018B3DB File Offset: 0x001895DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureFormatSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008FE5 RID: 36837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextureFormatSettings";

		// Token: 0x04008FE6 RID: 36838
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008FE7 RID: 36839
		internal static int __PropertyOffset_CompressionSettings;

		// Token: 0x04008FE8 RID: 36840
		internal static int __PropertyOffset_CompressionNoAlpha;

		// Token: 0x04008FE9 RID: 36841
		internal static byte __PropertyMask_CompressionNoAlpha;

		// Token: 0x04008FEA RID: 36842
		internal static int __PropertyOffset_CompressionNone;

		// Token: 0x04008FEB RID: 36843
		internal static byte __PropertyMask_CompressionNone;

		// Token: 0x04008FEC RID: 36844
		internal static int __PropertyOffset_CompressionYCoCg;

		// Token: 0x04008FED RID: 36845
		internal static byte __PropertyMask_CompressionYCoCg;

		// Token: 0x04008FEE RID: 36846
		internal static int __PropertyOffset_SRGB;

		// Token: 0x04008FEF RID: 36847
		internal static byte __PropertyMask_SRGB;
	}
}

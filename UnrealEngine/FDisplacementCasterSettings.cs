using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002785 RID: 10117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.DisplacementCasterSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FDisplacementCasterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025D6E RID: 154990 RVA: 0x00395E34 File Offset: 0x00394034
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDisplacementCasterSettings._ScriptStructPtr != 0) ? FDisplacementCasterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.DisplacementCasterSettings", ref FDisplacementCasterSettings._ScriptStructPtr);
		}

		// Token: 0x170091CB RID: 37323
		// (get) Token: 0x06025D6F RID: 154991 RVA: 0x00395E58 File Offset: 0x00394058
		// (set) Token: 0x06025D70 RID: 154992 RVA: 0x00395E6C File Offset: 0x0039406C
		public unsafe string MaterialChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDisplacementCasterSettings.__PropertyOffset_MaterialChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDisplacementCasterSettings.__PropertyOffset_MaterialChannel)), value);
			}
		}

		// Token: 0x170091CC RID: 37324
		// (get) Token: 0x06025D71 RID: 154993 RVA: 0x00395E81 File Offset: 0x00394081
		// (set) Token: 0x06025D72 RID: 154994 RVA: 0x00395E95 File Offset: 0x00394095
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDisplacementCasterSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDisplacementCasterSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x170091CD RID: 37325
		// (get) Token: 0x06025D73 RID: 154995 RVA: 0x00395EAA File Offset: 0x003940AA
		// (set) Token: 0x06025D74 RID: 154996 RVA: 0x00395EBA File Offset: 0x003940BA
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x170091CE RID: 37326
		// (get) Token: 0x06025D75 RID: 154997 RVA: 0x00395ECB File Offset: 0x003940CB
		// (set) Token: 0x06025D76 RID: 154998 RVA: 0x00395EDB File Offset: 0x003940DB
		public unsafe EDitherType DitherType
		{
			get
			{
				return (EDitherType)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_DitherType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_DitherType) = (byte)value;
			}
		}

		// Token: 0x170091CF RID: 37327
		// (get) Token: 0x06025D77 RID: 154999 RVA: 0x00395EEC File Offset: 0x003940EC
		// (set) Token: 0x06025D78 RID: 155000 RVA: 0x00395EFC File Offset: 0x003940FC
		public unsafe EFillMode FillMode
		{
			get
			{
				return (EFillMode)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_FillMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_FillMode) = (byte)value;
			}
		}

		// Token: 0x170091D0 RID: 37328
		// (get) Token: 0x06025D79 RID: 155001 RVA: 0x00395F0D File Offset: 0x0039410D
		// (set) Token: 0x06025D7A RID: 155002 RVA: 0x00395F1D File Offset: 0x0039411D
		public unsafe int Dilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_Dilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_Dilation) = value;
			}
		}

		// Token: 0x170091D1 RID: 37329
		// (get) Token: 0x06025D7B RID: 155003 RVA: 0x00395F2E File Offset: 0x0039412E
		// (set) Token: 0x06025D7C RID: 155004 RVA: 0x00395F47 File Offset: 0x00394147
		public unsafe bool UseMultisampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_UseMultisampling) & FDisplacementCasterSettings.__PropertyMask_UseMultisampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_UseMultisampling) = ((*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_UseMultisampling) & ~FDisplacementCasterSettings.__PropertyMask_UseMultisampling) | (value ? FDisplacementCasterSettings.__PropertyMask_UseMultisampling : 0));
			}
		}

		// Token: 0x170091D2 RID: 37330
		// (get) Token: 0x06025D7D RID: 155005 RVA: 0x00395F77 File Offset: 0x00394177
		// (set) Token: 0x06025D7E RID: 155006 RVA: 0x00395F87 File Offset: 0x00394187
		public unsafe EOutputPixelFormat OutputPixelFormat
		{
			get
			{
				return (EOutputPixelFormat)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputPixelFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputPixelFormat) = (byte)value;
			}
		}

		// Token: 0x170091D3 RID: 37331
		// (get) Token: 0x06025D7F RID: 155007 RVA: 0x00395F98 File Offset: 0x00394198
		// (set) Token: 0x06025D80 RID: 155008 RVA: 0x00395FA8 File Offset: 0x003941A8
		public unsafe EOutputImageFileFormat OutputImageFileFormat
		{
			get
			{
				return (EOutputImageFileFormat)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputImageFileFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputImageFileFormat) = (byte)value;
			}
		}

		// Token: 0x170091D4 RID: 37332
		// (get) Token: 0x06025D81 RID: 155009 RVA: 0x00395FB9 File Offset: 0x003941B9
		// (set) Token: 0x06025D82 RID: 155010 RVA: 0x00395FC9 File Offset: 0x003941C9
		public unsafe EOutputDDSCompressionType OutputDDSCompressionType
		{
			get
			{
				return (EOutputDDSCompressionType)(*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputDDSCompressionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputDDSCompressionType) = (byte)value;
			}
		}

		// Token: 0x170091D5 RID: 37333
		// (get) Token: 0x06025D83 RID: 155011 RVA: 0x00395FDA File Offset: 0x003941DA
		// (set) Token: 0x06025D84 RID: 155012 RVA: 0x00395FEA File Offset: 0x003941EA
		public unsafe float DistanceScaling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_DistanceScaling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_DistanceScaling) = value;
			}
		}

		// Token: 0x170091D6 RID: 37334
		// (get) Token: 0x06025D85 RID: 155013 RVA: 0x00395FFB File Offset: 0x003941FB
		// (set) Token: 0x06025D86 RID: 155014 RVA: 0x00396014 File Offset: 0x00394214
		public unsafe bool GenerateScalarDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateScalarDisplacement) & FDisplacementCasterSettings.__PropertyMask_GenerateScalarDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateScalarDisplacement) = ((*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateScalarDisplacement) & ~FDisplacementCasterSettings.__PropertyMask_GenerateScalarDisplacement) | (value ? FDisplacementCasterSettings.__PropertyMask_GenerateScalarDisplacement : 0));
			}
		}

		// Token: 0x170091D7 RID: 37335
		// (get) Token: 0x06025D87 RID: 155015 RVA: 0x00396044 File Offset: 0x00394244
		// (set) Token: 0x06025D88 RID: 155016 RVA: 0x0039605D File Offset: 0x0039425D
		public unsafe bool OutputToTessellatedAttributes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) & FDisplacementCasterSettings.__PropertyMask_OutputToTessellatedAttributes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) = ((*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_OutputToTessellatedAttributes) & ~FDisplacementCasterSettings.__PropertyMask_OutputToTessellatedAttributes) | (value ? FDisplacementCasterSettings.__PropertyMask_OutputToTessellatedAttributes : 0));
			}
		}

		// Token: 0x170091D8 RID: 37336
		// (get) Token: 0x06025D89 RID: 155017 RVA: 0x0039608D File Offset: 0x0039428D
		// (set) Token: 0x06025D8A RID: 155018 RVA: 0x003960A6 File Offset: 0x003942A6
		public unsafe bool GenerateTangentSpaceDisplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateTangentSpaceDisplacement) & FDisplacementCasterSettings.__PropertyMask_GenerateTangentSpaceDisplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateTangentSpaceDisplacement) = ((*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_GenerateTangentSpaceDisplacement) & ~FDisplacementCasterSettings.__PropertyMask_GenerateTangentSpaceDisplacement) | (value ? FDisplacementCasterSettings.__PropertyMask_GenerateTangentSpaceDisplacement : 0));
			}
		}

		// Token: 0x170091D9 RID: 37337
		// (get) Token: 0x06025D8B RID: 155019 RVA: 0x003960D6 File Offset: 0x003942D6
		// (set) Token: 0x06025D8C RID: 155020 RVA: 0x003960E6 File Offset: 0x003942E6
		public unsafe int NormalMapTexCoordLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_NormalMapTexCoordLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDisplacementCasterSettings.__PropertyOffset_NormalMapTexCoordLevel) = value;
			}
		}

		// Token: 0x06025D8D RID: 155021 RVA: 0x003960F7 File Offset: 0x003942F7
		public FDisplacementCasterSettings()
		{
		}

		// Token: 0x06025D8E RID: 155022 RVA: 0x00396100 File Offset: 0x00394300
		public FDisplacementCasterSettings(string MaterialChannel, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, EDitherType DitherType, EFillMode FillMode, int Dilation, bool UseMultisampling, EOutputPixelFormat OutputPixelFormat, EOutputImageFileFormat OutputImageFileFormat, EOutputDDSCompressionType OutputDDSCompressionType, float DistanceScaling, bool GenerateScalarDisplacement, bool OutputToTessellatedAttributes, bool GenerateTangentSpaceDisplacement, int NormalMapTexCoordLevel)
		{
			this.MaterialChannel = MaterialChannel;
			this.OpacityChannel = OpacityChannel;
			this.OpacityChannelComponent = OpacityChannelComponent;
			this.DitherType = DitherType;
			this.FillMode = FillMode;
			this.Dilation = Dilation;
			this.UseMultisampling = UseMultisampling;
			this.OutputPixelFormat = OutputPixelFormat;
			this.OutputImageFileFormat = OutputImageFileFormat;
			this.OutputDDSCompressionType = OutputDDSCompressionType;
			this.DistanceScaling = DistanceScaling;
			this.GenerateScalarDisplacement = GenerateScalarDisplacement;
			this.OutputToTessellatedAttributes = OutputToTessellatedAttributes;
			this.GenerateTangentSpaceDisplacement = GenerateTangentSpaceDisplacement;
			this.NormalMapTexCoordLevel = NormalMapTexCoordLevel;
		}

		// Token: 0x06025D8F RID: 155023 RVA: 0x00396188 File Offset: 0x00394388
		protected override IntPtr GetUStructPtr()
		{
			return FDisplacementCasterSettings.StaticStruct();
		}

		// Token: 0x06025D90 RID: 155024 RVA: 0x00396194 File Offset: 0x00394394
		[NullableContext(2)]
		public FDisplacementCasterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025D91 RID: 155025 RVA: 0x0039619E File Offset: 0x0039439E
		public FDisplacementCasterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025D92 RID: 155026 RVA: 0x003961A9 File Offset: 0x003943A9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDisplacementCasterSettings(Pointer, false, true);
		}

		// Token: 0x06025D93 RID: 155027 RVA: 0x003961B3 File Offset: 0x003943B3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDisplacementCasterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401499E RID: 84382
		public const string __ObjectPath = "/Script/SimplygonUObjects.DisplacementCasterSettings";

		// Token: 0x0401499F RID: 84383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149A0 RID: 84384
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x040149A1 RID: 84385
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x040149A2 RID: 84386
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x040149A3 RID: 84387
		internal static int __PropertyOffset_DitherType;

		// Token: 0x040149A4 RID: 84388
		internal static int __PropertyOffset_FillMode;

		// Token: 0x040149A5 RID: 84389
		internal static int __PropertyOffset_Dilation;

		// Token: 0x040149A6 RID: 84390
		internal static int __PropertyOffset_UseMultisampling;

		// Token: 0x040149A7 RID: 84391
		internal static byte __PropertyMask_UseMultisampling;

		// Token: 0x040149A8 RID: 84392
		internal static int __PropertyOffset_OutputPixelFormat;

		// Token: 0x040149A9 RID: 84393
		internal static int __PropertyOffset_OutputImageFileFormat;

		// Token: 0x040149AA RID: 84394
		internal static int __PropertyOffset_OutputDDSCompressionType;

		// Token: 0x040149AB RID: 84395
		internal static int __PropertyOffset_DistanceScaling;

		// Token: 0x040149AC RID: 84396
		internal static int __PropertyOffset_GenerateScalarDisplacement;

		// Token: 0x040149AD RID: 84397
		internal static byte __PropertyMask_GenerateScalarDisplacement;

		// Token: 0x040149AE RID: 84398
		internal static int __PropertyOffset_OutputToTessellatedAttributes;

		// Token: 0x040149AF RID: 84399
		internal static byte __PropertyMask_OutputToTessellatedAttributes;

		// Token: 0x040149B0 RID: 84400
		internal static int __PropertyOffset_GenerateTangentSpaceDisplacement;

		// Token: 0x040149B1 RID: 84401
		internal static byte __PropertyMask_GenerateTangentSpaceDisplacement;

		// Token: 0x040149B2 RID: 84402
		internal static int __PropertyOffset_NormalMapTexCoordLevel;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002302 RID: 8962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.CompositionGraphCaptureProtocol")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UCompositionGraphCaptureProtocol : UMovieSceneImageCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F50 RID: 139088 RVA: 0x0032372C File Offset: 0x0032192C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCompositionGraphCaptureProtocol._ClassPtr;
		}

		// Token: 0x06021F51 RID: 139089 RVA: 0x00323738 File Offset: 0x00321938
		public UCompositionGraphCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UCompositionGraphCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F52 RID: 139090 RVA: 0x00323760 File Offset: 0x00321960
		public UCompositionGraphCaptureProtocol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCompositionGraphCaptureProtocol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700833E RID: 33598
		// (get) Token: 0x06021F53 RID: 139091 RVA: 0x00323794 File Offset: 0x00321994
		// (set) Token: 0x06021F54 RID: 139092 RVA: 0x003237CD File Offset: 0x003219CD
		public FCompositionGraphCapturePasses IncludeRenderPasses
		{
			get
			{
				base.FastCheckIsValid();
				FCompositionGraphCapturePasses result;
				if ((result = this._IncludeRenderPasses) == null)
				{
					result = (this._IncludeRenderPasses = new FCompositionGraphCapturePasses(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_IncludeRenderPasses, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCompositionGraphCapturePasses.StaticStruct(), base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_IncludeRenderPasses, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700833F RID: 33599
		// (get) Token: 0x06021F55 RID: 139093 RVA: 0x003237EE File Offset: 0x003219EE
		// (set) Token: 0x06021F56 RID: 139094 RVA: 0x003237FE File Offset: 0x003219FE
		public unsafe bool bCaptureFramesInHDR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_bCaptureFramesInHDR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_bCaptureFramesInHDR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008340 RID: 33600
		// (get) Token: 0x06021F57 RID: 139095 RVA: 0x0032380F File Offset: 0x00321A0F
		// (set) Token: 0x06021F58 RID: 139096 RVA: 0x0032381F File Offset: 0x00321A1F
		public unsafe int HDRCompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_HDRCompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_HDRCompressionQuality) = value;
			}
		}

		// Token: 0x17008341 RID: 33601
		// (get) Token: 0x06021F59 RID: 139097 RVA: 0x00323830 File Offset: 0x00321A30
		// (set) Token: 0x06021F5A RID: 139098 RVA: 0x00323844 File Offset: 0x00321A44
		[Nullable(0)]
		public unsafe TEnumAsByte<EHDRCaptureGamut> CaptureGamut
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_CaptureGamut);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_CaptureGamut) = value;
			}
		}

		// Token: 0x17008342 RID: 33602
		// (get) Token: 0x06021F5B RID: 139099 RVA: 0x0032385C File Offset: 0x00321A5C
		// (set) Token: 0x06021F5C RID: 139100 RVA: 0x00323895 File Offset: 0x00321A95
		public FSoftObjectPath PostProcessingMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PostProcessingMaterial) == null)
				{
					result = (this._PostProcessingMaterial = new FSoftObjectPath(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_PostProcessingMaterial, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_PostProcessingMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008343 RID: 33603
		// (get) Token: 0x06021F5D RID: 139101 RVA: 0x003238B6 File Offset: 0x00321AB6
		// (set) Token: 0x06021F5E RID: 139102 RVA: 0x003238C6 File Offset: 0x00321AC6
		public unsafe bool bDisableScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_bDisableScreenPercentage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCompositionGraphCaptureProtocol.__PropertyOffset_bDisableScreenPercentage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008344 RID: 33604
		// (get) Token: 0x06021F5F RID: 139103 RVA: 0x003238D7 File Offset: 0x00321AD7
		// (set) Token: 0x06021F60 RID: 139104 RVA: 0x003238EB File Offset: 0x00321AEB
		[Nullable(2)]
		public unsafe UMaterialInterface PostProcessingMaterialPtr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UCompositionGraphCaptureProtocol.__PropertyOffset_PostProcessingMaterialPtr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCompositionGraphCaptureProtocol.__PropertyOffset_PostProcessingMaterialPtr, value);
			}
		}

		// Token: 0x06021F61 RID: 139105 RVA: 0x00323900 File Offset: 0x00321B00
		static UCompositionGraphCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.CompositionGraphCaptureProtocol");
		}

		// Token: 0x06021F62 RID: 139106 RVA: 0x0032390E File Offset: 0x00321B0E
		protected UCompositionGraphCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121C5 RID: 74181
		public new const string __ObjectPath = "/Script/MovieSceneCapture.CompositionGraphCaptureProtocol";

		// Token: 0x040121C6 RID: 74182
		private static IntPtr _ClassPtr;

		// Token: 0x040121C7 RID: 74183
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121C8 RID: 74184
		internal static int __PropertyOffset_IncludeRenderPasses;

		// Token: 0x040121C9 RID: 74185
		[Nullable(2)]
		private FCompositionGraphCapturePasses _IncludeRenderPasses;

		// Token: 0x040121CA RID: 74186
		internal static int __PropertyOffset_bCaptureFramesInHDR;

		// Token: 0x040121CB RID: 74187
		internal static int __PropertyOffset_HDRCompressionQuality;

		// Token: 0x040121CC RID: 74188
		internal static int __PropertyOffset_CaptureGamut;

		// Token: 0x040121CD RID: 74189
		internal static int __PropertyOffset_PostProcessingMaterial;

		// Token: 0x040121CE RID: 74190
		[Nullable(2)]
		private FSoftObjectPath _PostProcessingMaterial;

		// Token: 0x040121CF RID: 74191
		internal static int __PropertyOffset_bDisableScreenPercentage;

		// Token: 0x040121D0 RID: 74192
		internal static int __PropertyOffset_PostProcessingMaterialPtr;
	}
}

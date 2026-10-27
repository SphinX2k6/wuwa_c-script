using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001079 RID: 4217
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ReflectionCaptureComponent")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public abstract class UReflectionCaptureComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EFEB RID: 61419 RVA: 0x00163AC1 File Offset: 0x00161CC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReflectionCaptureComponent._ClassPtr;
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x00163ACD File Offset: 0x00161CCD
		// (set) Token: 0x0600EFED RID: 61421 RVA: 0x00163AE1 File Offset: 0x00161CE1
		[Nullable(2)]
		public unsafe UBillboardComponent CaptureOffsetComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_CaptureOffsetComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_CaptureOffsetComponent, value);
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600EFEE RID: 61422 RVA: 0x00163AF6 File Offset: 0x00161CF6
		// (set) Token: 0x0600EFEF RID: 61423 RVA: 0x00163B06 File Offset: 0x00161D06
		public unsafe bool bRealTimeCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_bRealTimeCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_bRealTimeCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600EFF0 RID: 61424 RVA: 0x00163B17 File Offset: 0x00161D17
		// (set) Token: 0x0600EFF1 RID: 61425 RVA: 0x00163B27 File Offset: 0x00161D27
		public unsafe int CubemapSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_CubemapSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_CubemapSize) = value;
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600EFF2 RID: 61426 RVA: 0x00163B38 File Offset: 0x00161D38
		// (set) Token: 0x0600EFF3 RID: 61427 RVA: 0x00163B71 File Offset: 0x00161D71
		public TArray<byte> MiniGBufferDepth
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._MiniGBufferDepth) == null)
				{
					result = (this._MiniGBufferDepth = new TArray<byte>(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MiniGBufferDepth, this));
				}
				return result;
			}
			set
			{
				this.MiniGBufferDepth.CopyAssign(value);
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600EFF4 RID: 61428 RVA: 0x00163B80 File Offset: 0x00161D80
		// (set) Token: 0x0600EFF5 RID: 61429 RVA: 0x00163BB9 File Offset: 0x00161DB9
		public TArray<byte> MiniGBufferA
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._MiniGBufferA) == null)
				{
					result = (this._MiniGBufferA = new TArray<byte>(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MiniGBufferA, this));
				}
				return result;
			}
			set
			{
				this.MiniGBufferA.CopyAssign(value);
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600EFF6 RID: 61430 RVA: 0x00163BC8 File Offset: 0x00161DC8
		// (set) Token: 0x0600EFF7 RID: 61431 RVA: 0x00163C01 File Offset: 0x00161E01
		public TArray<byte> MiniGBufferB
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._MiniGBufferB) == null)
				{
					result = (this._MiniGBufferB = new TArray<byte>(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MiniGBufferB, this));
				}
				return result;
			}
			set
			{
				this.MiniGBufferB.CopyAssign(value);
			}
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600EFF8 RID: 61432 RVA: 0x00163C10 File Offset: 0x00161E10
		// (set) Token: 0x0600EFF9 RID: 61433 RVA: 0x00163C49 File Offset: 0x00161E49
		public TArray<byte> MiniGBufferC
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._MiniGBufferC) == null)
				{
					result = (this._MiniGBufferC = new TArray<byte>(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MiniGBufferC, this));
				}
				return result;
			}
			set
			{
				this.MiniGBufferC.CopyAssign(value);
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600EFFA RID: 61434 RVA: 0x00163C57 File Offset: 0x00161E57
		// (set) Token: 0x0600EFFB RID: 61435 RVA: 0x00163C67 File Offset: 0x00161E67
		public unsafe EReflectionSourceType ReflectionSourceType
		{
			get
			{
				return (EReflectionSourceType)(*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_ReflectionSourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_ReflectionSourceType) = (byte)value;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600EFFC RID: 61436 RVA: 0x00163C78 File Offset: 0x00161E78
		// (set) Token: 0x0600EFFD RID: 61437 RVA: 0x00163C88 File Offset: 0x00161E88
		public unsafe EMobileReflectionCompression MobileReflectionCompression
		{
			get
			{
				return (EMobileReflectionCompression)(*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MobileReflectionCompression));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MobileReflectionCompression) = (byte)value;
			}
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600EFFE RID: 61438 RVA: 0x00163C99 File Offset: 0x00161E99
		// (set) Token: 0x0600EFFF RID: 61439 RVA: 0x00163CAD File Offset: 0x00161EAD
		[Nullable(2)]
		public unsafe UTextureCube Cubemap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_Cubemap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_Cubemap, value);
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600F000 RID: 61440 RVA: 0x00163CC2 File Offset: 0x00161EC2
		// (set) Token: 0x0600F001 RID: 61441 RVA: 0x00163CD2 File Offset: 0x00161ED2
		public unsafe float SourceCubemapAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_SourceCubemapAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_SourceCubemapAngle) = value;
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600F002 RID: 61442 RVA: 0x00163CE3 File Offset: 0x00161EE3
		// (set) Token: 0x0600F003 RID: 61443 RVA: 0x00163CF3 File Offset: 0x00161EF3
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_Brightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_Brightness) = value;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600F004 RID: 61444 RVA: 0x00163D04 File Offset: 0x00161F04
		// (set) Token: 0x0600F005 RID: 61445 RVA: 0x00163D14 File Offset: 0x00161F14
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_Saturation) = value;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600F006 RID: 61446 RVA: 0x00163D25 File Offset: 0x00161F25
		// (set) Token: 0x0600F007 RID: 61447 RVA: 0x00163D35 File Offset: 0x00161F35
		public unsafe bool bModifyMaxValueRGBM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_bModifyMaxValueRGBM) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_bModifyMaxValueRGBM) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600F008 RID: 61448 RVA: 0x00163D46 File Offset: 0x00161F46
		// (set) Token: 0x0600F009 RID: 61449 RVA: 0x00163D56 File Offset: 0x00161F56
		public unsafe float MaxValueRGBM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MaxValueRGBM);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MaxValueRGBM) = value;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600F00A RID: 61450 RVA: 0x00163D67 File Offset: 0x00161F67
		// (set) Token: 0x0600F00B RID: 61451 RVA: 0x00163D7B File Offset: 0x00161F7B
		public unsafe FVector CaptureOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_CaptureOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_CaptureOffset) = value;
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600F00C RID: 61452 RVA: 0x00163D90 File Offset: 0x00161F90
		// (set) Token: 0x0600F00D RID: 61453 RVA: 0x00163DA0 File Offset: 0x00161FA0
		public unsafe bool IsUIScenePrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_IsUIScenePrimitive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_IsUIScenePrimitive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600F00E RID: 61454 RVA: 0x00163DB1 File Offset: 0x00161FB1
		// (set) Token: 0x0600F00F RID: 61455 RVA: 0x00163DC5 File Offset: 0x00161FC5
		public unsafe FGuid MapBuildDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MapBuildDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReflectionCaptureComponent.__PropertyOffset_MapBuildDataId) = value;
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600F010 RID: 61456 RVA: 0x00163DDA File Offset: 0x00161FDA
		// (set) Token: 0x0600F011 RID: 61457 RVA: 0x00163DEE File Offset: 0x00161FEE
		[Nullable(2)]
		public unsafe UTextureCube CachedEncodedHDRCubemap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_CachedEncodedHDRCubemap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UReflectionCaptureComponent.__PropertyOffset_CachedEncodedHDRCubemap, value);
			}
		}

		// Token: 0x0600F012 RID: 61458 RVA: 0x00163E03 File Offset: 0x00162003
		public void SetIsUIScenePrimitive(bool bValue)
		{
			UReflectionCaptureComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600F013 RID: 61459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600F014 RID: 61460 RVA: 0x00163E11 File Offset: 0x00162011
		static UReflectionCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReflectionCaptureComponent");
		}

		// Token: 0x0600F015 RID: 61461 RVA: 0x00163E20 File Offset: 0x00162020
		protected UReflectionCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(UReflectionCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F016 RID: 61462 RVA: 0x00163E48 File Offset: 0x00162048
		protected UReflectionCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081C4 RID: 33220
		public new const string __ObjectPath = "/Script/Engine.ReflectionCaptureComponent";

		// Token: 0x040081C5 RID: 33221
		private static IntPtr _ClassPtr;

		// Token: 0x040081C6 RID: 33222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081C7 RID: 33223
		internal static int __PropertyOffset_CaptureOffsetComponent;

		// Token: 0x040081C8 RID: 33224
		internal static int __PropertyOffset_bRealTimeCapture;

		// Token: 0x040081C9 RID: 33225
		internal static int __PropertyOffset_CubemapSize;

		// Token: 0x040081CA RID: 33226
		internal static int __PropertyOffset_MiniGBufferDepth;

		// Token: 0x040081CB RID: 33227
		[Nullable(2)]
		private TArray<byte> _MiniGBufferDepth;

		// Token: 0x040081CC RID: 33228
		internal static int __PropertyOffset_MiniGBufferA;

		// Token: 0x040081CD RID: 33229
		[Nullable(2)]
		private TArray<byte> _MiniGBufferA;

		// Token: 0x040081CE RID: 33230
		internal static int __PropertyOffset_MiniGBufferB;

		// Token: 0x040081CF RID: 33231
		[Nullable(2)]
		private TArray<byte> _MiniGBufferB;

		// Token: 0x040081D0 RID: 33232
		internal static int __PropertyOffset_MiniGBufferC;

		// Token: 0x040081D1 RID: 33233
		[Nullable(2)]
		private TArray<byte> _MiniGBufferC;

		// Token: 0x040081D2 RID: 33234
		internal static int __PropertyOffset_ReflectionSourceType;

		// Token: 0x040081D3 RID: 33235
		internal static int __PropertyOffset_MobileReflectionCompression;

		// Token: 0x040081D4 RID: 33236
		internal static int __PropertyOffset_Cubemap;

		// Token: 0x040081D5 RID: 33237
		internal static int __PropertyOffset_SourceCubemapAngle;

		// Token: 0x040081D6 RID: 33238
		internal static int __PropertyOffset_Brightness;

		// Token: 0x040081D7 RID: 33239
		internal static int __PropertyOffset_Saturation;

		// Token: 0x040081D8 RID: 33240
		internal static int __PropertyOffset_bModifyMaxValueRGBM;

		// Token: 0x040081D9 RID: 33241
		internal static int __PropertyOffset_MaxValueRGBM;

		// Token: 0x040081DA RID: 33242
		internal static int __PropertyOffset_CaptureOffset;

		// Token: 0x040081DB RID: 33243
		internal static int __PropertyOffset_IsUIScenePrimitive;

		// Token: 0x040081DC RID: 33244
		internal static int __PropertyOffset_MapBuildDataId;

		// Token: 0x040081DD RID: 33245
		internal static int __PropertyOffset_CachedEncodedHDRCubemap;
	}
}

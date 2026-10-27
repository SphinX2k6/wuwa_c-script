using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017C7 RID: 6087
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSReadback")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class AKuroCSReadback : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016481 RID: 91265 RVA: 0x00209ACF File Offset: 0x00207CCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSReadback._ClassPtr;
		}

		// Token: 0x06016482 RID: 91266 RVA: 0x00209ADC File Offset: 0x00207CDC
		public AKuroCSReadback() : this(BuiltinUtils.AllocNativeUObject(AKuroCSReadback.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016483 RID: 91267 RVA: 0x00209B04 File Offset: 0x00207D04
		[NullableContext(1)]
		public AKuroCSReadback(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSReadback.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700596E RID: 22894
		// (get) Token: 0x06016484 RID: 91268 RVA: 0x00209B37 File Offset: 0x00207D37
		// (set) Token: 0x06016485 RID: 91269 RVA: 0x00209B4B File Offset: 0x00207D4B
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSReadback.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSReadback.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x1700596F RID: 22895
		// (get) Token: 0x06016486 RID: 91270 RVA: 0x00209B60 File Offset: 0x00207D60
		// (set) Token: 0x06016487 RID: 91271 RVA: 0x00209B74 File Offset: 0x00207D74
		public unsafe UTextureRenderTarget2D ReadbackTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSReadback.__PropertyOffset_ReadbackTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSReadback.__PropertyOffset_ReadbackTexture, value);
			}
		}

		// Token: 0x17005970 RID: 22896
		// (get) Token: 0x06016488 RID: 91272 RVA: 0x00209B89 File Offset: 0x00207D89
		// (set) Token: 0x06016489 RID: 91273 RVA: 0x00209B99 File Offset: 0x00207D99
		public unsafe int ReadbackX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackX) = value;
			}
		}

		// Token: 0x17005971 RID: 22897
		// (get) Token: 0x0601648A RID: 91274 RVA: 0x00209BAA File Offset: 0x00207DAA
		// (set) Token: 0x0601648B RID: 91275 RVA: 0x00209BBA File Offset: 0x00207DBA
		public unsafe int ReadbackY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackY) = value;
			}
		}

		// Token: 0x17005972 RID: 22898
		// (get) Token: 0x0601648C RID: 91276 RVA: 0x00209BCB File Offset: 0x00207DCB
		// (set) Token: 0x0601648D RID: 91277 RVA: 0x00209BDB File Offset: 0x00207DDB
		public unsafe EReadbackChannel ReadbackChannel
		{
			get
			{
				return (EReadbackChannel)(*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackChannel) = (byte)value;
			}
		}

		// Token: 0x17005973 RID: 22899
		// (get) Token: 0x0601648E RID: 91278 RVA: 0x00209BEC File Offset: 0x00207DEC
		// (set) Token: 0x0601648F RID: 91279 RVA: 0x00209BFC File Offset: 0x00207DFC
		public unsafe int ReadbackInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackInterval) = value;
			}
		}

		// Token: 0x17005974 RID: 22900
		// (get) Token: 0x06016490 RID: 91280 RVA: 0x00209C0D File Offset: 0x00207E0D
		// (set) Token: 0x06016491 RID: 91281 RVA: 0x00209C1D File Offset: 0x00207E1D
		public unsafe float ReadbackValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSReadback.__PropertyOffset_ReadbackValue) = value;
			}
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x00209C2E File Offset: 0x00207E2E
		public void StopSimulation()
		{
			AKuroCSReadback.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016493 RID: 91283 RVA: 0x00209C3B File Offset: 0x00207E3B
		public void StartSimulation()
		{
			AKuroCSReadback.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016494 RID: 91284 RVA: 0x00209C48 File Offset: 0x00207E48
		public void ReleaseShaderManager()
		{
			AKuroCSReadback.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016495 RID: 91285 RVA: 0x00209C55 File Offset: 0x00207E55
		public void InitShaderManager()
		{
			AKuroCSReadback.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016496 RID: 91286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06016497 RID: 91287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06016498 RID: 91288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06016499 RID: 91289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x0601649A RID: 91290 RVA: 0x00209C62 File Offset: 0x00207E62
		static AKuroCSReadback()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSReadback");
		}

		// Token: 0x0601649B RID: 91291 RVA: 0x00209C70 File Offset: 0x00207E70
		protected AKuroCSReadback(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C1E7 RID: 49639
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSReadback";

		// Token: 0x0400C1E8 RID: 49640
		private static IntPtr _ClassPtr;

		// Token: 0x0400C1E9 RID: 49641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C1EA RID: 49642
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C1EB RID: 49643
		internal static int __PropertyOffset_ReadbackTexture;

		// Token: 0x0400C1EC RID: 49644
		internal static int __PropertyOffset_ReadbackX;

		// Token: 0x0400C1ED RID: 49645
		internal static int __PropertyOffset_ReadbackY;

		// Token: 0x0400C1EE RID: 49646
		internal static int __PropertyOffset_ReadbackChannel;

		// Token: 0x0400C1EF RID: 49647
		internal static int __PropertyOffset_ReadbackInterval;

		// Token: 0x0400C1F0 RID: 49648
		internal static int __PropertyOffset_ReadbackValue;
	}
}

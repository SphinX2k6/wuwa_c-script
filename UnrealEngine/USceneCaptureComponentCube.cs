using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D7 RID: 4311
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponentCube")]
	[UnrealStructLayout(912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class USceneCaptureComponentCube : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F665 RID: 63077 RVA: 0x0016D19C File Offset: 0x0016B39C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneCaptureComponentCube._ClassPtr;
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x0016D1A8 File Offset: 0x0016B3A8
		public USceneCaptureComponentCube() : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponentCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x0016D1D0 File Offset: 0x0016B3D0
		[NullableContext(1)]
		public USceneCaptureComponentCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponentCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600F668 RID: 63080 RVA: 0x0016D203 File Offset: 0x0016B403
		// (set) Token: 0x0600F669 RID: 63081 RVA: 0x0016D217 File Offset: 0x0016B417
		public unsafe UTextureRenderTargetCube TextureTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTarget, value);
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600F66A RID: 63082 RVA: 0x0016D22C File Offset: 0x0016B42C
		// (set) Token: 0x0600F66B RID: 63083 RVA: 0x0016D23C File Offset: 0x0016B43C
		public unsafe bool bCaptureRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponentCube.__PropertyOffset_bCaptureRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponentCube.__PropertyOffset_bCaptureRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600F66C RID: 63084 RVA: 0x0016D24D File Offset: 0x0016B44D
		// (set) Token: 0x0600F66D RID: 63085 RVA: 0x0016D261 File Offset: 0x0016B461
		public unsafe UTextureRenderTargetCube TextureTargetLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetLeft);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetLeft, value);
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600F66E RID: 63086 RVA: 0x0016D276 File Offset: 0x0016B476
		// (set) Token: 0x0600F66F RID: 63087 RVA: 0x0016D28A File Offset: 0x0016B48A
		public unsafe UTextureRenderTargetCube TextureTargetRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetRight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetRight, value);
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600F670 RID: 63088 RVA: 0x0016D29F File Offset: 0x0016B49F
		// (set) Token: 0x0600F671 RID: 63089 RVA: 0x0016D2B3 File Offset: 0x0016B4B3
		public unsafe UTextureRenderTarget2D TextureTargetODS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetODS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponentCube.__PropertyOffset_TextureTargetODS, value);
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600F672 RID: 63090 RVA: 0x0016D2C8 File Offset: 0x0016B4C8
		// (set) Token: 0x0600F673 RID: 63091 RVA: 0x0016D2D8 File Offset: 0x0016B4D8
		public unsafe float IPD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponentCube.__PropertyOffset_IPD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponentCube.__PropertyOffset_IPD) = value;
			}
		}

		// Token: 0x0600F674 RID: 63092 RVA: 0x0016D2E9 File Offset: 0x0016B4E9
		public void CaptureScene()
		{
			USceneCaptureComponentCube.__CaptureScene_Internal(base.NativePtr);
		}

		// Token: 0x0600F675 RID: 63093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureScene_Internal(IntPtr @this);

		// Token: 0x0600F676 RID: 63094 RVA: 0x0016D2F6 File Offset: 0x0016B4F6
		static USceneCaptureComponentCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureComponentCube");
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x0016D304 File Offset: 0x0016B504
		protected USceneCaptureComponentCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400857A RID: 34170
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureComponentCube";

		// Token: 0x0400857B RID: 34171
		private static IntPtr _ClassPtr;

		// Token: 0x0400857C RID: 34172
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400857D RID: 34173
		internal static int __PropertyOffset_TextureTarget;

		// Token: 0x0400857E RID: 34174
		internal static int __PropertyOffset_bCaptureRotation;

		// Token: 0x0400857F RID: 34175
		internal static int __PropertyOffset_TextureTargetLeft;

		// Token: 0x04008580 RID: 34176
		internal static int __PropertyOffset_TextureTargetRight;

		// Token: 0x04008581 RID: 34177
		internal static int __PropertyOffset_TextureTargetODS;

		// Token: 0x04008582 RID: 34178
		internal static int __PropertyOffset_IPD;
	}
}

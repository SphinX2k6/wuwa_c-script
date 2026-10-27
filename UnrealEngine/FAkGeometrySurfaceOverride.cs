using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020A RID: 522
	[UnrealObjectPath("/Script/AkAudio.AkGeometrySurfaceOverride")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAkGeometrySurfaceOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F2C RID: 7980 RVA: 0x0002E18E File Offset: 0x0002C38E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkGeometrySurfaceOverride._ScriptStructPtr != 0) ? FAkGeometrySurfaceOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkGeometrySurfaceOverride", ref FAkGeometrySurfaceOverride._ScriptStructPtr);
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0002E1B2 File Offset: 0x0002C3B2
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0002E1C6 File Offset: 0x0002C3C6
		[Nullable(2)]
		public unsafe UAkAcousticTexture AcousticTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAcousticTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FAkGeometrySurfaceOverride.__PropertyOffset_AcousticTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAkGeometrySurfaceOverride.__PropertyOffset_AcousticTexture, value);
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x0002E1DB File Offset: 0x0002C3DB
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x0002E1EB File Offset: 0x0002C3EB
		public unsafe bool bEnableOcclusionOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_bEnableOcclusionOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_bEnableOcclusionOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0002E20C File Offset: 0x0002C40C
		public unsafe float OcclusionValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_OcclusionValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_OcclusionValue) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0002E21D File Offset: 0x0002C41D
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0002E22D File Offset: 0x0002C42D
		public unsafe float SurfaceArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_SurfaceArea);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkGeometrySurfaceOverride.__PropertyOffset_SurfaceArea) = value;
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0002E23E File Offset: 0x0002C43E
		public FAkGeometrySurfaceOverride()
		{
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0002E246 File Offset: 0x0002C446
		[NullableContext(1)]
		public FAkGeometrySurfaceOverride(UAkAcousticTexture AcousticTexture, bool bEnableOcclusionOverride, float OcclusionValue, float SurfaceArea)
		{
			this.AcousticTexture = AcousticTexture;
			this.bEnableOcclusionOverride = bEnableOcclusionOverride;
			this.OcclusionValue = OcclusionValue;
			this.SurfaceArea = SurfaceArea;
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0002E26B File Offset: 0x0002C46B
		protected override IntPtr GetUStructPtr()
		{
			return FAkGeometrySurfaceOverride.StaticStruct();
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0002E277 File Offset: 0x0002C477
		[NullableContext(2)]
		public FAkGeometrySurfaceOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0002E281 File Offset: 0x0002C481
		public FAkGeometrySurfaceOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0002E28C File Offset: 0x0002C48C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkGeometrySurfaceOverride(Pointer, false, true);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0002E296 File Offset: 0x0002C496
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkGeometrySurfaceOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04000A40 RID: 2624
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkGeometrySurfaceOverride";

		// Token: 0x04000A41 RID: 2625
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A42 RID: 2626
		internal static int __PropertyOffset_AcousticTexture;

		// Token: 0x04000A43 RID: 2627
		internal static int __PropertyOffset_bEnableOcclusionOverride;

		// Token: 0x04000A44 RID: 2628
		internal static int __PropertyOffset_OcclusionValue;

		// Token: 0x04000A45 RID: 2629
		internal static int __PropertyOffset_SurfaceArea;
	}
}

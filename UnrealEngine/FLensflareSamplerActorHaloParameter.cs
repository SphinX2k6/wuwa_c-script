using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF8 RID: 7160
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorHaloParameter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FLensflareSamplerActorHaloParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B9BF RID: 113087 RVA: 0x0028A14C File Offset: 0x0028834C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensflareSamplerActorHaloParameter._ScriptStructPtr != 0) ? FLensflareSamplerActorHaloParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorHaloParameter", ref FLensflareSamplerActorHaloParameter._ScriptStructPtr);
		}

		// Token: 0x17006F43 RID: 28483
		// (get) Token: 0x0601B9C0 RID: 113088 RVA: 0x0028A170 File Offset: 0x00288370
		// (set) Token: 0x0601B9C1 RID: 113089 RVA: 0x0028A180 File Offset: 0x00288380
		public unsafe bool bCustomHalo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_bCustomHalo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_bCustomHalo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F44 RID: 28484
		// (get) Token: 0x0601B9C2 RID: 113090 RVA: 0x0028A191 File Offset: 0x00288391
		// (set) Token: 0x0601B9C3 RID: 113091 RVA: 0x0028A1A1 File Offset: 0x002883A1
		public unsafe float HaloAtt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloAtt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloAtt) = value;
			}
		}

		// Token: 0x17006F45 RID: 28485
		// (get) Token: 0x0601B9C4 RID: 113092 RVA: 0x0028A1B2 File Offset: 0x002883B2
		// (set) Token: 0x0601B9C5 RID: 113093 RVA: 0x0028A1C2 File Offset: 0x002883C2
		public unsafe float HaloSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloSize) = value;
			}
		}

		// Token: 0x17006F46 RID: 28486
		// (get) Token: 0x0601B9C6 RID: 113094 RVA: 0x0028A1D3 File Offset: 0x002883D3
		// (set) Token: 0x0601B9C7 RID: 113095 RVA: 0x0028A1E3 File Offset: 0x002883E3
		public unsafe float HaloOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloOffset) = value;
			}
		}

		// Token: 0x17006F47 RID: 28487
		// (get) Token: 0x0601B9C8 RID: 113096 RVA: 0x0028A1F4 File Offset: 0x002883F4
		// (set) Token: 0x0601B9C9 RID: 113097 RVA: 0x0028A204 File Offset: 0x00288404
		public unsafe float HaloRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloRange) = value;
			}
		}

		// Token: 0x17006F48 RID: 28488
		// (get) Token: 0x0601B9CA RID: 113098 RVA: 0x0028A215 File Offset: 0x00288415
		// (set) Token: 0x0601B9CB RID: 113099 RVA: 0x0028A229 File Offset: 0x00288429
		public unsafe FLinearColor HaloColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloColorTint) = value;
			}
		}

		// Token: 0x17006F49 RID: 28489
		// (get) Token: 0x0601B9CC RID: 113100 RVA: 0x0028A23E File Offset: 0x0028843E
		// (set) Token: 0x0601B9CD RID: 113101 RVA: 0x0028A24E File Offset: 0x0028844E
		public unsafe float HaloOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloOpacity) = value;
			}
		}

		// Token: 0x17006F4A RID: 28490
		// (get) Token: 0x0601B9CE RID: 113102 RVA: 0x0028A25F File Offset: 0x0028845F
		// (set) Token: 0x0601B9CF RID: 113103 RVA: 0x0028A26F File Offset: 0x0028846F
		public unsafe float HaloBgInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloBgInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloBgInfluence) = value;
			}
		}

		// Token: 0x17006F4B RID: 28491
		// (get) Token: 0x0601B9D0 RID: 113104 RVA: 0x0028A280 File Offset: 0x00288480
		// (set) Token: 0x0601B9D1 RID: 113105 RVA: 0x0028A290 File Offset: 0x00288490
		public unsafe float HaloViewAtt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloViewAtt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloViewAtt) = value;
			}
		}

		// Token: 0x17006F4C RID: 28492
		// (get) Token: 0x0601B9D2 RID: 113106 RVA: 0x0028A2A1 File Offset: 0x002884A1
		// (set) Token: 0x0601B9D3 RID: 113107 RVA: 0x0028A2B1 File Offset: 0x002884B1
		public unsafe bool HaloUseFixRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloUseFixRot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloUseFixRot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F4D RID: 28493
		// (get) Token: 0x0601B9D4 RID: 113108 RVA: 0x0028A2C2 File Offset: 0x002884C2
		// (set) Token: 0x0601B9D5 RID: 113109 RVA: 0x0028A2D2 File Offset: 0x002884D2
		public unsafe float HaloFixRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloFixRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloFixRot) = value;
			}
		}

		// Token: 0x17006F4E RID: 28494
		// (get) Token: 0x0601B9D6 RID: 113110 RVA: 0x0028A2E3 File Offset: 0x002884E3
		// (set) Token: 0x0601B9D7 RID: 113111 RVA: 0x0028A2F3 File Offset: 0x002884F3
		public unsafe bool bCustomHaloTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_bCustomHaloTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorHaloParameter.__PropertyOffset_bCustomHaloTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F4F RID: 28495
		// (get) Token: 0x0601B9D8 RID: 113112 RVA: 0x0028A304 File Offset: 0x00288504
		// (set) Token: 0x0601B9D9 RID: 113113 RVA: 0x0028A318 File Offset: 0x00288518
		[Nullable(2)]
		public unsafe UTexture2D HaloTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorHaloParameter.__PropertyOffset_HaloTexture, value);
			}
		}

		// Token: 0x0601B9DA RID: 113114 RVA: 0x0028A32D File Offset: 0x0028852D
		public FLensflareSamplerActorHaloParameter()
		{
		}

		// Token: 0x0601B9DB RID: 113115 RVA: 0x0028A338 File Offset: 0x00288538
		[NullableContext(1)]
		public FLensflareSamplerActorHaloParameter(bool bCustomHalo, float HaloAtt, float HaloSize, float HaloOffset, float HaloRange, FLinearColor HaloColorTint, float HaloOpacity, float HaloBgInfluence, float HaloViewAtt, bool HaloUseFixRot, float HaloFixRot, bool bCustomHaloTexture, UTexture2D HaloTexture)
		{
			this.bCustomHalo = bCustomHalo;
			this.HaloAtt = HaloAtt;
			this.HaloSize = HaloSize;
			this.HaloOffset = HaloOffset;
			this.HaloRange = HaloRange;
			this.HaloColorTint = HaloColorTint;
			this.HaloOpacity = HaloOpacity;
			this.HaloBgInfluence = HaloBgInfluence;
			this.HaloViewAtt = HaloViewAtt;
			this.HaloUseFixRot = HaloUseFixRot;
			this.HaloFixRot = HaloFixRot;
			this.bCustomHaloTexture = bCustomHaloTexture;
			this.HaloTexture = HaloTexture;
		}

		// Token: 0x0601B9DC RID: 113116 RVA: 0x0028A3B0 File Offset: 0x002885B0
		protected override IntPtr GetUStructPtr()
		{
			return FLensflareSamplerActorHaloParameter.StaticStruct();
		}

		// Token: 0x0601B9DD RID: 113117 RVA: 0x0028A3BC File Offset: 0x002885BC
		[NullableContext(2)]
		public FLensflareSamplerActorHaloParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B9DE RID: 113118 RVA: 0x0028A3C6 File Offset: 0x002885C6
		public FLensflareSamplerActorHaloParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x0028A3D1 File Offset: 0x002885D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensflareSamplerActorHaloParameter(Pointer, false, true);
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x0028A3DB File Offset: 0x002885DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensflareSamplerActorHaloParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED89 RID: 60809
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorHaloParameter";

		// Token: 0x0400ED8A RID: 60810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED8B RID: 60811
		internal static int __PropertyOffset_bCustomHalo;

		// Token: 0x0400ED8C RID: 60812
		internal static int __PropertyOffset_HaloAtt;

		// Token: 0x0400ED8D RID: 60813
		internal static int __PropertyOffset_HaloSize;

		// Token: 0x0400ED8E RID: 60814
		internal static int __PropertyOffset_HaloOffset;

		// Token: 0x0400ED8F RID: 60815
		internal static int __PropertyOffset_HaloRange;

		// Token: 0x0400ED90 RID: 60816
		internal static int __PropertyOffset_HaloColorTint;

		// Token: 0x0400ED91 RID: 60817
		internal static int __PropertyOffset_HaloOpacity;

		// Token: 0x0400ED92 RID: 60818
		internal static int __PropertyOffset_HaloBgInfluence;

		// Token: 0x0400ED93 RID: 60819
		internal static int __PropertyOffset_HaloViewAtt;

		// Token: 0x0400ED94 RID: 60820
		internal static int __PropertyOffset_HaloUseFixRot;

		// Token: 0x0400ED95 RID: 60821
		internal static int __PropertyOffset_HaloFixRot;

		// Token: 0x0400ED96 RID: 60822
		internal static int __PropertyOffset_bCustomHaloTexture;

		// Token: 0x0400ED97 RID: 60823
		internal static int __PropertyOffset_HaloTexture;
	}
}

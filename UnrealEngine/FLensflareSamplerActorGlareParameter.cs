using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF7 RID: 7159
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGlareParameter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLensflareSamplerActorGlareParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B9A1 RID: 113057 RVA: 0x00289EF8 File Offset: 0x002880F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensflareSamplerActorGlareParameter._ScriptStructPtr != 0) ? FLensflareSamplerActorGlareParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGlareParameter", ref FLensflareSamplerActorGlareParameter._ScriptStructPtr);
		}

		// Token: 0x17006F38 RID: 28472
		// (get) Token: 0x0601B9A2 RID: 113058 RVA: 0x00289F1C File Offset: 0x0028811C
		// (set) Token: 0x0601B9A3 RID: 113059 RVA: 0x00289F2C File Offset: 0x0028812C
		public unsafe bool bCustomGlare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_bCustomGlare) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_bCustomGlare) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F39 RID: 28473
		// (get) Token: 0x0601B9A4 RID: 113060 RVA: 0x00289F3D File Offset: 0x0028813D
		// (set) Token: 0x0601B9A5 RID: 113061 RVA: 0x00289F51 File Offset: 0x00288151
		public unsafe FVector2D GlareSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareSize) = value;
			}
		}

		// Token: 0x17006F3A RID: 28474
		// (get) Token: 0x0601B9A6 RID: 113062 RVA: 0x00289F66 File Offset: 0x00288166
		// (set) Token: 0x0601B9A7 RID: 113063 RVA: 0x00289F7A File Offset: 0x0028817A
		public unsafe FLinearColor GlareColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareColorTint) = value;
			}
		}

		// Token: 0x17006F3B RID: 28475
		// (get) Token: 0x0601B9A8 RID: 113064 RVA: 0x00289F8F File Offset: 0x0028818F
		// (set) Token: 0x0601B9A9 RID: 113065 RVA: 0x00289F9F File Offset: 0x0028819F
		public unsafe float GlareOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareOpacity) = value;
			}
		}

		// Token: 0x17006F3C RID: 28476
		// (get) Token: 0x0601B9AA RID: 113066 RVA: 0x00289FB0 File Offset: 0x002881B0
		// (set) Token: 0x0601B9AB RID: 113067 RVA: 0x00289FC0 File Offset: 0x002881C0
		public unsafe float GlareRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareRot) = value;
			}
		}

		// Token: 0x17006F3D RID: 28477
		// (get) Token: 0x0601B9AC RID: 113068 RVA: 0x00289FD1 File Offset: 0x002881D1
		// (set) Token: 0x0601B9AD RID: 113069 RVA: 0x00289FE1 File Offset: 0x002881E1
		public unsafe float GlareFixRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareFixRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareFixRot) = value;
			}
		}

		// Token: 0x17006F3E RID: 28478
		// (get) Token: 0x0601B9AE RID: 113070 RVA: 0x00289FF2 File Offset: 0x002881F2
		// (set) Token: 0x0601B9AF RID: 113071 RVA: 0x0028A002 File Offset: 0x00288202
		public unsafe float GlareBgInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareBgInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareBgInfluence) = value;
			}
		}

		// Token: 0x17006F3F RID: 28479
		// (get) Token: 0x0601B9B0 RID: 113072 RVA: 0x0028A013 File Offset: 0x00288213
		// (set) Token: 0x0601B9B1 RID: 113073 RVA: 0x0028A023 File Offset: 0x00288223
		public unsafe float GlareViewAtt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareViewAtt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareViewAtt) = value;
			}
		}

		// Token: 0x17006F40 RID: 28480
		// (get) Token: 0x0601B9B2 RID: 113074 RVA: 0x0028A034 File Offset: 0x00288234
		// (set) Token: 0x0601B9B3 RID: 113075 RVA: 0x0028A044 File Offset: 0x00288244
		public unsafe bool bCustomGlareTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_bCustomGlareTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_bCustomGlareTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F41 RID: 28481
		// (get) Token: 0x0601B9B4 RID: 113076 RVA: 0x0028A055 File Offset: 0x00288255
		// (set) Token: 0x0601B9B5 RID: 113077 RVA: 0x0028A069 File Offset: 0x00288269
		[Nullable(2)]
		public unsafe UTexture2D GlareTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareTexture, value);
			}
		}

		// Token: 0x17006F42 RID: 28482
		// (get) Token: 0x0601B9B6 RID: 113078 RVA: 0x0028A07E File Offset: 0x0028827E
		// (set) Token: 0x0601B9B7 RID: 113079 RVA: 0x0028A092 File Offset: 0x00288292
		public unsafe FLinearColor GlareUvScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareUvScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGlareParameter.__PropertyOffset_GlareUvScaleBias) = value;
			}
		}

		// Token: 0x0601B9B8 RID: 113080 RVA: 0x0028A0A7 File Offset: 0x002882A7
		public FLensflareSamplerActorGlareParameter()
		{
		}

		// Token: 0x0601B9B9 RID: 113081 RVA: 0x0028A0B0 File Offset: 0x002882B0
		[NullableContext(1)]
		public FLensflareSamplerActorGlareParameter(bool bCustomGlare, FVector2D GlareSize, FLinearColor GlareColorTint, float GlareOpacity, float GlareRot, float GlareFixRot, float GlareBgInfluence, float GlareViewAtt, bool bCustomGlareTexture, UTexture2D GlareTexture, FLinearColor GlareUvScaleBias)
		{
			this.bCustomGlare = bCustomGlare;
			this.GlareSize = GlareSize;
			this.GlareColorTint = GlareColorTint;
			this.GlareOpacity = GlareOpacity;
			this.GlareRot = GlareRot;
			this.GlareFixRot = GlareFixRot;
			this.GlareBgInfluence = GlareBgInfluence;
			this.GlareViewAtt = GlareViewAtt;
			this.bCustomGlareTexture = bCustomGlareTexture;
			this.GlareTexture = GlareTexture;
			this.GlareUvScaleBias = GlareUvScaleBias;
		}

		// Token: 0x0601B9BA RID: 113082 RVA: 0x0028A118 File Offset: 0x00288318
		protected override IntPtr GetUStructPtr()
		{
			return FLensflareSamplerActorGlareParameter.StaticStruct();
		}

		// Token: 0x0601B9BB RID: 113083 RVA: 0x0028A124 File Offset: 0x00288324
		[NullableContext(2)]
		public FLensflareSamplerActorGlareParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x0028A12E File Offset: 0x0028832E
		public FLensflareSamplerActorGlareParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B9BD RID: 113085 RVA: 0x0028A139 File Offset: 0x00288339
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensflareSamplerActorGlareParameter(Pointer, false, true);
		}

		// Token: 0x0601B9BE RID: 113086 RVA: 0x0028A143 File Offset: 0x00288343
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensflareSamplerActorGlareParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED7C RID: 60796
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGlareParameter";

		// Token: 0x0400ED7D RID: 60797
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED7E RID: 60798
		internal static int __PropertyOffset_bCustomGlare;

		// Token: 0x0400ED7F RID: 60799
		internal static int __PropertyOffset_GlareSize;

		// Token: 0x0400ED80 RID: 60800
		internal static int __PropertyOffset_GlareColorTint;

		// Token: 0x0400ED81 RID: 60801
		internal static int __PropertyOffset_GlareOpacity;

		// Token: 0x0400ED82 RID: 60802
		internal static int __PropertyOffset_GlareRot;

		// Token: 0x0400ED83 RID: 60803
		internal static int __PropertyOffset_GlareFixRot;

		// Token: 0x0400ED84 RID: 60804
		internal static int __PropertyOffset_GlareBgInfluence;

		// Token: 0x0400ED85 RID: 60805
		internal static int __PropertyOffset_GlareViewAtt;

		// Token: 0x0400ED86 RID: 60806
		internal static int __PropertyOffset_bCustomGlareTexture;

		// Token: 0x0400ED87 RID: 60807
		internal static int __PropertyOffset_GlareTexture;

		// Token: 0x0400ED88 RID: 60808
		internal static int __PropertyOffset_GlareUvScaleBias;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF6 RID: 7158
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGhostParameter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLensflareSamplerActorGhostParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B981 RID: 113025 RVA: 0x00289C89 File Offset: 0x00287E89
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensflareSamplerActorGhostParameter._ScriptStructPtr != 0) ? FLensflareSamplerActorGhostParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGhostParameter", ref FLensflareSamplerActorGhostParameter._ScriptStructPtr);
		}

		// Token: 0x17006F2C RID: 28460
		// (get) Token: 0x0601B982 RID: 113026 RVA: 0x00289CAD File Offset: 0x00287EAD
		// (set) Token: 0x0601B983 RID: 113027 RVA: 0x00289CBD File Offset: 0x00287EBD
		public unsafe bool bCustomGhost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_bCustomGhost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_bCustomGhost) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F2D RID: 28461
		// (get) Token: 0x0601B984 RID: 113028 RVA: 0x00289CCE File Offset: 0x00287ECE
		// (set) Token: 0x0601B985 RID: 113029 RVA: 0x00289CDE File Offset: 0x00287EDE
		public unsafe float GhostSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostSize) = value;
			}
		}

		// Token: 0x17006F2E RID: 28462
		// (get) Token: 0x0601B986 RID: 113030 RVA: 0x00289CEF File Offset: 0x00287EEF
		// (set) Token: 0x0601B987 RID: 113031 RVA: 0x00289CFF File Offset: 0x00287EFF
		public unsafe float GhostOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostOffset) = value;
			}
		}

		// Token: 0x17006F2F RID: 28463
		// (get) Token: 0x0601B988 RID: 113032 RVA: 0x00289D10 File Offset: 0x00287F10
		// (set) Token: 0x0601B989 RID: 113033 RVA: 0x00289D20 File Offset: 0x00287F20
		public unsafe float GhostRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostRange) = value;
			}
		}

		// Token: 0x17006F30 RID: 28464
		// (get) Token: 0x0601B98A RID: 113034 RVA: 0x00289D31 File Offset: 0x00287F31
		// (set) Token: 0x0601B98B RID: 113035 RVA: 0x00289D45 File Offset: 0x00287F45
		public unsafe FLinearColor GhostColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostColorTint) = value;
			}
		}

		// Token: 0x17006F31 RID: 28465
		// (get) Token: 0x0601B98C RID: 113036 RVA: 0x00289D5A File Offset: 0x00287F5A
		// (set) Token: 0x0601B98D RID: 113037 RVA: 0x00289D6A File Offset: 0x00287F6A
		public unsafe float GhostOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostOpacity) = value;
			}
		}

		// Token: 0x17006F32 RID: 28466
		// (get) Token: 0x0601B98E RID: 113038 RVA: 0x00289D7B File Offset: 0x00287F7B
		// (set) Token: 0x0601B98F RID: 113039 RVA: 0x00289D8B File Offset: 0x00287F8B
		public unsafe float GhostBgInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostBgInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostBgInfluence) = value;
			}
		}

		// Token: 0x17006F33 RID: 28467
		// (get) Token: 0x0601B990 RID: 113040 RVA: 0x00289D9C File Offset: 0x00287F9C
		// (set) Token: 0x0601B991 RID: 113041 RVA: 0x00289DAC File Offset: 0x00287FAC
		public unsafe float GhostViewAtt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostViewAtt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostViewAtt) = value;
			}
		}

		// Token: 0x17006F34 RID: 28468
		// (get) Token: 0x0601B992 RID: 113042 RVA: 0x00289DBD File Offset: 0x00287FBD
		// (set) Token: 0x0601B993 RID: 113043 RVA: 0x00289DCD File Offset: 0x00287FCD
		public unsafe bool GhostUseFixRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostUseFixRot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostUseFixRot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F35 RID: 28469
		// (get) Token: 0x0601B994 RID: 113044 RVA: 0x00289DDE File Offset: 0x00287FDE
		// (set) Token: 0x0601B995 RID: 113045 RVA: 0x00289DEE File Offset: 0x00287FEE
		public unsafe float GhostFixRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostFixRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostFixRot) = value;
			}
		}

		// Token: 0x17006F36 RID: 28470
		// (get) Token: 0x0601B996 RID: 113046 RVA: 0x00289DFF File Offset: 0x00287FFF
		// (set) Token: 0x0601B997 RID: 113047 RVA: 0x00289E0F File Offset: 0x0028800F
		public unsafe bool bCustomGhostTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_bCustomGhostTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorGhostParameter.__PropertyOffset_bCustomGhostTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F37 RID: 28471
		// (get) Token: 0x0601B998 RID: 113048 RVA: 0x00289E20 File Offset: 0x00288020
		// (set) Token: 0x0601B999 RID: 113049 RVA: 0x00289E34 File Offset: 0x00288034
		[Nullable(2)]
		public unsafe UTexture2D GhostTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLensflareSamplerActorGhostParameter.__PropertyOffset_GhostTexture, value);
			}
		}

		// Token: 0x0601B99A RID: 113050 RVA: 0x00289E49 File Offset: 0x00288049
		public FLensflareSamplerActorGhostParameter()
		{
		}

		// Token: 0x0601B99B RID: 113051 RVA: 0x00289E54 File Offset: 0x00288054
		[NullableContext(1)]
		public FLensflareSamplerActorGhostParameter(bool bCustomGhost, float GhostSize, float GhostOffset, float GhostRange, FLinearColor GhostColorTint, float GhostOpacity, float GhostBgInfluence, float GhostViewAtt, bool GhostUseFixRot, float GhostFixRot, bool bCustomGhostTexture, UTexture2D GhostTexture)
		{
			this.bCustomGhost = bCustomGhost;
			this.GhostSize = GhostSize;
			this.GhostOffset = GhostOffset;
			this.GhostRange = GhostRange;
			this.GhostColorTint = GhostColorTint;
			this.GhostOpacity = GhostOpacity;
			this.GhostBgInfluence = GhostBgInfluence;
			this.GhostViewAtt = GhostViewAtt;
			this.GhostUseFixRot = GhostUseFixRot;
			this.GhostFixRot = GhostFixRot;
			this.bCustomGhostTexture = bCustomGhostTexture;
			this.GhostTexture = GhostTexture;
		}

		// Token: 0x0601B99C RID: 113052 RVA: 0x00289EC4 File Offset: 0x002880C4
		protected override IntPtr GetUStructPtr()
		{
			return FLensflareSamplerActorGhostParameter.StaticStruct();
		}

		// Token: 0x0601B99D RID: 113053 RVA: 0x00289ED0 File Offset: 0x002880D0
		[NullableContext(2)]
		public FLensflareSamplerActorGhostParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B99E RID: 113054 RVA: 0x00289EDA File Offset: 0x002880DA
		public FLensflareSamplerActorGhostParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B99F RID: 113055 RVA: 0x00289EE5 File Offset: 0x002880E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensflareSamplerActorGhostParameter(Pointer, false, true);
		}

		// Token: 0x0601B9A0 RID: 113056 RVA: 0x00289EEF File Offset: 0x002880EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensflareSamplerActorGhostParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED6E RID: 60782
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorGhostParameter";

		// Token: 0x0400ED6F RID: 60783
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED70 RID: 60784
		internal static int __PropertyOffset_bCustomGhost;

		// Token: 0x0400ED71 RID: 60785
		internal static int __PropertyOffset_GhostSize;

		// Token: 0x0400ED72 RID: 60786
		internal static int __PropertyOffset_GhostOffset;

		// Token: 0x0400ED73 RID: 60787
		internal static int __PropertyOffset_GhostRange;

		// Token: 0x0400ED74 RID: 60788
		internal static int __PropertyOffset_GhostColorTint;

		// Token: 0x0400ED75 RID: 60789
		internal static int __PropertyOffset_GhostOpacity;

		// Token: 0x0400ED76 RID: 60790
		internal static int __PropertyOffset_GhostBgInfluence;

		// Token: 0x0400ED77 RID: 60791
		internal static int __PropertyOffset_GhostViewAtt;

		// Token: 0x0400ED78 RID: 60792
		internal static int __PropertyOffset_GhostUseFixRot;

		// Token: 0x0400ED79 RID: 60793
		internal static int __PropertyOffset_GhostFixRot;

		// Token: 0x0400ED7A RID: 60794
		internal static int __PropertyOffset_bCustomGhostTexture;

		// Token: 0x0400ED7B RID: 60795
		internal static int __PropertyOffset_GhostTexture;
	}
}

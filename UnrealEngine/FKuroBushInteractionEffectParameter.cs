using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A0 RID: 6560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroBushInteractionEffectParameter")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FKuroBushInteractionEffectParameter : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018625 RID: 99877 RVA: 0x0023F26C File Offset: 0x0023D46C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBushInteractionEffectParameter._ScriptStructPtr != 0) ? FKuroBushInteractionEffectParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroBushInteractionEffectParameter", ref FKuroBushInteractionEffectParameter._ScriptStructPtr);
		}

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x06018626 RID: 99878 RVA: 0x0023F290 File Offset: 0x0023D490
		// (set) Token: 0x06018627 RID: 99879 RVA: 0x0023F2AF File Offset: 0x0023D4AF
		public TSoftObjectPtr<UStaticMesh> BushStaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_BushStaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_BushStaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x06018628 RID: 99880 RVA: 0x0023F2D4 File Offset: 0x0023D4D4
		// (set) Token: 0x06018629 RID: 99881 RVA: 0x0023F2E4 File Offset: 0x0023D4E4
		public unsafe float SpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnCountScale) = value;
			}
		}

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x0601862A RID: 99882 RVA: 0x0023F2F5 File Offset: 0x0023D4F5
		// (set) Token: 0x0601862B RID: 99883 RVA: 0x0023F305 File Offset: 0x0023D505
		public unsafe float SpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnSizeScale) = value;
			}
		}

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x0601862C RID: 99884 RVA: 0x0023F316 File Offset: 0x0023D516
		// (set) Token: 0x0601862D RID: 99885 RVA: 0x0023F32A File Offset: 0x0023D52A
		public unsafe FVector SpawnBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnBoxExtent) = value;
			}
		}

		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x0601862E RID: 99886 RVA: 0x0023F33F File Offset: 0x0023D53F
		// (set) Token: 0x0601862F RID: 99887 RVA: 0x0023F353 File Offset: 0x0023D553
		public unsafe FVector SpawnBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnBoxOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SpawnBoxOffset) = value;
			}
		}

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x06018630 RID: 99888 RVA: 0x0023F368 File Offset: 0x0023D568
		// (set) Token: 0x06018631 RID: 99889 RVA: 0x0023F378 File Offset: 0x0023D578
		public unsafe int UVIndexBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_UVIndexBegin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_UVIndexBegin) = value;
			}
		}

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x06018632 RID: 99890 RVA: 0x0023F389 File Offset: 0x0023D589
		// (set) Token: 0x06018633 RID: 99891 RVA: 0x0023F399 File Offset: 0x0023D599
		public unsafe int UVIndexEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_UVIndexEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_UVIndexEnd) = value;
			}
		}

		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x06018634 RID: 99892 RVA: 0x0023F3AA File Offset: 0x0023D5AA
		// (set) Token: 0x06018635 RID: 99893 RVA: 0x0023F3BA File Offset: 0x0023D5BA
		public unsafe float SoaringSpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpawnSizeScale) = value;
			}
		}

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x06018636 RID: 99894 RVA: 0x0023F3CB File Offset: 0x0023D5CB
		// (set) Token: 0x06018637 RID: 99895 RVA: 0x0023F3DB File Offset: 0x0023D5DB
		public unsafe float SoaringSpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpawnCountScale) = value;
			}
		}

		// Token: 0x1700615F RID: 24927
		// (get) Token: 0x06018638 RID: 99896 RVA: 0x0023F3EC File Offset: 0x0023D5EC
		// (set) Token: 0x06018639 RID: 99897 RVA: 0x0023F3FC File Offset: 0x0023D5FC
		public unsafe float SoaringSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringSpeedScale) = value;
			}
		}

		// Token: 0x17006160 RID: 24928
		// (get) Token: 0x0601863A RID: 99898 RVA: 0x0023F40D File Offset: 0x0023D60D
		// (set) Token: 0x0601863B RID: 99899 RVA: 0x0023F41D File Offset: 0x0023D61D
		public unsafe float SoaringLifeTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringLifeTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_SoaringLifeTimeScale) = value;
			}
		}

		// Token: 0x17006161 RID: 24929
		// (get) Token: 0x0601863C RID: 99900 RVA: 0x0023F42E File Offset: 0x0023D62E
		// (set) Token: 0x0601863D RID: 99901 RVA: 0x0023F43E File Offset: 0x0023D63E
		public unsafe int TreeEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_TreeEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_TreeEffectTypeIndex) = value;
			}
		}

		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x0601863E RID: 99902 RVA: 0x0023F44F File Offset: 0x0023D64F
		// (set) Token: 0x0601863F RID: 99903 RVA: 0x0023F45F File Offset: 0x0023D65F
		public unsafe int BushEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_BushEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushInteractionEffectParameter.__PropertyOffset_BushEffectTypeIndex) = value;
			}
		}

		// Token: 0x06018640 RID: 99904 RVA: 0x0023F470 File Offset: 0x0023D670
		public FKuroBushInteractionEffectParameter()
		{
		}

		// Token: 0x06018641 RID: 99905 RVA: 0x0023F478 File Offset: 0x0023D678
		public FKuroBushInteractionEffectParameter(TSoftObjectPtr<UStaticMesh> BushStaticMesh, float SpawnCountScale, float SpawnSizeScale, FVector SpawnBoxExtent, FVector SpawnBoxOffset, int UVIndexBegin, int UVIndexEnd, float SoaringSpawnSizeScale, float SoaringSpawnCountScale, float SoaringSpeedScale, float SoaringLifeTimeScale, int TreeEffectTypeIndex, int BushEffectTypeIndex)
		{
			this.BushStaticMesh = BushStaticMesh;
			this.SpawnCountScale = SpawnCountScale;
			this.SpawnSizeScale = SpawnSizeScale;
			this.SpawnBoxExtent = SpawnBoxExtent;
			this.SpawnBoxOffset = SpawnBoxOffset;
			this.UVIndexBegin = UVIndexBegin;
			this.UVIndexEnd = UVIndexEnd;
			this.SoaringSpawnSizeScale = SoaringSpawnSizeScale;
			this.SoaringSpawnCountScale = SoaringSpawnCountScale;
			this.SoaringSpeedScale = SoaringSpeedScale;
			this.SoaringLifeTimeScale = SoaringLifeTimeScale;
			this.TreeEffectTypeIndex = TreeEffectTypeIndex;
			this.BushEffectTypeIndex = BushEffectTypeIndex;
		}

		// Token: 0x06018642 RID: 99906 RVA: 0x0023F4F0 File Offset: 0x0023D6F0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBushInteractionEffectParameter.StaticStruct();
		}

		// Token: 0x06018643 RID: 99907 RVA: 0x0023F4FC File Offset: 0x0023D6FC
		[NullableContext(2)]
		public FKuroBushInteractionEffectParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018644 RID: 99908 RVA: 0x0023F506 File Offset: 0x0023D706
		public FKuroBushInteractionEffectParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018645 RID: 99909 RVA: 0x0023F511 File Offset: 0x0023D711
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBushInteractionEffectParameter(Pointer, false, true);
		}

		// Token: 0x06018646 RID: 99910 RVA: 0x0023F51B File Offset: 0x0023D71B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBushInteractionEffectParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2E7 RID: 53991
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroBushInteractionEffectParameter";

		// Token: 0x0400D2E8 RID: 53992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2E9 RID: 53993
		internal static int __PropertyOffset_BushStaticMesh;

		// Token: 0x0400D2EA RID: 53994
		internal static int __PropertyOffset_SpawnCountScale;

		// Token: 0x0400D2EB RID: 53995
		internal static int __PropertyOffset_SpawnSizeScale;

		// Token: 0x0400D2EC RID: 53996
		internal static int __PropertyOffset_SpawnBoxExtent;

		// Token: 0x0400D2ED RID: 53997
		internal static int __PropertyOffset_SpawnBoxOffset;

		// Token: 0x0400D2EE RID: 53998
		internal static int __PropertyOffset_UVIndexBegin;

		// Token: 0x0400D2EF RID: 53999
		internal static int __PropertyOffset_UVIndexEnd;

		// Token: 0x0400D2F0 RID: 54000
		internal static int __PropertyOffset_SoaringSpawnSizeScale;

		// Token: 0x0400D2F1 RID: 54001
		internal static int __PropertyOffset_SoaringSpawnCountScale;

		// Token: 0x0400D2F2 RID: 54002
		internal static int __PropertyOffset_SoaringSpeedScale;

		// Token: 0x0400D2F3 RID: 54003
		internal static int __PropertyOffset_SoaringLifeTimeScale;

		// Token: 0x0400D2F4 RID: 54004
		internal static int __PropertyOffset_TreeEffectTypeIndex;

		// Token: 0x0400D2F5 RID: 54005
		internal static int __PropertyOffset_BushEffectTypeIndex;
	}
}

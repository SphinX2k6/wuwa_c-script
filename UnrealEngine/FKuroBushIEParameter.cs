using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199F RID: 6559
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroBushIEParameter")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroBushIEParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018605 RID: 99845 RVA: 0x0023EFFF File Offset: 0x0023D1FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBushIEParameter._ScriptStructPtr != 0) ? FKuroBushIEParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroBushIEParameter", ref FKuroBushIEParameter._ScriptStructPtr);
		}

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x06018606 RID: 99846 RVA: 0x0023F023 File Offset: 0x0023D223
		// (set) Token: 0x06018607 RID: 99847 RVA: 0x0023F033 File Offset: 0x0023D233
		public unsafe float SpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnCountScale) = value;
			}
		}

		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x06018608 RID: 99848 RVA: 0x0023F044 File Offset: 0x0023D244
		// (set) Token: 0x06018609 RID: 99849 RVA: 0x0023F054 File Offset: 0x0023D254
		public unsafe float SpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnSizeScale) = value;
			}
		}

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0601860A RID: 99850 RVA: 0x0023F065 File Offset: 0x0023D265
		// (set) Token: 0x0601860B RID: 99851 RVA: 0x0023F079 File Offset: 0x0023D279
		public unsafe FVector SpawnBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxExtent) = value;
			}
		}

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0601860C RID: 99852 RVA: 0x0023F08E File Offset: 0x0023D28E
		// (set) Token: 0x0601860D RID: 99853 RVA: 0x0023F0A2 File Offset: 0x0023D2A2
		public unsafe FVector SpawnBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxOffset) = value;
			}
		}

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x0601860E RID: 99854 RVA: 0x0023F0B7 File Offset: 0x0023D2B7
		// (set) Token: 0x0601860F RID: 99855 RVA: 0x0023F0C7 File Offset: 0x0023D2C7
		public unsafe int UVIndexBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexBegin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexBegin) = value;
			}
		}

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x06018610 RID: 99856 RVA: 0x0023F0D8 File Offset: 0x0023D2D8
		// (set) Token: 0x06018611 RID: 99857 RVA: 0x0023F0E8 File Offset: 0x0023D2E8
		public unsafe int UVIndexEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexEnd) = value;
			}
		}

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x06018612 RID: 99858 RVA: 0x0023F0F9 File Offset: 0x0023D2F9
		// (set) Token: 0x06018613 RID: 99859 RVA: 0x0023F109 File Offset: 0x0023D309
		public unsafe float SoaringSpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnSizeScale) = value;
			}
		}

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x06018614 RID: 99860 RVA: 0x0023F11A File Offset: 0x0023D31A
		// (set) Token: 0x06018615 RID: 99861 RVA: 0x0023F12A File Offset: 0x0023D32A
		public unsafe float SoaringSpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnCountScale) = value;
			}
		}

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x06018616 RID: 99862 RVA: 0x0023F13B File Offset: 0x0023D33B
		// (set) Token: 0x06018617 RID: 99863 RVA: 0x0023F14B File Offset: 0x0023D34B
		public unsafe float SoaringSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpeedScale) = value;
			}
		}

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x06018618 RID: 99864 RVA: 0x0023F15C File Offset: 0x0023D35C
		// (set) Token: 0x06018619 RID: 99865 RVA: 0x0023F16C File Offset: 0x0023D36C
		public unsafe float SoaringLifeTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringLifeTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringLifeTimeScale) = value;
			}
		}

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x0601861A RID: 99866 RVA: 0x0023F17D File Offset: 0x0023D37D
		// (set) Token: 0x0601861B RID: 99867 RVA: 0x0023F18D File Offset: 0x0023D38D
		public unsafe int TreeEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_TreeEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_TreeEffectTypeIndex) = value;
			}
		}

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0601861C RID: 99868 RVA: 0x0023F19E File Offset: 0x0023D39E
		// (set) Token: 0x0601861D RID: 99869 RVA: 0x0023F1AE File Offset: 0x0023D3AE
		public unsafe int BushEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_BushEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_BushEffectTypeIndex) = value;
			}
		}

		// Token: 0x0601861E RID: 99870 RVA: 0x0023F1BF File Offset: 0x0023D3BF
		public FKuroBushIEParameter()
		{
		}

		// Token: 0x0601861F RID: 99871 RVA: 0x0023F1C8 File Offset: 0x0023D3C8
		public FKuroBushIEParameter(float SpawnCountScale, float SpawnSizeScale, FVector SpawnBoxExtent, FVector SpawnBoxOffset, int UVIndexBegin, int UVIndexEnd, float SoaringSpawnSizeScale, float SoaringSpawnCountScale, float SoaringSpeedScale, float SoaringLifeTimeScale, int TreeEffectTypeIndex, int BushEffectTypeIndex)
		{
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

		// Token: 0x06018620 RID: 99872 RVA: 0x0023F238 File Offset: 0x0023D438
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBushIEParameter.StaticStruct();
		}

		// Token: 0x06018621 RID: 99873 RVA: 0x0023F244 File Offset: 0x0023D444
		[NullableContext(2)]
		public FKuroBushIEParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018622 RID: 99874 RVA: 0x0023F24E File Offset: 0x0023D44E
		public FKuroBushIEParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018623 RID: 99875 RVA: 0x0023F259 File Offset: 0x0023D459
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBushIEParameter(Pointer, false, true);
		}

		// Token: 0x06018624 RID: 99876 RVA: 0x0023F263 File Offset: 0x0023D463
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBushIEParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2D9 RID: 53977
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.KuroBushIEParameter";

		// Token: 0x0400D2DA RID: 53978
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2DB RID: 53979
		internal static int __PropertyOffset_SpawnCountScale;

		// Token: 0x0400D2DC RID: 53980
		internal static int __PropertyOffset_SpawnSizeScale;

		// Token: 0x0400D2DD RID: 53981
		internal static int __PropertyOffset_SpawnBoxExtent;

		// Token: 0x0400D2DE RID: 53982
		internal static int __PropertyOffset_SpawnBoxOffset;

		// Token: 0x0400D2DF RID: 53983
		internal static int __PropertyOffset_UVIndexBegin;

		// Token: 0x0400D2E0 RID: 53984
		internal static int __PropertyOffset_UVIndexEnd;

		// Token: 0x0400D2E1 RID: 53985
		internal static int __PropertyOffset_SoaringSpawnSizeScale;

		// Token: 0x0400D2E2 RID: 53986
		internal static int __PropertyOffset_SoaringSpawnCountScale;

		// Token: 0x0400D2E3 RID: 53987
		internal static int __PropertyOffset_SoaringSpeedScale;

		// Token: 0x0400D2E4 RID: 53988
		internal static int __PropertyOffset_SoaringLifeTimeScale;

		// Token: 0x0400D2E5 RID: 53989
		internal static int __PropertyOffset_TreeEffectTypeIndex;

		// Token: 0x0400D2E6 RID: 53990
		internal static int __PropertyOffset_BushEffectTypeIndex;
	}
}

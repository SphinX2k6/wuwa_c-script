using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199C RID: 6556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.IEMeshMessageTableRow")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FIEMeshMessageTableRow : FKuroInteractionEffectNDCConfigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060185B5 RID: 99765 RVA: 0x0023E8DF File Offset: 0x0023CADF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIEMeshMessageTableRow._ScriptStructPtr != 0) ? FIEMeshMessageTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.IEMeshMessageTableRow", ref FIEMeshMessageTableRow._ScriptStructPtr);
		}

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x060185B6 RID: 99766 RVA: 0x0023E903 File Offset: 0x0023CB03
		// (set) Token: 0x060185B7 RID: 99767 RVA: 0x0023E922 File Offset: 0x0023CB22
		public TSoftObjectPtr<UStaticMesh> Mesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_Mesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_Mesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x060185B8 RID: 99768 RVA: 0x0023E947 File Offset: 0x0023CB47
		// (set) Token: 0x060185B9 RID: 99769 RVA: 0x0023E95B File Offset: 0x0023CB5B
		public unsafe string IEMeshMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIEMeshMessageTableRow.__PropertyOffset_IEMeshMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIEMeshMessageTableRow.__PropertyOffset_IEMeshMessage)), value);
			}
		}

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x060185BA RID: 99770 RVA: 0x0023E970 File Offset: 0x0023CB70
		// (set) Token: 0x060185BB RID: 99771 RVA: 0x0023E980 File Offset: 0x0023CB80
		public unsafe int UVIndexBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_UVIndexBegin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_UVIndexBegin) = value;
			}
		}

		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x060185BC RID: 99772 RVA: 0x0023E991 File Offset: 0x0023CB91
		// (set) Token: 0x060185BD RID: 99773 RVA: 0x0023E9A1 File Offset: 0x0023CBA1
		public unsafe int UVIndexEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_UVIndexEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_UVIndexEnd) = value;
			}
		}

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x060185BE RID: 99774 RVA: 0x0023E9B2 File Offset: 0x0023CBB2
		// (set) Token: 0x060185BF RID: 99775 RVA: 0x0023E9C2 File Offset: 0x0023CBC2
		public unsafe bool bEnableInOutInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_bEnableInOutInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_bEnableInOutInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x060185C0 RID: 99776 RVA: 0x0023E9D3 File Offset: 0x0023CBD3
		// (set) Token: 0x060185C1 RID: 99777 RVA: 0x0023E9E3 File Offset: 0x0023CBE3
		public unsafe float SpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnCountScale) = value;
			}
		}

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x060185C2 RID: 99778 RVA: 0x0023E9F4 File Offset: 0x0023CBF4
		// (set) Token: 0x060185C3 RID: 99779 RVA: 0x0023EA04 File Offset: 0x0023CC04
		public unsafe float SpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnSizeScale) = value;
			}
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x060185C4 RID: 99780 RVA: 0x0023EA15 File Offset: 0x0023CC15
		// (set) Token: 0x060185C5 RID: 99781 RVA: 0x0023EA25 File Offset: 0x0023CC25
		public unsafe int BushEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_BushEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_BushEffectTypeIndex) = value;
			}
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x060185C6 RID: 99782 RVA: 0x0023EA36 File Offset: 0x0023CC36
		// (set) Token: 0x060185C7 RID: 99783 RVA: 0x0023EA4A File Offset: 0x0023CC4A
		public unsafe FVector SpawnBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnBoxExtent) = value;
			}
		}

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x060185C8 RID: 99784 RVA: 0x0023EA5F File Offset: 0x0023CC5F
		// (set) Token: 0x060185C9 RID: 99785 RVA: 0x0023EA73 File Offset: 0x0023CC73
		public unsafe FVector SpawnBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnBoxOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SpawnBoxOffset) = value;
			}
		}

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x060185CA RID: 99786 RVA: 0x0023EA88 File Offset: 0x0023CC88
		// (set) Token: 0x060185CB RID: 99787 RVA: 0x0023EA98 File Offset: 0x0023CC98
		public unsafe bool bEnableSoaringInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_bEnableSoaringInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_bEnableSoaringInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x060185CC RID: 99788 RVA: 0x0023EAA9 File Offset: 0x0023CCA9
		// (set) Token: 0x060185CD RID: 99789 RVA: 0x0023EAB9 File Offset: 0x0023CCB9
		public unsafe float SoaringSpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpawnSizeScale) = value;
			}
		}

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x060185CE RID: 99790 RVA: 0x0023EACA File Offset: 0x0023CCCA
		// (set) Token: 0x060185CF RID: 99791 RVA: 0x0023EADA File Offset: 0x0023CCDA
		public unsafe float SoaringSpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpawnCountScale) = value;
			}
		}

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x060185D0 RID: 99792 RVA: 0x0023EAEB File Offset: 0x0023CCEB
		// (set) Token: 0x060185D1 RID: 99793 RVA: 0x0023EAFB File Offset: 0x0023CCFB
		public unsafe float SoaringSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringSpeedScale) = value;
			}
		}

		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x060185D2 RID: 99794 RVA: 0x0023EB0C File Offset: 0x0023CD0C
		// (set) Token: 0x060185D3 RID: 99795 RVA: 0x0023EB1C File Offset: 0x0023CD1C
		public unsafe float SoaringLifeTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringLifeTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SoaringLifeTimeScale) = value;
			}
		}

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x060185D4 RID: 99796 RVA: 0x0023EB2D File Offset: 0x0023CD2D
		// (set) Token: 0x060185D5 RID: 99797 RVA: 0x0023EB3D File Offset: 0x0023CD3D
		public unsafe int TreeEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_TreeEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_TreeEffectTypeIndex) = value;
			}
		}

		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x060185D6 RID: 99798 RVA: 0x0023EB50 File Offset: 0x0023CD50
		// (set) Token: 0x060185D7 RID: 99799 RVA: 0x0023EB93 File Offset: 0x0023CD93
		public TArray<FIEMeshBoxShape> BoxShapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIEMeshBoxShape> result;
				if ((result = this._BoxShapes) == null)
				{
					result = (this._BoxShapes = new TArray<FIEMeshBoxShape>(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_BoxShapes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoxShapes.CopyAssign(value);
			}
		}

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x060185D8 RID: 99800 RVA: 0x0023EBA4 File Offset: 0x0023CDA4
		// (set) Token: 0x060185D9 RID: 99801 RVA: 0x0023EBE7 File Offset: 0x0023CDE7
		public TArray<FIEMeshSphereShape> SphereShapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIEMeshSphereShape> result;
				if ((result = this._SphereShapes) == null)
				{
					result = (this._SphereShapes = new TArray<FIEMeshSphereShape>(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_SphereShapes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SphereShapes.CopyAssign(value);
			}
		}

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x060185DA RID: 99802 RVA: 0x0023EBF8 File Offset: 0x0023CDF8
		// (set) Token: 0x060185DB RID: 99803 RVA: 0x0023EC3B File Offset: 0x0023CE3B
		public TArray<FIEMeshCapsuleShape> CapsuleShapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIEMeshCapsuleShape> result;
				if ((result = this._CapsuleShapes) == null)
				{
					result = (this._CapsuleShapes = new TArray<FIEMeshCapsuleShape>(base.NativePtr + (IntPtr)FIEMeshMessageTableRow.__PropertyOffset_CapsuleShapes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CapsuleShapes.CopyAssign(value);
			}
		}

		// Token: 0x060185DC RID: 99804 RVA: 0x0023EC49 File Offset: 0x0023CE49
		public FIEMeshMessageTableRow()
		{
		}

		// Token: 0x060185DD RID: 99805 RVA: 0x0023EC54 File Offset: 0x0023CE54
		public FIEMeshMessageTableRow(TSoftObjectPtr<UStaticMesh> Mesh, string IEMeshMessage, int UVIndexBegin, int UVIndexEnd, bool bEnableInOutInteraction, float SpawnCountScale, float SpawnSizeScale, int BushEffectTypeIndex, FVector SpawnBoxExtent, FVector SpawnBoxOffset, bool bEnableSoaringInteraction, float SoaringSpawnSizeScale, float SoaringSpawnCountScale, float SoaringSpeedScale, float SoaringLifeTimeScale, int TreeEffectTypeIndex, TArray<FIEMeshBoxShape> BoxShapes, TArray<FIEMeshSphereShape> SphereShapes, TArray<FIEMeshCapsuleShape> CapsuleShapes, bool bEnableNDC, float SpawnNum, float HeightClamp, float Weight, float MoveSpawn, float WeaponSpawn, int EffectIndex, float TypeIndex, FVector PlayerSpawnOffset)
		{
			this.Mesh = Mesh;
			this.IEMeshMessage = IEMeshMessage;
			this.UVIndexBegin = UVIndexBegin;
			this.UVIndexEnd = UVIndexEnd;
			this.bEnableInOutInteraction = bEnableInOutInteraction;
			this.SpawnCountScale = SpawnCountScale;
			this.SpawnSizeScale = SpawnSizeScale;
			this.BushEffectTypeIndex = BushEffectTypeIndex;
			this.SpawnBoxExtent = SpawnBoxExtent;
			this.SpawnBoxOffset = SpawnBoxOffset;
			this.bEnableSoaringInteraction = bEnableSoaringInteraction;
			this.SoaringSpawnSizeScale = SoaringSpawnSizeScale;
			this.SoaringSpawnCountScale = SoaringSpawnCountScale;
			this.SoaringSpeedScale = SoaringSpeedScale;
			this.SoaringLifeTimeScale = SoaringLifeTimeScale;
			this.TreeEffectTypeIndex = TreeEffectTypeIndex;
			this.BoxShapes = BoxShapes;
			this.SphereShapes = SphereShapes;
			this.CapsuleShapes = CapsuleShapes;
			base.bEnableNDC = bEnableNDC;
			base.SpawnNum = SpawnNum;
			base.HeightClamp = HeightClamp;
			base.Weight = Weight;
			base.MoveSpawn = MoveSpawn;
			base.WeaponSpawn = WeaponSpawn;
			base.EffectIndex = EffectIndex;
			base.TypeIndex = TypeIndex;
			base.PlayerSpawnOffset = PlayerSpawnOffset;
		}

		// Token: 0x060185DE RID: 99806 RVA: 0x0023ED44 File Offset: 0x0023CF44
		protected override IntPtr GetUStructPtr()
		{
			return FIEMeshMessageTableRow.StaticStruct();
		}

		// Token: 0x060185DF RID: 99807 RVA: 0x0023ED50 File Offset: 0x0023CF50
		[NullableContext(2)]
		public FIEMeshMessageTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060185E0 RID: 99808 RVA: 0x0023ED5A File Offset: 0x0023CF5A
		public FIEMeshMessageTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060185E1 RID: 99809 RVA: 0x0023ED65 File Offset: 0x0023CF65
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIEMeshMessageTableRow(Pointer, false, true);
		}

		// Token: 0x060185E2 RID: 99810 RVA: 0x0023ED6F File Offset: 0x0023CF6F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIEMeshMessageTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2B4 RID: 53940
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.IEMeshMessageTableRow";

		// Token: 0x0400D2B5 RID: 53941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2B6 RID: 53942
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400D2B7 RID: 53943
		internal static int __PropertyOffset_IEMeshMessage;

		// Token: 0x0400D2B8 RID: 53944
		internal static int __PropertyOffset_UVIndexBegin;

		// Token: 0x0400D2B9 RID: 53945
		internal static int __PropertyOffset_UVIndexEnd;

		// Token: 0x0400D2BA RID: 53946
		internal static int __PropertyOffset_bEnableInOutInteraction;

		// Token: 0x0400D2BB RID: 53947
		internal static int __PropertyOffset_SpawnCountScale;

		// Token: 0x0400D2BC RID: 53948
		internal static int __PropertyOffset_SpawnSizeScale;

		// Token: 0x0400D2BD RID: 53949
		internal static int __PropertyOffset_BushEffectTypeIndex;

		// Token: 0x0400D2BE RID: 53950
		internal static int __PropertyOffset_SpawnBoxExtent;

		// Token: 0x0400D2BF RID: 53951
		internal static int __PropertyOffset_SpawnBoxOffset;

		// Token: 0x0400D2C0 RID: 53952
		internal static int __PropertyOffset_bEnableSoaringInteraction;

		// Token: 0x0400D2C1 RID: 53953
		internal static int __PropertyOffset_SoaringSpawnSizeScale;

		// Token: 0x0400D2C2 RID: 53954
		internal static int __PropertyOffset_SoaringSpawnCountScale;

		// Token: 0x0400D2C3 RID: 53955
		internal static int __PropertyOffset_SoaringSpeedScale;

		// Token: 0x0400D2C4 RID: 53956
		internal static int __PropertyOffset_SoaringLifeTimeScale;

		// Token: 0x0400D2C5 RID: 53957
		internal static int __PropertyOffset_TreeEffectTypeIndex;

		// Token: 0x0400D2C6 RID: 53958
		internal static int __PropertyOffset_BoxShapes;

		// Token: 0x0400D2C7 RID: 53959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIEMeshBoxShape> _BoxShapes;

		// Token: 0x0400D2C8 RID: 53960
		internal static int __PropertyOffset_SphereShapes;

		// Token: 0x0400D2C9 RID: 53961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIEMeshSphereShape> _SphereShapes;

		// Token: 0x0400D2CA RID: 53962
		internal static int __PropertyOffset_CapsuleShapes;

		// Token: 0x0400D2CB RID: 53963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FIEMeshCapsuleShape> _CapsuleShapes;
	}
}

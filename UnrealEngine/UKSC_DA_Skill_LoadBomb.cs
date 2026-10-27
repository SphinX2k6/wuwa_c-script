using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DC4 RID: 7620
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Skill_LoadBomb")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UKSC_DA_Skill_LoadBomb : UKSC_DA_Skill_RangeAttack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D223 RID: 119331 RVA: 0x002B0B33 File Offset: 0x002AED33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Skill_LoadBomb._ClassPtr;
		}

		// Token: 0x0601D224 RID: 119332 RVA: 0x002B0B40 File Offset: 0x002AED40
		public UKSC_DA_Skill_LoadBomb() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_LoadBomb.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D225 RID: 119333 RVA: 0x002B0B68 File Offset: 0x002AED68
		[NullableContext(1)]
		public UKSC_DA_Skill_LoadBomb(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Skill_LoadBomb.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x0601D226 RID: 119334 RVA: 0x002B0B9B File Offset: 0x002AED9B
		// (set) Token: 0x0601D227 RID: 119335 RVA: 0x002B0BAB File Offset: 0x002AEDAB
		public unsafe int MaxBombNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_MaxBombNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_MaxBombNum) = value;
			}
		}

		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x0601D228 RID: 119336 RVA: 0x002B0BBC File Offset: 0x002AEDBC
		// (set) Token: 0x0601D229 RID: 119337 RVA: 0x002B0BCC File Offset: 0x002AEDCC
		public unsafe float BombEndRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndRadius) = value;
			}
		}

		// Token: 0x170075AE RID: 30126
		// (get) Token: 0x0601D22A RID: 119338 RVA: 0x002B0BDD File Offset: 0x002AEDDD
		// (set) Token: 0x0601D22B RID: 119339 RVA: 0x002B0BF1 File Offset: 0x002AEDF1
		public unsafe FVector BombStartOffset1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset1) = value;
			}
		}

		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x0601D22C RID: 119340 RVA: 0x002B0C06 File Offset: 0x002AEE06
		// (set) Token: 0x0601D22D RID: 119341 RVA: 0x002B0C1A File Offset: 0x002AEE1A
		public unsafe FVector BombStartOffset2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset2) = value;
			}
		}

		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x0601D22E RID: 119342 RVA: 0x002B0C2F File Offset: 0x002AEE2F
		// (set) Token: 0x0601D22F RID: 119343 RVA: 0x002B0C43 File Offset: 0x002AEE43
		public unsafe FVector BombStartOffset3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset3) = value;
			}
		}

		// Token: 0x170075B1 RID: 30129
		// (get) Token: 0x0601D230 RID: 119344 RVA: 0x002B0C58 File Offset: 0x002AEE58
		// (set) Token: 0x0601D231 RID: 119345 RVA: 0x002B0C6C File Offset: 0x002AEE6C
		public unsafe FVector BombStartOffset4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombStartOffset4) = value;
			}
		}

		// Token: 0x170075B2 RID: 30130
		// (get) Token: 0x0601D232 RID: 119346 RVA: 0x002B0C81 File Offset: 0x002AEE81
		// (set) Token: 0x0601D233 RID: 119347 RVA: 0x002B0C95 File Offset: 0x002AEE95
		public unsafe FVector BombEndOffset1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset1) = value;
			}
		}

		// Token: 0x170075B3 RID: 30131
		// (get) Token: 0x0601D234 RID: 119348 RVA: 0x002B0CAA File Offset: 0x002AEEAA
		// (set) Token: 0x0601D235 RID: 119349 RVA: 0x002B0CBE File Offset: 0x002AEEBE
		public unsafe FVector BombEndOffset2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset2) = value;
			}
		}

		// Token: 0x170075B4 RID: 30132
		// (get) Token: 0x0601D236 RID: 119350 RVA: 0x002B0CD3 File Offset: 0x002AEED3
		// (set) Token: 0x0601D237 RID: 119351 RVA: 0x002B0CE7 File Offset: 0x002AEEE7
		public unsafe FVector BombEndOffset3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset3) = value;
			}
		}

		// Token: 0x170075B5 RID: 30133
		// (get) Token: 0x0601D238 RID: 119352 RVA: 0x002B0CFC File Offset: 0x002AEEFC
		// (set) Token: 0x0601D239 RID: 119353 RVA: 0x002B0D10 File Offset: 0x002AEF10
		public unsafe FVector BombEndOffset4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombEndOffset4) = value;
			}
		}

		// Token: 0x170075B6 RID: 30134
		// (get) Token: 0x0601D23A RID: 119354 RVA: 0x002B0D25 File Offset: 0x002AEF25
		// (set) Token: 0x0601D23B RID: 119355 RVA: 0x002B0D35 File Offset: 0x002AEF35
		public unsafe float BombLifeTimeOffset1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset1) = value;
			}
		}

		// Token: 0x170075B7 RID: 30135
		// (get) Token: 0x0601D23C RID: 119356 RVA: 0x002B0D46 File Offset: 0x002AEF46
		// (set) Token: 0x0601D23D RID: 119357 RVA: 0x002B0D56 File Offset: 0x002AEF56
		public unsafe float BombLifeTimeOffset2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset2) = value;
			}
		}

		// Token: 0x170075B8 RID: 30136
		// (get) Token: 0x0601D23E RID: 119358 RVA: 0x002B0D67 File Offset: 0x002AEF67
		// (set) Token: 0x0601D23F RID: 119359 RVA: 0x002B0D77 File Offset: 0x002AEF77
		public unsafe float BombLifeTimeOffset3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset3) = value;
			}
		}

		// Token: 0x170075B9 RID: 30137
		// (get) Token: 0x0601D240 RID: 119360 RVA: 0x002B0D88 File Offset: 0x002AEF88
		// (set) Token: 0x0601D241 RID: 119361 RVA: 0x002B0D98 File Offset: 0x002AEF98
		public unsafe float BombLifeTimeOffset4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_BombLifeTimeOffset4) = value;
			}
		}

		// Token: 0x170075BA RID: 30138
		// (get) Token: 0x0601D242 RID: 119362 RVA: 0x002B0DA9 File Offset: 0x002AEFA9
		// (set) Token: 0x0601D243 RID: 119363 RVA: 0x002B0DBD File Offset: 0x002AEFBD
		[Nullable(2)]
		public unsafe UEffectModelBase KuroLoadBombFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LoadBomb.__PropertyOffset_KuroLoadBombFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Skill_LoadBomb.__PropertyOffset_KuroLoadBombFX, value);
			}
		}

		// Token: 0x170075BB RID: 30139
		// (get) Token: 0x0601D244 RID: 119364 RVA: 0x002B0DD2 File Offset: 0x002AEFD2
		// (set) Token: 0x0601D245 RID: 119365 RVA: 0x002B0DE2 File Offset: 0x002AEFE2
		public unsafe float LaunchBombSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_LaunchBombSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_LaunchBombSize) = value;
			}
		}

		// Token: 0x170075BC RID: 30140
		// (get) Token: 0x0601D246 RID: 119366 RVA: 0x002B0DF3 File Offset: 0x002AEFF3
		// (set) Token: 0x0601D247 RID: 119367 RVA: 0x002B0E07 File Offset: 0x002AF007
		public unsafe FVector LaunchOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_LaunchOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_LaunchOffset) = value;
			}
		}

		// Token: 0x170075BD RID: 30141
		// (get) Token: 0x0601D248 RID: 119368 RVA: 0x002B0E1C File Offset: 0x002AF01C
		// (set) Token: 0x0601D249 RID: 119369 RVA: 0x002B0E55 File Offset: 0x002AF055
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ObjectTypes) == null)
				{
					result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)UKSC_DA_Skill_LoadBomb.__PropertyOffset_ObjectTypes, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x0601D24A RID: 119370 RVA: 0x002B0E63 File Offset: 0x002AF063
		static UKSC_DA_Skill_LoadBomb()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Skill_LoadBomb");
		}

		// Token: 0x0601D24B RID: 119371 RVA: 0x002B0E71 File Offset: 0x002AF071
		protected UKSC_DA_Skill_LoadBomb(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD10 RID: 64784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Skill_LoadBomb";

		// Token: 0x0400FD11 RID: 64785
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD12 RID: 64786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD13 RID: 64787
		internal static int __PropertyOffset_MaxBombNum;

		// Token: 0x0400FD14 RID: 64788
		internal static int __PropertyOffset_BombEndRadius;

		// Token: 0x0400FD15 RID: 64789
		internal static int __PropertyOffset_BombStartOffset1;

		// Token: 0x0400FD16 RID: 64790
		internal static int __PropertyOffset_BombStartOffset2;

		// Token: 0x0400FD17 RID: 64791
		internal static int __PropertyOffset_BombStartOffset3;

		// Token: 0x0400FD18 RID: 64792
		internal static int __PropertyOffset_BombStartOffset4;

		// Token: 0x0400FD19 RID: 64793
		internal static int __PropertyOffset_BombEndOffset1;

		// Token: 0x0400FD1A RID: 64794
		internal static int __PropertyOffset_BombEndOffset2;

		// Token: 0x0400FD1B RID: 64795
		internal static int __PropertyOffset_BombEndOffset3;

		// Token: 0x0400FD1C RID: 64796
		internal static int __PropertyOffset_BombEndOffset4;

		// Token: 0x0400FD1D RID: 64797
		internal static int __PropertyOffset_BombLifeTimeOffset1;

		// Token: 0x0400FD1E RID: 64798
		internal static int __PropertyOffset_BombLifeTimeOffset2;

		// Token: 0x0400FD1F RID: 64799
		internal static int __PropertyOffset_BombLifeTimeOffset3;

		// Token: 0x0400FD20 RID: 64800
		internal static int __PropertyOffset_BombLifeTimeOffset4;

		// Token: 0x0400FD21 RID: 64801
		internal static int __PropertyOffset_KuroLoadBombFX;

		// Token: 0x0400FD22 RID: 64802
		internal static int __PropertyOffset_LaunchBombSize;

		// Token: 0x0400FD23 RID: 64803
		internal static int __PropertyOffset_LaunchOffset;

		// Token: 0x0400FD24 RID: 64804
		internal static int __PropertyOffset_ObjectTypes;

		// Token: 0x0400FD25 RID: 64805
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B95 RID: 7061
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorSpawnProperties")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroRainActorSpawnProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ADD1 RID: 110033 RVA: 0x00279CDE File Offset: 0x00277EDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRainActorSpawnProperties._ScriptStructPtr != 0) ? FKuroRainActorSpawnProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorSpawnProperties", ref FKuroRainActorSpawnProperties._ScriptStructPtr);
		}

		// Token: 0x17006C46 RID: 27718
		// (get) Token: 0x0601ADD2 RID: 110034 RVA: 0x00279D02 File Offset: 0x00277F02
		// (set) Token: 0x0601ADD3 RID: 110035 RVA: 0x00279D16 File Offset: 0x00277F16
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRainActorSpawnProperties.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRainActorSpawnProperties.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17006C47 RID: 27719
		// (get) Token: 0x0601ADD4 RID: 110036 RVA: 0x00279D2B File Offset: 0x00277F2B
		// (set) Token: 0x0601ADD5 RID: 110037 RVA: 0x00279D3F File Offset: 0x00277F3F
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRainActorSpawnProperties.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRainActorSpawnProperties.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17006C48 RID: 27720
		// (get) Token: 0x0601ADD6 RID: 110038 RVA: 0x00279D54 File Offset: 0x00277F54
		// (set) Token: 0x0601ADD7 RID: 110039 RVA: 0x00279D64 File Offset: 0x00277F64
		public unsafe float SpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnRate) = value;
			}
		}

		// Token: 0x17006C49 RID: 27721
		// (get) Token: 0x0601ADD8 RID: 110040 RVA: 0x00279D75 File Offset: 0x00277F75
		// (set) Token: 0x0601ADD9 RID: 110041 RVA: 0x00279D85 File Offset: 0x00277F85
		public unsafe float SpawnInnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnInnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnInnerRadius) = value;
			}
		}

		// Token: 0x17006C4A RID: 27722
		// (get) Token: 0x0601ADDA RID: 110042 RVA: 0x00279D96 File Offset: 0x00277F96
		// (set) Token: 0x0601ADDB RID: 110043 RVA: 0x00279DA6 File Offset: 0x00277FA6
		public unsafe float SpawnOuterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnOuterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_SpawnOuterRadius) = value;
			}
		}

		// Token: 0x17006C4B RID: 27723
		// (get) Token: 0x0601ADDC RID: 110044 RVA: 0x00279DB7 File Offset: 0x00277FB7
		// (set) Token: 0x0601ADDD RID: 110045 RVA: 0x00279DC7 File Offset: 0x00277FC7
		public unsafe float LifeTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_LifeTimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_LifeTimeMin) = value;
			}
		}

		// Token: 0x17006C4C RID: 27724
		// (get) Token: 0x0601ADDE RID: 110046 RVA: 0x00279DD8 File Offset: 0x00277FD8
		// (set) Token: 0x0601ADDF RID: 110047 RVA: 0x00279DE8 File Offset: 0x00277FE8
		public unsafe float LifeTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_LifeTimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_LifeTimeMax) = value;
			}
		}

		// Token: 0x17006C4D RID: 27725
		// (get) Token: 0x0601ADE0 RID: 110048 RVA: 0x00279DF9 File Offset: 0x00277FF9
		// (set) Token: 0x0601ADE1 RID: 110049 RVA: 0x00279E0D File Offset: 0x0027800D
		public unsafe FVector VelocityMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_VelocityMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_VelocityMin) = value;
			}
		}

		// Token: 0x17006C4E RID: 27726
		// (get) Token: 0x0601ADE2 RID: 110050 RVA: 0x00279E22 File Offset: 0x00278022
		// (set) Token: 0x0601ADE3 RID: 110051 RVA: 0x00279E36 File Offset: 0x00278036
		public unsafe FVector VelocityMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_VelocityMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_VelocityMax) = value;
			}
		}

		// Token: 0x17006C4F RID: 27727
		// (get) Token: 0x0601ADE4 RID: 110052 RVA: 0x00279E4B File Offset: 0x0027804B
		// (set) Token: 0x0601ADE5 RID: 110053 RVA: 0x00279E5B File Offset: 0x0027805B
		public unsafe float ScaleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_ScaleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_ScaleMin) = value;
			}
		}

		// Token: 0x17006C50 RID: 27728
		// (get) Token: 0x0601ADE6 RID: 110054 RVA: 0x00279E6C File Offset: 0x0027806C
		// (set) Token: 0x0601ADE7 RID: 110055 RVA: 0x00279E7C File Offset: 0x0027807C
		public unsafe float ScaleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_ScaleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_ScaleMax) = value;
			}
		}

		// Token: 0x17006C51 RID: 27729
		// (get) Token: 0x0601ADE8 RID: 110056 RVA: 0x00279E8D File Offset: 0x0027808D
		// (set) Token: 0x0601ADE9 RID: 110057 RVA: 0x00279E9D File Offset: 0x0027809D
		public unsafe float BaseMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_BaseMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRainActorSpawnProperties.__PropertyOffset_BaseMass) = value;
			}
		}

		// Token: 0x0601ADEA RID: 110058 RVA: 0x00279EAE File Offset: 0x002780AE
		public FKuroRainActorSpawnProperties()
		{
		}

		// Token: 0x0601ADEB RID: 110059 RVA: 0x00279EB8 File Offset: 0x002780B8
		[NullableContext(1)]
		public FKuroRainActorSpawnProperties(UStaticMesh Mesh, UMaterialInterface Material, float SpawnRate, float SpawnInnerRadius, float SpawnOuterRadius, float LifeTimeMin, float LifeTimeMax, FVector VelocityMin, FVector VelocityMax, float ScaleMin, float ScaleMax, float BaseMass)
		{
			this.Mesh = Mesh;
			this.Material = Material;
			this.SpawnRate = SpawnRate;
			this.SpawnInnerRadius = SpawnInnerRadius;
			this.SpawnOuterRadius = SpawnOuterRadius;
			this.LifeTimeMin = LifeTimeMin;
			this.LifeTimeMax = LifeTimeMax;
			this.VelocityMin = VelocityMin;
			this.VelocityMax = VelocityMax;
			this.ScaleMin = ScaleMin;
			this.ScaleMax = ScaleMax;
			this.BaseMass = BaseMass;
		}

		// Token: 0x0601ADEC RID: 110060 RVA: 0x00279F28 File Offset: 0x00278128
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRainActorSpawnProperties.StaticStruct();
		}

		// Token: 0x0601ADED RID: 110061 RVA: 0x00279F34 File Offset: 0x00278134
		public FKuroRainActorSpawnProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x00279F3E File Offset: 0x0027813E
		public FKuroRainActorSpawnProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ADEF RID: 110063 RVA: 0x00279F49 File Offset: 0x00278149
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRainActorSpawnProperties(Pointer, false, true);
		}

		// Token: 0x0601ADF0 RID: 110064 RVA: 0x00279F53 File Offset: 0x00278153
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRainActorSpawnProperties(Pointer, MemoryOwner);
		}

		// Token: 0x0400E8AC RID: 59564
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainActorSpawnProperties";

		// Token: 0x0400E8AD RID: 59565
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E8AE RID: 59566
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400E8AF RID: 59567
		internal static int __PropertyOffset_Material;

		// Token: 0x0400E8B0 RID: 59568
		internal static int __PropertyOffset_SpawnRate;

		// Token: 0x0400E8B1 RID: 59569
		internal static int __PropertyOffset_SpawnInnerRadius;

		// Token: 0x0400E8B2 RID: 59570
		internal static int __PropertyOffset_SpawnOuterRadius;

		// Token: 0x0400E8B3 RID: 59571
		internal static int __PropertyOffset_LifeTimeMin;

		// Token: 0x0400E8B4 RID: 59572
		internal static int __PropertyOffset_LifeTimeMax;

		// Token: 0x0400E8B5 RID: 59573
		internal static int __PropertyOffset_VelocityMin;

		// Token: 0x0400E8B6 RID: 59574
		internal static int __PropertyOffset_VelocityMax;

		// Token: 0x0400E8B7 RID: 59575
		internal static int __PropertyOffset_ScaleMin;

		// Token: 0x0400E8B8 RID: 59576
		internal static int __PropertyOffset_ScaleMax;

		// Token: 0x0400E8B9 RID: 59577
		internal static int __PropertyOffset_BaseMass;
	}
}

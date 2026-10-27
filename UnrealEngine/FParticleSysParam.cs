using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC3 RID: 4035
	[UnrealObjectPath("/Script/Engine.ParticleSysParam")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FParticleSysParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D91D RID: 55581 RVA: 0x0014082E File Offset: 0x0013EA2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleSysParam._ScriptStructPtr != 0) ? FParticleSysParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleSysParam", ref FParticleSysParam._ScriptStructPtr);
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600D91E RID: 55582 RVA: 0x00140852 File Offset: 0x0013EA52
		// (set) Token: 0x0600D91F RID: 55583 RVA: 0x00140866 File Offset: 0x0013EA66
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x0014087B File Offset: 0x0013EA7B
		// (set) Token: 0x0600D921 RID: 55585 RVA: 0x0014088F File Offset: 0x0013EA8F
		public unsafe TEnumAsByte<EParticleSysParamType> ParamType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_ParamType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_ParamType) = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600D922 RID: 55586 RVA: 0x001408A4 File Offset: 0x0013EAA4
		// (set) Token: 0x0600D923 RID: 55587 RVA: 0x001408B4 File Offset: 0x0013EAB4
		public unsafe float Scalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Scalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Scalar) = value;
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600D924 RID: 55588 RVA: 0x001408C5 File Offset: 0x0013EAC5
		// (set) Token: 0x0600D925 RID: 55589 RVA: 0x001408D5 File Offset: 0x0013EAD5
		public unsafe float Scalar_Low
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Scalar_Low);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Scalar_Low) = value;
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600D926 RID: 55590 RVA: 0x001408E6 File Offset: 0x0013EAE6
		// (set) Token: 0x0600D927 RID: 55591 RVA: 0x001408FA File Offset: 0x0013EAFA
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x0014090F File Offset: 0x0013EB0F
		// (set) Token: 0x0600D929 RID: 55593 RVA: 0x00140923 File Offset: 0x0013EB23
		public unsafe FVector Vector_Low
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Vector_Low);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Vector_Low) = value;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600D92A RID: 55594 RVA: 0x00140938 File Offset: 0x0013EB38
		// (set) Token: 0x0600D92B RID: 55595 RVA: 0x0014094C File Offset: 0x0013EB4C
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleSysParam.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600D92C RID: 55596 RVA: 0x00140961 File Offset: 0x0013EB61
		// (set) Token: 0x0600D92D RID: 55597 RVA: 0x00140975 File Offset: 0x0013EB75
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FParticleSysParam.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FParticleSysParam.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600D92E RID: 55598 RVA: 0x0014098A File Offset: 0x0013EB8A
		// (set) Token: 0x0600D92F RID: 55599 RVA: 0x0014099E File Offset: 0x0013EB9E
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FParticleSysParam.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FParticleSysParam.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0600D930 RID: 55600 RVA: 0x001409B3 File Offset: 0x0013EBB3
		public FParticleSysParam()
		{
		}

		// Token: 0x0600D931 RID: 55601 RVA: 0x001409BC File Offset: 0x0013EBBC
		[NullableContext(1)]
		public FParticleSysParam(FName Name, [Nullable(0)] TEnumAsByte<EParticleSysParamType> ParamType, float Scalar, float Scalar_Low, FVector Vector, FVector Vector_Low, FColor Color, AActor Actor, UMaterialInterface Material)
		{
			this.Name = Name;
			this.ParamType = ParamType;
			this.Scalar = Scalar;
			this.Scalar_Low = Scalar_Low;
			this.Vector = Vector;
			this.Vector_Low = Vector_Low;
			this.Color = Color;
			this.Actor = Actor;
			this.Material = Material;
		}

		// Token: 0x0600D932 RID: 55602 RVA: 0x00140A14 File Offset: 0x0013EC14
		protected override IntPtr GetUStructPtr()
		{
			return FParticleSysParam.StaticStruct();
		}

		// Token: 0x0600D933 RID: 55603 RVA: 0x00140A20 File Offset: 0x0013EC20
		[NullableContext(2)]
		public FParticleSysParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D934 RID: 55604 RVA: 0x00140A2A File Offset: 0x0013EC2A
		public FParticleSysParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x00140A35 File Offset: 0x0013EC35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleSysParam(Pointer, false, true);
		}

		// Token: 0x0600D936 RID: 55606 RVA: 0x00140A3F File Offset: 0x0013EC3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleSysParam(Pointer, MemoryOwner);
		}

		// Token: 0x040075B9 RID: 30137
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleSysParam";

		// Token: 0x040075BA RID: 30138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040075BB RID: 30139
		internal static int __PropertyOffset_Name;

		// Token: 0x040075BC RID: 30140
		internal static int __PropertyOffset_ParamType;

		// Token: 0x040075BD RID: 30141
		internal static int __PropertyOffset_Scalar;

		// Token: 0x040075BE RID: 30142
		internal static int __PropertyOffset_Scalar_Low;

		// Token: 0x040075BF RID: 30143
		internal static int __PropertyOffset_Vector;

		// Token: 0x040075C0 RID: 30144
		internal static int __PropertyOffset_Vector_Low;

		// Token: 0x040075C1 RID: 30145
		internal static int __PropertyOffset_Color;

		// Token: 0x040075C2 RID: 30146
		internal static int __PropertyOffset_Actor;

		// Token: 0x040075C3 RID: 30147
		internal static int __PropertyOffset_Material;
	}
}

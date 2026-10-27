using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAD RID: 7597
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2DComp")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_DA_Shape2DComp : UKSC_DA_SceneComp, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0A6 RID: 118950 RVA: 0x002AEBDF File Offset: 0x002ACDDF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2DComp._ClassPtr;
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x002AEBEC File Offset: 0x002ACDEC
		public UKSC_DA_Shape2DComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x002AEC14 File Offset: 0x002ACE14
		[NullableContext(1)]
		public UKSC_DA_Shape2DComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007528 RID: 29992
		// (get) Token: 0x0601D0A9 RID: 118953 RVA: 0x002AEC47 File Offset: 0x002ACE47
		// (set) Token: 0x0601D0AA RID: 118954 RVA: 0x002AEC57 File Offset: 0x002ACE57
		public unsafe EKSC_ShapeCompType ShapeType
		{
			get
			{
				return (EKSC_ShapeCompType)(*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_ShapeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_ShapeType) = (byte)value;
			}
		}

		// Token: 0x17007529 RID: 29993
		// (get) Token: 0x0601D0AB RID: 118955 RVA: 0x002AEC68 File Offset: 0x002ACE68
		// (set) Token: 0x0601D0AC RID: 118956 RVA: 0x002AEC7C File Offset: 0x002ACE7C
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x1700752A RID: 29994
		// (get) Token: 0x0601D0AD RID: 118957 RVA: 0x002AEC91 File Offset: 0x002ACE91
		// (set) Token: 0x0601D0AE RID: 118958 RVA: 0x002AECA5 File Offset: 0x002ACEA5
		public unsafe FVector2D Pivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_Pivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_Pivot) = value;
			}
		}

		// Token: 0x1700752B RID: 29995
		// (get) Token: 0x0601D0AF RID: 118959 RVA: 0x002AECBA File Offset: 0x002ACEBA
		// (set) Token: 0x0601D0B0 RID: 118960 RVA: 0x002AECCA File Offset: 0x002ACECA
		public unsafe int MaterialID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_MaterialID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DComp.__PropertyOffset_MaterialID) = value;
			}
		}

		// Token: 0x0601D0B1 RID: 118961 RVA: 0x002AECDB File Offset: 0x002ACEDB
		static UKSC_DA_Shape2DComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2DComp");
		}

		// Token: 0x0601D0B2 RID: 118962 RVA: 0x002AECE9 File Offset: 0x002ACEE9
		protected UKSC_DA_Shape2DComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC3F RID: 64575
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2DComp";

		// Token: 0x0400FC40 RID: 64576
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC41 RID: 64577
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC42 RID: 64578
		internal static int __PropertyOffset_ShapeType;

		// Token: 0x0400FC43 RID: 64579
		internal static int __PropertyOffset_Size;

		// Token: 0x0400FC44 RID: 64580
		internal static int __PropertyOffset_Pivot;

		// Token: 0x0400FC45 RID: 64581
		internal static int __PropertyOffset_MaterialID;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB1 RID: 7601
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Bar")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity_Bar : UKSC_DA_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0C8 RID: 118984 RVA: 0x002AEED2 File Offset: 0x002AD0D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity_Bar._ClassPtr;
		}

		// Token: 0x0601D0C9 RID: 118985 RVA: 0x002AEEE0 File Offset: 0x002AD0E0
		public UKSC_DA_Shape2D_Entity_Bar() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Bar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0CA RID: 118986 RVA: 0x002AEF08 File Offset: 0x002AD108
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity_Bar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Bar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700752F RID: 29999
		// (get) Token: 0x0601D0CB RID: 118987 RVA: 0x002AEF3B File Offset: 0x002AD13B
		// (set) Token: 0x0601D0CC RID: 118988 RVA: 0x002AEF4B File Offset: 0x002AD14B
		public unsafe EKSC_ShapeBarSide Side
		{
			get
			{
				return (EKSC_ShapeBarSide)(*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Bar.__PropertyOffset_Side));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_Entity_Bar.__PropertyOffset_Side) = (byte)value;
			}
		}

		// Token: 0x0601D0CD RID: 118989 RVA: 0x002AEF5C File Offset: 0x002AD15C
		static UKSC_DA_Shape2D_Entity_Bar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Bar");
		}

		// Token: 0x0601D0CE RID: 118990 RVA: 0x002AEF6A File Offset: 0x002AD16A
		protected UKSC_DA_Shape2D_Entity_Bar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC52 RID: 64594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Bar";

		// Token: 0x0400FC53 RID: 64595
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC54 RID: 64596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC55 RID: 64597
		internal static int __PropertyOffset_Side;
	}
}

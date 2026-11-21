using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000571 RID: 1393
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2DComp")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_DA_Shape2DComp : UKSC_DA_SceneComp, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E81 RID: 32385 RVA: 0x000BB782 File Offset: 0x000B9982
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2DComp._ClassPtr;
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x000BB790 File Offset: 0x000B9990
		public UKSC_DA_Shape2DComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x000BB7B8 File Offset: 0x000B99B8
		[NullableContext(1)]
		public UKSC_DA_Shape2DComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x000BB7EB File Offset: 0x000B99EB
		// (set) Token: 0x06007E85 RID: 32389 RVA: 0x000BB7FF File Offset: 0x000B99FF
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

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x000BB814 File Offset: 0x000B9A14
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x000BB828 File Offset: 0x000B9A28
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

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x000BB83D File Offset: 0x000B9A3D
		// (set) Token: 0x06007E89 RID: 32393 RVA: 0x000BB84D File Offset: 0x000B9A4D
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

		// Token: 0x06007E8A RID: 32394 RVA: 0x000BB85E File Offset: 0x000B9A5E
		static UKSC_DA_Shape2DComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2DComp");
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x000BB86C File Offset: 0x000B9A6C
		protected UKSC_DA_Shape2DComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003739 RID: 14137
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2DComp";

		// Token: 0x0400373A RID: 14138
		private static IntPtr _ClassPtr;

		// Token: 0x0400373B RID: 14139
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400373C RID: 14140
		internal static int __PropertyOffset_Size;

		// Token: 0x0400373D RID: 14141
		internal static int __PropertyOffset_Pivot;

		// Token: 0x0400373E RID: 14142
		internal static int __PropertyOffset_MaterialID;
	}
}

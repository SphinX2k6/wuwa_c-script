using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA1 RID: 7585
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Around")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Move_Around : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D02E RID: 118830 RVA: 0x002AE0D7 File Offset: 0x002AC2D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Around._ClassPtr;
		}

		// Token: 0x0601D02F RID: 118831 RVA: 0x002AE0E4 File Offset: 0x002AC2E4
		public UKSC_DA_Move_Around() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Around.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D030 RID: 118832 RVA: 0x002AE10C File Offset: 0x002AC30C
		[NullableContext(1)]
		public UKSC_DA_Move_Around(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Around.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700750A RID: 29962
		// (get) Token: 0x0601D031 RID: 118833 RVA: 0x002AE13F File Offset: 0x002AC33F
		// (set) Token: 0x0601D032 RID: 118834 RVA: 0x002AE14F File Offset: 0x002AC34F
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Around.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Around.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700750B RID: 29963
		// (get) Token: 0x0601D033 RID: 118835 RVA: 0x002AE160 File Offset: 0x002AC360
		// (set) Token: 0x0601D034 RID: 118836 RVA: 0x002AE170 File Offset: 0x002AC370
		public unsafe float OffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Around.__PropertyOffset_OffsetZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Around.__PropertyOffset_OffsetZ) = value;
			}
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x002AE181 File Offset: 0x002AC381
		static UKSC_DA_Move_Around()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Around");
		}

		// Token: 0x0601D036 RID: 118838 RVA: 0x002AE18F File Offset: 0x002AC38F
		protected UKSC_DA_Move_Around(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBF6 RID: 64502
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Around";

		// Token: 0x0400FBF7 RID: 64503
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBF8 RID: 64504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBF9 RID: 64505
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400FBFA RID: 64506
		internal static int __PropertyOffset_OffsetZ;
	}
}

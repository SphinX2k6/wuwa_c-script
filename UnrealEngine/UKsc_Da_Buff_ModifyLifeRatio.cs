using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D70 RID: 7536
	[UnrealObjectPath("/Script/KuroSimpleCombat.Ksc_Da_Buff_ModifyLifeRatio")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKsc_Da_Buff_ModifyLifeRatio : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDE3 RID: 118243 RVA: 0x002AABDB File Offset: 0x002A8DDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKsc_Da_Buff_ModifyLifeRatio._ClassPtr;
		}

		// Token: 0x0601CDE4 RID: 118244 RVA: 0x002AABE8 File Offset: 0x002A8DE8
		public UKsc_Da_Buff_ModifyLifeRatio() : this(BuiltinUtils.AllocNativeUObject(UKsc_Da_Buff_ModifyLifeRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDE5 RID: 118245 RVA: 0x002AAC10 File Offset: 0x002A8E10
		[NullableContext(1)]
		public UKsc_Da_Buff_ModifyLifeRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKsc_Da_Buff_ModifyLifeRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700745D RID: 29789
		// (get) Token: 0x0601CDE6 RID: 118246 RVA: 0x002AAC43 File Offset: 0x002A8E43
		// (set) Token: 0x0601CDE7 RID: 118247 RVA: 0x002AAC53 File Offset: 0x002A8E53
		public unsafe int LifeRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKsc_Da_Buff_ModifyLifeRatio.__PropertyOffset_LifeRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKsc_Da_Buff_ModifyLifeRatio.__PropertyOffset_LifeRatio) = value;
			}
		}

		// Token: 0x0601CDE8 RID: 118248 RVA: 0x002AAC64 File Offset: 0x002A8E64
		static UKsc_Da_Buff_ModifyLifeRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.Ksc_Da_Buff_ModifyLifeRatio");
		}

		// Token: 0x0601CDE9 RID: 118249 RVA: 0x002AAC72 File Offset: 0x002A8E72
		protected UKsc_Da_Buff_ModifyLifeRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA95 RID: 64149
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.Ksc_Da_Buff_ModifyLifeRatio";

		// Token: 0x0400FA96 RID: 64150
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA97 RID: 64151
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA98 RID: 64152
		internal static int __PropertyOffset_LifeRatio;
	}
}

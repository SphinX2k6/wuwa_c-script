using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3A RID: 7482
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_SummonLink")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Buff_SummonLink : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAB7 RID: 117431 RVA: 0x002A620F File Offset: 0x002A440F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_SummonLink._ClassPtr;
		}

		// Token: 0x0601CAB8 RID: 117432 RVA: 0x002A621C File Offset: 0x002A441C
		public UKSC_Buff_SummonLink() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_SummonLink.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x002A6244 File Offset: 0x002A4444
		[NullableContext(1)]
		public UKSC_Buff_SummonLink(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_SummonLink.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007354 RID: 29524
		// (get) Token: 0x0601CABA RID: 117434 RVA: 0x002A6277 File Offset: 0x002A4477
		// (set) Token: 0x0601CABB RID: 117435 RVA: 0x002A628B File Offset: 0x002A448B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_SummonLink DaBuffSummonLink_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_SummonLink>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_SummonLink.__PropertyOffset_DaBuffSummonLink_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_SummonLink.__PropertyOffset_DaBuffSummonLink_, value);
			}
		}

		// Token: 0x0601CABC RID: 117436 RVA: 0x002A62A0 File Offset: 0x002A44A0
		static UKSC_Buff_SummonLink()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_SummonLink");
		}

		// Token: 0x0601CABD RID: 117437 RVA: 0x002A62AE File Offset: 0x002A44AE
		protected UKSC_Buff_SummonLink(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8B0 RID: 63664
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_SummonLink";

		// Token: 0x0400F8B1 RID: 63665
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8B2 RID: 63666
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8B3 RID: 63667
		internal static int __PropertyOffset_DaBuffSummonLink_;
	}
}

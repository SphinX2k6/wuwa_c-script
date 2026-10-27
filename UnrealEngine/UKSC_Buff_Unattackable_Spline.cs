using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3C RID: 7484
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Unattackable_Spline")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_Unattackable_Spline : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAC7 RID: 117447 RVA: 0x002A636E File Offset: 0x002A456E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Unattackable_Spline._ClassPtr;
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x002A637C File Offset: 0x002A457C
		public UKSC_Buff_Unattackable_Spline() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Unattackable_Spline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAC9 RID: 117449 RVA: 0x002A63A4 File Offset: 0x002A45A4
		[NullableContext(1)]
		public UKSC_Buff_Unattackable_Spline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Unattackable_Spline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007356 RID: 29526
		// (get) Token: 0x0601CACA RID: 117450 RVA: 0x002A63D7 File Offset: 0x002A45D7
		// (set) Token: 0x0601CACB RID: 117451 RVA: 0x002A63EB File Offset: 0x002A45EB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Unattackable_Spline DaBuffUnattackable_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Unattackable_Spline>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Unattackable_Spline.__PropertyOffset_DaBuffUnattackable_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Unattackable_Spline.__PropertyOffset_DaBuffUnattackable_, value);
			}
		}

		// Token: 0x0601CACC RID: 117452 RVA: 0x002A6400 File Offset: 0x002A4600
		static UKSC_Buff_Unattackable_Spline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Unattackable_Spline");
		}

		// Token: 0x0601CACD RID: 117453 RVA: 0x002A640E File Offset: 0x002A460E
		protected UKSC_Buff_Unattackable_Spline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8B8 RID: 63672
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Unattackable_Spline";

		// Token: 0x0400F8B9 RID: 63673
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8BA RID: 63674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8BB RID: 63675
		internal static int __PropertyOffset_DaBuffUnattackable_;
	}
}

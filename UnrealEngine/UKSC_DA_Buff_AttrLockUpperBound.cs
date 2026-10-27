using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D56 RID: 7510
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockUpperBound")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_AttrLockUpperBound : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC15 RID: 117781 RVA: 0x002A80AC File Offset: 0x002A62AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AttrLockUpperBound._ClassPtr;
		}

		// Token: 0x0601CC16 RID: 117782 RVA: 0x002A80B8 File Offset: 0x002A62B8
		public UKSC_DA_Buff_AttrLockUpperBound() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrLockUpperBound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC17 RID: 117783 RVA: 0x002A80E0 File Offset: 0x002A62E0
		[NullableContext(1)]
		public UKSC_DA_Buff_AttrLockUpperBound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrLockUpperBound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073B7 RID: 29623
		// (get) Token: 0x0601CC18 RID: 117784 RVA: 0x002A8113 File Offset: 0x002A6313
		// (set) Token: 0x0601CC19 RID: 117785 RVA: 0x002A8123 File Offset: 0x002A6323
		public unsafe EKSC_AttrType Id
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockUpperBound.__PropertyOffset_Id));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockUpperBound.__PropertyOffset_Id) = (byte)value;
			}
		}

		// Token: 0x170073B8 RID: 29624
		// (get) Token: 0x0601CC1A RID: 117786 RVA: 0x002A8134 File Offset: 0x002A6334
		// (set) Token: 0x0601CC1B RID: 117787 RVA: 0x002A8144 File Offset: 0x002A6344
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockUpperBound.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrLockUpperBound.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601CC1C RID: 117788 RVA: 0x002A8155 File Offset: 0x002A6355
		static UKSC_DA_Buff_AttrLockUpperBound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockUpperBound");
		}

		// Token: 0x0601CC1D RID: 117789 RVA: 0x002A8163 File Offset: 0x002A6363
		protected UKSC_DA_Buff_AttrLockUpperBound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F978 RID: 63864
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrLockUpperBound";

		// Token: 0x0400F979 RID: 63865
		private static IntPtr _ClassPtr;

		// Token: 0x0400F97A RID: 63866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F97B RID: 63867
		internal static int __PropertyOffset_Id;

		// Token: 0x0400F97C RID: 63868
		internal static int __PropertyOffset_Value;
	}
}

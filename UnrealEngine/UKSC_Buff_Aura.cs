using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0D RID: 7437
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Aura")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKSC_Buff_Aura : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C960 RID: 117088 RVA: 0x002A4233 File Offset: 0x002A2433
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Aura._ClassPtr;
		}

		// Token: 0x0601C961 RID: 117089 RVA: 0x002A4240 File Offset: 0x002A2440
		public UKSC_Buff_Aura() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Aura.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C962 RID: 117090 RVA: 0x002A4268 File Offset: 0x002A2468
		[NullableContext(1)]
		public UKSC_Buff_Aura(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Aura.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731D RID: 29469
		// (get) Token: 0x0601C963 RID: 117091 RVA: 0x002A429B File Offset: 0x002A249B
		// (set) Token: 0x0601C964 RID: 117092 RVA: 0x002A42AF File Offset: 0x002A24AF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Aura DaBuffAura_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Aura>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Aura.__PropertyOffset_DaBuffAura_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Aura.__PropertyOffset_DaBuffAura_, value);
			}
		}

		// Token: 0x0601C965 RID: 117093 RVA: 0x002A42C4 File Offset: 0x002A24C4
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_Aura.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601C966 RID: 117094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601C967 RID: 117095 RVA: 0x002A42D3 File Offset: 0x002A24D3
		static UKSC_Buff_Aura()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Aura");
		}

		// Token: 0x0601C968 RID: 117096 RVA: 0x002A42E1 File Offset: 0x002A24E1
		protected UKSC_Buff_Aura(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7EE RID: 63470
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Aura";

		// Token: 0x0400F7EF RID: 63471
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7F0 RID: 63472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7F1 RID: 63473
		internal static int __PropertyOffset_DaBuffAura_;
	}
}

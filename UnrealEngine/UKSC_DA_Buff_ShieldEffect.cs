using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7E RID: 7550
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ShieldEffect")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Buff_ShieldEffect : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CEA0 RID: 118432 RVA: 0x002ABD36 File Offset: 0x002A9F36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ShieldEffect._ClassPtr;
		}

		// Token: 0x0601CEA1 RID: 118433 RVA: 0x002ABD44 File Offset: 0x002A9F44
		public UKSC_DA_Buff_ShieldEffect() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ShieldEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CEA2 RID: 118434 RVA: 0x002ABD6C File Offset: 0x002A9F6C
		[NullableContext(1)]
		public UKSC_DA_Buff_ShieldEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ShieldEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007499 RID: 29849
		// (get) Token: 0x0601CEA3 RID: 118435 RVA: 0x002ABD9F File Offset: 0x002A9F9F
		// (set) Token: 0x0601CEA4 RID: 118436 RVA: 0x002ABDB3 File Offset: 0x002A9FB3
		[Nullable(2)]
		public unsafe UEffectModelBase ShieldBuffFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldBuffFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldBuffFX, value);
			}
		}

		// Token: 0x1700749A RID: 29850
		// (get) Token: 0x0601CEA5 RID: 118437 RVA: 0x002ABDC8 File Offset: 0x002A9FC8
		// (set) Token: 0x0601CEA6 RID: 118438 RVA: 0x002ABDDC File Offset: 0x002A9FDC
		public unsafe FTransform ShieldBuffFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldBuffFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldBuffFX_Offset) = value;
			}
		}

		// Token: 0x1700749B RID: 29851
		// (get) Token: 0x0601CEA7 RID: 118439 RVA: 0x002ABDF1 File Offset: 0x002A9FF1
		// (set) Token: 0x0601CEA8 RID: 118440 RVA: 0x002ABE05 File Offset: 0x002AA005
		public unsafe FName ShieldSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ShieldEffect.__PropertyOffset_ShieldSocket) = value;
			}
		}

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x002ABE1A File Offset: 0x002AA01A
		static UKSC_DA_Buff_ShieldEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ShieldEffect");
		}

		// Token: 0x0601CEAA RID: 118442 RVA: 0x002ABE28 File Offset: 0x002AA028
		protected UKSC_DA_Buff_ShieldEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB09 RID: 64265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ShieldEffect";

		// Token: 0x0400FB0A RID: 64266
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB0B RID: 64267
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB0C RID: 64268
		internal static int __PropertyOffset_ShieldBuffFX;

		// Token: 0x0400FB0D RID: 64269
		internal static int __PropertyOffset_ShieldBuffFX_Offset;

		// Token: 0x0400FB0E RID: 64270
		internal static int __PropertyOffset_ShieldSocket;
	}
}

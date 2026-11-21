using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C9 RID: 969
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelNDC")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEffectModelNDC : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005EA3 RID: 24227 RVA: 0x00085F06 File Offset: 0x00084106
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelNDC._ClassPtr;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00085F14 File Offset: 0x00084114
		public UEffectModelNDC() : this(BuiltinUtils.AllocNativeUObject(UEffectModelNDC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00085F3C File Offset: 0x0008413C
		[NullableContext(1)]
		public UEffectModelNDC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x00085F6F File Offset: 0x0008416F
		// (set) Token: 0x06005EA7 RID: 24231 RVA: 0x00085F83 File Offset: 0x00084183
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset NiagaraDataChannel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNDC.__PropertyOffset_NiagaraDataChannel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNDC.__PropertyOffset_NiagaraDataChannel, value);
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06005EA8 RID: 24232 RVA: 0x00085F98 File Offset: 0x00084198
		// (set) Token: 0x06005EA9 RID: 24233 RVA: 0x00085FAC File Offset: 0x000841AC
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06005EAA RID: 24234 RVA: 0x00085FC1 File Offset: 0x000841C1
		// (set) Token: 0x06005EAB RID: 24235 RVA: 0x00085FD1 File Offset: 0x000841D1
		public unsafe bool IgnoreActorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_IgnoreActorScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_IgnoreActorScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00085FE2 File Offset: 0x000841E2
		static UEffectModelNDC()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelNDC");
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00085FF0 File Offset: 0x000841F0
		protected UEffectModelNDC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040027A3 RID: 10147
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelNDC";

		// Token: 0x040027A4 RID: 10148
		private static IntPtr _ClassPtr;

		// Token: 0x040027A5 RID: 10149
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040027A6 RID: 10150
		internal static int __PropertyOffset_NiagaraDataChannel;

		// Token: 0x040027A7 RID: 10151
		internal static int __PropertyOffset_Scale;

		// Token: 0x040027A8 RID: 10152
		internal static int __PropertyOffset_IgnoreActorScale;
	}
}

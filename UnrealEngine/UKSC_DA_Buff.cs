using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000568 RID: 1384
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DE7 RID: 32231 RVA: 0x000BAAA8 File Offset: 0x000B8CA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff._ClassPtr;
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x000BAAB4 File Offset: 0x000B8CB4
		public UKSC_DA_Buff() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x000BAADC File Offset: 0x000B8CDC
		[NullableContext(1)]
		public UKSC_DA_Buff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x000BAB0F File Offset: 0x000B8D0F
		// (set) Token: 0x06007DEB RID: 32235 RVA: 0x000BAB1F File Offset: 0x000B8D1F
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06007DEC RID: 32236 RVA: 0x000BAB30 File Offset: 0x000B8D30
		// (set) Token: 0x06007DED RID: 32237 RVA: 0x000BAB40 File Offset: 0x000B8D40
		public unsafe bool RefreshTagWhenBuffRefresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RefreshTagWhenBuffRefresh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RefreshTagWhenBuffRefresh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x000BAB51 File Offset: 0x000B8D51
		// (set) Token: 0x06007DEF RID: 32239 RVA: 0x000BAB61 File Offset: 0x000B8D61
		public unsafe bool InstantNeedUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_InstantNeedUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_InstantNeedUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x000BAB74 File Offset: 0x000B8D74
		// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x000BABAD File Offset: 0x000B8DAD
		[Nullable(1)]
		public FGameplayTagContainer BuffTags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BuffTags) == null)
				{
					result = (this._BuffTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffTags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x000BABD0 File Offset: 0x000B8DD0
		// (set) Token: 0x06007DF3 RID: 32243 RVA: 0x000BAC09 File Offset: 0x000B8E09
		[Nullable(1)]
		public TArray<UKSC_DA_Buff> BuffAddBuffs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._BuffAddBuffs) == null)
				{
					result = (this._BuffAddBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffAddBuffs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BuffAddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x000BAC17 File Offset: 0x000B8E17
		// (set) Token: 0x06007DF5 RID: 32245 RVA: 0x000BAC27 File Offset: 0x000B8E27
		public unsafe bool RemoveChildBuffWhenEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RemoveChildBuffWhenEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_RemoveChildBuffWhenEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x000BAC38 File Offset: 0x000B8E38
		// (set) Token: 0x06007DF7 RID: 32247 RVA: 0x000BAC4C File Offset: 0x000B8E4C
		public unsafe UEffectModelBase BuffFX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX, value);
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x000BAC61 File Offset: 0x000B8E61
		// (set) Token: 0x06007DF9 RID: 32249 RVA: 0x000BAC75 File Offset: 0x000B8E75
		public unsafe FTransform BuffFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset) = value;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06007DFA RID: 32250 RVA: 0x000BAC8A File Offset: 0x000B8E8A
		// (set) Token: 0x06007DFB RID: 32251 RVA: 0x000BAC9E File Offset: 0x000B8E9E
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06007DFC RID: 32252 RVA: 0x000BACB3 File Offset: 0x000B8EB3
		// (set) Token: 0x06007DFD RID: 32253 RVA: 0x000BACC3 File Offset: 0x000B8EC3
		public unsafe bool BuffFX_AttackLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06007DFE RID: 32254 RVA: 0x000BACD4 File Offset: 0x000B8ED4
		// (set) Token: 0x06007DFF RID: 32255 RVA: 0x000BACE4 File Offset: 0x000B8EE4
		public unsafe bool BuffFX_AttackRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06007E00 RID: 32256 RVA: 0x000BACF5 File Offset: 0x000B8EF5
		// (set) Token: 0x06007E01 RID: 32257 RVA: 0x000BAD05 File Offset: 0x000B8F05
		public unsafe bool BuffFX_AttackScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x000BAD16 File Offset: 0x000B8F16
		// (set) Token: 0x06007E03 RID: 32259 RVA: 0x000BAD26 File Offset: 0x000B8F26
		public unsafe bool BuffFX_DetachOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_DetachOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_DetachOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x000BAD37 File Offset: 0x000B8F37
		// (set) Token: 0x06007E05 RID: 32261 RVA: 0x000BAD47 File Offset: 0x000B8F47
		public unsafe bool MobileInvisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_MobileInvisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_MobileInvisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06007E06 RID: 32262 RVA: 0x000BAD58 File Offset: 0x000B8F58
		// (set) Token: 0x06007E07 RID: 32263 RVA: 0x000BAD6C File Offset: 0x000B8F6C
		public unsafe UEffectModelBase BuffFX_Add
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Add);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Add, value);
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06007E08 RID: 32264 RVA: 0x000BAD81 File Offset: 0x000B8F81
		// (set) Token: 0x06007E09 RID: 32265 RVA: 0x000BAD95 File Offset: 0x000B8F95
		public unsafe FTransform BuffFX_Offset_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Add) = value;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06007E0A RID: 32266 RVA: 0x000BADAA File Offset: 0x000B8FAA
		// (set) Token: 0x06007E0B RID: 32267 RVA: 0x000BADBE File Offset: 0x000B8FBE
		public unsafe FName Socket_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Add) = value;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06007E0C RID: 32268 RVA: 0x000BADD3 File Offset: 0x000B8FD3
		// (set) Token: 0x06007E0D RID: 32269 RVA: 0x000BADE3 File Offset: 0x000B8FE3
		public unsafe bool BuffFX_AttackLocation_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06007E0E RID: 32270 RVA: 0x000BADF4 File Offset: 0x000B8FF4
		// (set) Token: 0x06007E0F RID: 32271 RVA: 0x000BAE04 File Offset: 0x000B9004
		public unsafe bool BuffFX_AttackRotation_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06007E10 RID: 32272 RVA: 0x000BAE15 File Offset: 0x000B9015
		// (set) Token: 0x06007E11 RID: 32273 RVA: 0x000BAE25 File Offset: 0x000B9025
		public unsafe bool BuffFX_AttackScale_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Add) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Add) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06007E12 RID: 32274 RVA: 0x000BAE36 File Offset: 0x000B9036
		// (set) Token: 0x06007E13 RID: 32275 RVA: 0x000BAE4A File Offset: 0x000B904A
		public unsafe UEffectModelBase BuffFX_Remove
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Remove);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_BuffFX_Remove, value);
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06007E14 RID: 32276 RVA: 0x000BAE5F File Offset: 0x000B905F
		// (set) Token: 0x06007E15 RID: 32277 RVA: 0x000BAE73 File Offset: 0x000B9073
		public unsafe FTransform BuffFX_Offset_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Remove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_Offset_Remove) = value;
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x000BAE88 File Offset: 0x000B9088
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x000BAE9C File Offset: 0x000B909C
		public unsafe FName Socket_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Remove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_Socket_Remove) = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x000BAEB1 File Offset: 0x000B90B1
		// (set) Token: 0x06007E19 RID: 32281 RVA: 0x000BAEC1 File Offset: 0x000B90C1
		public unsafe bool BuffFX_AttackLocation_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackLocation_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x000BAED2 File Offset: 0x000B90D2
		// (set) Token: 0x06007E1B RID: 32283 RVA: 0x000BAEE2 File Offset: 0x000B90E2
		public unsafe bool BuffFX_AttackRotation_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackRotation_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x000BAEF3 File Offset: 0x000B90F3
		// (set) Token: 0x06007E1D RID: 32285 RVA: 0x000BAF03 File Offset: 0x000B9103
		public unsafe bool BuffFX_AttackScale_Remove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Remove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff.__PropertyOffset_BuffFX_AttackScale_Remove) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06007E1E RID: 32286 RVA: 0x000BAF14 File Offset: 0x000B9114
		// (set) Token: 0x06007E1F RID: 32287 RVA: 0x000BAF28 File Offset: 0x000B9128
		public unsafe UKuroMaterialControllerDataAsset Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x000BAF3D File Offset: 0x000B913D
		static UKSC_DA_Buff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff");
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x000BAF4B File Offset: 0x000B914B
		protected UKSC_DA_Buff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036E2 RID: 14050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff";

		// Token: 0x040036E3 RID: 14051
		private static IntPtr _ClassPtr;

		// Token: 0x040036E4 RID: 14052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036E5 RID: 14053
		internal static int __PropertyOffset_Duration;

		// Token: 0x040036E6 RID: 14054
		internal static int __PropertyOffset_RefreshTagWhenBuffRefresh;

		// Token: 0x040036E7 RID: 14055
		internal static int __PropertyOffset_InstantNeedUpdate;

		// Token: 0x040036E8 RID: 14056
		internal static int __PropertyOffset_BuffTags;

		// Token: 0x040036E9 RID: 14057
		private FGameplayTagContainer _BuffTags;

		// Token: 0x040036EA RID: 14058
		internal static int __PropertyOffset_BuffAddBuffs;

		// Token: 0x040036EB RID: 14059
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _BuffAddBuffs;

		// Token: 0x040036EC RID: 14060
		internal static int __PropertyOffset_RemoveChildBuffWhenEnd;

		// Token: 0x040036ED RID: 14061
		internal static int __PropertyOffset_BuffFX;

		// Token: 0x040036EE RID: 14062
		internal static int __PropertyOffset_BuffFX_Offset;

		// Token: 0x040036EF RID: 14063
		internal static int __PropertyOffset_Socket;

		// Token: 0x040036F0 RID: 14064
		internal static int __PropertyOffset_BuffFX_AttackLocation;

		// Token: 0x040036F1 RID: 14065
		internal static int __PropertyOffset_BuffFX_AttackRotation;

		// Token: 0x040036F2 RID: 14066
		internal static int __PropertyOffset_BuffFX_AttackScale;

		// Token: 0x040036F3 RID: 14067
		internal static int __PropertyOffset_BuffFX_DetachOnEnd;

		// Token: 0x040036F4 RID: 14068
		internal static int __PropertyOffset_MobileInvisible;

		// Token: 0x040036F5 RID: 14069
		internal static int __PropertyOffset_BuffFX_Add;

		// Token: 0x040036F6 RID: 14070
		internal static int __PropertyOffset_BuffFX_Offset_Add;

		// Token: 0x040036F7 RID: 14071
		internal static int __PropertyOffset_Socket_Add;

		// Token: 0x040036F8 RID: 14072
		internal static int __PropertyOffset_BuffFX_AttackLocation_Add;

		// Token: 0x040036F9 RID: 14073
		internal static int __PropertyOffset_BuffFX_AttackRotation_Add;

		// Token: 0x040036FA RID: 14074
		internal static int __PropertyOffset_BuffFX_AttackScale_Add;

		// Token: 0x040036FB RID: 14075
		internal static int __PropertyOffset_BuffFX_Remove;

		// Token: 0x040036FC RID: 14076
		internal static int __PropertyOffset_BuffFX_Offset_Remove;

		// Token: 0x040036FD RID: 14077
		internal static int __PropertyOffset_Socket_Remove;

		// Token: 0x040036FE RID: 14078
		internal static int __PropertyOffset_BuffFX_AttackLocation_Remove;

		// Token: 0x040036FF RID: 14079
		internal static int __PropertyOffset_BuffFX_AttackRotation_Remove;

		// Token: 0x04003700 RID: 14080
		internal static int __PropertyOffset_BuffFX_AttackScale_Remove;

		// Token: 0x04003701 RID: 14081
		internal static int __PropertyOffset_Material;
	}
}

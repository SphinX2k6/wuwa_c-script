using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A5 RID: 6309
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelMultiEffect")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEffectModelMultiEffect : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060173F3 RID: 95219 RVA: 0x0021EA24 File Offset: 0x0021CC24
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelMultiEffect._ClassPtr;
		}

		// Token: 0x060173F4 RID: 95220 RVA: 0x0021EA30 File Offset: 0x0021CC30
		public UEffectModelMultiEffect() : this(BuiltinUtils.AllocNativeUObject(UEffectModelMultiEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060173F5 RID: 95221 RVA: 0x0021EA58 File Offset: 0x0021CC58
		[NullableContext(1)]
		public UEffectModelMultiEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelMultiEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x060173F6 RID: 95222 RVA: 0x0021EA8B File Offset: 0x0021CC8B
		// (set) Token: 0x060173F7 RID: 95223 RVA: 0x0021EA9F File Offset: 0x0021CC9F
		[Nullable(2)]
		public unsafe UEffectModelBase EffectData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMultiEffect.__PropertyOffset_EffectData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelMultiEffect.__PropertyOffset_EffectData, value);
			}
		}

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x060173F8 RID: 95224 RVA: 0x0021EAB4 File Offset: 0x0021CCB4
		// (set) Token: 0x060173F9 RID: 95225 RVA: 0x0021EAC4 File Offset: 0x0021CCC4
		public unsafe EMultiEffectType Type
		{
			get
			{
				return (EMultiEffectType)(*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x060173FA RID: 95226 RVA: 0x0021EAD5 File Offset: 0x0021CCD5
		// (set) Token: 0x060173FB RID: 95227 RVA: 0x0021EAE5 File Offset: 0x0021CCE5
		public unsafe int BaseNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_BaseNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_BaseNum) = value;
			}
		}

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x060173FC RID: 95228 RVA: 0x0021EAF6 File Offset: 0x0021CCF6
		// (set) Token: 0x060173FD RID: 95229 RVA: 0x0021EB06 File Offset: 0x0021CD06
		public unsafe float SpinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_SpinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_SpinSpeed) = value;
			}
		}

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x060173FE RID: 95230 RVA: 0x0021EB17 File Offset: 0x0021CD17
		// (set) Token: 0x060173FF RID: 95231 RVA: 0x0021EB27 File Offset: 0x0021CD27
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelMultiEffect.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x06017400 RID: 95232 RVA: 0x0021EB38 File Offset: 0x0021CD38
		static UEffectModelMultiEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelMultiEffect");
		}

		// Token: 0x06017401 RID: 95233 RVA: 0x0021EB46 File Offset: 0x0021CD46
		protected UEffectModelMultiEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C9D2 RID: 51666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelMultiEffect";

		// Token: 0x0400C9D3 RID: 51667
		private static IntPtr _ClassPtr;

		// Token: 0x0400C9D4 RID: 51668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C9D5 RID: 51669
		internal static int __PropertyOffset_EffectData;

		// Token: 0x0400C9D6 RID: 51670
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C9D7 RID: 51671
		internal static int __PropertyOffset_BaseNum;

		// Token: 0x0400C9D8 RID: 51672
		internal static int __PropertyOffset_SpinSpeed;

		// Token: 0x0400C9D9 RID: 51673
		internal static int __PropertyOffset_Radius;
	}
}

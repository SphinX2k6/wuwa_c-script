using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189E RID: 6302
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelCurveTrailDecal")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UEffectModelCurveTrailDecal : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017350 RID: 95056 RVA: 0x0021D89C File Offset: 0x0021BA9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelCurveTrailDecal._ClassPtr;
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x0021D8A8 File Offset: 0x0021BAA8
		public UEffectModelCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(UEffectModelCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017352 RID: 95058 RVA: 0x0021D8D0 File Offset: 0x0021BAD0
		[NullableContext(1)]
		public UEffectModelCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x06017353 RID: 95059 RVA: 0x0021D903 File Offset: 0x0021BB03
		// (set) Token: 0x06017354 RID: 95060 RVA: 0x0021D917 File Offset: 0x0021BB17
		[Nullable(2)]
		public unsafe UKuroCurveTrailDecalConfig Config
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCurveTrailDecalConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelCurveTrailDecal.__PropertyOffset_Config);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelCurveTrailDecal.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x06017355 RID: 95061 RVA: 0x0021D92C File Offset: 0x0021BB2C
		static UEffectModelCurveTrailDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelCurveTrailDecal");
		}

		// Token: 0x06017356 RID: 95062 RVA: 0x0021D93A File Offset: 0x0021BB3A
		protected UEffectModelCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C963 RID: 51555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelCurveTrailDecal";

		// Token: 0x0400C964 RID: 51556
		private static IntPtr _ClassPtr;

		// Token: 0x0400C965 RID: 51557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C966 RID: 51558
		internal static int __PropertyOffset_Config;
	}
}

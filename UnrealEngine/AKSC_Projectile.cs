using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E13 RID: 7699
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Projectile")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class AKSC_Projectile : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D60A RID: 120330 RVA: 0x002B5DB1 File Offset: 0x002B3FB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Projectile._ClassPtr;
		}

		// Token: 0x0601D60B RID: 120331 RVA: 0x002B5DC0 File Offset: 0x002B3FC0
		public AKSC_Projectile() : this(BuiltinUtils.AllocNativeUObject(AKSC_Projectile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D60C RID: 120332 RVA: 0x002B5DE8 File Offset: 0x002B3FE8
		[NullableContext(1)]
		public AKSC_Projectile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Projectile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700767F RID: 30335
		// (get) Token: 0x0601D60D RID: 120333 RVA: 0x002B5E1B File Offset: 0x002B401B
		// (set) Token: 0x0601D60E RID: 120334 RVA: 0x002B5E2F File Offset: 0x002B402F
		[Nullable(2)]
		public unsafe UKSC_DA_Entity_Projectile DaEntityProjectile_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity_Projectile>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Projectile.__PropertyOffset_DaEntityProjectile_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Projectile.__PropertyOffset_DaEntityProjectile_, value);
			}
		}

		// Token: 0x0601D60F RID: 120335 RVA: 0x002B5E44 File Offset: 0x002B4044
		static AKSC_Projectile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Projectile");
		}

		// Token: 0x0601D610 RID: 120336 RVA: 0x002B5E52 File Offset: 0x002B4052
		protected AKSC_Projectile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEF0 RID: 65264
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Projectile";

		// Token: 0x0400FEF1 RID: 65265
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEF2 RID: 65266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEF3 RID: 65267
		internal static int __PropertyOffset_DaEntityProjectile_;
	}
}

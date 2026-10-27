using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6E RID: 3950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLifetime")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UParticleModuleLifetime : UParticleModuleLifetimeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D51B RID: 54555 RVA: 0x00139580 File Offset: 0x00137780
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLifetime._ClassPtr;
		}

		// Token: 0x0600D51C RID: 54556 RVA: 0x0013958C File Offset: 0x0013778C
		public UParticleModuleLifetime() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLifetime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x001395B4 File Offset: 0x001377B4
		public UParticleModuleLifetime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLifetime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600D51E RID: 54558 RVA: 0x001395E8 File Offset: 0x001377E8
		// (set) Token: 0x0600D51F RID: 54559 RVA: 0x00139621 File Offset: 0x00137821
		public FRawDistributionFloat Lifetime
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Lifetime) == null)
				{
					result = (this._Lifetime = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLifetime.__PropertyOffset_Lifetime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLifetime.__PropertyOffset_Lifetime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D520 RID: 54560 RVA: 0x00139642 File Offset: 0x00137842
		static UParticleModuleLifetime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLifetime");
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x00139650 File Offset: 0x00137850
		protected UParticleModuleLifetime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072D8 RID: 29400
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLifetime";

		// Token: 0x040072D9 RID: 29401
		private static IntPtr _ClassPtr;

		// Token: 0x040072DA RID: 29402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072DB RID: 29403
		internal static int __PropertyOffset_Lifetime;

		// Token: 0x040072DC RID: 29404
		[Nullable(2)]
		private FRawDistributionFloat _Lifetime;
	}
}

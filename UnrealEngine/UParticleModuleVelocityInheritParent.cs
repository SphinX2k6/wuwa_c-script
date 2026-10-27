using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FBC RID: 4028
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocityInheritParent")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8D5 RID: 55509 RVA: 0x0014004E File Offset: 0x0013E24E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocityInheritParent._ClassPtr;
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x0014005C File Offset: 0x0013E25C
		public UParticleModuleVelocityInheritParent() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityInheritParent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x00140084 File Offset: 0x0013E284
		public UParticleModuleVelocityInheritParent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityInheritParent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x001400B8 File Offset: 0x0013E2B8
		// (set) Token: 0x0600D8D9 RID: 55513 RVA: 0x001400F1 File Offset: 0x0013E2F1
		public FRawDistributionVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleVelocityInheritParent.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocityInheritParent.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x00140112 File Offset: 0x0013E312
		static UParticleModuleVelocityInheritParent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocityInheritParent");
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x00140120 File Offset: 0x0013E320
		protected UParticleModuleVelocityInheritParent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007590 RID: 30096
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocityInheritParent";

		// Token: 0x04007591 RID: 30097
		private static IntPtr _ClassPtr;

		// Token: 0x04007592 RID: 30098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007593 RID: 30099
		internal static int __PropertyOffset_Scale;

		// Token: 0x04007594 RID: 30100
		[Nullable(2)]
		private FRawDistributionVector _Scale;
	}
}

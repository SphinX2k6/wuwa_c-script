using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4D RID: 3917
	[UnrealObjectPath("/Script/Engine.ParticleModuleAccelerationConstant")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UParticleModuleAccelerationConstant : UParticleModuleAccelerationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D35F RID: 54111 RVA: 0x00135FD1 File Offset: 0x001341D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAccelerationConstant._ClassPtr;
		}

		// Token: 0x0600D360 RID: 54112 RVA: 0x00135FE0 File Offset: 0x001341E0
		public UParticleModuleAccelerationConstant() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D361 RID: 54113 RVA: 0x00136008 File Offset: 0x00134208
		[NullableContext(1)]
		public UParticleModuleAccelerationConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600D362 RID: 54114 RVA: 0x0013603B File Offset: 0x0013423B
		// (set) Token: 0x0600D363 RID: 54115 RVA: 0x0013604F File Offset: 0x0013424F
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAccelerationConstant.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAccelerationConstant.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x00136064 File Offset: 0x00134264
		static UParticleModuleAccelerationConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAccelerationConstant");
		}

		// Token: 0x0600D365 RID: 54117 RVA: 0x00136072 File Offset: 0x00134272
		protected UParticleModuleAccelerationConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400717D RID: 29053
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAccelerationConstant";

		// Token: 0x0400717E RID: 29054
		private static IntPtr _ClassPtr;

		// Token: 0x0400717F RID: 29055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007180 RID: 29056
		internal static int __PropertyOffset_Acceleration;
	}
}

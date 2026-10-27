using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8E RID: 3982
	[UnrealObjectPath("/Script/Engine.ParticleModuleOrientationAxisLock")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UParticleModuleOrientationAxisLock : UParticleModuleOrientationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D674 RID: 54900 RVA: 0x0013BE15 File Offset: 0x0013A015
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleOrientationAxisLock._ClassPtr;
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x0013BE24 File Offset: 0x0013A024
		public UParticleModuleOrientationAxisLock() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrientationAxisLock.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D676 RID: 54902 RVA: 0x0013BE4C File Offset: 0x0013A04C
		[NullableContext(1)]
		public UParticleModuleOrientationAxisLock(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrientationAxisLock.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600D677 RID: 54903 RVA: 0x0013BE7F File Offset: 0x0013A07F
		// (set) Token: 0x0600D678 RID: 54904 RVA: 0x0013BE93 File Offset: 0x0013A093
		public unsafe TEnumAsByte<EParticleAxisLock> LockAxisFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleOrientationAxisLock.__PropertyOffset_LockAxisFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleOrientationAxisLock.__PropertyOffset_LockAxisFlags) = value;
			}
		}

		// Token: 0x0600D679 RID: 54905 RVA: 0x0013BEA8 File Offset: 0x0013A0A8
		static UParticleModuleOrientationAxisLock()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleOrientationAxisLock");
		}

		// Token: 0x0600D67A RID: 54906 RVA: 0x0013BEB6 File Offset: 0x0013A0B6
		protected UParticleModuleOrientationAxisLock(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073D8 RID: 29656
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleOrientationAxisLock";

		// Token: 0x040073D9 RID: 29657
		private static IntPtr _ClassPtr;

		// Token: 0x040073DA RID: 29658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073DB RID: 29659
		internal static int __PropertyOffset_LockAxisFlags;
	}
}

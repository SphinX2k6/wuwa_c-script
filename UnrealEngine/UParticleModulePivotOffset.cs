using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F93 RID: 3987
	[UnrealObjectPath("/Script/Engine.ParticleModulePivotOffset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UParticleModulePivotOffset : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D695 RID: 54933 RVA: 0x0013C165 File Offset: 0x0013A365
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModulePivotOffset._ClassPtr;
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x0013C174 File Offset: 0x0013A374
		public UParticleModulePivotOffset() : this(BuiltinUtils.AllocNativeUObject(UParticleModulePivotOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D697 RID: 54935 RVA: 0x0013C19C File Offset: 0x0013A39C
		[NullableContext(1)]
		public UParticleModulePivotOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModulePivotOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600D698 RID: 54936 RVA: 0x0013C1CF File Offset: 0x0013A3CF
		// (set) Token: 0x0600D699 RID: 54937 RVA: 0x0013C1E3 File Offset: 0x0013A3E3
		public unsafe FVector2D PivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModulePivotOffset.__PropertyOffset_PivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModulePivotOffset.__PropertyOffset_PivotOffset) = value;
			}
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x0013C1F8 File Offset: 0x0013A3F8
		static UParticleModulePivotOffset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModulePivotOffset");
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x0013C206 File Offset: 0x0013A406
		protected UParticleModulePivotOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073EF RID: 29679
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModulePivotOffset";

		// Token: 0x040073F0 RID: 29680
		private static IntPtr _ClassPtr;

		// Token: 0x040073F1 RID: 29681
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073F2 RID: 29682
		internal static int __PropertyOffset_PivotOffset;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001109 RID: 4361
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSimplificationSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USkeletalMeshSimplificationSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FD0E RID: 64782 RVA: 0x00175B16 File Offset: 0x00173D16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshSimplificationSettings._ClassPtr;
		}

		// Token: 0x0600FD0F RID: 64783 RVA: 0x00175B24 File Offset: 0x00173D24
		public USkeletalMeshSimplificationSettings() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSimplificationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FD10 RID: 64784 RVA: 0x00175B4C File Offset: 0x00173D4C
		[NullableContext(1)]
		public USkeletalMeshSimplificationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSimplificationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600FD11 RID: 64785 RVA: 0x00175B7F File Offset: 0x00173D7F
		// (set) Token: 0x0600FD12 RID: 64786 RVA: 0x00175B93 File Offset: 0x00173D93
		public unsafe FName SkeletalMeshReductionModuleName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimplificationSettings.__PropertyOffset_SkeletalMeshReductionModuleName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimplificationSettings.__PropertyOffset_SkeletalMeshReductionModuleName) = value;
			}
		}

		// Token: 0x0600FD13 RID: 64787 RVA: 0x00175BA8 File Offset: 0x00173DA8
		static USkeletalMeshSimplificationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshSimplificationSettings");
		}

		// Token: 0x0600FD14 RID: 64788 RVA: 0x00175BB6 File Offset: 0x00173DB6
		protected USkeletalMeshSimplificationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008864 RID: 34916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshSimplificationSettings";

		// Token: 0x04008865 RID: 34917
		private static IntPtr _ClassPtr;

		// Token: 0x04008866 RID: 34918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008867 RID: 34919
		internal static int __PropertyOffset_SkeletalMeshReductionModuleName;
	}
}

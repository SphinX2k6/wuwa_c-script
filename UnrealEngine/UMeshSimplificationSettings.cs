using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EAB RID: 3755
	[UnrealObjectPath("/Script/Engine.MeshSimplificationSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMeshSimplificationSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CB42 RID: 52034 RVA: 0x001283F4 File Offset: 0x001265F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshSimplificationSettings._ClassPtr;
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x00128400 File Offset: 0x00126600
		public UMeshSimplificationSettings() : this(BuiltinUtils.AllocNativeUObject(UMeshSimplificationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x00128428 File Offset: 0x00126628
		[NullableContext(1)]
		public UMeshSimplificationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshSimplificationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x0012845B File Offset: 0x0012665B
		// (set) Token: 0x0600CB46 RID: 52038 RVA: 0x0012846F File Offset: 0x0012666F
		public unsafe FName MeshReductionModuleName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshSimplificationSettings.__PropertyOffset_MeshReductionModuleName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshSimplificationSettings.__PropertyOffset_MeshReductionModuleName) = value;
			}
		}

		// Token: 0x0600CB47 RID: 52039 RVA: 0x00128484 File Offset: 0x00126684
		static UMeshSimplificationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MeshSimplificationSettings");
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x00128492 File Offset: 0x00126692
		protected UMeshSimplificationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006D85 RID: 28037
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MeshSimplificationSettings";

		// Token: 0x04006D86 RID: 28038
		private static IntPtr _ClassPtr;

		// Token: 0x04006D87 RID: 28039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006D88 RID: 28040
		internal static int __PropertyOffset_MeshReductionModuleName;
	}
}

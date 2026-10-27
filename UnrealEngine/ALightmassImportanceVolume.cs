using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D52 RID: 3410
	[UnrealObjectPath("/Script/Engine.LightmassImportanceVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ALightmassImportanceVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B80C RID: 47116 RVA: 0x00105EDA File Offset: 0x001040DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALightmassImportanceVolume._ClassPtr;
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x00105EE8 File Offset: 0x001040E8
		public ALightmassImportanceVolume() : this(BuiltinUtils.AllocNativeUObject(ALightmassImportanceVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x00105F10 File Offset: 0x00104110
		[NullableContext(1)]
		public ALightmassImportanceVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALightmassImportanceVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x00105F43 File Offset: 0x00104143
		static ALightmassImportanceVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassImportanceVolume");
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x00105F51 File Offset: 0x00104151
		protected ALightmassImportanceVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006072 RID: 24690
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassImportanceVolume";

		// Token: 0x04006073 RID: 24691
		private static IntPtr _ClassPtr;

		// Token: 0x04006074 RID: 24692
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

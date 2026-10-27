using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D2F RID: 3375
	[UnrealObjectPath("/Script/Engine.LevelInstancePivot")]
	[UnrealStructLayout(1200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class ALevelInstancePivot : AActor, IUnrealUObject, IUnrealObject, ILevelInstanceEditorPivotInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B4CD RID: 46285 RVA: 0x00101EBF File Offset: 0x001000BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelInstancePivot._ClassPtr;
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x00101ECB File Offset: 0x001000CB
		int ILevelInstanceEditorPivotInterface.InterfaceOffset()
		{
			return ALevelInstancePivot.__InterfaceOffset_ILevelInstanceEditorPivotInterface;
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x00101ED4 File Offset: 0x001000D4
		public ALevelInstancePivot() : this(BuiltinUtils.AllocNativeUObject(ALevelInstancePivot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x00101EFC File Offset: 0x001000FC
		[NullableContext(1)]
		public ALevelInstancePivot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelInstancePivot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x00101F2F File Offset: 0x0010012F
		static ALevelInstancePivot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstancePivot");
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x00101F3D File Offset: 0x0010013D
		protected ALevelInstancePivot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F0C RID: 24332
		internal static int __InterfaceOffset_ILevelInstanceEditorPivotInterface;

		// Token: 0x04005F0D RID: 24333
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstancePivot";

		// Token: 0x04005F0E RID: 24334
		private static IntPtr _ClassPtr;

		// Token: 0x04005F0F RID: 24335
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

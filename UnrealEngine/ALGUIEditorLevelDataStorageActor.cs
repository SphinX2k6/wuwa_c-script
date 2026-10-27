using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200206D RID: 8301
	[UnrealObjectPath("/Script/LGUI.LGUIEditorLevelDataStorageActor")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ALGUIEditorLevelDataStorageActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F502 RID: 128258 RVA: 0x002E821F File Offset: 0x002E641F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIEditorLevelDataStorageActor._ClassPtr;
		}

		// Token: 0x0601F503 RID: 128259 RVA: 0x002E822C File Offset: 0x002E642C
		public ALGUIEditorLevelDataStorageActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIEditorLevelDataStorageActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x002E8254 File Offset: 0x002E6454
		[NullableContext(1)]
		public ALGUIEditorLevelDataStorageActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIEditorLevelDataStorageActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x002E8287 File Offset: 0x002E6487
		static ALGUIEditorLevelDataStorageActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEditorLevelDataStorageActor");
		}

		// Token: 0x0601F506 RID: 128262 RVA: 0x002E8295 File Offset: 0x002E6495
		protected ALGUIEditorLevelDataStorageActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010ED7 RID: 69335
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEditorLevelDataStorageActor";

		// Token: 0x04010ED8 RID: 69336
		private static IntPtr _ClassPtr;

		// Token: 0x04010ED9 RID: 69337
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

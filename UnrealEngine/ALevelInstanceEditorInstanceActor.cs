using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D2A RID: 3370
	[UnrealObjectPath("/Script/Engine.LevelInstanceEditorInstanceActor")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class ALevelInstanceEditorInstanceActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4BA RID: 46266 RVA: 0x00101C2E File Offset: 0x000FFE2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelInstanceEditorInstanceActor._ClassPtr;
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x00101C3C File Offset: 0x000FFE3C
		public ALevelInstanceEditorInstanceActor() : this(BuiltinUtils.AllocNativeUObject(ALevelInstanceEditorInstanceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4BC RID: 46268 RVA: 0x00101C64 File Offset: 0x000FFE64
		[NullableContext(1)]
		public ALevelInstanceEditorInstanceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelInstanceEditorInstanceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x00101C97 File Offset: 0x000FFE97
		static ALevelInstanceEditorInstanceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceEditorInstanceActor");
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x00101CA5 File Offset: 0x000FFEA5
		protected ALevelInstanceEditorInstanceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F03 RID: 24323
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceEditorInstanceActor";

		// Token: 0x04005F04 RID: 24324
		private static IntPtr _ClassPtr;

		// Token: 0x04005F05 RID: 24325
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

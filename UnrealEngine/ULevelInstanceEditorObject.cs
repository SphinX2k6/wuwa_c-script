using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D2B RID: 3371
	[UnrealObjectPath("/Script/Engine.LevelInstanceEditorObject")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class ULevelInstanceEditorObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4BF RID: 46271 RVA: 0x00101CAE File Offset: 0x000FFEAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelInstanceEditorObject._ClassPtr;
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x00101CBC File Offset: 0x000FFEBC
		public ULevelInstanceEditorObject() : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceEditorObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x00101CE4 File Offset: 0x000FFEE4
		[NullableContext(1)]
		public ULevelInstanceEditorObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceEditorObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x00101D17 File Offset: 0x000FFF17
		static ULevelInstanceEditorObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceEditorObject");
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x00101D25 File Offset: 0x000FFF25
		protected ULevelInstanceEditorObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F06 RID: 24326
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceEditorObject";

		// Token: 0x04005F07 RID: 24327
		private static IntPtr _ClassPtr;

		// Token: 0x04005F08 RID: 24328
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

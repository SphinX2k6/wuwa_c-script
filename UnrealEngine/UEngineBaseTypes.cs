using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF1 RID: 2801
	[UnrealObjectPath("/Script/Engine.EngineBaseTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEngineBaseTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600924D RID: 37453 RVA: 0x000D1EF9 File Offset: 0x000D00F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineBaseTypes._ClassPtr;
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x000D1F05 File Offset: 0x000D0105
		static UEngineBaseTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineBaseTypes");
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x000D1F14 File Offset: 0x000D0114
		protected UEngineBaseTypes() : this(BuiltinUtils.AllocNativeUObject(UEngineBaseTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x000D1F3C File Offset: 0x000D013C
		protected UEngineBaseTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CCE RID: 19662
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineBaseTypes";

		// Token: 0x04004CCF RID: 19663
		private static IntPtr _ClassPtr;

		// Token: 0x04004CD0 RID: 19664
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

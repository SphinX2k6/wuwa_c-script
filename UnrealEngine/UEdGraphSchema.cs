using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A4D RID: 2637
	[UnrealObjectPath("/Script/Engine.EdGraphSchema")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEdGraphSchema : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008F41 RID: 36673 RVA: 0x000CCEB4 File Offset: 0x000CB0B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraphSchema._ClassPtr;
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x000CCEC0 File Offset: 0x000CB0C0
		static UEdGraphSchema()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraphSchema");
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x000CCED0 File Offset: 0x000CB0D0
		protected UEdGraphSchema() : this(BuiltinUtils.AllocNativeUObject(UEdGraphSchema.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x000CCEF8 File Offset: 0x000CB0F8
		protected UEdGraphSchema(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046BD RID: 18109
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EdGraphSchema";

		// Token: 0x040046BE RID: 18110
		private static IntPtr _ClassPtr;

		// Token: 0x040046BF RID: 18111
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

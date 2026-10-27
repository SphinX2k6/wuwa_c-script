using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000ED0 RID: 3792
	[UnrealObjectPath("/Script/Engine.NavAreaBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UNavAreaBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CD4B RID: 52555 RVA: 0x0012B100 File Offset: 0x00129300
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavAreaBase._ClassPtr;
		}

		// Token: 0x0600CD4C RID: 52556 RVA: 0x0012B10C File Offset: 0x0012930C
		static UNavAreaBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavAreaBase");
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x0012B11C File Offset: 0x0012931C
		protected UNavAreaBase() : this(BuiltinUtils.AllocNativeUObject(UNavAreaBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x0012B144 File Offset: 0x00129344
		protected UNavAreaBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006E81 RID: 28289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavAreaBase";

		// Token: 0x04006E82 RID: 28290
		private static IntPtr _ClassPtr;

		// Token: 0x04006E83 RID: 28291
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

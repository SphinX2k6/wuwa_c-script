using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002860 RID: 10336
	[UnrealObjectPath("/Script/Slate.ToolMenuBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UToolMenuBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602653D RID: 156989 RVA: 0x003A3941 File Offset: 0x003A1B41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToolMenuBase._ClassPtr;
		}

		// Token: 0x0602653E RID: 156990 RVA: 0x003A394D File Offset: 0x003A1B4D
		static UToolMenuBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ToolMenuBase");
		}

		// Token: 0x0602653F RID: 156991 RVA: 0x003A395C File Offset: 0x003A1B5C
		protected UToolMenuBase() : this(BuiltinUtils.AllocNativeUObject(UToolMenuBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026540 RID: 156992 RVA: 0x003A3984 File Offset: 0x003A1B84
		protected UToolMenuBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401503A RID: 86074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Slate.ToolMenuBase";

		// Token: 0x0401503B RID: 86075
		private static IntPtr _ClassPtr;

		// Token: 0x0401503C RID: 86076
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

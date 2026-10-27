using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200288A RID: 10378
	[UnrealObjectPath("/Script/SMSystem.SMNodeBlueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class USMNodeBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026722 RID: 157474 RVA: 0x003A86CD File Offset: 0x003A68CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMNodeBlueprint._ClassPtr;
		}

		// Token: 0x06026723 RID: 157475 RVA: 0x003A86DC File Offset: 0x003A68DC
		public USMNodeBlueprint() : this(BuiltinUtils.AllocNativeUObject(USMNodeBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026724 RID: 157476 RVA: 0x003A8704 File Offset: 0x003A6904
		[NullableContext(1)]
		public USMNodeBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMNodeBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026725 RID: 157477 RVA: 0x003A8737 File Offset: 0x003A6937
		static USMNodeBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMNodeBlueprint");
		}

		// Token: 0x06026726 RID: 157478 RVA: 0x003A8745 File Offset: 0x003A6945
		protected USMNodeBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015192 RID: 86418
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMNodeBlueprint";

		// Token: 0x04015193 RID: 86419
		private static IntPtr _ClassPtr;

		// Token: 0x04015194 RID: 86420
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200288B RID: 10379
	[UnrealObjectPath("/Script/SMSystem.SMNodeBlueprintGeneratedClass")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class USMNodeBlueprintGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026727 RID: 157479 RVA: 0x003A874E File Offset: 0x003A694E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMNodeBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x06026728 RID: 157480 RVA: 0x003A875C File Offset: 0x003A695C
		public USMNodeBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(USMNodeBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026729 RID: 157481 RVA: 0x003A8784 File Offset: 0x003A6984
		[NullableContext(1)]
		public USMNodeBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMNodeBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602672A RID: 157482 RVA: 0x003A87B7 File Offset: 0x003A69B7
		static USMNodeBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMNodeBlueprintGeneratedClass");
		}

		// Token: 0x0602672B RID: 157483 RVA: 0x003A87C5 File Offset: 0x003A69C5
		protected USMNodeBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015195 RID: 86421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMNodeBlueprintGeneratedClass";

		// Token: 0x04015196 RID: 86422
		private static IntPtr _ClassPtr;

		// Token: 0x04015197 RID: 86423
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

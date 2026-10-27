using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BA RID: 1210
	[UnrealObjectPath("/Script/ControlRig.ControlRigBlueprintGeneratedClass")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class UControlRigBlueprintGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600407A RID: 16506 RVA: 0x00060E7E File Offset: 0x0005F07E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00060E8C File Offset: 0x0005F08C
		public UControlRigBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UControlRigBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00060EB4 File Offset: 0x0005F0B4
		[NullableContext(1)]
		public UControlRigBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00060EE7 File Offset: 0x0005F0E7
		static UControlRigBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigBlueprintGeneratedClass");
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00060EF5 File Offset: 0x0005F0F5
		protected UControlRigBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001ED9 RID: 7897
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigBlueprintGeneratedClass";

		// Token: 0x04001EDA RID: 7898
		private static IntPtr _ClassPtr;

		// Token: 0x04001EDB RID: 7899
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

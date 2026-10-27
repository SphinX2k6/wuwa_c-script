using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EFD RID: 3837
	[UnrealObjectPath("/Script/Engine.ObjectTraceWorldSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UObjectTraceWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFDC RID: 53212 RVA: 0x0012F31A File Offset: 0x0012D51A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectTraceWorldSubsystem._ClassPtr;
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x0012F328 File Offset: 0x0012D528
		public UObjectTraceWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UObjectTraceWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFDE RID: 53214 RVA: 0x0012F350 File Offset: 0x0012D550
		[NullableContext(1)]
		public UObjectTraceWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectTraceWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x0012F383 File Offset: 0x0012D583
		static UObjectTraceWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ObjectTraceWorldSubsystem");
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x0012F391 File Offset: 0x0012D591
		protected UObjectTraceWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400700D RID: 28685
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ObjectTraceWorldSubsystem";

		// Token: 0x0400700E RID: 28686
		private static IntPtr _ClassPtr;

		// Token: 0x0400700F RID: 28687
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

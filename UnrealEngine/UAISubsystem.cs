using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000113 RID: 275
	[UnrealObjectPath("/Script/AIModule.AISubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAISubsystem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x0001DED6 File Offset: 0x0001C0D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISubsystem._ClassPtr;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		public UAISubsystem() : this(BuiltinUtils.AllocNativeUObject(UAISubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0001DF0C File Offset: 0x0001C10C
		[NullableContext(1)]
		public UAISubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0001DF3F File Offset: 0x0001C13F
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0001DF53 File Offset: 0x0001C153
		[Nullable(2)]
		public unsafe UAISystem AISystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAISystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAISubsystem.__PropertyOffset_AISystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISubsystem.__PropertyOffset_AISystem, value);
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0001DF68 File Offset: 0x0001C168
		static UAISubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISubsystem");
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0001DF76 File Offset: 0x0001C176
		protected UAISubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000406 RID: 1030
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISubsystem";

		// Token: 0x04000407 RID: 1031
		private static IntPtr _ClassPtr;

		// Token: 0x04000408 RID: 1032
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000409 RID: 1033
		internal static int __PropertyOffset_AISystem;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000100 RID: 256
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Damage")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAISenseConfig_Damage : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001388 RID: 5000 RVA: 0x0001CD25 File Offset: 0x0001AF25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Damage._ClassPtr;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0001CD34 File Offset: 0x0001AF34
		public UAISenseConfig_Damage() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Damage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		[NullableContext(1)]
		public UAISenseConfig_Damage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Damage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0001CD8F File Offset: 0x0001AF8F
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0001CDA3 File Offset: 0x0001AFA3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAISense_Damage> Implementation
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Damage.__PropertyOffset_Implementation);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Damage.__PropertyOffset_Implementation) = value;
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		static UAISenseConfig_Damage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Damage");
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0001CDC6 File Offset: 0x0001AFC6
		protected UAISenseConfig_Damage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400039E RID: 926
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Damage";

		// Token: 0x0400039F RID: 927
		private static IntPtr _ClassPtr;

		// Token: 0x040003A0 RID: 928
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003A1 RID: 929
		internal static int __PropertyOffset_Implementation;
	}
}

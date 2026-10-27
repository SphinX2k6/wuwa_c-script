using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001184 RID: 4484
	[UnrealObjectPath("/Script/Engine.StandaloneBodySetup")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UStandaloneBodySetup : UBodySetup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060107C9 RID: 67529 RVA: 0x0018363F File Offset: 0x0018183F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStandaloneBodySetup._ClassPtr;
		}

		// Token: 0x060107CA RID: 67530 RVA: 0x0018364C File Offset: 0x0018184C
		public UStandaloneBodySetup() : this(BuiltinUtils.AllocNativeUObject(UStandaloneBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060107CB RID: 67531 RVA: 0x00183674 File Offset: 0x00181874
		[NullableContext(1)]
		public UStandaloneBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStandaloneBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060107CC RID: 67532 RVA: 0x001836A7 File Offset: 0x001818A7
		static UStandaloneBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StandaloneBodySetup");
		}

		// Token: 0x060107CD RID: 67533 RVA: 0x001836B5 File Offset: 0x001818B5
		protected UStandaloneBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D1D RID: 36125
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StandaloneBodySetup";

		// Token: 0x04008D1E RID: 36126
		private static IntPtr _ClassPtr;

		// Token: 0x04008D1F RID: 36127
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

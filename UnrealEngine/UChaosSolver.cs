using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000451 RID: 1105
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosSolver")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UChaosSolver : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B98 RID: 15256 RVA: 0x00059D0C File Offset: 0x00057F0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosSolver._ClassPtr;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00059D18 File Offset: 0x00057F18
		public UChaosSolver() : this(BuiltinUtils.AllocNativeUObject(UChaosSolver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00059D40 File Offset: 0x00057F40
		[NullableContext(1)]
		public UChaosSolver(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosSolver.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00059D73 File Offset: 0x00057F73
		static UChaosSolver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosSolver");
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x00059D81 File Offset: 0x00057F81
		protected UChaosSolver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B6E RID: 7022
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosSolver";

		// Token: 0x04001B6F RID: 7023
		private static IntPtr _ClassPtr;

		// Token: 0x04001B70 RID: 7024
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

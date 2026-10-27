using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C5 RID: 197
	[UnrealObjectPath("/Engine/PythonTypes.USDScriptedSequenceExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UUSDScriptedSequenceExporter : UExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600112C RID: 4396 RVA: 0x000198D2 File Offset: 0x00017AD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUSDScriptedSequenceExporter._ClassPtr;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000198E0 File Offset: 0x00017AE0
		public UUSDScriptedSequenceExporter() : this(BuiltinUtils.AllocNativeUObject(UUSDScriptedSequenceExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00019908 File Offset: 0x00017B08
		[NullableContext(1)]
		public UUSDScriptedSequenceExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUSDScriptedSequenceExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0001993B File Offset: 0x00017B3B
		static UUSDScriptedSequenceExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Engine/PythonTypes.USDScriptedSequenceExporter");
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00019949 File Offset: 0x00017B49
		protected UUSDScriptedSequenceExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000268 RID: 616
		[Nullable(1)]
		public new const string __ObjectPath = "/Engine/PythonTypes.USDScriptedSequenceExporter";

		// Token: 0x04000269 RID: 617
		private static IntPtr _ClassPtr;

		// Token: 0x0400026A RID: 618
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
